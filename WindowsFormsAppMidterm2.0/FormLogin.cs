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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
                     
        }
        // 按下登入按鈕
        private void btnLogin_Click(object sender, EventArgs e)
        {
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            string account = txtAccount.Text;
            string password = txtPassword.Text;
            IQueryable<Employee> search = from person
                                in mydb.Employee
                                where (person.account == account) && (person.password == password)
                                select person;
            Employee employee = search.FirstOrDefault();
            if(search.Count() == 1)
            {
                GlobalVar.ID = employee.ID;
                GlobalVar.userName = employee.name;
                GlobalVar.isLogin = true;
                Close();
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.isLogin == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
