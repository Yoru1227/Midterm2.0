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
        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"{GlobalVar.userName}的購物車";
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 查詢Order資料表與customerID有關的資料
            IQueryable<Order> orderQuery = from order in mydb.Order where order.customerID == GlobalVar.ID select order;
            foreach(Order order in orderQuery)
            {
                // 查詢order對應的Product
                IQueryable<Product> productQuery = from product in mydb.Product where product.ID == order.productID select product; 
                Product selectedProduct = productQuery.FirstOrDefault();
                string str = $"ID :訂單編號:{order.ID},{selectedProduct.name},單價:{selectedProduct.price},數量:{order.amount},總價:{order.totalPrice}{(order.comment == "" ? "" : ",")}{order.comment}";               
                listViewOrderList.Items.Add(str);
                Console.WriteLine($"orderID : {order.ID}" +
                $"customerID : {order.customerID}\n" +
                $"datetime : {order.datetime}\n" +
                $"productID : {order.productID}\n" +
                $"amount : {order.amount}\n" +
                $"totalPrice : {order.totalPrice}\n" +
                $"employeeID : {order.employeeID}\n" +
                $"comment : {order.comment}");
            }

        }
    }
}
