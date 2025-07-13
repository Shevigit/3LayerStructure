namespace UI
{
    partial class ManagerForm
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
            buttonCustomer = new Button();
            buttonSales = new Button();
            buttonProduct = new Button();
            SuspendLayout();
            // 
            // buttonCustomer
            // 
            buttonCustomer.Location = new Point(422, 85);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(101, 54);
            buttonCustomer.TabIndex = 0;
            buttonCustomer.Text = "לקוחות";
            buttonCustomer.UseVisualStyleBackColor = true;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonSales
            // 
            buttonSales.Location = new Point(422, 242);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(101, 54);
            buttonSales.TabIndex = 0;
            buttonSales.Text = "מבצעים";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += button2_Click;
            // 
            // buttonProduct
            // 
            buttonProduct.Location = new Point(422, 164);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(101, 54);
            buttonProduct.TabIndex = 0;
            buttonProduct.Text = "מוצרים";
            buttonProduct.UseVisualStyleBackColor = true;
            buttonProduct.Click += buttonProduct_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProduct);
            Controls.Add(buttonSales);
            Controls.Add(buttonCustomer);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCustomer;
        private Button buttonSales;
        private Button buttonProduct;
    }
}