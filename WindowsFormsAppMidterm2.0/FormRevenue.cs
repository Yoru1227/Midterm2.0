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
    public partial class FormRevenue : Form
    {
        int revenue = 0;
        public FormRevenue()
        {
            InitializeComponent();
        }

        private void FormRevenue_Load(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now.AddDays(-7);
            dtpToDate.Value = DateTime.Now;           
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;           
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now.AddYears(-1);
            dtpToDate.Value = DateTime.Now;           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            revenue = 0;
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Order> orders = from order
                                       in mydb.Order
                                       where (order.datetime >= dtpFromDate.Value) && (order.datetime <= dtpToDate.Value) && (order.isPaid == true)
                                       select order;
            foreach (Order order in orders)
            {
                revenue += order.totalPrice;
            }
            lblRevenue.Text = $"{revenue}元";
        }
    }
}
