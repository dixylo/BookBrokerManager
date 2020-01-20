namespace BookBrokers
{
    partial class VendorsForm
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
            this.btnPrintVendors = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrintVendors
            // 
            this.btnPrintVendors.Location = new System.Drawing.Point(52, 31);
            this.btnPrintVendors.Name = "btnPrintVendors";
            this.btnPrintVendors.Size = new System.Drawing.Size(100, 25);
            this.btnPrintVendors.TabIndex = 0;
            this.btnPrintVendors.Text = "Print Vendors";
            this.btnPrintVendors.UseVisualStyleBackColor = true;
            this.btnPrintVendors.Click += new System.EventHandler(this.btnPrintVendors_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(237, 31);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 25);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // VendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 90);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintVendors);
            this.Name = "VendorsForm";
            this.Text = "Vendors";
            this.Load += new System.EventHandler(this.VendorsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintVendors;
        private System.Windows.Forms.Button btnReturn;
    }
}