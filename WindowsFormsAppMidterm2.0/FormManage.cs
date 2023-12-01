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
    public partial class FormManage : Form
    {
        private Form activeForm;
        public FormManage()
        {
            InitializeComponent();
        }

        private void FormManage_Load(object sender, EventArgs e)
        {
            DisableButton();
            OpenChildForm(new FormCustomerInfo(), btnMemberInfoManage);
        }
        // 取消勾選按鈕, 改變前後景顏色
        void DisableButton()
        {
            Color bgColor = Color.FromArgb(51, 51, 76);
            Color foreColor = Color.Gainsboro;
            foreach (Control button in panelMenu.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
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

        private void btnMemberInfoManage_Click(object sender, EventArgs e)
        {
            DisableButton();
            OpenChildForm(new FormCustomerInfo(), sender);
        }

        private void btnProductInfoManage_Click(object sender, EventArgs e)
        {
            DisableButton();
            OpenChildForm(new FormProductInfo(), sender);
        }

        private void btnOrderManage_Click(object sender, EventArgs e)
        {
            DisableButton();
            OpenChildForm(new FormOrderInfo(), sender);
        }

        private void btnSystemManage_Click(object sender, EventArgs e)
        {
            DisableButton();
            OpenChildForm(new FormEmployeeManage(), sender);
        }
        // 開啟子表單
        private void OpenChildForm(Form childForm, object btnSender)
        {
            // 若childForm已開啟, 將activeForm關掉
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton((Button)btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
