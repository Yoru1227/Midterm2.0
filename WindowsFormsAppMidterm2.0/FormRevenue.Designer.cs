namespace WindowsFormsAppMidterm2._0
{
    partial class FormRevenue
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(944, 69);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 69);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(353, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "營業額 : ";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRevenue.Location = new System.Drawing.Point(478, 169);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(59, 35);
            this.lblRevenue.TabIndex = 3;
            this.lblRevenue.Text = "0元";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.btnYear);
            this.panel2.Controls.Add(this.btnMonth);
            this.panel2.Controls.Add(this.btnWeek);
            this.panel2.Controls.Add(this.btnToday);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 69);
            this.panel2.TabIndex = 4;
            // 
            // btnYear
            // 
            this.btnYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.Location = new System.Drawing.Point(708, 0);
            this.btnYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(236, 69);
            this.btnYear.TabIndex = 14;
            this.btnYear.Text = "本年";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Location = new System.Drawing.Point(472, 0);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(236, 69);
            this.btnMonth.TabIndex = 13;
            this.btnMonth.Text = "本月";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Location = new System.Drawing.Point(236, 0);
            this.btnWeek.Margin = new System.Windows.Forms.Padding(4);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(236, 69);
            this.btnWeek.TabIndex = 12;
            this.btnWeek.Text = "本周";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnToday
            // 
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Location = new System.Drawing.Point(0, 0);
            this.btnToday.Margin = new System.Windows.Forms.Padding(4);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(236, 69);
            this.btnToday.TabIndex = 11;
            this.btnToday.Text = "本日";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpFromDate.Location = new System.Drawing.Point(74, 350);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(385, 43);
            this.dtpFromDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "從";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(478, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "到";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpToDate.Location = new System.Drawing.Point(538, 348);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(385, 43);
            this.dtpToDate.TabIndex = 7;
            // 
            // FormRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormRevenue";
            this.Text = "FormRevenue";
            this.Load += new System.EventHandler(this.FormRevenue_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
    }
}