namespace BookBrokers
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnClientOrder = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBookInfo = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnAddBook);
            this.grpMaintenance.Controls.Add(this.btnClientOrder);
            this.grpMaintenance.Controls.Add(this.btnBook);
            this.grpMaintenance.Controls.Add(this.btnBookInfo);
            this.grpMaintenance.Controls.Add(this.btnClient);
            this.grpMaintenance.Controls.Add(this.btnVendor);
            this.grpMaintenance.Location = new System.Drawing.Point(12, 12);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(258, 299);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(43, 237);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(166, 22);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add Book to a Client Order";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnClientOrder
            // 
            this.btnClientOrder.Location = new System.Drawing.Point(43, 196);
            this.btnClientOrder.Name = "btnClientOrder";
            this.btnClientOrder.Size = new System.Drawing.Size(166, 22);
            this.btnClientOrder.TabIndex = 5;
            this.btnClientOrder.Text = "Client Order Maintenance";
            this.btnClientOrder.UseVisualStyleBackColor = true;
            this.btnClientOrder.Click += new System.EventHandler(this.btnClientOrder_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(43, 155);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(166, 22);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book Maintenance";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBookInfo
            // 
            this.btnBookInfo.Location = new System.Drawing.Point(43, 114);
            this.btnBookInfo.Name = "btnBookInfo";
            this.btnBookInfo.Size = new System.Drawing.Size(166, 22);
            this.btnBookInfo.TabIndex = 3;
            this.btnBookInfo.Text = "Book Info Maintenance";
            this.btnBookInfo.UseVisualStyleBackColor = true;
            this.btnBookInfo.Click += new System.EventHandler(this.btnBookInfo_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(43, 74);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(166, 22);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Client Maintenance";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.Location = new System.Drawing.Point(43, 34);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(166, 22);
            this.btnVendor.TabIndex = 1;
            this.btnVendor.Text = "Vendor Maintenance";
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // grpReporting
            // 
            this.grpReporting.Controls.Add(this.btnExit);
            this.grpReporting.Controls.Add(this.btnVendors);
            this.grpReporting.Controls.Add(this.btnInvoices);
            this.grpReporting.Location = new System.Drawing.Point(302, 12);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(250, 299);
            this.grpReporting.TabIndex = 1;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(43, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 22);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(43, 74);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(166, 22);
            this.btnVendors.TabIndex = 3;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(43, 34);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(166, 22);
            this.btnInvoices.TabIndex = 2;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 324);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnClientOrder;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBookInfo;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.GroupBox grpReporting;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnInvoices;
    }
}

