namespace BookBrokers
{
    partial class VendorForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.btnUpdateVendor = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCountryID = new System.Windows.Forms.TextBox();
            this.txtPostBoxNumber = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostBoxNumber = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lstVendor = new System.Windows.Forms.ListBox();
            this.pnlAddVendor = new System.Windows.Forms.Panel();
            this.cmbAddCountryName = new System.Windows.Forms.ComboBox();
            this.cmbAddCountryID = new System.Windows.Forms.ComboBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnSaveVendor = new System.Windows.Forms.Button();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddPostBoxNumber = new System.Windows.Forms.TextBox();
            this.txtAddVendorName = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblAddPostBoxNumber = new System.Windows.Forms.Label();
            this.lblAddVendorName = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.pnlUpdateVendor = new System.Windows.Forms.Panel();
            this.txtUpdateCountryName = new System.Windows.Forms.TextBox();
            this.txtUpdateVendorID = new System.Windows.Forms.TextBox();
            this.lblUpdateVendorID = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdatePostBoxNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateVendorName = new System.Windows.Forms.TextBox();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.lblUpdatePostBoxNumber = new System.Windows.Forms.Label();
            this.lblUpdateVendorName = new System.Windows.Forms.Label();
            this.txtUpdateCountryID = new System.Windows.Forms.TextBox();
            this.pnlAddVendor.SuspendLayout();
            this.pnlUpdateVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(452, 232);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 25);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteVendor
            // 
            this.btnDeleteVendor.Location = new System.Drawing.Point(452, 192);
            this.btnDeleteVendor.Name = "btnDeleteVendor";
            this.btnDeleteVendor.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteVendor.TabIndex = 33;
            this.btnDeleteVendor.Text = "Delete Vendor";
            this.btnDeleteVendor.UseVisualStyleBackColor = true;
            this.btnDeleteVendor.Click += new System.EventHandler(this.btnDeleteVendor_Click);
            // 
            // btnUpdateVendor
            // 
            this.btnUpdateVendor.Location = new System.Drawing.Point(342, 192);
            this.btnUpdateVendor.Name = "btnUpdateVendor";
            this.btnUpdateVendor.Size = new System.Drawing.Size(100, 25);
            this.btnUpdateVendor.TabIndex = 32;
            this.btnUpdateVendor.Text = "Update Vendor";
            this.btnUpdateVendor.UseVisualStyleBackColor = true;
            this.btnUpdateVendor.Click += new System.EventHandler(this.btnUpdateVendor_Click);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(232, 192);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(100, 25);
            this.btnAddVendor.TabIndex = 31;
            this.btnAddVendor.Text = "Add Vendor";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(122, 192);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 25);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 192);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 25);
            this.btnPrevious.TabIndex = 29;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(342, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtCountryID
            // 
            this.txtCountryID.Location = new System.Drawing.Point(342, 102);
            this.txtCountryID.Name = "txtCountryID";
            this.txtCountryID.Size = new System.Drawing.Size(10, 20);
            this.txtCountryID.TabIndex = 26;
            this.txtCountryID.TextChanged += new System.EventHandler(this.txtCountryID_TextChanged);
            // 
            // txtPostBoxNumber
            // 
            this.txtPostBoxNumber.Location = new System.Drawing.Point(342, 72);
            this.txtPostBoxNumber.Name = "txtPostBoxNumber";
            this.txtPostBoxNumber.Size = new System.Drawing.Size(65, 20);
            this.txtPostBoxNumber.TabIndex = 25;
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(342, 42);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(136, 20);
            this.txtVendorName.TabIndex = 24;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(342, 12);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(48, 20);
            this.txtVendorID.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(297, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(286, 105);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "Country:";
            // 
            // lblPostBoxNumber
            // 
            this.lblPostBoxNumber.AutoSize = true;
            this.lblPostBoxNumber.Location = new System.Drawing.Point(240, 75);
            this.lblPostBoxNumber.Name = "lblPostBoxNumber";
            this.lblPostBoxNumber.Size = new System.Drawing.Size(92, 13);
            this.lblPostBoxNumber.TabIndex = 20;
            this.lblPostBoxNumber.Text = "Post Box Number:";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(257, 45);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblVendorName.TabIndex = 19;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(274, 15);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblVendorID.TabIndex = 18;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // lstVendor
            // 
            this.lstVendor.FormattingEnabled = true;
            this.lstVendor.Location = new System.Drawing.Point(12, 12);
            this.lstVendor.Name = "lstVendor";
            this.lstVendor.Size = new System.Drawing.Size(200, 147);
            this.lstVendor.TabIndex = 17;
            // 
            // pnlAddVendor
            // 
            this.pnlAddVendor.Controls.Add(this.cmbAddCountryName);
            this.pnlAddVendor.Controls.Add(this.cmbAddCountryID);
            this.pnlAddVendor.Controls.Add(this.btnCancelAdd);
            this.pnlAddVendor.Controls.Add(this.btnSaveVendor);
            this.pnlAddVendor.Controls.Add(this.txtAddEmail);
            this.pnlAddVendor.Controls.Add(this.txtAddPostBoxNumber);
            this.pnlAddVendor.Controls.Add(this.txtAddVendorName);
            this.pnlAddVendor.Controls.Add(this.lblAddEmail);
            this.pnlAddVendor.Controls.Add(this.lblAddCountry);
            this.pnlAddVendor.Controls.Add(this.lblAddPostBoxNumber);
            this.pnlAddVendor.Controls.Add(this.lblAddVendorName);
            this.pnlAddVendor.Location = new System.Drawing.Point(578, 12);
            this.pnlAddVendor.Name = "pnlAddVendor";
            this.pnlAddVendor.Size = new System.Drawing.Size(281, 161);
            this.pnlAddVendor.TabIndex = 35;
            // 
            // cmbAddCountryName
            // 
            this.cmbAddCountryName.FormattingEnabled = true;
            this.cmbAddCountryName.Location = new System.Drawing.Point(164, 70);
            this.cmbAddCountryName.Name = "cmbAddCountryName";
            this.cmbAddCountryName.Size = new System.Drawing.Size(100, 21);
            this.cmbAddCountryName.TabIndex = 28;
            // 
            // cmbAddCountryID
            // 
            this.cmbAddCountryID.FormattingEnabled = true;
            this.cmbAddCountryID.Location = new System.Drawing.Point(123, 70);
            this.cmbAddCountryID.Name = "cmbAddCountryID";
            this.cmbAddCountryID.Size = new System.Drawing.Size(35, 21);
            this.cmbAddCountryID.TabIndex = 27;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(164, 131);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(100, 25);
            this.btnCancelAdd.TabIndex = 31;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnSaveVendor
            // 
            this.btnSaveVendor.Location = new System.Drawing.Point(13, 131);
            this.btnSaveVendor.Name = "btnSaveVendor";
            this.btnSaveVendor.Size = new System.Drawing.Size(100, 25);
            this.btnSaveVendor.TabIndex = 30;
            this.btnSaveVendor.Text = "Save Vendor";
            this.btnSaveVendor.UseVisualStyleBackColor = true;
            this.btnSaveVendor.Click += new System.EventHandler(this.btnSaveVendor_Click);
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(123, 101);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(100, 20);
            this.txtAddEmail.TabIndex = 29;
            // 
            // txtAddPostBoxNumber
            // 
            this.txtAddPostBoxNumber.Location = new System.Drawing.Point(123, 40);
            this.txtAddPostBoxNumber.Name = "txtAddPostBoxNumber";
            this.txtAddPostBoxNumber.Size = new System.Drawing.Size(90, 20);
            this.txtAddPostBoxNumber.TabIndex = 26;
            // 
            // txtAddVendorName
            // 
            this.txtAddVendorName.Location = new System.Drawing.Point(123, 10);
            this.txtAddVendorName.Name = "txtAddVendorName";
            this.txtAddVendorName.Size = new System.Drawing.Size(141, 20);
            this.txtAddVendorName.TabIndex = 25;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(78, 103);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(35, 13);
            this.lblAddEmail.TabIndex = 23;
            this.lblAddEmail.Text = "Email:";
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(67, 73);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(46, 13);
            this.lblAddCountry.TabIndex = 22;
            this.lblAddCountry.Text = "Country:";
            // 
            // lblAddPostBoxNumber
            // 
            this.lblAddPostBoxNumber.AutoSize = true;
            this.lblAddPostBoxNumber.Location = new System.Drawing.Point(21, 43);
            this.lblAddPostBoxNumber.Name = "lblAddPostBoxNumber";
            this.lblAddPostBoxNumber.Size = new System.Drawing.Size(92, 13);
            this.lblAddPostBoxNumber.TabIndex = 21;
            this.lblAddPostBoxNumber.Text = "Post Box Number:";
            // 
            // lblAddVendorName
            // 
            this.lblAddVendorName.AutoSize = true;
            this.lblAddVendorName.Location = new System.Drawing.Point(38, 13);
            this.lblAddVendorName.Name = "lblAddVendorName";
            this.lblAddVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblAddVendorName.TabIndex = 20;
            this.lblAddVendorName.Text = "Vendor Name:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(342, 102);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 27;
            // 
            // pnlUpdateVendor
            // 
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateCountryName);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateVendorID);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateVendorID);
            this.pnlUpdateVendor.Controls.Add(this.btnCancelUpdate);
            this.pnlUpdateVendor.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateEmail);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdatePostBoxNumber);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateVendorName);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateEmail);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateCountry);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdatePostBoxNumber);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateVendorName);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateCountryID);
            this.pnlUpdateVendor.Location = new System.Drawing.Point(578, 192);
            this.pnlUpdateVendor.Name = "pnlUpdateVendor";
            this.pnlUpdateVendor.Size = new System.Drawing.Size(281, 188);
            this.pnlUpdateVendor.TabIndex = 36;
            // 
            // txtUpdateCountryName
            // 
            this.txtUpdateCountryName.Location = new System.Drawing.Point(123, 100);
            this.txtUpdateCountryName.Name = "txtUpdateCountryName";
            this.txtUpdateCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateCountryName.TabIndex = 29;
            // 
            // txtUpdateVendorID
            // 
            this.txtUpdateVendorID.Location = new System.Drawing.Point(123, 10);
            this.txtUpdateVendorID.Name = "txtUpdateVendorID";
            this.txtUpdateVendorID.Size = new System.Drawing.Size(48, 20);
            this.txtUpdateVendorID.TabIndex = 25;
            // 
            // lblUpdateVendorID
            // 
            this.lblUpdateVendorID.AutoSize = true;
            this.lblUpdateVendorID.Location = new System.Drawing.Point(55, 13);
            this.lblUpdateVendorID.Name = "lblUpdateVendorID";
            this.lblUpdateVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateVendorID.TabIndex = 20;
            this.lblUpdateVendorID.Text = "Vendor ID:";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(164, 161);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnCancelUpdate.TabIndex = 32;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(13, 161);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 25);
            this.btnSaveChanges.TabIndex = 31;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(123, 130);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateEmail.TabIndex = 30;
            // 
            // txtUpdatePostBoxNumber
            // 
            this.txtUpdatePostBoxNumber.Location = new System.Drawing.Point(123, 70);
            this.txtUpdatePostBoxNumber.Name = "txtUpdatePostBoxNumber";
            this.txtUpdatePostBoxNumber.Size = new System.Drawing.Size(90, 20);
            this.txtUpdatePostBoxNumber.TabIndex = 27;
            // 
            // txtUpdateVendorName
            // 
            this.txtUpdateVendorName.Location = new System.Drawing.Point(123, 40);
            this.txtUpdateVendorName.Name = "txtUpdateVendorName";
            this.txtUpdateVendorName.Size = new System.Drawing.Size(141, 20);
            this.txtUpdateVendorName.TabIndex = 26;
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(78, 133);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateEmail.TabIndex = 24;
            this.lblUpdateEmail.Text = "Email:";
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.Location = new System.Drawing.Point(67, 103);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(46, 13);
            this.lblUpdateCountry.TabIndex = 23;
            this.lblUpdateCountry.Text = "Country:";
            // 
            // lblUpdatePostBoxNumber
            // 
            this.lblUpdatePostBoxNumber.AutoSize = true;
            this.lblUpdatePostBoxNumber.Location = new System.Drawing.Point(21, 73);
            this.lblUpdatePostBoxNumber.Name = "lblUpdatePostBoxNumber";
            this.lblUpdatePostBoxNumber.Size = new System.Drawing.Size(92, 13);
            this.lblUpdatePostBoxNumber.TabIndex = 22;
            this.lblUpdatePostBoxNumber.Text = "Post Box Number:";
            // 
            // lblUpdateVendorName
            // 
            this.lblUpdateVendorName.AutoSize = true;
            this.lblUpdateVendorName.Location = new System.Drawing.Point(38, 43);
            this.lblUpdateVendorName.Name = "lblUpdateVendorName";
            this.lblUpdateVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateVendorName.TabIndex = 21;
            this.lblUpdateVendorName.Text = "Vendor Name:";
            // 
            // txtUpdateCountryID
            // 
            this.txtUpdateCountryID.Location = new System.Drawing.Point(123, 100);
            this.txtUpdateCountryID.Name = "txtUpdateCountryID";
            this.txtUpdateCountryID.Size = new System.Drawing.Size(10, 20);
            this.txtUpdateCountryID.TabIndex = 28;
            this.txtUpdateCountryID.TextChanged += new System.EventHandler(this.txtUpdateCountryID_TextChanged);
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 402);
            this.Controls.Add(this.pnlUpdateVendor);
            this.Controls.Add(this.pnlAddVendor);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVendor);
            this.Controls.Add(this.btnUpdateVendor);
            this.Controls.Add(this.btnAddVendor);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPostBoxNumber);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPostBoxNumber);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.lstVendor);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.txtCountryID);
            this.Name = "VendorForm";
            this.Text = "Vendor Maintenance";
            this.pnlAddVendor.ResumeLayout(false);
            this.pnlAddVendor.PerformLayout();
            this.pnlUpdateVendor.ResumeLayout(false);
            this.pnlUpdateVendor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteVendor;
        private System.Windows.Forms.Button btnUpdateVendor;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCountryID;
        private System.Windows.Forms.TextBox txtPostBoxNumber;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostBoxNumber;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.ListBox lstVendor;
        private System.Windows.Forms.Panel pnlAddVendor;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPostBoxNumber;
        private System.Windows.Forms.TextBox txtAddVendorName;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblAddPostBoxNumber;
        private System.Windows.Forms.Label lblAddVendorName;
        private System.Windows.Forms.ComboBox cmbAddCountryName;
        private System.Windows.Forms.ComboBox cmbAddCountryID;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnSaveVendor;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Panel pnlUpdateVendor;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdatePostBoxNumber;
        private System.Windows.Forms.TextBox txtUpdateVendorName;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Label lblUpdatePostBoxNumber;
        private System.Windows.Forms.Label lblUpdateVendorName;
        private System.Windows.Forms.TextBox txtUpdateVendorID;
        private System.Windows.Forms.Label lblUpdateVendorID;
        private System.Windows.Forms.TextBox txtUpdateCountryName;
        private System.Windows.Forms.TextBox txtUpdateCountryID;
    }
}