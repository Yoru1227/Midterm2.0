namespace WindowsFormsAppMidterm2._0
{
    partial class FormDetail
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.lblAmountText = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnAddCart = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "阿儒小吃部";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(264, 79);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(191, 62);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "品名";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(264, 225);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(191, 62);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "價格";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("微軟正黑體 Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtComment.Location = new System.Drawing.Point(16, 311);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(641, 173);
            this.txtComment.TabIndex = 4;
            this.txtComment.Text = "備註(例 : 小辣)";
            this.txtComment.Enter += new System.EventHandler(this.txtComment_Enter);
            this.txtComment.Leave += new System.EventHandler(this.txtComment_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(621, 161);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubstract.Location = new System.Drawing.Point(488, 161);
            this.btnSubstract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(40, 38);
            this.btnSubstract.TabIndex = 8;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // lblAmountText
            // 
            this.lblAmountText.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmountText.Location = new System.Drawing.Point(481, 79);
            this.lblAmountText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountText.Name = "lblAmountText";
            this.lblAmountText.Size = new System.Drawing.Size(191, 62);
            this.lblAmountText.TabIndex = 11;
            this.lblAmountText.Text = "數量";
            this.lblAmountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(484, 225);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(191, 62);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "總價";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCart.FlatAppearance.BorderSize = 0;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddCart.Location = new System.Drawing.Point(0, 496);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(675, 64);
            this.btnAddCart.TabIndex = 13;
            this.btnAddCart.Text = "加入購物車";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(20, 79);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(215, 215);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmount.Location = new System.Drawing.Point(540, 164);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(77, 35);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "1";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 560);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblAmountText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDetail";
            this.Text = "FormDetail";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Label lblAmountText;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblAmount;
    }
}