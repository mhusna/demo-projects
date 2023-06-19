namespace Northwind.WinFormsUI
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 146);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(663, 231);
            this.dgwProducts.TabIndex = 0;
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(663, 55);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search By Category";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Controls.Add(this.tbxProduct);
            this.gbxProduct.Location = new System.Drawing.Point(12, 73);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(663, 55);
            this.gbxProduct.TabIndex = 2;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Search By Product Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(16, 26);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(21, 30);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(47, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product:";
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(74, 27);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(121, 20);
            this.tbxProduct.TabIndex = 1;
            this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(74, 23);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 389);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox tbxProduct;
    }
}

