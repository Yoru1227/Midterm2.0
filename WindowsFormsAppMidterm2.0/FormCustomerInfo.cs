﻿using System;
using System.Collections;
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
    public partial class FormCustomerInfo : Form
    {
        int customerID = 0;
        string customerName = "";
        string customerGender = "";
        string customerPhone = "";
        string customerEmail = "";
        string customerAddress = "";
        string customerAccount = "";
        string customerPassword = "";
        bool isBanned = false;
        bool isIDEmpty = true;
        bool isNameEmpty = true;
        bool isGenderEmpty = true;
        bool isPhoneEmpty = true;
        bool isEmailEmpty = true;
        bool isAddressEmpty = true;
        bool isAccountEmpty = true;
        bool isPasswordEmpty = true;
        bool isIsBannedParseSuccess = false;

        public FormCustomerInfo()
        {
            InitializeComponent();
        }

        private void FormCustomerInfo_Load(object sender, EventArgs e)
        {
            // 店員無法新增、刪除顧客
            if(GlobalVar.permission < 10000)
            {
                btnInsert.Visible = false;
                btnSearch.Dock = DockStyle.Fill;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }
        // 讀取所有textbox
        void ReadTextBox()
        {
            // 若txtID沒有字串, 則customerID為0
            Int32.TryParse(txtID.Text, out customerID);   
            customerName = txtName.Text;
            customerGender = comboGender.Text;
            customerPhone = txtPhone.Text;
            customerEmail = txtEmail.Text;
            customerAddress = txtAddress.Text;
            customerAccount = txtAccount.Text;
            customerPassword = txtPassword.Text;
            // 若txtIsBanned輸入失敗, 則isBanned為false
            isIsBannedParseSuccess = bool.TryParse(txtIsBanned.Text, out isBanned);
            // 檢查各textbox是否有輸入字串
            if(customerID == 0)
                isIDEmpty = true;    
            else
                isIDEmpty = false;

            if(customerName == "")
                isNameEmpty = true;
            else
                isNameEmpty = false;

            if (customerGender == "")
                isGenderEmpty = true;
            else
                isGenderEmpty = false;

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
            txtID.Text = "";
            txtName.Text = "";
            comboGender.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtIsBanned.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool isEnrolled = false;
            ReadTextBox();
            // 檢查所有欄位是否有字串
            if(isNameEmpty || isGenderEmpty || isPhoneEmpty || isEmailEmpty || isAddressEmpty || isAccountEmpty || isPasswordEmpty)
            {
                MessageBox.Show("所有欄位必須填入");
            }
            // 檢查電話是否已被註冊
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Customer> search = from Customer
                                          in mydb.Customer
                                          where Customer.phone == customerPhone
                                          select Customer;
            if(search.Count() > 0)
            {
                MessageBox.Show("電話已被註冊, 請重新輸入");
                txtPhone.Text = "";
                isEnrolled = true;
            }
            // 檢查email是否已被註冊
            search = from Customer
                     in mydb.Customer
                     where Customer.email == customerEmail
                     select Customer;
            if (search.Count() > 0)
            {
                MessageBox.Show("email已被註冊, 請重新輸入");
                txtPhone.Text = "";
                isEnrolled = true;
            }
            // 檢查帳號是否已被註冊
            search = from Customer
                     in mydb.Customer
                     where Customer.account == customerAccount
                     select Customer;
            if (search.Count() > 0)
            {
                MessageBox.Show("帳號已被註冊, 請重新輸入");
                txtPhone.Text = "";
                isEnrolled = true;
            }
            if(isEnrolled == false)
            {
                Customer customer = new Customer();
                customer.name = customerName;
                customer.gender = customerGender;
                customer.phone = customerPhone;
                customer.email = customerEmail;
                customer.address = customerAddress;
                customer.account = customerAccount;
                customer.password = customerPassword;
                mydb.Customer.InsertOnSubmit(customer);
                mydb.SubmitChanges();
                Console.WriteLine($"name : {customer.name}\n" +
                    $"gender : {customer.gender}\n" +
                    $"phone : {customer.phone}\n" +
                    $"address : {customer.address}\n" +
                    $"email : {customer.email}\n" +
                    $"account : {customer.account}\n" +
                    $"password : {customer.password}");
                MessageBox.Show("Insert成功");
            }
        }
        // 查詢customer資料表
        // 多重欄位查詢
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Customer> query = from customer
                                         in mydb.Customer
                                         select customer;
            // 若ID非空字串
            if(isIDEmpty == false)
            {
                query = from customer
                        in query
                        where customer.ID == customerID
                        select customer;
            }
            // 若名字非空字串
            if (isNameEmpty == false)
            {
                query = from customer
                        in query
                        where customer.name.Contains(customerName)
                        select customer;
            }
            // 若性別非空字串
            if (isGenderEmpty == false)
            {
                query = from customer
                        in query
                        where customer.gender == customerGender
                        select customer;
            }
            // 若電話非空字串
            if (isPhoneEmpty == false)
            {
                query = from customer
                        in query
                        where customer.phone == customerPhone            
                        select customer;
            }
            // 若email非空字串
            if (isEmailEmpty == false)
            {
                query = from customer
                        in query
                        where customer.email == customerEmail
                        select customer;
            }
            // 若地址非空字串
            if (isAddressEmpty == false)
            {
                query = from customer
                        in query
                        where customer.address.Contains(customerAddress)
                        select customer;
            }
            // 若帳號非空字串
            if (isAccountEmpty == false)
            {
                query = from customer
                        in query
                        where customer.account == customerAccount
                        select customer;
            }
            // 若密碼非空字串
            if (isPasswordEmpty == false)
            {
                query = from customer
                        in query
                        where customer.password == customerPassword
                        select customer;
            }
            // 若停權輸入成功
            if(isIsBannedParseSuccess == true)
            {
                query = from customer
                        in query
                        where customer.isBanned == isBanned
                        select customer;
            }
            // 將listViewDataInfo顯示資料
            if(query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Customer customer in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = customer.ID;
                    item.Text = $"ID:{customer.ID},姓名:{customer.name},電話:{customer.phone},email:{customer.email},地址:{customer.address},帳號:{customer.account},密碼:{customer.password},停權:{customer.isBanned}";
                    listViewDataInfo.Items.Add(item);
                }
            }           
        }
        // 更新customer資料表, 依ID更新
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Customer selectedCustomer = (from customer
                                         in mydb.Customer
                                         where customer.ID == customerID
                                         select customer)
                                         .FirstOrDefault();
            if (selectedCustomer != null)
            {                
                if(isNameEmpty == false)
                    selectedCustomer.name = customerName;
                if(isGenderEmpty == false)
                    selectedCustomer.gender = customerGender;
                if(isPhoneEmpty == false)
                    selectedCustomer.phone = customerPhone;
                if(isEmailEmpty == false)
                    selectedCustomer.email = customerEmail;
                if(isAddressEmpty == false)
                    selectedCustomer.address = customerAddress;
                if(isAccountEmpty == false)
                    selectedCustomer.account = customerAccount;
                if(isPasswordEmpty == false)
                    selectedCustomer.password = customerPassword;
                if(isIsBannedParseSuccess == true)
                    selectedCustomer.isBanned = isBanned;
                mydb.SubmitChanges();
                MessageBox.Show("資料更新成功");
            }
            // 將listViewDataInfo顯示資料
            IQueryable<Customer> query = from customer
                                         in mydb.Customer
                                         select customer;
            if (query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Customer customer in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = customer.ID;
                    item.Text = $"ID:{customer.ID},姓名:{customer.name},電話:{customer.phone},email:{customer.email},地址:{customer.address},帳號:{customer.account},密碼:{customer.password}";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }
        // 刪除customer資料表資料
        private void btnDelete_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 以ID刪除
            if(isIDEmpty == false)
            {
                Customer selectedCustomer = (from customer
                                             in mydb.Customer
                                             where customer.ID == customerID
                                             select customer)
                                             .FirstOrDefault();
                if (selectedCustomer != null)
                {
                    // 將顧客的所有訂單刪除
                    IQueryable<Order> PaidOrders = from order
                                                   in mydb.Order
                                                   where order.customerID == selectedCustomer.ID
                                                   select order;
                    foreach(Order order in PaidOrders)
                    {
                        mydb.Order.DeleteOnSubmit(order);
                        mydb.SubmitChanges();
                    }
                    mydb.Customer.DeleteOnSubmit(selectedCustomer);
                    mydb.SubmitChanges();
                    MessageBox.Show("資料刪除成功");
                }
                else
                {
                    MessageBox.Show("查無此ID");
                }
            }           
            else
            {
                MessageBox.Show("請輸入ID");
            }
            // 將listViewDataInfo顯示資料
            IQueryable<Customer> query = from customer
                                         in mydb.Customer
                                         select customer;
            if (query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Customer customer in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = customer.ID;
                    item.Text = $"ID:{customer.ID},姓名:{customer.name},電話:{customer.phone},email:{customer.email},地址:{customer.address},帳號:{customer.account},密碼:{customer.password}";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }

        private void listViewDataInfo_ItemActivate(object sender, EventArgs e)
        {
            if(listViewDataInfo.SelectedItems.Count > 0)
            {
                RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
                int selectedCustomerID = (int)listViewDataInfo.SelectedItems[0].Tag;
                Customer selectedCustomer = (from customer
                                            in mydb.Customer
                                            where customer.ID == selectedCustomerID
                                            select customer)
                                            .FirstOrDefault();
                // 將資料顯示在textbox
                txtID.Text = selectedCustomer.ID.ToString();
                txtName.Text = selectedCustomer.name;
                comboGender.Text = selectedCustomer.gender;
                txtPhone.Text = selectedCustomer.phone;
                txtEmail.Text = selectedCustomer.email;
                txtAddress.Text = selectedCustomer.address;
                txtAccount.Text = selectedCustomer.account;
                txtPassword.Text = selectedCustomer.password;
                txtIsBanned.Text = selectedCustomer.isBanned.ToString();
            }
        }
    }
}
