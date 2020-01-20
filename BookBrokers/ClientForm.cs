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
    public partial class ClientForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmCountry;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public ClientForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            Width = 580;
            Height = 425;
            pnlAddClient.Left = 219;
            pnlAddClient.Top = 2;
            pnlAddClient.Visible = false;
            pnlUpdateClient.Left = 219;
            pnlUpdateClient.Top = 2;
            pnlUpdateClient.Visible = false;
        }

        /// <summary>
        /// data bind control
        /// </summary>
        public void BindControls()
        {
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.ClientID");
            txtLastName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsBookBrokers, "Client.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Suburb");
            txtCity.DataBindings.Add("Text", DM.dsBookBrokers, "Client.City");
            txtCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CountryID");
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Email");
            txtCreditStatus.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CreditStatus");
            txtUpdateClientID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.ClientID");
            txtUpdateLastName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.LastName");
            txtUpdateFirstName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.FirstName");
            txtUpdateStreetAddress.DataBindings.Add("Text", DM.dsBookBrokers, "Client.StreetAddress");
            txtUpdateSuburb.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Suburb");
            txtUpdateCity.DataBindings.Add("Text", DM.dsBookBrokers, "Client.City");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Email");
            txtClientID.Enabled = false;
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtCity.Enabled = false;
            txtCountryID.Enabled = false;
            txtCountryName.Enabled = false;
            txtEmail.Enabled = false;
            txtCreditStatus.Enabled = false;
            txtUpdateClientID.Enabled = false;
            lstClient.DisplayMember = "Client.LastName";
            lstClient.ValueMember = "Client.LastName";
            lstClient.DataSource = DM.dsBookBrokers;
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
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
        /// open a new panel to add a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            lstClient.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddClient.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddClient.Show();
            LoadCountries();
            LoadCreditStatus();
        }

        /// <summary>
        /// add a new client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            txtClientID = null;
            DataRow newClientRow = DM.dtClient.NewRow();

            if (txtAddLastName.Text == "")
            {
                MessageBox.Show("You must type in a last name!", "Error");
            }
            else if (txtAddFirstName.Text == "")
            {
                MessageBox.Show("You must type in a first name!", "Error");
            }
            else if (txtAddStreetAddress.Text == "")
            {
                MessageBox.Show("You must type in a street address!", "Error");
            }
            else if (txtAddSuburb.Text == "")
            {
                MessageBox.Show("You must type in a suburb!", "Error");
            }
            else if (txtAddCity.Text == "")
            {
                MessageBox.Show("You must type in a city!", "Error");
            }
            else if (txtAddEmail.Text == "")
            {
                MessageBox.Show("You must type in an email!", "Error");
            }
            else
            {
                newClientRow["LastName"] = txtAddLastName.Text;
                newClientRow["FirstName"] = txtAddFirstName.Text;
                newClientRow["StreetAddress"] = txtAddStreetAddress.Text;
                newClientRow["Suburb"] = txtAddSuburb.Text;
                newClientRow["City"] = txtAddCity.Text;
                newClientRow["CountryID"] = this.cmbAddCountryID.GetItemText(this.cmbAddCountryID.SelectedItem);
                newClientRow["Email"] = txtAddEmail.Text;
                newClientRow["CreditStatus"] = this.cmbAddCreditStatus.GetItemText(this.cmbAddCreditStatus.SelectedItem);
                DM.dtClient.Rows.Add(newClientRow);
                DM.UpdateClient();
                MessageBox.Show("New Client Added Successfully!", "Success");
            }
        }

        /// <summary>
        /// cancel adding a new client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            pnlAddClient.Hide();
            lstClient.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddClient.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnDeleteClient.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// open a new panel to update a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            lstClient.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddClient.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateClient.Show();
            LoadCountries();
            LoadCreditStatus();
        }

        /// <summary>
        /// update a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateClientRow = DM.dtClient.Rows[currencyManager.Position];

            if (txtUpdateLastName.Text == "")
            {
                MessageBox.Show("You must type in a last name!", "Error");
            }
            else if (txtUpdateFirstName.Text == "")
            {
                MessageBox.Show("You must type in a first name!", "Error");
            }
            else if (txtUpdateStreetAddress.Text == "")
            {
                MessageBox.Show("You must type in a street address!", "Error");
            }
            else if (txtUpdateSuburb.Text == "")
            {
                MessageBox.Show("You must type in a suburb!", "Error");
            }
            else if (txtUpdateCity.Text == "")
            {
                MessageBox.Show("You must type in a city!", "Error");
            }
            else if (txtUpdateEmail.Text == "")
            {
                MessageBox.Show("You must type in an email!", "Error");
            }
            else
            {
                updateClientRow["LastName"] = txtUpdateLastName.Text;
                updateClientRow["FirstName"] = txtUpdateFirstName.Text;
                updateClientRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                updateClientRow["Suburb"] = txtUpdateSuburb.Text;
                updateClientRow["City"] = txtUpdateCity.Text;
                updateClientRow["CountryID"] = this.cmbUpdateCountryID.GetItemText(this.cmbUpdateCountryID.SelectedItem);
                updateClientRow["Email"] = txtUpdateEmail.Text;
                updateClientRow["CreditStatus"] = this.cmbUpdateCreditStatus.GetItemText(this.cmbUpdateCreditStatus.SelectedItem);
                currencyManager.EndCurrentEdit();
                DM.UpdateClient();
                MessageBox.Show("Client Updated Successfully!", "Success");
            }
        }

        /// <summary>
        /// cancel updating a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdateClient.Hide();
            lstClient.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddClient.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnDeleteClient.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// interlock countryid and name
        /// </summary>
        private void LoadCountries()
        {
            cmbAddCountryID.DisplayMember = "Country.CountryID";
            cmbAddCountryID.ValueMember = "Country.CountryID";
            cmbAddCountryID.DataSource = DM.dsBookBrokers;
            cmbAddCountryName.DisplayMember = "Country.CountryName";
            cmbAddCountryName.ValueMember = "Country.CountryName";
            cmbAddCountryName.DataSource = DM.dsBookBrokers;
            cmbUpdateCountryID.DisplayMember = "Country.CountryID";
            cmbUpdateCountryID.ValueMember = "Country.CountryID";
            cmbUpdateCountryID.DataSource = DM.dsBookBrokers;
            cmbUpdateCountryName.DisplayMember = "Country.CountryName";
            cmbUpdateCountryName.ValueMember = "Country.CountryName";
            cmbUpdateCountryName.DataSource = DM.dsBookBrokers;
        }

        /// <summary>
        /// load credit status
        /// </summary>
        private void LoadCreditStatus()
        {
            cmbAddCreditStatus.DisplayMember = "Client.CreditStatus";
            cmbAddCreditStatus.ValueMember = "Client.CreditStatus";
            cmbAddCreditStatus.DataSource = DM.dsBookBrokers;
            cmbUpdateCreditStatus.DisplayMember = "Client.CreditStatus";
            cmbUpdateCreditStatus.ValueMember = "Client.CreditStatus";
            cmbUpdateCreditStatus.DataSource = DM.dsBookBrokers;
        }

        /// <summary>
        /// interlock country id and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCountryID_TextChanged(object sender, EventArgs e)
        {
            if (txtCountryID.Text == "")
            {
                txtCountryName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtCountryID.Text);
                cmCountry.Position = DM.countryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountryName.Text = drCountry["CountryName"].ToString();
            }
        }

        /// <summary>
        /// delete a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DataRow deleteClientRow = DM.dtClient.Rows[currencyManager.Position];
            DataRow[] ClientOrderRow = DM.dtClientOrder.Select("ClientID = " + txtClientID.Text);
            if (ClientOrderRow.Length != 0)
            {
                MessageBox.Show("You may only delete clients that have not placed any orders", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientRow.Delete();
                    DM.UpdateClient();
                    MessageBox.Show("Client Deleted Successfully!", "Success");
                }
            }
        }
    }
}
