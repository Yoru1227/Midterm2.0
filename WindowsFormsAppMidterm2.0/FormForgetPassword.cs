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
    public partial class FormForgetPassword : Form
    {
        string account = "";
        string phone = "";
        string email = "";
        string password = "";
        string confirmPassword = "";
        bool isAccountEmpty = true;
        bool isPhoneEmpty = true;
        bool isEmailEmpty = true;
        bool isPasswordEmpty = true;
        bool isConfirmPasswordEmpty = true;

        public FormForgetPassword()
        {
            InitializeComponent();
        }

        private void FormForgetPassword_Load(object sender, EventArgs e)
        {

        }
        // 讀取所有textbox欄位
        void ReadTextBox()
        {
            account = txtAccount.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;
            password = txtPassword.Text;
            confirmPassword = txtConfirmPassword.Text;

            if (account == "")
                isAccountEmpty = true;
            else
                isAccountEmpty = false;

            if(phone == "")
                isPhoneEmpty = true; 
            else
                isPhoneEmpty = false;

            if(email == "")
                isEmailEmpty = true;
            else
                isEmailEmpty = false;

            if(password == "")
                isPasswordEmpty = true;
            else
                isPasswordEmpty = false;

            if (confirmPassword == "")
                isConfirmPasswordEmpty = true;
            else
                isConfirmPasswordEmpty = false;
            // 清空所有textbox
            txtAccount.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
        // 更新customer密碼
        // 多重欄位查詢
        private void btnChange_Click(object sender, EventArgs e)
        {
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Customer> query = from customer
                                         in mydb.Customer
                                         select customer;           
            if (isAccountEmpty == true)
            {
                MessageBox.Show("請輸入帳號");
                return;
            }              
            else
            {
                query = from customer
                        in query
                        where customer.account == account
                        select customer;
            }
            // 密碼與確認密碼不符
            if(password != confirmPassword)
            {
                MessageBox.Show("密碼與確認密碼不符, 請重新輸入");
                return;
            }
            if (isPhoneEmpty == false)
            {
                query = from customer 
                        in query
                        where customer.phone == phone
                        select customer;
            }
            if (isEmailEmpty == false)
            {
                query = from customer
                        in query
                        where customer.email == email
                        select customer;
            }        
            // 查詢到對應的帳號
            if(query.Count() == 1)
            {
                Customer selectedCustomer = (from customer
                                            in query
                                            select customer)
                                            .FirstOrDefault();
                selectedCustomer.password = password;
                mydb.SubmitChanges();
                MessageBox.Show("密碼更新成功");
            }
        }
    }
}
