namespace BookBrokers
{
    partial class AddBookForm
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
            this.dgvClientOrder = new System.Windows.Forms.DataGridView();
            this.dgvOrderedBooks = new System.Windows.Forms.DataGridView();
            this.dgvUnorderedBooks = new System.Windows.Forms.DataGridView();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnorderedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientOrder
            // 
            this.dgvClientOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrder.Location = new System.Drawing.Point(12, 12);
            this.dgvClientOrder.Name = "dgvClientOrder";
            this.dgvClientOrder.Size = new System.Drawing.Size(469, 190);
            this.dgvClientOrder.TabIndex = 0;
            this.dgvClientOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientOrder_CellClick);
            // 
            // dgvOrderedBooks
            // 
            this.dgvOrderedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderedBooks.Location = new System.Drawing.Point(12, 224);
            this.dgvOrderedBooks.Name = "dgvOrderedBooks";
            this.dgvOrderedBooks.Size = new System.Drawing.Size(458, 190);
            this.dgvOrderedBooks.TabIndex = 1;
            this.dgvOrderedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderedBooks_CellClick);
            // 
            // dgvUnorderedBooks
            // 
            this.dgvUnorderedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnorderedBooks.Location = new System.Drawing.Point(482, 224);
            this.dgvUnorderedBooks.Name = "dgvUnorderedBooks";
            this.dgvUnorderedBooks.Size = new System.Drawing.Size(442, 190);
            this.dgvUnorderedBooks.TabIndex = 2;
            this.dgvUnorderedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnorderedBooks_CellClick);
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(586, 66);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(90, 13);
            this.lblClientLastName.TabIndex = 3;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Location = new System.Drawing.Point(586, 110);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(89, 13);
            this.lblClientFirstName.TabIndex = 4;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(334, 436);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title:";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(682, 63);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(111, 20);
            this.txtClientLastName.TabIndex = 6;
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(681, 107);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(111, 20);
            this.txtClientFirstName.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(370, 433);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(111, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(63, 476);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 30);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(370, 476);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveBook.TabIndex = 10;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(649, 476);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 30);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 527);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClientFirstName);
            this.Controls.Add(this.lblClientLastName);
            this.Controls.Add(this.dgvUnorderedBooks);
            this.Controls.Add(this.dgvOrderedBooks);
            this.Controls.Add(this.dgvClientOrder);
            this.Name = "AddBookForm";
            this.Text = "Add Book to a Client Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnorderedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientOrder;
        private System.Windows.Forms.DataGridView dgvOrderedBooks;
        private System.Windows.Forms.DataGridView dgvUnorderedBooks;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnReturn;
    }
}