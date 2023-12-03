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
            Console.WriteLine(DateTime.Now.ToString());
        }
        // 按下登入按鈕
        private void btnLogin_Click(object sender, EventArgs e)
        {
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            string account = txtAccount.Text;
            string password = txtPassword.Text;
            IQueryable<Employee> searchEmployee = from person
                                in mydb.Employee
                                where (person.account == account) && (person.password == password)
                                select person;
            IQueryable<Customer> searchCustomer = from person
                                in mydb.Customer
                                where (person.account == account) && (person.password == password)
                                select person;
            Employee employee = searchEmployee.FirstOrDefault();
            Customer customer = searchCustomer.FirstOrDefault();
            if(searchEmployee.Count() == 1)
            {
                GlobalVar.ID = employee.ID;
                GlobalVar.userName = employee.name;
                GlobalVar.isLogin = true;
                GlobalVar.permission = employee.permission;
                Hide();
                FormManage formManage = new FormManage();
                formManage.ShowDialog();
            }
            if(searchCustomer.Count() == 1)
            {
                // 檢查是否被停權
                if(searchCustomer.FirstOrDefault().isBanned == true)
                {
                    MessageBox.Show("此帳號已被停權");
                }
                else
                {
                    GlobalVar.ID = customer.ID;
                    GlobalVar.userName = customer.name;
                    GlobalVar.isLogin = true;
                    GlobalVar.permission = 1;
                    Hide();
                    FormOrder formOrder = new FormOrder();
                    formOrder.ShowDialog();
                }            
            }
            if(searchEmployee.Count() + searchCustomer.Count() == 0)
            {
                MessageBox.Show("登入資訊有誤, 請重新輸入");
                txtAccount.Text = "";
                txtPassword.Text = "";
            }
        }        

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            FormEnroll formEnroll = new FormEnroll();
            formEnroll.ShowDialog();
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            FormForgetPassword formForgetPassword = new FormForgetPassword();
            formForgetPassword.ShowDialog();
        }

        private void txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtAccount.Focus();
            }           
        }
    }
}
