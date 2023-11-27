using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMidterm2._0
{
    
    public partial class FormDetail : Form
    {
        public int productID = 0;
        string name = string.Empty;
        int price = 0;
        int totalPrice = 0;
        int amount = 0;
        public FormDetail()
        {
            InitializeComponent();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {            
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Product result = (
                from product 
                in mydb.Product
                where product.ID == productID
                select product
                ).FirstOrDefault();
            name = result.name;
            lblName.Text = result.name;
            price = result.price;
            lblPrice.Text = $"{result.price.ToString()}元";
            lblTotalPrice.Text = $"{result.price}元";
            // 載入圖片
            Image image = Image.FromFile(GlobalVar.imageDirWork + @"\" + result.picName);
            imageList.Images.Add(image);
            listViewImage.View = View.LargeIcon;
            imageList.ImageSize = new Size(120, 120);
            listViewImage.LargeImageList = imageList;
            ListViewItem item = new ListViewItem();
            item.ImageIndex = 0;
            item.Text = $"";
            item.Font = new Font("微軟正黑體", 12);
            item.Tag = productID;
            listViewImage.Items.Add(item);
        }
        // 減數量button
        private void btnSubstract_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(tbAmount.Text, out amount);
            if (success)
            {
                if (amount > 1)
                {
                    amount--;
                    totalPrice = amount * price;
                    tbAmount.Text = amount.ToString();
                    lblTotalPrice.Text = totalPrice.ToString() + "元";
                }
            }
            else
            {
                MessageBox.Show("數量輸入有誤,請重新輸入");
                tbAmount.Text = "1";
            }
        }
        // 加數量button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(tbAmount.Text, out amount);
            if (success)
            {
                amount++;
                totalPrice = amount * price;
                tbAmount.Text = amount.ToString();
                lblTotalPrice.Text = totalPrice.ToString() + "元";
            }
            else
            {
                MessageBox.Show("杯數輸入有誤,請重新輸入");
                tbAmount.Text = "1";
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Order order = new Order();
            order.customerID = 0;
            order.datetime = DateTime.Now;
            order.productID = productID;
            order.amount = amount;
            order.totalPrice = totalPrice;
            order.employeeID = 1;

            mydb.Order.InsertOnSubmit(order);
            mydb.SubmitChanges();
            Console.WriteLine($"customerID : {order.customerID}\n" +
                $"datetime : {order.datetime}\n" +
                $"productID : {order.productID}\n" +
                $"amount : {order.amount}\n" +
                $"totalPrice : {order.totalPrice}\n" +
                $"employeeID : {order.employeeID}");
        }
    }
}
