using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BookBrokers
{
    public partial class DataModule : Form
    {
        public DataTable dtVendor;
        public DataTable dtClient;
        public DataTable dtBookInfo;
        public DataTable dtBook;
        public DataTable dtClientOrder;
        public DataTable dtAuthor;
        public DataTable dtCountry;
        public DataView vendorView;
        public DataView clientView;
        public DataView bookInfoView;
        public DataView bookView;
        public DataView clientOrderView;
        public DataView authorView;
        public DataView countryView;

        public DataModule()
        {
            InitializeComponent();
            dsBookBrokers.EnforceConstraints = false;
            daVendor.Fill(dsBookBrokers);
            daClient.Fill(dsBookBrokers);
            daBookInfo.Fill(dsBookBrokers);
            daBook.Fill(dsBookBrokers);
            daClientOrder.Fill(dsBookBrokers);
            daAuthor.Fill(dsBookBrokers);
            daCountry.Fill(dsBookBrokers);
            dtVendor = dsBookBrokers.Tables["Vendor"];
            dtClient = dsBookBrokers.Tables["Client"];
            dtBookInfo = dsBookBrokers.Tables["BookInfo"];
            dtBook = dsBookBrokers.Tables["Book"];
            dtClientOrder = dsBookBrokers.Tables["ClientOrder"];
            dtAuthor = dsBookBrokers.Tables["Author"];
            dtCountry = dsBookBrokers.Tables["Country"];
            vendorView = new DataView(dtVendor);
            vendorView.Sort = "VendorID";
            clientView = new DataView(dtClient);
            clientView.Sort = "ClientID";
            bookInfoView = new DataView(dtBookInfo);
            bookInfoView.Sort = "BookInfoID";
            bookView = new DataView(dtBook);
            bookView.Sort = "BookID";
            clientOrderView = new DataView(dtClientOrder);
            clientOrderView.Sort = "ClientOrderID";
            authorView = new DataView(dtAuthor);
            authorView.Sort = "AuthorID";
            countryView = new DataView(dtCountry);
            countryView.Sort = "CountryID";
            dsBookBrokers.EnforceConstraints = true;
        }

        public void UpdateVendor()
        {
            daVendor.Update(dtVendor);
        }

        public void UpdateClient()
        {
            daClient.Update(dtClient);
        }

        public void UpdateClientOrder()
        {
            daClientOrder.Update(dtClientOrder);
        }

        public void UpdateBookInfo()
        {
            daBookInfo.Update(dtBookInfo);
        }

        public void UpdateBook()
        {
            daBook.Update(dtBook);
        }

        private void daVendor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and store it in the VendorID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VendorID"] = newID;
            }
        }

        private void daClient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and store it in the ClientID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientID"] = newID;
            }
        }

        private void daClientOrder_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and store it in the ClientID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientOrderID"] = newID;
            }
        }

        private void daBookInfo_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and store it in the ClientID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookInfoID"] = newID;
            }
        }

        private void daBook_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and store it in the ClientID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookID"] = newID;
            }
        }
    }
}
