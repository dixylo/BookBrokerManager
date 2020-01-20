namespace BookBrokers
{
    partial class BookInfoForm
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
            this.btnDeleteBookInfo = new System.Windows.Forms.Button();
            this.btnUpdateBookInfo = new System.Windows.Forms.Button();
            this.btnAddBookInfo = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookInfoID = new System.Windows.Forms.TextBox();
            this.lblAuthorFirstName = new System.Windows.Forms.Label();
            this.lblAuthorLastName = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookInfoID = new System.Windows.Forms.Label();
            this.lstBookInfo = new System.Windows.Forms.ListBox();
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pnlAddBookInfo = new System.Windows.Forms.Panel();
            this.txtAddNotes = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.cmbAddAuthorFirstName = new System.Windows.Forms.ComboBox();
            this.cmbAddAuthorLastName = new System.Windows.Forms.ComboBox();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.cmbAddAuthorID = new System.Windows.Forms.ComboBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnSaveBookInfo = new System.Windows.Forms.Button();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.pnlUpdateBookInfo = new System.Windows.Forms.Panel();
            this.lblUpdateNotes = new System.Windows.Forms.Label();
            this.lblUpdateAuthorFirstName = new System.Windows.Forms.Label();
            this.lblUpdateAuthorLastName = new System.Windows.Forms.Label();
            this.txtUpdateNotes = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorID = new System.Windows.Forms.TextBox();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateBookInfoID = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorFirstName = new System.Windows.Forms.TextBox();
            this.lblUpdateAuthorID = new System.Windows.Forms.Label();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblUpdateBookInfoID = new System.Windows.Forms.Label();
            this.pnlAddBookInfo.SuspendLayout();
            this.pnlUpdateBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(452, 309);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 25);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteBookInfo
            // 
            this.btnDeleteBookInfo.Location = new System.Drawing.Point(452, 269);
            this.btnDeleteBookInfo.Name = "btnDeleteBookInfo";
            this.btnDeleteBookInfo.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteBookInfo.TabIndex = 52;
            this.btnDeleteBookInfo.Text = "Delete Book Info";
            this.btnDeleteBookInfo.UseVisualStyleBackColor = true;
            this.btnDeleteBookInfo.Click += new System.EventHandler(this.btnDeleteBookInfo_Click);
            // 
            // btnUpdateBookInfo
            // 
            this.btnUpdateBookInfo.Location = new System.Drawing.Point(342, 269);
            this.btnUpdateBookInfo.Name = "btnUpdateBookInfo";
            this.btnUpdateBookInfo.Size = new System.Drawing.Size(100, 25);
            this.btnUpdateBookInfo.TabIndex = 51;
            this.btnUpdateBookInfo.Text = "Update Book Info";
            this.btnUpdateBookInfo.UseVisualStyleBackColor = true;
            this.btnUpdateBookInfo.Click += new System.EventHandler(this.btnUpdateBookInfo_Click);
            // 
            // btnAddBookInfo
            // 
            this.btnAddBookInfo.Location = new System.Drawing.Point(232, 269);
            this.btnAddBookInfo.Name = "btnAddBookInfo";
            this.btnAddBookInfo.Size = new System.Drawing.Size(100, 25);
            this.btnAddBookInfo.TabIndex = 50;
            this.btnAddBookInfo.Text = "Add Book Info";
            this.btnAddBookInfo.UseVisualStyleBackColor = true;
            this.btnAddBookInfo.Click += new System.EventHandler(this.btnAddBookInfo_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(122, 269);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 25);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 269);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 25);
            this.btnPrevious.TabIndex = 48;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(342, 161);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(210, 65);
            this.txtNotes.TabIndex = 47;
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(342, 102);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorLastName.TabIndex = 45;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(342, 72);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(44, 20);
            this.txtAuthorID.TabIndex = 44;
            this.txtAuthorID.TextChanged += new System.EventHandler(this.txtAuthorID_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(342, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 20);
            this.txtTitle.TabIndex = 43;
            // 
            // txtBookInfoID
            // 
            this.txtBookInfoID.Location = new System.Drawing.Point(342, 12);
            this.txtBookInfoID.Name = "txtBookInfoID";
            this.txtBookInfoID.Size = new System.Drawing.Size(44, 20);
            this.txtBookInfoID.TabIndex = 42;
            // 
            // lblAuthorFirstName
            // 
            this.lblAuthorFirstName.AutoSize = true;
            this.lblAuthorFirstName.Location = new System.Drawing.Point(238, 135);
            this.lblAuthorFirstName.Name = "lblAuthorFirstName";
            this.lblAuthorFirstName.Size = new System.Drawing.Size(94, 13);
            this.lblAuthorFirstName.TabIndex = 40;
            this.lblAuthorFirstName.Text = "Author First Name:";
            // 
            // lblAuthorLastName
            // 
            this.lblAuthorLastName.AutoSize = true;
            this.lblAuthorLastName.Location = new System.Drawing.Point(237, 105);
            this.lblAuthorLastName.Name = "lblAuthorLastName";
            this.lblAuthorLastName.Size = new System.Drawing.Size(95, 13);
            this.lblAuthorLastName.TabIndex = 39;
            this.lblAuthorLastName.Text = "Author Last Name:";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(277, 75);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(55, 13);
            this.lblAuthorID.TabIndex = 38;
            this.lblAuthorID.Text = "Author ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(302, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Title:";
            // 
            // lblBookInfoID
            // 
            this.lblBookInfoID.AutoSize = true;
            this.lblBookInfoID.Location = new System.Drawing.Point(262, 15);
            this.lblBookInfoID.Name = "lblBookInfoID";
            this.lblBookInfoID.Size = new System.Drawing.Size(70, 13);
            this.lblBookInfoID.TabIndex = 36;
            this.lblBookInfoID.Text = "Book Info ID:";
            // 
            // lstBookInfo
            // 
            this.lstBookInfo.FormattingEnabled = true;
            this.lstBookInfo.Location = new System.Drawing.Point(12, 12);
            this.lstBookInfo.Name = "lstBookInfo";
            this.lstBookInfo.Size = new System.Drawing.Size(200, 147);
            this.lstBookInfo.TabIndex = 35;
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(342, 132);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorFirstName.TabIndex = 46;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(294, 164);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 41;
            this.lblNotes.Text = "Notes:";
            // 
            // pnlAddBookInfo
            // 
            this.pnlAddBookInfo.Controls.Add(this.txtAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.txtAddTitle);
            this.pnlAddBookInfo.Controls.Add(this.lblAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.cmbAddAuthorFirstName);
            this.pnlAddBookInfo.Controls.Add(this.cmbAddAuthorLastName);
            this.pnlAddBookInfo.Controls.Add(this.lblAddAuthor);
            this.pnlAddBookInfo.Controls.Add(this.cmbAddAuthorID);
            this.pnlAddBookInfo.Controls.Add(this.btnCancelAdd);
            this.pnlAddBookInfo.Controls.Add(this.btnSaveBookInfo);
            this.pnlAddBookInfo.Controls.Add(this.lblAddTitle);
            this.pnlAddBookInfo.Location = new System.Drawing.Point(562, 12);
            this.pnlAddBookInfo.Name = "pnlAddBookInfo";
            this.pnlAddBookInfo.Size = new System.Drawing.Size(381, 176);
            this.pnlAddBookInfo.TabIndex = 91;
            // 
            // txtAddNotes
            // 
            this.txtAddNotes.Location = new System.Drawing.Point(100, 75);
            this.txtAddNotes.Multiline = true;
            this.txtAddNotes.Name = "txtAddNotes";
            this.txtAddNotes.Size = new System.Drawing.Size(257, 65);
            this.txtAddNotes.TabIndex = 66;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(100, 12);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(257, 20);
            this.txtAddTitle.TabIndex = 62;
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.lblAddNotes.Location = new System.Drawing.Point(56, 78);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(38, 13);
            this.lblAddNotes.TabIndex = 61;
            this.lblAddNotes.Text = "Notes:";
            // 
            // cmbAddAuthorFirstName
            // 
            this.cmbAddAuthorFirstName.FormattingEnabled = true;
            this.cmbAddAuthorFirstName.Location = new System.Drawing.Point(257, 43);
            this.cmbAddAuthorFirstName.Name = "cmbAddAuthorFirstName";
            this.cmbAddAuthorFirstName.Size = new System.Drawing.Size(100, 21);
            this.cmbAddAuthorFirstName.TabIndex = 65;
            // 
            // cmbAddAuthorLastName
            // 
            this.cmbAddAuthorLastName.FormattingEnabled = true;
            this.cmbAddAuthorLastName.Location = new System.Drawing.Point(151, 43);
            this.cmbAddAuthorLastName.Name = "cmbAddAuthorLastName";
            this.cmbAddAuthorLastName.Size = new System.Drawing.Size(100, 21);
            this.cmbAddAuthorLastName.TabIndex = 64;
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(53, 46);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAddAuthor.TabIndex = 60;
            this.lblAddAuthor.Text = "Author:";
            // 
            // cmbAddAuthorID
            // 
            this.cmbAddAuthorID.FormattingEnabled = true;
            this.cmbAddAuthorID.Location = new System.Drawing.Point(100, 43);
            this.cmbAddAuthorID.Name = "cmbAddAuthorID";
            this.cmbAddAuthorID.Size = new System.Drawing.Size(45, 21);
            this.cmbAddAuthorID.TabIndex = 63;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(257, 146);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(110, 25);
            this.btnCancelAdd.TabIndex = 68;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnSaveBookInfo
            // 
            this.btnSaveBookInfo.Location = new System.Drawing.Point(8, 146);
            this.btnSaveBookInfo.Name = "btnSaveBookInfo";
            this.btnSaveBookInfo.Size = new System.Drawing.Size(110, 25);
            this.btnSaveBookInfo.TabIndex = 67;
            this.btnSaveBookInfo.Text = "Save Book Info";
            this.btnSaveBookInfo.UseVisualStyleBackColor = true;
            this.btnSaveBookInfo.Click += new System.EventHandler(this.btnSaveBookInfo_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(64, 15);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(30, 13);
            this.lblAddTitle.TabIndex = 58;
            this.lblAddTitle.Text = "Title:";
            // 
            // pnlUpdateBookInfo
            // 
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateNotes);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorFirstName);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorLastName);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateNotes);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorLastName);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorID);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateTitle);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateBookInfoID);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorFirstName);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorID);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateTitle);
            this.pnlUpdateBookInfo.Controls.Add(this.btnCancelUpdate);
            this.pnlUpdateBookInfo.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateBookInfoID);
            this.pnlUpdateBookInfo.Location = new System.Drawing.Point(562, 194);
            this.pnlUpdateBookInfo.Name = "pnlUpdateBookInfo";
            this.pnlUpdateBookInfo.Size = new System.Drawing.Size(381, 263);
            this.pnlUpdateBookInfo.TabIndex = 92;
            // 
            // lblUpdateNotes
            // 
            this.lblUpdateNotes.AutoSize = true;
            this.lblUpdateNotes.Location = new System.Drawing.Point(61, 164);
            this.lblUpdateNotes.Name = "lblUpdateNotes";
            this.lblUpdateNotes.Size = new System.Drawing.Size(38, 13);
            this.lblUpdateNotes.TabIndex = 64;
            this.lblUpdateNotes.Text = "Notes:";
            // 
            // lblUpdateAuthorFirstName
            // 
            this.lblUpdateAuthorFirstName.AutoSize = true;
            this.lblUpdateAuthorFirstName.Location = new System.Drawing.Point(5, 135);
            this.lblUpdateAuthorFirstName.Name = "lblUpdateAuthorFirstName";
            this.lblUpdateAuthorFirstName.Size = new System.Drawing.Size(94, 13);
            this.lblUpdateAuthorFirstName.TabIndex = 63;
            this.lblUpdateAuthorFirstName.Text = "Author First Name:";
            // 
            // lblUpdateAuthorLastName
            // 
            this.lblUpdateAuthorLastName.AutoSize = true;
            this.lblUpdateAuthorLastName.Location = new System.Drawing.Point(4, 105);
            this.lblUpdateAuthorLastName.Name = "lblUpdateAuthorLastName";
            this.lblUpdateAuthorLastName.Size = new System.Drawing.Size(95, 13);
            this.lblUpdateAuthorLastName.TabIndex = 62;
            this.lblUpdateAuthorLastName.Text = "Author Last Name:";
            // 
            // txtUpdateNotes
            // 
            this.txtUpdateNotes.Location = new System.Drawing.Point(105, 161);
            this.txtUpdateNotes.Multiline = true;
            this.txtUpdateNotes.Name = "txtUpdateNotes";
            this.txtUpdateNotes.Size = new System.Drawing.Size(252, 65);
            this.txtUpdateNotes.TabIndex = 70;
            // 
            // txtUpdateAuthorLastName
            // 
            this.txtUpdateAuthorLastName.Location = new System.Drawing.Point(105, 102);
            this.txtUpdateAuthorLastName.Name = "txtUpdateAuthorLastName";
            this.txtUpdateAuthorLastName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAuthorLastName.TabIndex = 68;
            // 
            // txtUpdateAuthorID
            // 
            this.txtUpdateAuthorID.Location = new System.Drawing.Point(105, 72);
            this.txtUpdateAuthorID.Name = "txtUpdateAuthorID";
            this.txtUpdateAuthorID.Size = new System.Drawing.Size(51, 20);
            this.txtUpdateAuthorID.TabIndex = 67;
            this.txtUpdateAuthorID.TextChanged += new System.EventHandler(this.txtUpdateAuthorID_TextChanged);
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(105, 42);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(252, 20);
            this.txtUpdateTitle.TabIndex = 66;
            // 
            // txtUpdateBookInfoID
            // 
            this.txtUpdateBookInfoID.Location = new System.Drawing.Point(105, 12);
            this.txtUpdateBookInfoID.Name = "txtUpdateBookInfoID";
            this.txtUpdateBookInfoID.Size = new System.Drawing.Size(51, 20);
            this.txtUpdateBookInfoID.TabIndex = 65;
            // 
            // txtUpdateAuthorFirstName
            // 
            this.txtUpdateAuthorFirstName.Location = new System.Drawing.Point(105, 132);
            this.txtUpdateAuthorFirstName.Name = "txtUpdateAuthorFirstName";
            this.txtUpdateAuthorFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAuthorFirstName.TabIndex = 69;
            // 
            // lblUpdateAuthorID
            // 
            this.lblUpdateAuthorID.AutoSize = true;
            this.lblUpdateAuthorID.Location = new System.Drawing.Point(44, 75);
            this.lblUpdateAuthorID.Name = "lblUpdateAuthorID";
            this.lblUpdateAuthorID.Size = new System.Drawing.Size(55, 13);
            this.lblUpdateAuthorID.TabIndex = 61;
            this.lblUpdateAuthorID.Text = "Author ID:";
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(69, 45);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(30, 13);
            this.lblUpdateTitle.TabIndex = 60;
            this.lblUpdateTitle.Text = "Title:";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(257, 232);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(110, 25);
            this.btnCancelUpdate.TabIndex = 72;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(8, 232);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(110, 25);
            this.btnSaveChanges.TabIndex = 71;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblUpdateBookInfoID
            // 
            this.lblUpdateBookInfoID.AutoSize = true;
            this.lblUpdateBookInfoID.Location = new System.Drawing.Point(29, 15);
            this.lblUpdateBookInfoID.Name = "lblUpdateBookInfoID";
            this.lblUpdateBookInfoID.Size = new System.Drawing.Size(70, 13);
            this.lblUpdateBookInfoID.TabIndex = 58;
            this.lblUpdateBookInfoID.Text = "Book Info ID:";
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 486);
            this.Controls.Add(this.pnlUpdateBookInfo);
            this.Controls.Add(this.pnlAddBookInfo);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteBookInfo);
            this.Controls.Add(this.btnUpdateBookInfo);
            this.Controls.Add(this.btnAddBookInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtAuthorLastName);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBookInfoID);
            this.Controls.Add(this.lblAuthorFirstName);
            this.Controls.Add(this.lblAuthorLastName);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookInfoID);
            this.Controls.Add(this.lstBookInfo);
            this.Controls.Add(this.txtAuthorFirstName);
            this.Name = "BookInfoForm";
            this.Text = "Book Info Maintenance";
            this.pnlAddBookInfo.ResumeLayout(false);
            this.pnlAddBookInfo.PerformLayout();
            this.pnlUpdateBookInfo.ResumeLayout(false);
            this.pnlUpdateBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteBookInfo;
        private System.Windows.Forms.Button btnUpdateBookInfo;
        private System.Windows.Forms.Button btnAddBookInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookInfoID;
        private System.Windows.Forms.Label lblAuthorFirstName;
        private System.Windows.Forms.Label lblAuthorLastName;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookInfoID;
        private System.Windows.Forms.ListBox lstBookInfo;
        private System.Windows.Forms.TextBox txtAuthorFirstName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Panel pnlAddBookInfo;
        private System.Windows.Forms.TextBox txtAddNotes;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label lblAddNotes;
        private System.Windows.Forms.ComboBox cmbAddAuthorFirstName;
        private System.Windows.Forms.ComboBox cmbAddAuthorLastName;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.ComboBox cmbAddAuthorID;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnSaveBookInfo;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Panel pnlUpdateBookInfo;
        private System.Windows.Forms.Label lblUpdateNotes;
        private System.Windows.Forms.Label lblUpdateAuthorFirstName;
        private System.Windows.Forms.Label lblUpdateAuthorLastName;
        private System.Windows.Forms.TextBox txtUpdateNotes;
        private System.Windows.Forms.TextBox txtUpdateAuthorLastName;
        private System.Windows.Forms.TextBox txtUpdateAuthorID;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateBookInfoID;
        private System.Windows.Forms.TextBox txtUpdateAuthorFirstName;
        private System.Windows.Forms.Label lblUpdateAuthorID;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblUpdateBookInfoID;
    }
}