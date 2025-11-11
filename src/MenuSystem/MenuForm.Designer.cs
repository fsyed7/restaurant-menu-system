namespace MenuSystem {
    partial class Menu_Select {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.foodMenulayout = new System.Windows.Forms.FlowLayoutPanel();
            this.menuListLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.rTextCart = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.flpCart = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // foodMenulayout
            // 
            this.foodMenulayout.AutoSize = true;
            this.foodMenulayout.Location = new System.Drawing.Point(48, 33);
            this.foodMenulayout.Margin = new System.Windows.Forms.Padding(4);
            this.foodMenulayout.Name = "foodMenulayout";
            this.foodMenulayout.Size = new System.Drawing.Size(136, 103);
            this.foodMenulayout.TabIndex = 3;
            // 
            // menuListLayout
            // 
            this.menuListLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuListLayout.AutoSize = true;
            this.menuListLayout.Location = new System.Drawing.Point(48, 329);
            this.menuListLayout.Margin = new System.Windows.Forms.Padding(4);
            this.menuListLayout.Name = "menuListLayout";
            this.menuListLayout.Size = new System.Drawing.Size(1321, 469);
            this.menuListLayout.TabIndex = 4;
            this.menuListLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.menuListLayoutPanel_Paint);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1183, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 38);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rTextCart
            // 
            this.rTextCart.Enabled = false;
            this.rTextCart.Location = new System.Drawing.Point(1098, 61);
            this.rTextCart.Margin = new System.Windows.Forms.Padding(4);
            this.rTextCart.Name = "rTextCart";
            this.rTextCart.Size = new System.Drawing.Size(262, 147);
            this.rTextCart.TabIndex = 6;
            this.rTextCart.Text = "";
            this.rTextCart.TextChanged += new System.EventHandler(this.rTextCart_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cart:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(48, 805);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(176, 36);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1095, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.AutoSize = true;
            this.lblCartTotal.Location = new System.Drawing.Point(1095, 221);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(0, 16);
            this.lblCartTotal.TabIndex = 11;
            // 
            // flpCart
            // 
            this.flpCart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpCart.AutoSize = true;
            this.flpCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCart.Location = new System.Drawing.Point(900, 61);
            this.flpCart.Name = "flpCart";
            this.flpCart.Size = new System.Drawing.Size(2, 2);
            this.flpCart.TabIndex = 12;
            // 
            // Menu_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1385, 875);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpCart);
            this.Controls.Add(this.lblCartTotal);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTextCart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuListLayout);
            this.Controls.Add(this.foodMenulayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu_Select";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel foodMenulayout;
        private System.Windows.Forms.FlowLayoutPanel menuListLayout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rTextCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.FlowLayoutPanel flpCart;
    }
}

