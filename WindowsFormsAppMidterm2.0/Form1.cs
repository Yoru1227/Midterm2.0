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
    public partial class Form1 : Form
    {        
        List<int> listProductID = new List<int>();
        List<string> listProductName = new List<string>();
        List<int> listProductPrice = new List<int>();
        List<string> listProductCategory = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "RestaurantDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.strMyDBConnectionString = scsb.ConnectionString;
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            if(GlobalVar.isLogin == false)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
            }

            lblLoginInfo.Text = $"{GlobalVar.userName}, 您好";
            ReadPics();
            
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
                    Button temp = (Button)button;
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
                listProductID.Add(product.ID);
                listProductName.Add(product.name);
                listProductPrice.Add(product.price);
                listProductCategory.Add(product.category);
                string fullDir = GlobalVar.imageDirWork + @"\" + product.picName;
                Console.WriteLine(fullDir);
                Image image = Image.FromFile(fullDir);
                imageList.Images.Add(image);
            }
        }
        // 顯示listViewImage的圖片
        void DisplayListView(string category)
        {
            listViewImage.Clear();
            listViewImage.View = View.LargeIcon;
            imageList.ImageSize = new Size(128, 128);
            listViewImage.LargeImageList = imageList;         
            for(int i = 0; i < imageList.Images.Count; i++)
            {
                // 將同類別加入ListView
                if (category == listProductCategory[i])
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = $"{listProductName[i]} {listProductPrice[i]}元";
                    item.Font = new Font("微軟正黑體", 12);
                    item.Tag = listProductID[i];
                    listViewImage.Items.Add(item);
                }
            }
        }

        private void listViewImage_ItemActivate(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            FormDetail formDetail = new FormDetail();
            formDetail.selectID = (int)listView.SelectedItems[0].Tag;
            formDetail.ShowDialog();
        }

        private void btnCheckCart_Click(object sender, EventArgs e)
        {

        }
    }
}
