﻿namespace WindowsFormsAppMidterm2._0
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
            this.btnSystemManage = new System.Windows.Forms.Button();
            this.btnOrderManage = new System.Windows.Forms.Button();
            this.btnProductInfoManage = new System.Windows.Forms.Button();
            this.btnMemberInfoManage = new System.Windows.Forms.Button();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnRevenue);
            this.panelMenu.Controls.Add(this.btnSystemManage);
            this.panelMenu.Controls.Add(this.btnOrderManage);
            this.panelMenu.Controls.Add(this.btnProductInfoManage);
            this.panelMenu.Controls.Add(this.btnMemberInfoManage);
            this.panelMenu.Controls.Add(this.lblLoginInfo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(249, 654);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSystemManage
            // 
            this.btnSystemManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemManage.FlatAppearance.BorderSize = 0;
            this.btnSystemManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSystemManage.Location = new System.Drawing.Point(0, 298);
            this.btnSystemManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSystemManage.Name = "btnSystemManage";
            this.btnSystemManage.Size = new System.Drawing.Size(249, 76);
            this.btnSystemManage.TabIndex = 4;
            this.btnSystemManage.Text = "員工管理";
            this.btnSystemManage.UseVisualStyleBackColor = true;
            this.btnSystemManage.Click += new System.EventHandler(this.btnSystemManage_Click);
            // 
            // btnOrderManage
            // 
            this.btnOrderManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderManage.FlatAppearance.BorderSize = 0;
            this.btnOrderManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrderManage.Location = new System.Drawing.Point(0, 222);
            this.btnOrderManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderManage.Name = "btnOrderManage";
            this.btnOrderManage.Size = new System.Drawing.Size(249, 76);
            this.btnOrderManage.TabIndex = 3;
            this.btnOrderManage.Text = "訂單管理";
            this.btnOrderManage.UseVisualStyleBackColor = true;
            this.btnOrderManage.Click += new System.EventHandler(this.btnOrderManage_Click);
            // 
            // btnProductInfoManage
            // 
            this.btnProductInfoManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductInfoManage.FlatAppearance.BorderSize = 0;
            this.btnProductInfoManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInfoManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductInfoManage.Location = new System.Drawing.Point(0, 146);
            this.btnProductInfoManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductInfoManage.Name = "btnProductInfoManage";
            this.btnProductInfoManage.Size = new System.Drawing.Size(249, 76);
            this.btnProductInfoManage.TabIndex = 2;
            this.btnProductInfoManage.Text = "商品資料管理";
            this.btnProductInfoManage.UseVisualStyleBackColor = true;
            this.btnProductInfoManage.Click += new System.EventHandler(this.btnProductInfoManage_Click);
            // 
            // btnMemberInfoManage
            // 
            this.btnMemberInfoManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberInfoManage.FlatAppearance.BorderSize = 0;
            this.btnMemberInfoManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberInfoManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMemberInfoManage.Location = new System.Drawing.Point(0, 70);
            this.btnMemberInfoManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemberInfoManage.Name = "btnMemberInfoManage";
            this.btnMemberInfoManage.Size = new System.Drawing.Size(249, 76);
            this.btnMemberInfoManage.TabIndex = 1;
            this.btnMemberInfoManage.Text = "會員資料管理";
            this.btnMemberInfoManage.UseVisualStyleBackColor = true;
            this.btnMemberInfoManage.Click += new System.EventHandler(this.btnMemberInfoManage_Click);
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblLoginInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoginInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLoginInfo.Location = new System.Drawing.Point(0, 0);
            this.lblLoginInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(249, 70);
            this.lblLoginInfo.TabIndex = 0;
            this.lblLoginInfo.Text = "登入資訊";
            this.lblLoginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(249, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(943, 70);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "阿儒小吃部管理系統";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(249, 70);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(943, 584);
            this.panelChildForm.TabIndex = 7;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRevenue.Location = new System.Drawing.Point(0, 374);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(249, 76);
            this.btnRevenue.TabIndex = 5;
            this.btnRevenue.Text = "營業額計算";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 654);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManage";
            this.Text = "FormManage";
            this.Load += new System.EventHandler(this.FormManage_Load);
            this.panelMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnRevenue;
    }
}