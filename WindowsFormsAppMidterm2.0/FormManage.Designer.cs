namespace WindowsFormsAppMidterm2._0
{
    partial class FormManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.btnMemberInfoManage = new System.Windows.Forms.Button();
            this.btnProductInfoManage = new System.Windows.Forms.Button();
            this.btnOrderManage = new System.Windows.Forms.Button();
            this.btnSystemManage = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFunc = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSystemManage);
            this.panelMenu.Controls.Add(this.btnOrderManage);
            this.panelMenu.Controls.Add(this.btnProductInfoManage);
            this.panelMenu.Controls.Add(this.btnMemberInfoManage);
            this.panelMenu.Controls.Add(this.lblLoginInfo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(187, 490);
            this.panelMenu.TabIndex = 0;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblLoginInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoginInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLoginInfo.Location = new System.Drawing.Point(0, 0);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(187, 56);
            this.lblLoginInfo.TabIndex = 0;
            this.lblLoginInfo.Text = "登入資訊";
            this.lblLoginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMemberInfoManage
            // 
            this.btnMemberInfoManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberInfoManage.FlatAppearance.BorderSize = 0;
            this.btnMemberInfoManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberInfoManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMemberInfoManage.Location = new System.Drawing.Point(0, 56);
            this.btnMemberInfoManage.Name = "btnMemberInfoManage";
            this.btnMemberInfoManage.Size = new System.Drawing.Size(187, 61);
            this.btnMemberInfoManage.TabIndex = 1;
            this.btnMemberInfoManage.Text = "會員資料管理";
            this.btnMemberInfoManage.UseVisualStyleBackColor = true;
            this.btnMemberInfoManage.Click += new System.EventHandler(this.btnMemberInfoManage_Click);
            // 
            // btnProductInfoManage
            // 
            this.btnProductInfoManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductInfoManage.FlatAppearance.BorderSize = 0;
            this.btnProductInfoManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInfoManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductInfoManage.Location = new System.Drawing.Point(0, 117);
            this.btnProductInfoManage.Name = "btnProductInfoManage";
            this.btnProductInfoManage.Size = new System.Drawing.Size(187, 61);
            this.btnProductInfoManage.TabIndex = 2;
            this.btnProductInfoManage.Text = "商品資料管理";
            this.btnProductInfoManage.UseVisualStyleBackColor = true;
            this.btnProductInfoManage.Click += new System.EventHandler(this.btnProductInfoManage_Click);
            // 
            // btnOrderManage
            // 
            this.btnOrderManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderManage.FlatAppearance.BorderSize = 0;
            this.btnOrderManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrderManage.Location = new System.Drawing.Point(0, 178);
            this.btnOrderManage.Name = "btnOrderManage";
            this.btnOrderManage.Size = new System.Drawing.Size(187, 61);
            this.btnOrderManage.TabIndex = 3;
            this.btnOrderManage.Text = "訂單管理";
            this.btnOrderManage.UseVisualStyleBackColor = true;
            this.btnOrderManage.Click += new System.EventHandler(this.btnOrderManage_Click);
            // 
            // btnSystemManage
            // 
            this.btnSystemManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemManage.FlatAppearance.BorderSize = 0;
            this.btnSystemManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSystemManage.Location = new System.Drawing.Point(0, 239);
            this.btnSystemManage.Name = "btnSystemManage";
            this.btnSystemManage.Size = new System.Drawing.Size(187, 61);
            this.btnSystemManage.TabIndex = 4;
            this.btnSystemManage.Text = "系統管理";
            this.btnSystemManage.UseVisualStyleBackColor = true;
            this.btnSystemManage.Click += new System.EventHandler(this.btnSystemManage_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(187, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(632, 56);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "OO小吃部管理系統";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFunc
            // 
            this.panelFunc.Controls.Add(this.button4);
            this.panelFunc.Controls.Add(this.button3);
            this.panelFunc.Controls.Add(this.button2);
            this.panelFunc.Controls.Add(this.button1);
            this.panelFunc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFunc.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelFunc.Location = new System.Drawing.Point(187, 426);
            this.panelFunc.Name = "panelFunc";
            this.panelFunc.Size = new System.Drawing.Size(632, 64);
            this.panelFunc.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(158, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "查詢";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(316, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 64);
            this.button3.TabIndex = 9;
            this.button3.Text = "更新";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(474, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 64);
            this.button4.TabIndex = 10;
            this.button4.Text = "刪除";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 490);
            this.Controls.Add(this.panelFunc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormManage";
            this.Text = "FormManage";
            this.Load += new System.EventHandler(this.FormManage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.Button btnSystemManage;
        private System.Windows.Forms.Button btnOrderManage;
        private System.Windows.Forms.Button btnProductInfoManage;
        private System.Windows.Forms.Button btnMemberInfoManage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFunc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}