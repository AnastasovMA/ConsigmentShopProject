
namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.storeItems = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCart = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.purchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 15;
            this.itemsListBox.Location = new System.Drawing.Point(37, 56);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(275, 289);
            this.itemsListBox.TabIndex = 0;
            // 
            // storeItems
            // 
            this.storeItems.AutoSize = true;
            this.storeItems.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeItems.Location = new System.Drawing.Point(37, 32);
            this.storeItems.Name = "storeItems";
            this.storeItems.Size = new System.Drawing.Size(96, 21);
            this.storeItems.TabIndex = 1;
            this.storeItems.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addToCart.Location = new System.Drawing.Point(346, 176);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(130, 33);
            this.addToCart.TabIndex = 2;
            this.addToCart.Text = "Add to Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCart
            // 
            this.shoppingCart.AutoSize = true;
            this.shoppingCart.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shoppingCart.Location = new System.Drawing.Point(500, 32);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(119, 21);
            this.shoppingCart.TabIndex = 4;
            this.shoppingCart.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 15;
            this.shoppingCartListbox.Location = new System.Drawing.Point(500, 56);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(275, 289);
            this.shoppingCartListbox.TabIndex = 3;
            // 
            // purchase
            // 
            this.purchase.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.purchase.Location = new System.Drawing.Point(645, 360);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(130, 33);
            this.purchase.TabIndex = 5;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 476);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.shoppingCart);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.storeItems);
            this.Controls.Add(this.itemsListBox);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label storeItems;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCart;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button purchase;
    }
}

