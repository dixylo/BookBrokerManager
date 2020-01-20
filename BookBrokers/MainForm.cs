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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private VendorForm frmVendor;           // the reference to the vendor form
        private ClientForm frmClient;           // the reference to the client form
        private BookInfoForm frmBookInfo;       // the reference to the book info form
        private BookForm frmBook;               // the reference to the book form
        private ClientOrderForm frmClientOrder; // the reference to the client order form
        private AddBookForm frmAddBook;         // the reference to the add book form
        private InvoiceForm frmInvoice;         // the reference to the invoice form
        private VendorsForm frmVendors;         // the reference to the vendors form

        /// <summary>
        /// constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();  // create the data module and load the dataset
        }

        /// <summary>
        /// exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// open vendor form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendor_Click(object sender, EventArgs e)
        {
            if (frmVendor == null)
            {
                frmVendor = new VendorForm(DM, this);
            }
            frmVendor.ShowDialog();
        }

        /// <summary>
        /// open client form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClient_Click(object sender, EventArgs e)
        {
            if (frmClient == null)
            {
                frmClient = new ClientForm(DM, this);
            }
            frmClient.ShowDialog();
        }

        /// <summary>
        /// open client order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientOrder_Click(object sender, EventArgs e)
        {
            if (frmClientOrder == null)
            {
                frmClientOrder = new ClientOrderForm(DM, this);
            }
            frmClientOrder.ShowDialog();
        }

        /// <summary>
        /// open book info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            if (frmBookInfo == null)
            {
                frmBookInfo = new BookInfoForm(DM, this);
            }
            frmBookInfo.ShowDialog();
        }

        /// <summary>
        ///  open book form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (frmBook == null)
            {
                frmBook = new BookForm(DM, this);
            }
            frmBook.ShowDialog();
        }

        /// <summary>
        /// open add book to client order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (frmAddBook == null)
            {
                frmAddBook = new AddBookForm(DM, this);
            }
            frmAddBook.ShowDialog();
        }

        /// <summary>
        /// open invoices form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();
        }

        /// <summary>
        /// open vendors form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendors_Click(object sender, EventArgs e)
        {
            if (frmVendors == null)
            {
                frmVendors = new VendorsForm(DM, this);
            }
            frmVendors.ShowDialog();
        }
    }
}
