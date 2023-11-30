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
        int price = 0;
        int totalPrice = 0;
        int amount = 0;
        // 檢查txtComment是否有文字
        bool textboxHasText = false;
        public FormDetail()
        {
            InitializeComponent();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {            
            // 載入資料庫
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 查詢product
            Product result = (
                from product 
                in mydb.Product
                where product.ID == productID
                select product
                ).FirstOrDefault();
            // 預設值
            lblName.Text = result.name;
            price = result.price;
            totalPrice = result.price;
            amount = 1;
            lblPrice.Text = $"{result.price}元";
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
            bool success = int.TryParse(txtAmount.Text, out amount);
            if (success)
            {
                if (amount > 1)
                {
                    amount--;
                    totalPrice = amount * price;
                    txtAmount.Text = amount.ToString();
                    lblTotalPrice.Text = totalPrice.ToString() + "元";
                }
            }
            else
            {
                MessageBox.Show("數量輸入有誤,請重新輸入");
                txtAmount.Text = "1";
            }
        }
        // 加數量button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(txtAmount.Text, out amount);
            if (success)
            {
                amount++;
                totalPrice = amount * price;
                txtAmount.Text = amount.ToString();
                lblTotalPrice.Text = totalPrice.ToString() + "元";
            }
            else
            {
                MessageBox.Show("杯數輸入有誤,請重新輸入");
                txtAmount.Text = "1";
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Order order = new Order();
            order.customerID = GlobalVar.ID;
            order.datetime = DateTime.Now;
            order.productID = productID;
            order.amount = amount;
            order.totalPrice = totalPrice;
            order.employeeID = 1;
            // lblComment有文字就輸入資料, 否則輸入空字串
            if (textboxHasText == true)
                order.comment = txtComment.Text;
            else
                order.comment = "";
            // insert into DB
            mydb.Order.InsertOnSubmit(order);
            mydb.SubmitChanges();
            Console.WriteLine($"customerID : {order.customerID}\n" +
                $"datetime : {order.datetime}\n" +
                $"productID : {order.productID}\n" +
                $"amount : {order.amount}\n" +
                $"totalPrice : {order.totalPrice}\n" +
                $"employeeID : {order.employeeID}");
            Close();
        }
        // 聚焦txtComment
        private void txtComment_Enter(object sender, EventArgs e)
        {
            if(textboxHasText == false)
            {
                txtComment.Text = "";
                txtComment.ForeColor = Color.Black;
                txtComment.Font = new Font("微軟正黑體", 16, FontStyle.Regular);
            }
        }
        // txtComment失去焦點
        private void txtComment_Leave(object sender, EventArgs e)
        {
            if(txtComment.Text == "")
            {
                txtComment.Text = "備註(例 : 小辣)";
                txtComment.ForeColor = Color.LightGray;
                txtComment.Font = new Font("微軟正黑體", 16, FontStyle.Italic);
                textboxHasText = false;
            }
            else
            {
                textboxHasText = true;
            }
        }
    }
}
