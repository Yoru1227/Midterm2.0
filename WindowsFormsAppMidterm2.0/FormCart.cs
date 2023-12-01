using System;
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
    public partial class FormCart : Form
    {
        int totalPrice = 0;
        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"{GlobalVar.userName}的購物車";
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 查詢Order資料表與customerID有關的資料
            ShowListView();
        }
        void ShowListView()
        {
            // 將總價重置
            totalPrice = 0;
            // 將listViewOrderList移除所有項目
            listViewOrderList.Items.Clear();
            // 資料庫連線
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 查詢customer未結帳的order
            IQueryable<Order> orderQuery = from order
                                           in mydb.Order
                                           where (order.customerID == GlobalVar.ID) && (order.isPaid == false)
                                           select order;
            foreach (Order order in orderQuery)
            {
                // 查詢order對應的Product
                IQueryable<Product> productQuery = from product 
                                                   in mydb.Product 
                                                   where product.ID == order.productID 
                                                   select product;
                Product selectedProduct = productQuery.FirstOrDefault();
                string str = $"訂單編號:{order.ID},{selectedProduct.name},單價:{selectedProduct.price},數量:{order.amount},總價:{order.totalPrice}{(order.comment == "" ? "" : ",")}{order.comment}";
                ListViewItem item = new ListViewItem(str);
                item.Tag = order.ID;
                listViewOrderList.Items.Add(item);
                totalPrice += order.totalPrice;
                Console.WriteLine($"orderID : {order.ID}" +
                    $"customerID : {order.customerID}\n" +
                    $"datetime : {order.datetime}\n" +
                    $"productID : {order.productID}\n" +
                    $"amount : {order.amount}\n" +
                    $"totalPrice : {order.totalPrice}\n" +
                    $"employeeID : {order.employeeID}\n" +
                    $"comment : {order.comment}");
            }
            btnPay.Text = $"結帳 :\n{totalPrice}元";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // 當listViewOrderList被選中item
            if (listViewOrderList.SelectedItems.Count > 0)
            {
                int orderID = (int)listViewOrderList.SelectedItems[0].Tag;
                RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
                IQueryable<Order> query = from order 
                                          in mydb.Order
                                          where order.ID == orderID
                                          select order;
                Order selectedOrder = query.FirstOrDefault();
                Console.WriteLine($"orderID : {selectedOrder.ID}" +
                $"customerID : {selectedOrder.customerID}\n" +
                $"datetime : {selectedOrder.datetime}\n" +
                $"productID : {selectedOrder.productID}\n" +
                $"amount : {selectedOrder.amount}\n" +
                $"totalPrice : {selectedOrder.totalPrice}\n" +
                $"employeeID : {selectedOrder.employeeID}\n" +
                $"comment : {selectedOrder.comment}");
                // selectedOrder不為null則刪除selectedOrder
                if (selectedOrder != null)
                {
                    mydb.Order.DeleteOnSubmit(selectedOrder);
                    mydb.SubmitChanges();
                    totalPrice -= selectedOrder.totalPrice;
                    ShowListView();
                }
            }           
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // 資料庫連線
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 查詢customer未結帳的order
            IQueryable<Order> orderQuery = from order
                                           in mydb.Order
                                           where (order.customerID == GlobalVar.ID) && (order.isPaid == false)
                                           select order;
            // 將訂單結帳
            foreach(Order order in orderQuery)
            {
                order.isPaid = true;
            }
            mydb.SubmitChanges();
            ShowListView();
        }
    }
}
