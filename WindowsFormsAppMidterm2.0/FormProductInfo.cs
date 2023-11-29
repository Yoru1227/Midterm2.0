using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        bool isNameEmpty = true;
        bool isPriceEmpty = true;
        bool isCategoryEmpty = true;
        bool isIsInStockEmpty = true;
        bool isPicNameEmpty = true;
        public FormProductInfo()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            ReadTextBox();
            // 檢查所有欄位是否有字串
            if(isNameEmpty || isPriceEmpty || isCategoryEmpty || isIsInStockEmpty || isPicNameEmpty)
            {
                MessageBox.Show("所有欄位必須填入");
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
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Product> query = from product
                                        in mydb.Product
                                        select product;
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
            // 若存貨非空字串
            if(isIsInStockEmpty == false)
            {
                query = from product
                        in query
                        where product.isInStock == isInStock
                        select product;
            }
            foreach(Product product in query)
            {
                listViewDataInfo.Items.Add($"$ID:{product.ID},名稱:{product.name},價格:{product.price},分類:{product.category},存貨:{product.isInStock},檔名:{product.picName}");
            }
        }
        // 更新product資料表
        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
                if(isIsInStockEmpty == false)
                    selectedProduct.isInStock = isInStock;
                if(isPicNameEmpty == false)
                    selectedProduct.picName = productPicName;
                mydb.SubmitChanges();
                MessageBox.Show("資料更新成功");
            }
        }
        // 刪除product資料表資料
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 以ID刪除
            if(productID > 0)
            {
                Product selectedProduct = (from product
                                           in mydb.Product
                                           where product.ID == productID
                                           select product)
                                           .FirstOrDefault();
                if(selectedProduct != null)
                {
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
            else if(productName != "")
            {
                Product selectedProduct = (from product
                                           in mydb.Product
                                           where product.name == productName
                                           select product)
                                           .FirstOrDefault();
                if(selectedProduct != null)
                {
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
        }
        // 讀取所有textbox
        void ReadTextBox()
        {
            bool success = Int32.TryParse(txtID.Text, out int result);
            if (success)
                productID = result;
            productName = txtName.Text;
            success = Int32.TryParse(txtPrice.Text, out result);
            if (success)
                productCategory = txtCategory.Text;           
                productPrice = result;
            productPicName = txtFileName.Text;
            // 檢查各textbox是否有輸入字串
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
                isCategoryEmpty = true;
            else
                isCategoryEmpty = false;
            // 清空所有textbox
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtCategory.Text = "";
            txtIsInStock.Text = "";
            txtFileName.Text = "";
        }
    }
}
