using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMidterm2._0
{
    public partial class FormProductInfo : Form
    {
        int productID = 0;
        string productName = "";
        int productPrice = 0;
        string productCategory = "";
        bool isInStock = false;
        string productPicName = "";
        bool isIDEmpty = true;
        bool isNameEmpty = true;
        bool isPriceEmpty = true;
        bool isCategoryEmpty = true;
        bool isIsInStockParseSuccess = false;
        bool isPicNameEmpty = true;
        public FormProductInfo()
        {
            InitializeComponent();
        }
        private void FormProductInfo_Load(object sender, EventArgs e)
        {
            // 店員無法新增、更新、刪除商品
            if(GlobalVar.permission < 10000)
            {
                btnInsert.Visible = false;
                btnSearch.Dock = DockStyle.Fill;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }           
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            ReadTextBox();
            // 檢查所有欄位是否有字串
            Console.WriteLine(isNameEmpty);
            Console.WriteLine(isPriceEmpty);
            Console.WriteLine(isCategoryEmpty);
            Console.WriteLine(isIsInStockParseSuccess);
            Console.WriteLine(isPicNameEmpty);
            if(isNameEmpty || isPriceEmpty || isCategoryEmpty || !isIsInStockParseSuccess || isPicNameEmpty)
            {
                MessageBox.Show("所有欄位必須填入");
                return;
            }
            // 檢查名字是否被使用
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Product> search = from product
                                         in mydb.Product
                                         where product.name == productName
                                         select product;
            if(search.Count() > 0)
            {
                MessageBox.Show("名字已被使用, 請重新輸入");
                txtName.Text = "";
                isExist = true;
            }
            if(isExist == false)
            {
                Product product = new Product();
                product.name = productName;
                product.price = productPrice;
                product.category = productCategory;
                product.isInStock = isInStock;
                product.picName = productPicName;
                mydb.Product.InsertOnSubmit(product);
                mydb.SubmitChanges();
                Console.WriteLine($"Name : {product.name}\n" +
                    $"price : {product.price}\n" +
                    $"category : {product.category}\n" +
                    $"isInStock : {product.isInStock}\n" +
                    $"picName : {product.picName}");
                MessageBox.Show("Insert成功");
            }
        }
        // 查詢product資料表
        // 多重欄位查詢
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Product> query = from product
                                        in mydb.Product
                                        select product;            
            // 若ID非空字串
            if (isIDEmpty == false)
            {
                query = from product
                        in query
                        where product.ID == productID
                        select product;
            }
            // 若名稱非空字串
            if(isNameEmpty == false)
            {
                query = from product
                        in query
                        where product.name.Contains(productName)
                        select product;
            }
            // 若價格非空字串
            if(isPriceEmpty == false)
            {
                query = from product
                        in query
                        where product.price == productPrice
                        select product;
            }
            // 若分類非空字串
            if(isCategoryEmpty == false)
            {
                query = from product
                        in query
                        where product.category == productCategory
                        select product;
            }
            // 若存貨輸入成功
            if(isIsInStockParseSuccess == true)
            {
                query = from product
                        in query
                        where product.isInStock == isInStock
                        select product;
            }
            if(query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Product product in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = product.ID;
                    item.Text = $"ID:{product.ID},名稱:{product.name},價格:{product.price},分類:{product.category},存貨:{product.isInStock},檔名:{product.picName}";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }
        // 更新product資料表
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Product selectedProduct = (from product
                                       in mydb.Product
                                       where product.ID == productID
                                       select product)
                                       .FirstOrDefault();
            if(selectedProduct != null)
            {
                if(isNameEmpty == false)
                    selectedProduct.name = productName;
                if(isPriceEmpty == false)
                    selectedProduct.price = productPrice;
                if(isCategoryEmpty == false)
                    selectedProduct.category = productCategory;
                if(isIsInStockParseSuccess == true)
                    selectedProduct.isInStock = isInStock;
                if(isPicNameEmpty == false)
                    selectedProduct.picName = productPicName;
                mydb.SubmitChanges();
                MessageBox.Show("資料更新成功");                
            }
            // 將listViewDataInfo顯示資料
            IQueryable<Product> query = from product
                                        in mydb.Product
                                        select product;
            if (query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Product product in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = product.ID;
                    item.Text = $"ID:{product.ID},名稱:{product.name},價格:{product.price},分類:{product.category},存貨:{product.isInStock},檔名:{product.picName}";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }
        // 刪除product資料表資料
        private void btnDelete_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 以ID刪除
            if(isIDEmpty == false)
            {
                Product selectedProduct = (from product
                                           in mydb.Product
                                           where product.ID == productID
                                           select product)
                                           .FirstOrDefault();
                if(selectedProduct != null)
                {
                    // 先刪除與產品有關的訂單
                    IQueryable<Order> orders = from order
                                               in mydb.Order
                                               where order.productID == selectedProduct.ID
                                               select order;
                    foreach (Order order in orders)
                    {
                        mydb.Order.DeleteOnSubmit(order);
                        mydb.SubmitChanges();
                    }
                    // 再刪除產品
                    mydb.Product.DeleteOnSubmit(selectedProduct);
                    mydb.SubmitChanges();
                    MessageBox.Show("資料刪除成功");
                }
                else
                {
                    MessageBox.Show("查無此ID");
                }    
            }
            // 以名稱刪除
            else if(isNameEmpty == false)
            {
                Product selectedProduct = (from product
                                           in mydb.Product
                                           where product.name == productName
                                           select product)
                                           .FirstOrDefault();
                if(selectedProduct != null)
                {
                    // 先刪除與產品有關的訂單
                    IQueryable<Order> orders = from order
                                               in mydb.Order
                                               where order.productID == selectedProduct.ID
                                               select order;
                    foreach(Order order in orders)
                    {
                        mydb.Order.DeleteOnSubmit(order);
                        mydb.SubmitChanges();
                    }
                    // 再刪除產品
                    mydb.Product.DeleteOnSubmit(selectedProduct);
                    mydb.SubmitChanges();
                    MessageBox.Show("刪除資料成功");
                }
                else
                {
                    MessageBox.Show("查無此名稱");
                }
            }
            else
            {
                MessageBox.Show("請輸入ID或名稱");
            }
            // 將listViewDataInfo顯示資料
            IQueryable<Product> query = from product
                                        in mydb.Product
                                        select product;
            if (query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Product product in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = product.ID;
                    item.Text = $"ID:{product.ID},名稱:{product.name},價格:{product.price},分類:{product.category},存貨:{product.isInStock},檔名:{product.picName}";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }
        // 讀取所有textbox
        void ReadTextBox()
        {
            // 若txtID沒有字串, 則productID為0
            Int32.TryParse(txtID.Text, out productID);       
            productName = txtName.Text;
            // 若txtPrice沒有字串, 則productPrice為0
            Int32.TryParse(txtPrice.Text, out productPrice);
            // 若txtIsInStock輸入失敗, 則isInStock為false
            isIsInStockParseSuccess = bool.TryParse(txtIsInStock.Text, out isInStock);
            productCategory = txtCategory.Text; 
            productPicName = txtFileName.Text;
            // 檢查各textbox是否有輸入字串
            if (productID == 0)
                isIDEmpty = true;
            else
                isIDEmpty = false;

            if (productName == "")
                isNameEmpty = true;
            else
                isNameEmpty = false;

            if (productPrice == 0)
                isPriceEmpty = true;
            else
                isPriceEmpty = false;

            if (productCategory == "")
                isCategoryEmpty = true;
            else
                isCategoryEmpty = false;

            if (productPicName == "")
                isPicNameEmpty = true;
            else
                isPicNameEmpty = false;
            // 清空所有textbox
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtCategory.Text = "";
            txtIsInStock.Text = "";
            txtFileName.Text = "";
        }
        // 當listViewDataInfo的Item被點擊時, 顯示其資料在所有textbox
        private void listViewDataInfo_ItemActivate(object sender, EventArgs e)
        {           
            if(listViewDataInfo.SelectedItems.Count > 0)
            {
                RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
                int selectedProductID = (int)listViewDataInfo.SelectedItems[0].Tag;
                Product selectedProduct = (from product
                                          in mydb.Product
                                          where product.ID == selectedProductID
                                          select product)
                                          .FirstOrDefault();
                // 將資料顯示在textbox
                txtID.Text = selectedProduct.ID.ToString();
                txtName.Text = selectedProduct.name;
                txtPrice.Text = selectedProduct.price.ToString();
                txtCategory.Text = selectedProduct.category.ToString();
                txtIsInStock.Text = selectedProduct.isInStock.ToString();
                txtFileName.Text = selectedProduct.picName;               
            }
        }
    }
}
