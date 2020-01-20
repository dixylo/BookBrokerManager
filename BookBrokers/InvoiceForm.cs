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
    public partial class InvoiceForm : Form
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

        public InvoiceForm(DataModule dm, MainForm mnu)
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
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

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

        private void btnPrintInvoices_Click(object sender, EventArgs e)
        {
            ReadDocument();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            CurrencyManager cmClient;
            CurrencyManager cmCountry;
            CurrencyManager cmBook;
            CurrencyManager cmBookInfo;
            CurrencyManager cmClientOrder;

            string clientOrderText = "";
            double clientOrderTotal = 0;

            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];

            documentContents = "";

            foreach (DataRow drClientOrder in DM.dtClientOrder.Rows)
            {
                string clientOrderStatus = drClientOrder["Status"].ToString();
                if (clientOrderStatus.Equals("Shipped") == true)
                {
                    int aClientID = Convert.ToInt32(drClientOrder["ClientID"].ToString());
                    cmClient.Position = DM.clientView.Find(aClientID);
                    DataRow drClient = DM.dtClient.Rows[cmClient.Position];

                    int aCountryID = Convert.ToInt32(drClient["CountryID"].ToString());
                    cmCountry.Position = DM.countryView.Find(aCountryID);
                    DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

                    clientOrderText += "Client ID: " + drClient["ClientID"] + "\r\n\r\n\r\n";
                    clientOrderText += drClient["FirstName"] + " " + drClient["LastName"] + "\r\n";
                    clientOrderText += drClient["StreetAddress"] + "\r\n";
                    clientOrderText += drClient["Suburb"] + "\r\n";
                    clientOrderText += drClient["City"] + "\r\n";
                    clientOrderText += drCountry["CountryName"] + "\r\n\r\n\r\n";
                    clientOrderText += "Client Order ID: " + drClientOrder["ClientOrderID"] +
                        "Date: " + drClientOrder["OrderDate"] + "\r\n\r\n\r\n";
                    clientOrderText += "Books: " + "\r\n\r\n\r\n";

                    DataRow[] drBooks = DM.dtBook.Select("ClientOrderID = " + drClientOrder["ClientOrderID"].ToString());

                    if (drBooks.Length > 0)
                    {
                        documentContents += clientOrderText;
                        foreach (DataRow drBook in drBooks)
                        {
                            string clientBookText = "";

                            int aBookInfoID = Convert.ToInt32(drBook["BookInfoID"].ToString());
                            cmBookInfo.Position = DM.bookInfoView.Find(aBookInfoID);
                            DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];

                            double bookCost = Convert.ToDouble(drBook["Cost"]);
                            clientOrderTotal += bookCost;

                            clientBookText = drBook["BookID"] + " " + drBookInfo["Title"] + " $" + drBook["Price"] + "\r\n";
                            documentContents += clientBookText;
                        }

                        documentContents += "\r\n";
                        documentContents += "\t\t\t\t\t\t\t\t\t\t\t\t\t\tTotal: " + Convert.ToString(clientOrderTotal);
                        documentContents += "\r\n\r\n\r\n\r\n\r\n";
                    }
                    clientOrderText = "";
                    clientOrderTotal = 0;
                }
            }
        }
    }
}
