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
    public partial class VendorForm : Form
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
        public VendorForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            Width = 580;
            Height = 310;
            pnlAddVendor.Left = 219;
            pnlAddVendor.Top = 2;
            pnlAddVendor.Visible = false;
            pnlUpdateVendor.Left = 219;
            pnlUpdateVendor.Top = 2;
            pnlUpdateVendor.Visible = false;            
        }

        /// <summary>
        /// data bind control
        /// </summary>
        public void BindControls()
        {
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorID");
            txtVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");
            txtPostBoxNumber.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");
            txtCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.CountryID");
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");
            txtUpdateVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorID");
            txtUpdateVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");
            txtUpdatePostBoxNumber.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");
            txtUpdateCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.CountryID");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtPostBoxNumber.Enabled = false;
            txtCountryID.Enabled = false;
            txtCountryName.Enabled = false;
            txtEmail.Enabled = false;
            txtUpdateVendorID.Enabled = false;
            txtUpdateCountryID.Enabled = false;
            txtUpdateCountryName.Enabled = false;
            lstVendor.DisplayMember = "Vendor.VendorName";
            lstVendor.ValueMember = "Vendor.VendorName";
            lstVendor.DataSource = DM.dsBookBrokers;
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
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
        /// open a new panel to update a vendor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateVendor_Click(object sender, EventArgs e)
        {
            lstVendor.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddVendor.Enabled = false;
            btnUpdateVendor.Enabled = false;
            btnDeleteVendor.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateVendor.Show();
        }

        /// <summary>
        /// update a vendor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateVendorRow = DM.dtVendor.Rows[currencyManager.Position];

            if (txtUpdateVendorName.Text == "")
            {
                MessageBox.Show("You must type in a vendor name!", "Error");
            }
            else if (txtUpdatePostBoxNumber.Text == "")
            {
                MessageBox.Show("You must type in a post box number!", "Error");
            }
            else if (txtUpdateEmail.Text == "")
            {
                MessageBox.Show("You must type in an email address!", "Error");
            }
            else
            {
                updateVendorRow["VendorName"] = txtUpdateVendorName.Text;
                updateVendorRow["PostBoxNumber"] = txtUpdatePostBoxNumber.Text;
                updateVendorRow["Email"] = txtUpdateEmail.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateVendor();
                MessageBox.Show("Vendor Updated Successfully!", "Success");
            }
        }

        /// <summary>
        /// cancel updating a vendor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdateVendor.Hide();
            lstVendor.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddVendor.Enabled = true;
            btnUpdateVendor.Enabled = true;
            btnDeleteVendor.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// cancel adding a new vendor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            pnlAddVendor.Hide();
            lstVendor.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddVendor.Enabled = true;
            btnUpdateVendor.Enabled = true;
            btnDeleteVendor.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// open a new panel to add a vendor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            lstVendor.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddVendor.Enabled = false;
            btnUpdateVendor.Enabled = false;
            btnDeleteVendor.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddVendor.Show();
            LoadCountries();
        }

        /// <summary>
        /// add a new vendor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveVendor_Click(object sender, EventArgs e)
        {
            txtVendorID = null;
            DataRow newVendorRow = DM.dtVendor.NewRow();

            if (txtAddVendorName.Text == "")
            {
                MessageBox.Show("You must type in a vendor name!", "Error");
            }
            else if (txtAddPostBoxNumber.Text == "")
            {
                MessageBox.Show("You must type in a post box number!", "Error");
            }
            else if (txtAddEmail.Text == "")
            {
                MessageBox.Show("You must type in an email address!", "Error");
            }
            else
            {
                newVendorRow["VendorName"] = txtAddVendorName.Text;
                newVendorRow["PostBoxNumber"] = txtAddPostBoxNumber.Text;
                newVendorRow["Email"] = txtAddEmail.Text;
                newVendorRow["CountryID"] = this.cmbAddCountryID.GetItemText(this.cmbAddCountryID.SelectedItem);
                DM.dtVendor.Rows.Add(newVendorRow);
                DM.UpdateVendor();
                MessageBox.Show("New Vendor Added Successfully!", "Success");
            }
        }

        /// <summary>
        /// bind control country id and name
        /// </summary>
        private void LoadCountries()
        {
            cmbAddCountryID.DisplayMember = "Country.CountryID";
            cmbAddCountryID.ValueMember = "Country.CountryID";
            cmbAddCountryID.DataSource = DM.dsBookBrokers;
            cmbAddCountryName.DisplayMember = "Country.CountryName";
            cmbAddCountryName.ValueMember = "Country.CountryName";
            cmbAddCountryName.DataSource = DM.dsBookBrokers;
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
        /// delete a vendor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteVendor_Click(object sender, EventArgs e)
        {
            DataRow deleteVendorRow = DM.dtVendor.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("VendorID = " + txtVendorID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete vendors that do not sell any books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVendorRow.Delete();
                    DM.UpdateVendor();
                    MessageBox.Show("Vendor Deleted Successfully!", "Success");
                }
            }
        }

        /// <summary>
        /// interlock a countryid and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUpdateCountryID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateCountryID.Text == "")
            {
                txtUpdateCountryName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtUpdateCountryID.Text);
                cmCountry.Position = DM.countryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtUpdateCountryName.Text = drCountry["CountryName"].ToString();
            }
        }
    }
}
