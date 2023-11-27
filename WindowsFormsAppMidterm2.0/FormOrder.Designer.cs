namespace WindowsFormsAppMidterm2._0
{
    partial class FormOrder
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSide = new System.Windows.Forms.Button();
            this.btnSoup = new System.Windows.Forms.Button();
            this.btnNoodles = new System.Windows.Forms.Button();
            this.btnRice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewImage = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckCart = new System.Windows.Forms.Button();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnCheckCart);
            this.panelMenu.Controls.Add(this.btnSide);
            this.panelMenu.Controls.Add(this.btnSoup);
            this.panelMenu.Controls.Add(this.btnNoodles);
            this.panelMenu.Controls.Add(this.btnRice);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 461);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSide
            // 
            this.btnSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSide.FlatAppearance.BorderSize = 0;
            this.btnSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSide.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSide.Location = new System.Drawing.Point(0, 209);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(188, 51);
            this.btnSide.TabIndex = 2;
            this.btnSide.Text = "小菜";
            this.btnSide.UseVisualStyleBackColor = false;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // btnSoup
            // 
            this.btnSoup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSoup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSoup.FlatAppearance.BorderSize = 0;
            this.btnSoup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSoup.Location = new System.Drawing.Point(0, 158);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(188, 51);
            this.btnSoup.TabIndex = 1;
            this.btnSoup.Text = "湯類";
            this.btnSoup.UseVisualStyleBackColor = false;
            this.btnSoup.Click += new System.EventHandler(this.btnSoup_Click);
            // 
            // btnNoodles
            // 
            this.btnNoodles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnNoodles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoodles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNoodles.FlatAppearance.BorderSize = 0;
            this.btnNoodles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoodles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNoodles.Location = new System.Drawing.Point(0, 107);
            this.btnNoodles.Name = "btnNoodles";
            this.btnNoodles.Size = new System.Drawing.Size(188, 51);
            this.btnNoodles.TabIndex = 2;
            this.btnNoodles.Text = "麵類";
            this.btnNoodles.UseVisualStyleBackColor = false;
            this.btnNoodles.Click += new System.EventHandler(this.btnNoodles_Click);
            // 
            // btnRice
            // 
            this.btnRice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRice.FlatAppearance.BorderSize = 0;
            this.btnRice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRice.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRice.Location = new System.Drawing.Point(0, 56);
            this.btnRice.Name = "btnRice";
            this.btnRice.Size = new System.Drawing.Size(188, 51);
            this.btnRice.TabIndex = 2;
            this.btnRice.Text = "飯類";
            this.btnRice.UseVisualStyleBackColor = false;
            this.btnRice.Click += new System.EventHandler(this.btnRice_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "OO小吃部";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewImage
            // 
            this.listViewImage.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewImage.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewImage.HideSelection = false;
            this.listViewImage.Location = new System.Drawing.Point(188, 55);
            this.listViewImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewImage.Name = "listViewImage";
            this.listViewImage.Size = new System.Drawing.Size(596, 406);
            this.listViewImage.TabIndex = 1;
            this.listViewImage.UseCompatibleStateImageBehavior = false;
            this.listViewImage.ItemActivate += new System.EventHandler(this.listViewImage_ItemActivate);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(266, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblLoginInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 56);
            this.panel1.TabIndex = 3;
            // 
            // btnCheckCart
            // 
            this.btnCheckCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCheckCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckCart.FlatAppearance.BorderSize = 0;
            this.btnCheckCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckCart.Location = new System.Drawing.Point(0, 410);
            this.btnCheckCart.Name = "btnCheckCart";
            this.btnCheckCart.Size = new System.Drawing.Size(188, 51);
            this.btnCheckCart.TabIndex = 3;
            this.btnCheckCart.Text = "購物車";
            this.btnCheckCart.UseVisualStyleBackColor = false;
            this.btnCheckCart.Click += new System.EventHandler(this.btnCheckCart_Click);
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLoginInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoginInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLoginInfo.Location = new System.Drawing.Point(0, 0);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(596, 56);
            this.lblLoginInfo.TabIndex = 4;
            this.lblLoginInfo.Text = "登入資訊";
            this.lblLoginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewImage);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSoup;
        private System.Windows.Forms.Button btnSide;
        private System.Windows.Forms.Button btnNoodles;
        private System.Windows.Forms.Button btnRice;
        private System.Windows.Forms.ListView listViewImage;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckCart;
        private System.Windows.Forms.Label lblLoginInfo;
    }
}

