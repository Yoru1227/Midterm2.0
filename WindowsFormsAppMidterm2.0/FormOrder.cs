using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace WindowsFormsAppMidterm2._0
{
    public partial class FormOrder : Form
    {        
        public FormOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 資料庫連線
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "RestaurantDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.strMyDBConnectionString = scsb.ConnectionString;
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();           

            lblLoginInfo.Text = $"{GlobalVar.userName}, 您好";
            ReadPics();
            // 預設顯示飯類
            string category = "飯類";
            DisableButton();
            ActivateButton(btnRice);
            DisplayListView(category);

        }
        // 取消勾選按鈕, 改變前後景顏色
        void DisableButton()
        {      
            Color bgColor = Color.FromArgb(51, 51, 76);
            Color foreColor = Color.Gainsboro;
            foreach(Control button in panelMenu.Controls)
            {
                if(button.GetType() == typeof(Button))
                {
                    button.BackColor = bgColor;
                    button.ForeColor = foreColor;
                }
            }
        }
        // 勾選按鈕, 改變前後景顏色
        void ActivateButton(Button sender)
        {
            Color bgColor = Color.AliceBlue;
            Color foreColor = Color.Coral;
            sender.BackColor = bgColor;
            sender.ForeColor = foreColor;
        }
        private void btnRice_Click(object sender, EventArgs e)
        {
            string category = "飯類";
            DisableButton();
            ActivateButton((Button)sender);           
            DisplayListView(category);
        }

        private void btnNoodles_Click(object sender, EventArgs e)
        {
            string category = "麵類";
            DisableButton();
            ActivateButton((Button)sender);
            DisplayListView(category);
        }

        private void btnSoup_Click(object sender, EventArgs e)
        {
            string category = "湯類";
            DisableButton();
            ActivateButton((Button)sender);
            DisplayListView(category);
        }
        private void btnSide_Click(object sender, EventArgs e)
        {
            string category = "小菜";
            DisableButton();
            ActivateButton((Button)sender);
            DisplayListView(category);
        }
        // 讀取圖檔
        void ReadPics()
        {
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable result = from product in mydb.Product select product;
            foreach (Product product in result)
            {
                // 從路徑中讀取圖檔
                string fullDir = GlobalVar.imageDirHome + @"\" + product.picName;
                Image image = Image.FromFile(fullDir);
                imageList.Images.Add(image);               
            }
        }
        // 顯示listViewImage的圖片
        void DisplayListView(string category)
        {
            listViewImage.Clear();
            listViewImage.View = View.LargeIcon;
            imageList.ImageSize = new Size(150, 150);
            listViewImage.LargeImageList = imageList;
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Product> search = from product
                                         in mydb.Product 
                                         select product;
            int index = 0;
            foreach(Product product in search)
            {
                if (category == product.category)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = index;
                    item.Text = $"{product.name} {product.price}元";
                    item.Font = new Font("微軟正黑體", 12);
                    item.Tag = product.ID;
                    listViewImage.Items.Add(item);
                }
                index++;
            }           
        }
        // 點擊listViewImage的Item
        private void listViewImage_ItemActivate(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            FormDetail formDetail = new FormDetail();
            formDetail.productID = (int)listView.SelectedItems[0].Tag;
            formDetail.ShowDialog();
        }
        // 點擊購物車按鈕
        private void btnCheckCart_Click(object sender, EventArgs e)
        {
            // 創建formCart表單
            FormCart formCart = new FormCart();
            // 隱藏formOrder表單
            Hide();
            // 顯示formCart表單
            formCart.ShowDialog();
            // 隱藏formOrder表單
            Show();
        }
    }
}
