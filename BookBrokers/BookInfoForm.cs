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
    public partial class BookInfoForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmAuthor;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public BookInfoForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            Width = 610;
            Height = 380;
            pnlAddBookInfo.Left = 128;
            pnlAddBookInfo.Top = 2;
            pnlAddBookInfo.Visible = false;
            pnlUpdateBookInfo.Left = 128;
            pnlUpdateBookInfo.Top = 2;
            pnlUpdateBookInfo.Visible = false;
        }

        /// <summary>
        /// data bind control
        /// </summary>
        public void BindControls()
        {
            txtBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.BookInfoID");
            txtTitle.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Title");
            txtAuthorID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.AuthorID");
            txtNotes.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Notes");
            txtUpdateBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.BookInfoID");
            txtUpdateTitle.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Title");
            txtUpdateAuthorID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.AuthorID");
            txtUpdateNotes.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Notes");
            txtBookInfoID.Enabled = false;
            txtTitle.Enabled = false;
            txtAuthorID.Enabled = false;
            txtAuthorLastName.Enabled = false;
            txtAuthorFirstName.Enabled = false;
            txtNotes.Enabled = false;
            txtUpdateBookInfoID.Enabled = false;
            txtUpdateAuthorID.Enabled = false;
            txtUpdateAuthorLastName.Enabled = false;
            txtUpdateAuthorFirstName.Enabled = false;
            lstBookInfo.DisplayMember = "BookInfo.Title";
            lstBookInfo.ValueMember = "BookInfo.Title";
            lstBookInfo.DataSource = DM.dsBookBrokers;
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "AUTHOR"];
        }

        /// <summary>
        /// scoll up
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
        /// bind control author id and name
        /// </summary>
        private void LoadAuthors()
        {
            cmbAddAuthorID.DisplayMember = "Author.AuthorID";
            cmbAddAuthorID.ValueMember = "Author.AuthorID";
            cmbAddAuthorID.DataSource = DM.dsBookBrokers;
            cmbAddAuthorLastName.DisplayMember = "Author.LastName";
            cmbAddAuthorLastName.ValueMember = "Author.LastName";
            cmbAddAuthorLastName.DataSource = DM.dsBookBrokers;
            cmbAddAuthorFirstName.DisplayMember = "Author.FirstName";
            cmbAddAuthorFirstName.ValueMember = "Author.FirstName";
            cmbAddAuthorFirstName.DataSource = DM.dsBookBrokers;
        }

        /// <summary>
        /// open a new panel to add a book into
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBookInfo_Click(object sender, EventArgs e)
        {
            lstBookInfo.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddBookInfo.Enabled = false;
            btnUpdateBookInfo.Enabled = false;
            btnDeleteBookInfo.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddBookInfo.Show();
            LoadAuthors();
        }

        /// <summary>
        /// add a book info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveBookInfo_Click(object sender, EventArgs e)
        {
            txtBookInfoID = null;
            DataRow newBookInfoRow = DM.dtBookInfo.NewRow();

            if (txtAddTitle.Text == "")
            {
                MessageBox.Show("You must type in a title!", "Error");
            }
            else
            {
                newBookInfoRow["Title"] = txtAddTitle.Text;
                newBookInfoRow["AuthorID"] = this.cmbAddAuthorID.GetItemText(this.cmbAddAuthorID.SelectedItem);
                newBookInfoRow["Notes"] = txtAddNotes.Text;
                DM.dtBookInfo.Rows.Add(newBookInfoRow);
                DM.UpdateBookInfo();
                MessageBox.Show("New Book Info Added Successfully!", "Success");
            }
        }

        /// <summary>
        /// cancel adding a book info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            pnlAddBookInfo.Hide();
            lstBookInfo.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddBookInfo.Enabled = true;
            btnUpdateBookInfo.Enabled = true;
            btnDeleteBookInfo.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// open a new panel to update a book info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateBookInfo_Click(object sender, EventArgs e)
        {
            lstBookInfo.Visible = false;
            lstBookInfo.Enabled = false;
            lstBookInfo.SelectedItem = null;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddBookInfo.Enabled = false;
            btnUpdateBookInfo.Enabled = false;
            btnDeleteBookInfo.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateBookInfo.Show();
            
        }

        /// <summary>
        /// update a book info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];

            if (txtUpdateTitle.Text == "")
            {
                MessageBox.Show("You must type in a title!", "Error");
            }
            else
            {
                updateBookInfoRow["Title"] = txtUpdateTitle.Text;
                updateBookInfoRow["Notes"] = txtUpdateNotes.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateBookInfo();
                MessageBox.Show("Book Info Updated Successfully!", "Success");
            }
        }

        /// <summary>
        /// cancel updating a book info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdateBookInfo.Hide();
            lstBookInfo.Enabled = true;
            lstBookInfo.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddBookInfo.Enabled = true;
            btnUpdateBookInfo.Enabled = true;
            btnDeleteBookInfo.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// delete a book info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteBookInfo_Click(object sender, EventArgs e)
        {
            DataRow deleteBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("BookInfoID = " + txtBookInfoID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete a piece of book info that belongs to books sold out", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookInfoRow.Delete();
                    DM.UpdateBookInfo();
                    MessageBox.Show("Book Info Deleted Successfully!", "Success");
                }
            }
        }

        /// <summary>
        /// interlock author id and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAuthorID_TextChanged(object sender, EventArgs e)
        {
            if (txtAuthorID.Text == "")
            {
                txtAuthorLastName.Text = "";
                txtAuthorFirstName.Text = "";
            }
            else
            {
                int anAuthorID = Convert.ToInt32(txtAuthorID.Text);
                cmAuthor.Position = DM.authorView.Find(anAuthorID);
                DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];
                txtAuthorLastName.Text = drAuthor["LastName"].ToString();
                txtAuthorFirstName.Text = drAuthor["FirstName"].ToString();
            }
        }

        /// <summary>
        /// interlock author id and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUpdateAuthorID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateAuthorID.Text == "")
            {
                txtUpdateAuthorLastName.Text = "";
                txtUpdateAuthorFirstName.Text = "";
            }
            else
            {
                int anAuthorID = Convert.ToInt32(txtUpdateAuthorID.Text);
                cmAuthor.Position = DM.authorView.Find(anAuthorID);
                DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];
                txtUpdateAuthorLastName.Text = drAuthor["LastName"].ToString();
                txtUpdateAuthorFirstName.Text = drAuthor["FirstName"].ToString();
            }
        }
    }
}
