namespace BookBrokers
{
    partial class InvoiceForm
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
            this.btnPrintInvoices = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrintInvoices
            // 
            this.btnPrintInvoices.Location = new System.Drawing.Point(25, 21);
            this.btnPrintInvoices.Name = "btnPrintInvoices";
            this.btnPrintInvoices.Size = new System.Drawing.Size(100, 25);
            this.btnPrintInvoices.TabIndex = 2;
            this.btnPrintInvoices.Text = "Print Invoices";
            this.btnPrintInvoices.UseVisualStyleBackColor = true;
            this.btnPrintInvoices.Click += new System.EventHandler(this.btnPrintInvoices_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(153, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 25);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 77);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintInvoices);
            this.Name = "InvoiceForm";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrintInvoices;
        private System.Windows.Forms.Button btnReturn;
    }
}