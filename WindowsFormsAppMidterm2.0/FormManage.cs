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
        public FormManage()
        {
            InitializeComponent();
        }

        private void FormManage_Load(object sender, EventArgs e)
        {

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
                    Button temp = (Button)button;
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

        }

        private void btnProductInfoManage_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderManage_Click(object sender, EventArgs e)
        {

        }

        private void btnSystemManage_Click(object sender, EventArgs e)
        {

        }
    }
}
