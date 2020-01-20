using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBrokers
{
    public partial class BookForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmBookInfo;
        private CurrencyManager cmVendor;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public BookForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            Width = 580;
            Height = 430;
            pnlAddBook.Left = 128;
            pnlAddBook.Top = 2;
            pnlAddBook.Visible = false;
            pnlUpdateBook.Left = 128;
            pnlUpdateBook.Top = 2;
            pnlUpdateBook.Visible = false;
        }

        /// <summary>
        /// data bind control
        /// </summary>
        public void BindControls()
        {
            txtBookID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookID");
            txtBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookInfoID");
            txtCost.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Cost");
            txtPrice.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Price");
            txtDatePublished.DataBindings.Add("Text", DM.dsBookBrokers, "Book.DatePublished");
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.VendorID");
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.ClientOrderID");

            txtUpdateBookID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookID");
            txtUpdateBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookInfoID");
            txtUpdateCost.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Cost");
            txtUpdatePrice.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Price");
            dtpUpdateDatePublished.DataBindings.Add("Text", DM.dsBookBrokers, "Book.DatePublished");
            txtUpdateVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.VendorID");

            txtBookID.Enabled = false;
            txtBookInfoID.Enabled = false;
            txtTitle.Enabled = false;
            txtCost.Enabled = false;
            txtPrice.Enabled = false;
            txtDatePublished.Enabled = false;
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtClientOrderID.Enabled = false;

            txtUpdateBookID.Enabled = false;
            txtUpdateBookInfoID.Enabled = false;
            txtUpdateTitle.Enabled = false;
            txtUpdateVendorID.Enabled = false;
            txtUpdateVendorName.Enabled = false;

            lstBookID.DisplayMember = "Book.BookID";
            lstBookID.ValueMember = "Book.BookID";
            lstBookID.DataSource = DM.dsBookBrokers;

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
        }

        /// <summary>
        /// scroll up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// scroll down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// update book info id and title comboxes
        /// </summary>
        private void LoadBookInfo()
        {
            cmbAddBookInfoID.DisplayMember = "BookInfo.BookInfoID";
            cmbAddBookInfoID.ValueMember = "BookInfo.BookInfoID";
            cmbAddBookInfoID.DataSource = DM.dsBookBrokers;
            cmbAddTitle.DisplayMember = "BookInfo.Title";
            cmbAddTitle.ValueMember = "BookInfo.Title";
            cmbAddTitle.DataSource = DM.dsBookBrokers;
        }

        /// <summary>
        /// update vendors comboxes
        /// </summary>
        private void LoadVendors()
        {
            cmbAddVendorID.DisplayMember = "Vendor.VendorID";
            cmbAddVendorID.ValueMember = "Vendor.VendorID";
            cmbAddVendorID.DataSource = DM.dsBookBrokers;
            cmbAddVendorName.DisplayMember = "Vendor.VendorName";
            cmbAddVendorName.ValueMember = "Vendor.VendorName";
            cmbAddVendorName.DataSource = DM.dsBookBrokers;
        }

        /// <summary>
        /// open a new panel to add a new book record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            lstBookID.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddBook.Show();
            LoadBookInfo();
            LoadVendors();
        }

        /// <summary>
        /// add a new book record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            DataRow newBookRow = DM.dtBook.NewRow();

            if (txtAddCost.Text == "")
            {
                MessageBox.Show("You must type in a cost!", "Error");
            }
            else if (txtAddPrice.Text == "")
            {
                MessageBox.Show("You must type in a price!", "Error");
            }
            else
            {
                newBookRow["Cost"] = txtAddCost.Text;
                newBookRow["Price"] = txtAddPrice.Text;
                newBookRow["DatePublished"] = this.dtpAddDatePublished.Text;
                newBookRow["BookInfoID"] = this.cmbAddBookInfoID.GetItemText(this.cmbAddBookInfoID.SelectedItem);
                newBookRow["VendorID"] = this.cmbAddVendorID.GetItemText(this.cmbAddVendorID.SelectedItem);
                DM.dtBook.Rows.Add(newBookRow);
                DM.UpdateBook();
                MessageBox.Show("New Book Added Successfully!", "Success");
            }
        }

        /// <summary>
        /// cancel adding a new book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            pnlAddBook.Hide();
            lstBookID.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddBook.Enabled = true;
            btnUpdateBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// open a new panel to update a book record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            lstBookID.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateBook.Show();
        }

        /// <summary>
        /// update a book record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateBookRow = DM.dtBook.Rows[currencyManager.Position];

            if (updateBookRow["ClientOrderID"] != null)
            {
                MessageBox.Show("You may only update a book that is not on order", "Error");
            }
            else if (txtUpdateCost.Text == "")
            {
                MessageBox.Show("You must type in a cost!", "Error");
            }
            else if (txtUpdatePrice.Text == "")
            {
                MessageBox.Show("You must type in a price!", "Error");
            }
            else
            {
                updateBookRow["Cost"] = txtUpdateCost.Text;
                updateBookRow["Price"] = txtUpdatePrice.Text;
                updateBookRow["DatePublished"] = this.dtpUpdateDatePublished.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateBook();
                MessageBox.Show("Book Updated Successfully!", "Success");
            }
        }

        /// <summary>
        /// cancel updating a new book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdateBook.Hide();
            lstBookID.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddBook.Enabled = true;
            btnUpdateBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// delete a book record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataRow deleteBookRow = DM.dtBook.Rows[currencyManager.Position];

            if (deleteBookRow["ClientOrderID"] != null)
            {
                MessageBox.Show("You may only delete a book that is not on order", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookRow.Delete();
                    DM.UpdateBook();
                    MessageBox.Show("Book Deleted Successfully!", "Success");
                }
            }
        }

        /// <summary>
        /// let title update with other attributes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBookInfoID_TextChanged(object sender, EventArgs e)
        {
            if (txtBookInfoID.Text == "")
            {
                txtTitle.Text = "";
            }
            else
            {
                int aBookInfoID = Convert.ToInt32(txtBookInfoID.Text);
                cmBookInfo.Position = DM.bookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();
            }
        }

        /// <summary>
        /// let vendor name update with other attributes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            if (txtVendorID.Text == "")
            {
                txtVendorName.Text = "";
            }
            else
            {
                int aVendorID = Convert.ToInt32(txtVendorID.Text);
                cmVendor.Position = DM.vendorView.Find(aVendorID);
                DataRow drVendor = DM.dtVendor.Rows[cmVendor.Position];
                txtVendorName.Text = drVendor["VendorName"].ToString();
            }
        }

        /// <summary>
        /// let title update with other attributes
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUpdateBookInfoID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateBookInfoID.Text == "")
            {
                txtUpdateTitle.Text = "";
            }
            else
            {
                int aBookInfoID = Convert.ToInt32(txtUpdateBookInfoID.Text);
                cmBookInfo.Position = DM.bookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtUpdateTitle.Text = drBookInfo["Title"].ToString();
            }
        }

        /// <summary>
        /// let vendor name update with other attributes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUpdateVendorID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateVendorID.Text == "")
            {
                txtUpdateVendorName.Text = "";
            }
            else
            {
                int aVendorID = Convert.ToInt32(txtUpdateVendorID.Text);
                cmVendor.Position = DM.vendorView.Find(aVendorID);
                DataRow drVendor = DM.dtVendor.Rows[cmVendor.Position];
                txtUpdateVendorName.Text = drVendor["VendorName"].ToString();
            }
        }
    }
}
