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
            this.SuspendLayout();
            // 
            // foodMenulayout
            // 
            this.foodMenulayout.AutoSize = true;
            this.foodMenulayout.Location = new System.Drawing.Point(36, 27);
            this.foodMenulayout.Name = "foodMenulayout";
            this.foodMenulayout.Size = new System.Drawing.Size(102, 84);
            this.foodMenulayout.TabIndex = 3;
            // 
            // menuListLayout
            // 
            this.menuListLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuListLayout.AutoSize = true;
            this.menuListLayout.Location = new System.Drawing.Point(36, 267);
            this.menuListLayout.Name = "menuListLayout";
            this.menuListLayout.Size = new System.Drawing.Size(991, 381);
            this.menuListLayout.TabIndex = 4;
            this.menuListLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.menuListLayoutPanel_Paint);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(887, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 51);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rTextCart
            // 
            this.rTextCart.Location = new System.Drawing.Point(739, 69);
            this.rTextCart.Name = "rTextCart";
            this.rTextCart.Size = new System.Drawing.Size(269, 179);
            this.rTextCart.TabIndex = 6;
            this.rTextCart.Text = "";
            this.rTextCart.TextChanged += new System.EventHandler(this.rTextCart_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cart:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(36, 654);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(132, 29);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // Menu_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1039, 711);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTextCart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuListLayout);
            this.Controls.Add(this.foodMenulayout);
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
    }
}

