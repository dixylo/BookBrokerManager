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
    public partial class ClientOrderForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmClient;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public ClientOrderForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            Width = 610;
            Height = 340;
            pnlAddClientOrder.Left = 128;
            pnlAddClientOrder.Top = 2;
            pnlAddClientOrder.Visible = false;
            pnlUpdateClientOrder.Left = 128;
            pnlUpdateClientOrder.Top = 2;
            pnlUpdateClientOrder.Visible = false;
        }

        /// <summary>
        /// data bind control
        /// </summary>
        public void BindControls()
        {
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientOrderID");
            txtOrderDate.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.OrderDate");
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");
            txtStatus.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.Status");
            txtUpdateClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientOrderID");
            dtpUpdateOrderDate.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.OrderDate");
            txtUpdateStatus.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.Status");
            txtUpdateClientID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");
            txtClientOrderID.Enabled = false;
            txtOrderDate.Enabled = false;
            txtClientID.Enabled = false;
            txtStatus.Enabled = false;
            txtClientLastName.Enabled = false;
            txtClientFirstName.Enabled = false;
            txtUpdateClientOrderID.Enabled = false;
            txtUpdateStatus.Enabled = false;
            txtUpdateClientID.Enabled = false;
            txtUpdateClientLastName.Enabled = false;
            txtUpdateClientFirstName.Enabled = false;
            lstClientOrder.DisplayMember = "ClientOrder.ClientOrderID";
            lstClientOrder.ValueMember = "ClientOrder.ClientOrderID";
            lstClientOrder.DataSource = DM.dsBookBrokers;
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
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
        /// bind control clientid and name
        /// </summary>
        private void LoadClients()
        {
            cmbAddClientID.DisplayMember = "Client.ClientID";
            cmbAddClientID.ValueMember = "Client.ClientID";
            cmbAddClientID.DataSource = DM.dsBookBrokers;
            cmbAddClientLastName.DisplayMember = "Client.LastName";
            cmbAddClientLastName.ValueMember = "Client.LastName";
            cmbAddClientLastName.DataSource = DM.dsBookBrokers;
            cmbAddClientFirstName.DisplayMember = "Client.FirstName";
            cmbAddClientFirstName.ValueMember = "Client.FirstName";
            cmbAddClientFirstName.DataSource = DM.dsBookBrokers;
        }

        /// <summary>
        /// open a new panel to add a client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddClientOrder_Click(object sender, EventArgs e)
        {
            lstClientOrder.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddClientOrder.Enabled = false;
            btnUpdateClientOrder.Enabled = false;
            btnDeleteClientOrder.Enabled = false;
            btnMarkShipped.Enabled = false;
            btnMarkPaid.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddClientOrder.Show();
            LoadClients();
        }

        /// <summary>
        /// add a client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveClientOrder_Click(object sender, EventArgs e)
        {
            txtClientOrderID = null;
            DataRow newClientOrderRow = DM.dtClientOrder.NewRow();
            newClientOrderRow["OrderDate"] = this.dtpAddOrderDate.Text;
            newClientOrderRow["ClientID"] = this.cmbAddClientID.GetItemText(this.cmbAddClientID.SelectedItem);
            newClientOrderRow["Status"] = "Current";
            DM.dtClientOrder.Rows.Add(newClientOrderRow);
            DM.UpdateClientOrder();
            MessageBox.Show("New Client Order Added Successfully!", "Success");
        }

        /// <summary>
        /// cancel adding a client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            pnlAddClientOrder.Hide();
            lstClientOrder.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddClientOrder.Enabled = true;
            btnUpdateClientOrder.Enabled = true;
            btnDeleteClientOrder.Enabled = true;
            btnMarkShipped.Enabled = true;
            btnMarkPaid.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// open a new panel to update a client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateClientOrder_Click(object sender, EventArgs e)
        {
            lstClientOrder.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddClientOrder.Enabled = false;
            btnUpdateClientOrder.Enabled = false;
            btnDeleteClientOrder.Enabled = false;
            btnMarkShipped.Enabled = false;
            btnMarkPaid.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateClientOrder.Show();
        }

        /// <summary>
        /// update a client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            updateClientOrderRow["OrderDate"] = this.dtpUpdateOrderDate.Text;
            currencyManager.EndCurrentEdit();
            DM.UpdateClientOrder();
            MessageBox.Show("Client Order Updated Successfully!", "Success");
        }

        /// <summary>
        /// cancel updating a client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdateClientOrder.Hide();
            lstClientOrder.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddClientOrder.Enabled = true;
            btnUpdateClientOrder.Enabled = true;
            btnDeleteClientOrder.Enabled = true;
            btnMarkShipped.Enabled = true;
            btnMarkPaid.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// delete a client order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteClientOrder_Click(object sender, EventArgs e)
        {
            DataRow deleteClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("ClientOrderID = " + txtClientOrderID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete client orders that don't contain any books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientOrderRow.Delete();
                    DM.UpdateClientOrder();
                    MessageBox.Show("Client Order Deleted Successfully!", "Success");
                }
            }
        }

        /// <summary>
        /// interlock clientid and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtClientID.Text == "")
            {
                txtClientLastName.Text = "";
                txtClientFirstName.Text = "";
            }
            else
            {
                int aClientID = Convert.ToInt32(txtClientID.Text);
                cmClient.Position = DM.clientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtClientLastName.Text = drClient["LastName"].ToString();
                txtClientFirstName.Text = drClient["FirstName"].ToString();
            }
        }

        /// <summary>
        /// mark as shipped a current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkShipped_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];

            if (txtStatus.Text == "Current")
            {
                updateClientOrderRow["Status"] = "Shipped";
                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client Order Marked as Shipped!", "Success");
            }
            else if (txtStatus.Text == "Shipped" || txtStatus.Text == "Paid")
            {
                MessageBox.Show("Only Current Client Orders Can be Marked as Shipped!", "Error");
            }
            else
            {
                MessageBox.Show("Order Status Unclear!", "Error");
            } 
        }

        /// <summary>
        /// mark a shipped order as paid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];

            if (txtStatus.Text.Equals("Shipped"))
            {
                updateClientOrderRow["Status"] = "Paid";
                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client Order Marked as Paid!", "Success");
            }
            else if (txtStatus.Text.Equals("Current") || txtStatus.Text.Equals("Paid"))
            {
                MessageBox.Show("Only Shipped Client Orders Can be Marked as Paid!", "Error");
            }
            else
            {
                MessageBox.Show("Order Status Unclear!", "Error");
            }
        }

        /// <summary>
        /// interlock clientid and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUpdateClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateClientID.Text == "")
            {
                txtUpdateClientLastName.Text = "";
                txtUpdateClientFirstName.Text = "";
            }
            else
            {
                int aClientID = Convert.ToInt32(txtUpdateClientID.Text);
                cmClient.Position = DM.clientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtUpdateClientLastName.Text = drClient["LastName"].ToString();
                txtUpdateClientFirstName.Text = drClient["FirstName"].ToString();
            }
        }
    }
}
