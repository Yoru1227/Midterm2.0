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
    public partial class FormEmployeeManage : Form
    {
        int employeeID = 0;
        string employeeName = "";
        int employeePermission = 0;
        int employeeSalary = 0;
        string employeeTitle = "";
        DateTime onboardingDate = DateTime.Now;
        DateTime resignDate = DateTime.Now;
        string employeeAccount = "";
        string employeePassword = "";
        bool isIDEmpty = true;
        bool isNameEmpty = true;
        bool isPermissionEmpty = true;
        bool isSalaryEmpty = true;
        bool isTitleEmpty = true;
        bool isOnboardingDateEmpty = true;
        bool isResignDateEmpty = true;
        bool isAccountEmpty = true;
        bool isPasswordEmpty = true;

        public FormEmployeeManage()
        {
            InitializeComponent();
        }

        private void FormEmployeeManage_Load(object sender, EventArgs e)
        {

        }
        // 讀取所有textbox
        void ReadTextBox()
        {
            // 若txtID沒有字串, 則EmployeeID為0
            Int32.TryParse(txtID.Text, out employeeID);
            employeeName = txtName.Text;
            // 若txtPermission沒有字串, 則EmployeePermission為0
            Int32.TryParse(txtPermission.Text, out employeePermission);
            // 若txtSalary沒有字串, 則EmployeeSalary為0
            Int32.TryParse(txtSalary.Text, out employeeSalary);
            employeeTitle = txtTitle.Text;
            onboardingDate = dtpStartDate.Value;
            resignDate = dtpEndDate.Value;
            employeeAccount = txtAccount.Text;
            employeePassword = txtPassword.Text;
            // 檢查各textbox或dtp是否有輸入字串
            if(employeeID == 0)
                isIDEmpty = true;
            else
                isIDEmpty = false;

            if(employeeName == "")
                isNameEmpty = true;
            else
                isNameEmpty = false;

            if(employeePermission == 0)
                isPermissionEmpty = true;
            else
                isPermissionEmpty = false;

            if(employeeSalary == 0)
                isSalaryEmpty = true;
            else
                isSalaryEmpty = false;

            if(employeeTitle == "")
                isTitleEmpty = true;
            else
                isTitleEmpty = false;

            if(employeeAccount == "")
                isAccountEmpty = true;
            else
                isAccountEmpty = false;

            if(employeePassword == "")
                isPasswordEmpty = true;
            else
                isPasswordEmpty = false;

            if(dtpStartDate.Value == DateTime.Now)
                isOnboardingDateEmpty = true;
            else
                isOnboardingDateEmpty = false;

            if(dtpEndDate.Value == DateTime.Now)
                isResignDateEmpty = true;
            else
                isResignDateEmpty = false;
            // 清空所有textbox
            txtID.Text = "";
            txtName.Text = "";
            txtPermission.Text = "";
            txtSalary.Text = "";
            txtTitle.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            dtpStartDate.Text = DateTime.Now.ToString();
            dtpEndDate.Text = DateTime.Now.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool isEnrolled = false;
            ReadTextBox();
            // 檢查所有欄位是否有字串
            Console.WriteLine(isNameEmpty);
            Console.WriteLine(isSalaryEmpty);
            Console.WriteLine(isTitleEmpty);
            Console.WriteLine(isPermissionEmpty);
            Console.WriteLine(isOnboardingDateEmpty);
            Console.WriteLine(isAccountEmpty);
            Console.WriteLine(isPasswordEmpty);
            if (isNameEmpty || isSalaryEmpty || isTitleEmpty|| isPermissionEmpty || isAccountEmpty || isPasswordEmpty)
            {
                MessageBox.Show("所有欄位必須填入");
            }
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 檢查帳號是否已被註冊
            IQueryable<Employee> search = from employee
                                          in mydb.Employee
                                          where employee.account == employeeAccount
                                          select employee;
            if(search.Count() > 0)
            {
                MessageBox.Show("帳號已被註冊, 請重新輸入");
                txtAccount.Text = "";
                isEnrolled = true;
            }
            if(isEnrolled == false)
            {
                Employee employee = new Employee();
                employee.name = employeeName;
                employee.permission = employeePermission;
                employee.salary = employeeSalary;
                employee.title = employeeTitle;
                employee.onBoardingDate = onboardingDate;
                // 離職日被更改才將資料輸入
                if(isResignDateEmpty == false)
                    employee.resignDate = resignDate;
                employee.account = employeeAccount;
                employee.password = employeePassword;
                mydb.Employee.InsertOnSubmit(employee);
                mydb.SubmitChanges();
                Console.WriteLine($"name : {employee.name}\n" +
                    $"permission : {employee.permission}\n" +
                    $"salary : {employee.salary}\n" +
                    $"title : {employee.title}\n" +
                    $"onboardingDate : {employee.onBoardingDate}\n" +
                    $"resignDate : {employee.resignDate}" +
                    $"account : {employee.account}\n" +
                    $"password : {employee.password}");
                MessageBox.Show("Insert成功");
            }
        }
        // 查詢employee資料表
        // 查詢所有員工
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            IQueryable<Employee> query = from employee
                                         in mydb.Employee
                                         select employee;
            // 將listViewDataInfo顯示資料
            if(query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach(Employee employee in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = employee.ID;
                    item.Text = $"ID:{employee.ID},姓名:{employee.name},薪水:{employee.salary}元,職稱:{employee.title},權限:{employee.permission},就職日:{employee.onBoardingDate},離職日:{employee.resignDate},帳號:{employee.account},密碼:{employee.password}";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            Employee selectedEmployee = (from employee
                                         in mydb.Employee
                                         where employee.ID == employeeID
                                         select employee)
                                         .FirstOrDefault();
            if(selectedEmployee != null)
            {
                if(isNameEmpty == false)
                    selectedEmployee.name = employeeName;
                if(isSalaryEmpty == false)
                    selectedEmployee.salary = employeeSalary;
                if(isPermissionEmpty == false)
                    selectedEmployee.permission = employeePermission;
                if (isOnboardingDateEmpty == false)
                    selectedEmployee.onBoardingDate = onboardingDate;
                if(isResignDateEmpty == false)
                    selectedEmployee.resignDate = resignDate;
                if(isTitleEmpty == false)
                    selectedEmployee.title = employeeTitle;
                if(isAccountEmpty == false)
                    selectedEmployee.account = employeeAccount;
                if(isPasswordEmpty == false)
                    selectedEmployee.password = employeePassword;
                mydb.SubmitChanges();
                MessageBox.Show("資料更新成功");
            }
            // 將listViewDataInfo更新
            IQueryable<Employee> query = from employee
                                         in mydb.Employee
                                         select employee;
            if (query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Employee employee in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = employee.ID;
                    item.Text = $"ID:{employee.ID},姓名:{employee.name},薪水:{employee.salary}元,職稱:{employee.title},權限:{employee.permission},就職日:{employee.onBoardingDate},離職日:{employee.resignDate},帳號:{employee.account},密碼:{employee.password}";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listViewDataInfo.Clear();
            ReadTextBox();
            RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
            // 以ID刪除
            if(isIDEmpty == false)
            {
                Employee selectedEmployee = (from employee
                                             in mydb.Employee
                                             where employee.ID == employeeID
                                             select employee)
                                             .FirstOrDefault();
                if(selectedEmployee != null)
                {
                    mydb.Employee.DeleteOnSubmit(selectedEmployee);
                    mydb.SubmitChanges();
                    MessageBox.Show("資料刪除成功");
                }
                else
                {
                    MessageBox.Show("查無此ID");
                }
            }
            // 以名字刪除
            else if(isNameEmpty == false)
            {
                Employee selectedEmployee = (from employee
                                             in mydb.Employee
                                             where employee.name == employeeName
                                             select employee)
                                             .FirstOrDefault();
                if(selectedEmployee != null)
                {
                    mydb.Employee.DeleteOnSubmit(selectedEmployee);
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
                MessageBox.Show("請輸入ID或名字");
            }
            // 將listViewDataInfo更新
            IQueryable<Employee> query = from employee
                                         in mydb.Employee
                                         select employee;
            if (query.Count() == 0)
            {
                MessageBox.Show("查無資料");
            }
            else
            {
                foreach (Employee employee in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = employee.ID;
                    item.Text = $"ID:{employee.ID},姓名:{employee.name},薪水:{employee.salary}元,職稱:{employee.title},權限:{employee.permission},就職日:{employee.onBoardingDate},離職日:{employee.resignDate},帳號:{employee.account},密碼:{employee.password}";
                    listViewDataInfo.Items.Add(item);
                }
            }
        }

        private void listViewDataInfo_ItemActivate(object sender, EventArgs e)
        {
            if(listViewDataInfo.SelectedItems.Count > 0)
            {
                RestaurantDataClassesDataContext mydb = new RestaurantDataClassesDataContext();
                int selectedEmployeeID = (int)listViewDataInfo.SelectedItems[0].Tag;
                Employee selectedEmployee = (from employee
                                          in mydb.Employee
                                          where employee.ID == selectedEmployeeID
                                          select employee)
                                          .FirstOrDefault();
                // 將資料顯示在textbox
                txtID.Text = selectedEmployee.ID.ToString();
                txtName.Text = selectedEmployee.name;
                txtPermission.Text = selectedEmployee.permission.ToString();
                txtTitle.Text = selectedEmployee.title;
                txtSalary.Text = selectedEmployee.salary.ToString();
                dtpStartDate.Text = selectedEmployee.onBoardingDate.ToString();
                dtpEndDate.Text = selectedEmployee.resignDate.ToString();
                txtAccount.Text = selectedEmployee.account;
                txtPassword.Text = selectedEmployee.password;
            }
        }
    }
}
