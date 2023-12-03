using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMidterm2._0
{
    public partial class FormOrderInfo : Form
    {
        int orderID = 0;
        int customerID = 0;
        DateTime fromDateTime = DateTime.Now;
        DateTime toDateTime = DateTime.Now;
        int productID = 0;
        string productName = "";
        int amount = 0;
        int totalPrice = 0;
        int employeeID = 0;
        string comment = "";
        bool isOrderIDEmpty = true;
        bool isCustomerIDEmpty = true;
        // dateTimePicker不考慮空白
        bool isProductIDEmpty = true;
        bool isProductNameEmpty = true;
        bool isAmountEmpty = true;
        // totalPrice ReadOnly       
        bool isEmployeeIDEmpty = true;
        // 沒有備註的textbox
        public FormOrderInfo()
        {
            InitializeComponent();
        }
        // 讀取所有textbox
        void ReadTextBox()
        {
            // 若txtOrderID沒有字串, 則orderID為0
            Int32.TryParse(txtOrderID.Text, out orderID);
            // 若txtCustomerID沒有字串, 則customerID為0
            Int32.TryParse(txtCustomerID.Text, out customerID);
            fromDateTime = dtpFromDate.Value;
            toDateTime = dtpToDate.Value;
            // 若txtProductID沒有字串, 則productID為0
            Int32.TryParse(txtProductID.Text, out productID);
            // 若txtAmountID沒有字串, 則amount為0
            Int32.TryParse(txtAmount.Text, out amount);
            // 若txtTotalPrice沒有字串, 則totalPrice為0
            Int32.TryParse(txtTotalPrice.Text, out totalPrice);
            // 若txtEmployeeID沒有字串, 則employeeID為0
            Int32.TryParse(txtEmployeeID.Text, out employeeID);
            // 檢查各textbox是否有輸入字串
            if (orderID == 0)
                isOrderIDEmpty = true;
            else
                isOrderIDEmpty = false;

            if(customerID == 0)
                isCustomerIDEmpty = true; 
            else
                isCustomerIDEmpty = false;            

            if(productID == 0)
                isProductIDEmpty = true;
            else
                isProductIDEmpty = false;

            if(productName == "")
                isProductNameEmpty = true;
            else
                isProductNameEmpty = false;

            if(amount == 0)
                isAmountEmpty = true;
            else
                isAmountEmpty = false;

            if (employeeID == 0)
                isEmployeeIDEmpty = true;
            else
                isEmployeeIDEmpty = false;
            // 清空所有textbox
            txtOrderID.Text = "";
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtCustomerID.Text = "";
            dtpFromDate.Text = DateTime.Now.ToString();
            dtpToDate.Text = DateTime.Now.ToString();
            txtAmount.Text = "";
            txtTotalPrice.Text = "";
            txtEmployeeID.Text = "";           
            
        }

        private void FormOrderInfo_Load(object sender, EventArgs e)
        {
            dtpFromDate.Text = DateTime.Now.ToString();
            dtpToDate.Text = DateTime.Now.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 檢查欄位是否有字串
            if(isProductIDEmpty)
            {
                MessageBox.Show("商品ID必須填入");
            }
            else if(isCustomerIDEmpty)
            {
                MessageBox.Show("顧客ID必須填入");
            }
            else if(isAmountEmpty)
            {
                MessageBox.Show("數量必須填入");
            }
            else if(isEmployeeIDEmpty)
            {
                MessageBox.Show("員工ID必須填入");
            }
            else if(fromDateTime != toDateTime)
            {
                MessageBox.Show("起始日期必須與結束日期相同");
            }
            else
            {
                Order order = new Order();
                order.productID = productID;
                order.customerID = customerID;
                order.employeeID = employeeID;
                order.amount = amount;
                order.totalPrice = (from product in mydb.Product where product.ID == productID select product.price).FirstOrDefault() * amount;
                order.datetime = fromDateTime;
                order.comment = "";
                mydb.Order.InsertOnSubmit(order);
                mydb.SubmitChanges();
                Console.WriteLine($"productID : {order.ID}\n" +
                    $"customerID : {order.customerID}\n" +
                    $"employeeID : {order.employeeID}\n" +
                    $"amount : {order.amount}\n" +
                    $"totalPrice : {order.totalPrice}\n" +
                    $"dateTime : {order.datetime}\n" +
                    $"comment : {order.comment}");
                MessageBox.Show("Insert成功");
            }        
        }
        // 查詢order資料表
        // 多重欄位查詢
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 查詢訂單, 日期
            IQueryable<Order> query = from order
                                      in mydb.Order
                                      where (order.datetime >= fromDateTime) && (order.datetime <= toDateTime)
                                      select order;
            // 若orderID非空字串
            if (isOrderIDEmpty == false)
            {
                query = from order
                        in query
                        where order.ID == orderID
                        select order;
            }
            // 若productID非空字串
            if (isProductIDEmpty == false)
            {
                query = from order
                        in query
                        where order.productID == productID
                        select order;
            }
            // 若customerID非空字串
            if (isCustomerIDEmpty == false)
            {
                query = from order
                        in query
                        where order.customerID == customerID
                        select order;
            }
            // 若employeeID非空字串
            if (isEmployeeIDEmpty == false)
            {
                query = from order
                        in query
                        where order.employeeID == employeeID
                        select order;
            }
            // 若productName非空字串
            if (isProductNameEmpty == false)
            {
                // 先找productName對應的productID
                int searchProductID = (from product 
                                           in mydb.Product
                                           where product.name == productName
                                           select product.ID)
                                           .FirstOrDefault();
                query = from order
                        in query
                        where order.productID == searchProductID
                        select order;
            }
            if(query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach(Order order in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = order.ID;
                    item.Text = $"訂單ID:{order.ID}," +
                                $"顧客ID:{order.customerID}," +
                                $"時間:{order.datetime}," +
                                $"商品ID:{order.productID}," +
                                $"數量:{order.amount}," +
                                $"總價:{order.totalPrice}," +
                                $"員工ID:{order.employeeID}," +
                                $"備註:{order.comment}," +
                                $"{(order.isPaid ? "已" : "未")}付款";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }
        // 更新order資料表, 依orderID更新
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Order selectedOrder = (from order
                                  in mydb.Order
                                   where order.ID == orderID
                                   select order)
                                  .FirstOrDefault();
            if(selectedOrder != null)
            {
                // 變動商品, 總價也會跟著變動
                if(isProductIDEmpty == false)
                {
                    selectedOrder.productID = productID;
                    selectedOrder.totalPrice = selectedOrder.amount * (from product in mydb.Product where product.ID == productID select product.price).FirstOrDefault();
                }
                if(isCustomerIDEmpty == false)
                    selectedOrder.customerID = customerID;
                if(isEmployeeIDEmpty == false)
                    selectedOrder.employeeID = employeeID;
                // 變動數量, 總價也會跟著變動
                if(isAmountEmpty == false)
                {
                    selectedOrder.amount = amount;
                    selectedOrder.totalPrice = amount * (from product in mydb.Product where product.ID == selectedOrder.productID select product.price).FirstOrDefault();
                }
                if(selectedOrder.datetime != fromDateTime)
                    selectedOrder.datetime = fromDateTime;
                mydb.SubmitChanges();
                MessageBox.Show("資料更新成功");
            }
            IQueryable<Order> query = from order
                    in mydb.Order
                    select order;
            if (query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Order order in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = order.ID;
                    item.Text = $"訂單ID:{order.ID}," +
                                $"顧客ID:{order.customerID}," +
                                $"時間:{order.datetime}," +
                                $"商品ID:{order.productID}," +
                                $"數量:{order.amount}," +
                                $"總價:{order.totalPrice}," +
                                $"員工ID:{order.employeeID}," +
                                $"備註:{order.comment}," +
                                $"{(order.isPaid ? "已" : "未")}付款"; 
                    listViewDataInfo.Items.Add(item);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 以orderID刪除
            if(isOrderIDEmpty == false)
            {
                Order selectedOrder = (from order
                                      in mydb.Order
                                      where order.ID == orderID
                                      select order)
                                      .FirstOrDefault();
                if(selectedOrder != null)
                {
                    mydb.Order.DeleteOnSubmit(selectedOrder);
                    mydb.SubmitChanges();
                    MessageBox.Show("資料刪除成功");
                }
                else
                {
                    MessageBox.Show("查無此ID");
                }
            }
            else
            {
                MessageBox.Show("請輸入ID");
            }
            // 將listViewDataInfo顯示資料
            IQueryable<Order> query = from order
                                      in mydb.Order
                                      select order;
            if (query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Order order in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = order.ID;
                    item.Text = $"訂單ID:{order.ID}," +
                                $"顧客ID:{order.customerID}," +
                                $"時間:{order.datetime}," +
                                $"商品ID:{order.productID}," +
                                $"數量:{order.amount}," +
                                $"總價:{order.totalPrice}," +
                                $"員工ID:{order.employeeID}," +
                                $"備註:{order.comment}," +
                                $"{(order.isPaid?"已":"未")}付款";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }

        private void listViewDataInfo_ItemActivate(object sender, EventArgs e)
        {
            if(listViewDataInfo.SelectedItems.Count > 0)
            {
                RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
                int selectedOrderID = (int)listViewDataInfo.SelectedItems[0].Tag;
                Order selectedOrder = (from order
                                       in mydb.Order
                                       where order.ID == selectedOrderID
                                       select order)
                                       .FirstOrDefault();
                // 將資料顯示在textbox與dateTimePicker
                txtOrderID.Text = selectedOrder.ID.ToString();
                txtProductID.Text = selectedOrder.productID.ToString();
                txtCustomerID.Text = selectedOrder.customerID.ToString();
                txtEmployeeID.Text = selectedOrder.employeeID.ToString();
                txtAmount.Text = selectedOrder.amount.ToString();
                txtTotalPrice.Text = selectedOrder.totalPrice.ToString();
                txtProductName.Text = (from product in mydb.Product where product.ID == selectedOrder.productID select product.name).FirstOrDefault();
                dtpFromDate.Value = selectedOrder.datetime;
            }
        }
    }
}
