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
    public partial class AddBookForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmClientOrder;
        private CurrencyManager cmOrderedBooks;
        private CurrencyManager cmUnorderedBooks;
        private CurrencyManager cmClient;
        private CurrencyManager cmBook;
        private CurrencyManager cmBookInfo;
        private DataView dvUnorderedBooks;
        private DataView dvOrderedBooks;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public AddBookForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        /// <summary>
        /// Bind controling of data
        /// </summary>
        public void BindControls()
        {
            txtClientLastName.Enabled = false;
            txtClientFirstName.Enabled = false;
            txtTitle.Enabled = false;

            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "ClientOrder"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Client"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BookInfo"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];

            dgvClientOrder.DataSource = DM.dsBookBrokers;
            dgvClientOrder.DataMember = "ClientOrder";

            UpdateUnorderedBooks();
        }

        /// <summary>
        /// update ordered books
        /// </summary>
        private void UpdateOrderedBooks()
        {
            string aClientOrderID = DM.dtClientOrder.Rows[cmClientOrder.Position]["ClientOrderID"].ToString();
            dvOrderedBooks = new DataView(DM.dtBook, "ClientOrderID = " + aClientOrderID, "BookID ASC", DataViewRowState.CurrentRows);
            cmOrderedBooks = (CurrencyManager)this.BindingContext[dvOrderedBooks];
            dgvOrderedBooks.DataSource = dvOrderedBooks;
        }

        /// <summary>
        /// update unordered books
        /// </summary>
        private void UpdateUnorderedBooks()
        {
            dvUnorderedBooks = new DataView(DM.dtBook, "ClientOrderID IS NULL", "BookID ASC", DataViewRowState.CurrentRows);
            cmUnorderedBooks = (CurrencyManager)this.BindingContext[dvUnorderedBooks];
            dgvUnorderedBooks.DataSource = dvUnorderedBooks;
            dgvUnorderedBooks.Columns[6].Visible = false;
        }

        /// <summary>
        /// add book to client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
                {
                    string clientOrderID = DM.dtClientOrder.Rows[cmClientOrder.Position]["ClientOrderID"].ToString();
                    int aClientOrderID = Convert.ToInt32(clientOrderID);
                    string bookID = dgvUnorderedBooks["BookID", cmUnorderedBooks.Position].Value.ToString();
                    int aBookID = Convert.ToInt32(bookID);
                    cmBook.Position = DM.bookView.Find(aBookID);
                    DataRow newOrder = DM.dtBook.Rows[cmBook.Position];
                    newOrder["ClientOrderID"] = aClientOrderID;
                    cmBook.EndCurrentEdit();
                    DM.UpdateBook();
                    UpdateOrderedBooks();
                    UpdateUnorderedBooks();
                    MessageBox.Show("Book Added to Client Order Successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Books can only be added to current orders!", "Error");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This book has already been added to this client order!", "Error");
            }
        }

        /// <summary>
        /// remove book from client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            string clientOrderID = dgvOrderedBooks["ClientOrderID", cmOrderedBooks.Position].Value.ToString();
            int aClientOrderID = Convert.ToInt32(clientOrderID);
            cmClientOrder.Position = DM.clientOrderView.Find(aClientOrderID);


            if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string bookID = dgvOrderedBooks["BookID", cmOrderedBooks.Position].Value.ToString();
                    int aBookID = Convert.ToInt32(bookID);
                    cmBook.Position = DM.bookView.Find(aBookID);
                    DataRow newOrder = DM.dtBook.Rows[cmBook.Position];
                    newOrder["ClientOrderID"] = DBNull.Value;
                    cmBook.EndCurrentEdit();
                    DM.UpdateBook();
                    UpdateOrderedBooks();
                    UpdateUnorderedBooks();
                    MessageBox.Show("Book Removed Successfully!", "Success");
                }
            }
            else
            {
                MessageBox.Show("Books can only be removed from current orders!", "Error");
            }

        }

        /// <summary>
        /// return to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// if client order data grid view is clicked, ordered books data grid view is updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateOrderedBooks();

            string aClientID = DM.dtClientOrder.Rows[cmClientOrder.Position]["ClientID"].ToString();
            if (aClientID == "")
            {
                txtClientLastName.Text = "";
                txtClientFirstName.Text = "";
            }
            else
            {
                int aCID = Convert.ToInt32(aClientID);
                cmClient.Position = DM.clientView.Find(aCID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtClientLastName.Text = drClient["LastName"].ToString();
                txtClientFirstName.Text = drClient["FirstName"].ToString();
            }
        }

        /// <summary>
        /// clicking event handler of ordered bookds data grdi view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOrderedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookInfoID = dgvOrderedBooks["BookInfoID", cmOrderedBooks.Position].Value.ToString();

            if (bookInfoID == "")
            {
                txtTitle.Text = "";
            }
            else
            {
                int aBookInfoID = Convert.ToInt32(bookInfoID);
                cmBookInfo.Position = DM.bookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();
            }
        }

        /// <summary>
        /// clicking event handler of ordered bookds data grdi view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUnorderedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookInfoID = dgvUnorderedBooks["BookInfoID", cmUnorderedBooks.Position].Value.ToString();

            if (bookInfoID == "")
            {
                txtTitle.Text = "";
            }
            else
            {
                int aBookInfoID = Convert.ToInt32(bookInfoID);
                cmBookInfo.Position = DM.bookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();
            }
        }
    }
}
