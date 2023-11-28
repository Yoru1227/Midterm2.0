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
    public partial class FormEnroll : Form
    {
        public FormEnroll()
        {
            InitializeComponent();
        }

        private void FormEnroll_Load(object sender, EventArgs e)
        {

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = comboGender.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;           
            string email = txtEmail.Text;
            string account = txtAccount.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            // 確認各欄位是否空白
            if(name == "")
            {
                MessageBox.Show("姓名欄位請勿空白");
            }
            else if(gender == "")
            {
                MessageBox.Show("性別欄位請勿空白");
            }
            else if (phone == "")
            {
                MessageBox.Show("電話欄位請勿空白");
            }
            else if (address == "")
            {
                MessageBox.Show("地址欄位請勿空白");
            }
            else if (email == "")
            {
                MessageBox.Show("email欄位請勿空白");
            }
            else if (account == "")
            {
                MessageBox.Show("帳號欄位請勿空白");
            }
            else if (password == "")
            {
                MessageBox.Show("密碼欄位請勿空白");
            }
            else if (confirmPassword == "")
            {
                MessageBox.Show("確認密碼欄位請勿空白");
            }
            // 密碼與確認密碼是否相同
            else if(password != confirmPassword)
            {
                MessageBox.Show("確認密碼輸入錯誤, 請重新輸入");
                txtConfirmPassword.Text = "";
            }
            else
            {
                RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
                Customer customer = new Customer();
                customer.name = name;
                customer.gender = gender;
                customer.phone = phone;
                customer.address = address;
                customer.email = email;
                customer.account = account;
                customer.password = password;

                mydb.Customer.InsertOnSubmit(customer);
                mydb.SubmitChanges();
                Console.WriteLine($"Name : {customer.name}\n" +
                    $"gender : {customer.gender}\n" +
                    $"phone : {customer.phone}\n" +
                    $"address : {customer.address}\n" +
                    $"email : {customer.email}\n" +
                    $"account : {customer.account}\n" +
                    $"password : {customer.password}");
                MessageBox.Show("註冊成功!");
                Close();
            }            
        }
    }
}
