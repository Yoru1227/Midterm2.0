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
    public partial class FormCustomerUpdate : Form
    {
        int customerID = 0;
        string customerName = "";
        string customerPhone = "";
        string customerEmail = "";
        string customerAddress = "";
        string customerAccount = "";
        string customerPassword = "";
        string customerConfirmPassword = "";
        bool isNameEmpty = true;
        bool isPhoneEmpty = true;
        bool isEmailEmpty = true;
        bool isAddressEmpty = true;
        bool isAccountEmpty = true;
        bool isPasswordEmpty = true;
        public FormCustomerUpdate()
        {
            InitializeComponent();
        }

        private void FormCustomerUpdate_Load(object sender, EventArgs e)
        {
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Customer selectedCustomer = (from customer
                                         in mydb.Customer
                                         where customer.ID == GlobalVar.ID
                                         select customer)
                                         .FirstOrDefault();
            txtName.Text = selectedCustomer.name;
            txtPhone.Text = selectedCustomer.phone;
            txtEmail.Text = selectedCustomer.email;
            txtAddress.Text = selectedCustomer.address;
            txtAccount.Text = selectedCustomer.account;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Customer selectedCustomer = (from customer
                                        in mydb.Customer
                                        where customer.ID == customerID
                                        select customer)
                                        .FirstOrDefault();
            if (selectedCustomer != null)
            {
                // 更新名字
                if(isNameEmpty == false)
                    selectedCustomer.name = customerName;
                // 更新手機號碼
                if (isPhoneEmpty == false)
                    selectedCustomer.phone = customerPhone;                
                // 更新email
                if(isEmailEmpty == false)
                {
                    // 判斷更新後的email是否被註冊過
                    IQueryable<Customer> query = from customer
                                                 in mydb.Customer
                                                 where (customer.email == customerEmail) && (customer.ID != customerID)
                                                 select customer;
                    if (query.Count() == 1)
                        MessageBox.Show("Email已被註冊");
                    else
                        selectedCustomer.email = customerEmail;
                }
                if(isAddressEmpty == false)
                    selectedCustomer.address = customerAddress;
                // 更新帳號
                if (isAccountEmpty == false)
                {
                    // 判斷更新後的帳號是否被註冊過
                    IQueryable<Customer> query = from customer
                                                 in mydb.Customer
                                                 where (customer.account == customerAccount) && (customer.ID != customerID)
                                                 select customer;
                    if (query.Count() == 1)
                        MessageBox.Show("帳號已被註冊");
                    else
                        selectedCustomer.account = customerAccount;
                }
                // 更新密碼
                if(isPasswordEmpty == false)
                {
                    // 密碼與確認密碼相同則更新密碼
                    if (customerPassword == customerConfirmPassword)
                        selectedCustomer.password = customerPassword;
                    else
                        MessageBox.Show("密碼與確認密碼不符");
                }
                mydb.SubmitChanges();
                MessageBox.Show("會員資料更改成功");
                Close();
            }
        }

        // 讀取所有textbox
        void ReadTextBox()
        {
            customerID = GlobalVar.ID;
            customerName = txtName.Text;
            customerPhone = txtPhone.Text;
            customerEmail = txtEmail.Text;
            customerAddress = txtAddress.Text;
            customerAccount = txtAccount.Text;
            customerPassword = txtPassword.Text;
            customerConfirmPassword = txtConfirmPassword.Text;
            // 檢查各textbox是否有輸入字串
            if (customerName == "")
                isNameEmpty = true;
            else
                isNameEmpty = false;

            if (customerPhone == "")
                isPhoneEmpty = true;
            else
                isPhoneEmpty = false;

            if (customerEmail == "")
                isEmailEmpty = true;
            else
                isEmailEmpty = false;

            if (customerAddress == "")
                isAddressEmpty = true;
            else
                isAddressEmpty = false;

            if (customerAccount == "")
                isAccountEmpty = true;
            else
                isAccountEmpty = false;

            if (customerPassword == "")
                isPasswordEmpty = true;
            else
                isPasswordEmpty = false;
            // 清空所有textbox
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
