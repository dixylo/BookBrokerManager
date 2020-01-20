using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBrokers
{
    public partial class VendorsForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;

        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        // Declare a string to hold the entire document contents.
        private string documentContents;

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint;

        public VendorsForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }


        private void ReadDocument()
        {
            stringToPrint = documentContents;
        }

        void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintVendors_Click(object sender, EventArgs e)
        {
            ReadDocument();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void VendorsForm_Load(object sender, EventArgs e)
        {
            CurrencyManager cmVendor;
            CurrencyManager cmCountry;
            CurrencyManager cmBook;
            CurrencyManager cmBookInfo;
            CurrencyManager cmAuthor;

            string vendorsText = "";

            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "AUTHOR"];

            documentContents = "";

            foreach (DataRow drVendor in DM.dtVendor.Rows)
            {
                int aCountryID = Convert.ToInt32(drVendor["CountryID"].ToString());
                cmCountry.Position = DM.countryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

                vendorsText += "Vendor ID: " + drVendor["VendorID"] + "\r\n\r\n\r\n";
                vendorsText += drVendor["VendorName"] + "\r\n";
                vendorsText += "PO BOX " + drVendor["PostBoxNumber"] + "\r\n";
                vendorsText += drCountry["CountryName"] + "\r\n";
                vendorsText += drVendor["Email"] + "\r\n\r\n\r\n";
                vendorsText += "Books: " + "\r\n\r\n\r\n";

                DataRow[] drBooks = DM.dtBook.Select("VendorID = " + drVendor["VendorID"].ToString());

                if (drBooks.Length > 0)
                {
                    documentContents += vendorsText;
                    foreach (DataRow drBook in drBooks)
                    {
                        string unorderedBookText = "";

                        int aBookInfoID = Convert.ToInt32(drBook["BookInfoID"].ToString());
                        cmBookInfo.Position = DM.bookInfoView.Find(aBookInfoID);
                        DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];

                        int anAuthorID = Convert.ToInt32(drBookInfo["AuthorID"].ToString());
                        cmAuthor.Position = DM.authorView.Find(anAuthorID);
                        DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];

                        unorderedBookText = drBook["BookID"] + " " + drBookInfo["Title"] + " $" + drBook["Cost"] + " $" + drBook["Price"]
                                            + " " + drBook["DatePublished"] + " " + drAuthor["FirstName"] + " " + drAuthor["LastName"] + "\r\n";
                        documentContents += unorderedBookText;
                    }
                    documentContents += "\r\n\r\n\r\n\r\n\f";
                }
                vendorsText = "";
            }
        }
    }
}
