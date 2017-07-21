// Its a Test Project use should be for Study purpose only 
//Author :  Mohnish Lokhande
using ProductManageDataLayer.Entities;
using ProductManageDataLayer.Service;
using ProductManageDataLayer.Service.Interface;
using ProductManageDesktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManageDesktop
{
    public partial class MainForm : Form
    {

        #region Declaration
        /// <summary>
        /// Variable to store error message
        /// </summary>
        private string errorMessage;

        private IProductMasterService productMasterService;
        private IProductHistoryService productHistoryService;

        /// <summary>
        /// Member id
        /// </summary>
        private int productId;
        private bool IsAdd = false;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            this.productMasterService = new ProductMasterService();
            this.productHistoryService = new ProductHistoryService();
            this.InitilizeDataGridViewStyle(dgCurrentStock);
        }

        #region Common Methods  

        /// <summary>
        /// Grid Styling
        /// </summary>
        /// <param name="dgv"></param>
        private void InitilizeDataGridViewStyle(DataGridView dgv)
        {
            // Setting the style of the DataGridView control
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgv.DefaultCellStyle.BackColor = Color.Empty;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = SystemColors.ControlDarkDark;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
        }

        /// <summary>
        /// Method to show general error message on any system level exception
        /// </summary>
        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                //Resources.System_Error_Message, 
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// To generate the error message
        /// </summary>
        /// <param name="error">error message</param>
        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = Resources.Error_Message_Header + "\n\n";
            }

            this.errorMessage += error + "\n";
        }

        /// <summary>
        /// Method to load data grid view
        /// </summary>
        /// <param name="data">data table</param>
        private void LoadDataGridView(DataTable data, DataGridView grdView)
        {
            // change datatable column name
            data.Columns[0].ColumnName = "ID";
            data.Columns[1].ColumnName = "Product Name";
            data.Columns[4].ColumnName = "Purchase Rate #";
            data.Columns[6].ColumnName = "Sell Rate #";
            data.Columns[9].ColumnName = "Dealer";
            data.Columns[10].ColumnName = "Date Added";
            data.Columns[11].ColumnName = "Date Last Updated";


            // Data grid view column setting   
            InitilizeDataGridViewStyle(grdView);
            grdView.DataSource = data;
            grdView.DataMember = data.TableName;
            // Hide Columns
            grdView.Columns["ID"].Visible = false;
            grdView.Columns["ProductHistory"].Visible = false;
            grdView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            EnableDisableActions(false);
        }
        #endregion

        #region Validation

        /// <summary>
        /// Validates registration input
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidateRegistration()
        {
            this.errorMessage = string.Empty;

            if (txtProductName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please Add Product Name");
            }

            if (txtQuantity.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please enter the Quantity Taken");
            }

            if (txtPurchaseRate.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please enter the  Purchase Rate");
            }

            if (txtSellingRate.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please enter the  Selling  Rate");
            }

            if (txtReminderAfter.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please enter the  Reminder  After");
            }

            if (txtSellingRate.Text.Trim() != string.Empty && txtPurchaseRate.Text.Trim() != string.Empty)
            {
                if (Convert.ToDecimal(txtSellingRate.Text.Trim()) < Convert.ToDecimal(txtPurchaseRate.Text.Trim()))
                {
                    this.AddErrorMessage("Seling Rate Can't be Less then Purchase rate");
                }
            }


            return this.errorMessage != string.Empty ? false : true;
        }

        /// <summary>
        /// Validate Update
        /// </summary>
        /// <returns></returns>
        private bool ValidateUpdate()
        {
            this.errorMessage = string.Empty;

            if (txtSProductName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please Add Product Name");
            }

            if (txtSQuantity.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please enter the Quantity Taken");
            }

            if (txtSPurchaseRate.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please enter the  Purchase Rate");
            }

            if (txtSSellingRate.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please enter the  Selling  Rate");
            }

            if (txtSReminderAfter.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please enter the  Reminder  After");
            }

            if (txtSSellingRate.Text.Trim() != string.Empty && txtSPurchaseRate.Text.Trim() != string.Empty)
            {
                if (Convert.ToDecimal(txtSSellingRate.Text.Trim()) < Convert.ToDecimal(txtSPurchaseRate.Text.Trim()))
                {
                    this.AddErrorMessage("Seling Rate Can't be Less then Purchase rate");
                }
            }


            return this.errorMessage != string.Empty ? false : true;
        }

        #endregion

        #region Add Product

        /// <summary>
        /// Add product to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the validation passes
                if (this.ValidateRegistration())
                {
                    // Assign the values to the model
                    ProductMaster productModel = new ProductMaster()
                    {
                        Name = txtProductName.Text.Trim(),
                        Description = txtProductDescription.Text.Trim(),
                        HSN = txtHsnNumber.Text.Trim(),
                        Purchase_Rate = Convert.ToDecimal((txtPurchaseRate.Text.Trim())),
                        Packing = txtPacking.Text.Trim(),
                        Sell_Rate = Convert.ToDecimal((txtSellingRate.Text.Trim())),
                        Quantity = Convert.ToInt32(txtQuantity.Text.Trim()),
                        Reminder = Convert.ToInt32(txtReminderAfter.Text.Trim()),
                        DealerName = txtDealerName.Text.Trim(),
                        Purchase_Date = System.DateTime.Now,
                        LastUpdated_Date = System.DateTime.Now
                    };

                    //// Call the service method and assign the return status to variable
                    var success = this.productMasterService.Create(productModel);

                    // if status of success variable is true then display a information else display the error message
                    if (success)
                    {
                        // display the message box
                        MessageBox.Show(
                            Resources.Registration_Successful_Message,
                            Resources.Registration_Successful_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Reset the screen
                        this.ResetProductRegistration();
                    }
                    else
                    {
                        // display the error messge
                        MessageBox.Show(
                            Resources.Registration_Error_Message,
                            Resources.Registration_Error_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Display the validation failed message
                    MessageBox.Show(
                        this.errorMessage,
                        "Product Registration",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        #endregion

        #region Key Press
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReminderAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPurchaseRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        private void txtSellingRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Search Form 

        private void dgvSearchGridview_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    productId = int.Parse(id);
                    DataRow dataRow = this.productMasterService.GetById(productId);
                    txtSProductName.Text = dataRow["Name"].ToString();
                    txtSHSNNumber.Text = dataRow["HSN"].ToString();
                    txtSPacking.Text = dataRow["Packing"].ToString() == null ? string.Empty : dataRow["Packing"].ToString();
                    txtSQuantity.Text = dataRow["Quantity"].ToString() == null ? "0" : dataRow["Quantity"].ToString();
                    txtSPurchaseRate.Text = dataRow["Purchase_Rate"].ToString() == null ? "0.0" : dataRow["Purchase_Rate"].ToString();
                    txtSSellingRate.Text = dataRow["Sell_Rate"].ToString() == null ? "0.0" : dataRow["Sell_Rate"].ToString();
                    txtSReminderAfter.Text = dataRow["Reminder"].ToString() == null ? "0" : dataRow["Reminder"].ToString();
                    txtSDescription.Text = dataRow["Description"].ToString() == null ? "" : dataRow["Description"].ToString();
                    txtSDealer.Text = dataRow["DealerName"].ToString() == null ? "" : dataRow["DealerName"].ToString();
                    EnableDisableActions(true);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = this.productMasterService.Search(txtSProductNameSearch.Text.Trim());
                this.LoadDataGridView(data, dgvSearchGridview);
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable data = this.productMasterService.GetAll();
            this.LoadDataGridView(data, dgvSearchGridview);
            ResetSearchPage();
        }

        /// <summary>
        /// Send the Quantity to the shop from godown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToShop_Click(object sender, EventArgs e)
        {
            IsAdd = false;

            DialogResult dialogResult = MessageBox.Show("You opt to take " + "  " + txtSQuantity.Text.Trim() + " " + "units of Quantity to the Shop from Godown! \n Are you sure !", "Are you Sure!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // Validate the Quantity 
                if (validateQuantity(IsAdd))
                {
                    UpdateMasterRecord(IsAdd);
                }

            }
        }

        /// <summary>
        /// Function Adds Data to the Godown or Stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToGodown_Click(object sender, EventArgs e)
        {
            try
            {
                IsAdd = true;
                DialogResult dialogResult = MessageBox.Show("You opt to add " + "  " + txtSQuantity.Text.Trim() + " " + "units of Quantity to the Godown! \n Are you sure !", "Are you Sure!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    // Validate the Quantity 
                    if (validateQuantity(IsAdd))
                    {
                        UpdateMasterRecord(IsAdd);
                    }

                }

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void UpdateMasterRecord(bool isAdd)
        {
            try
            {
                ProductMaster productMasterUpdate = this.productMasterService.GetByIdForEdit(this.productId);
                bool success = false;
                string sentTo = string.Empty;
                if (productMasterUpdate != null)
                {
                    if (isAdd)
                    {
                        //added to godown
                        sentTo = "Godown";
                        productMasterUpdate.Quantity = productMasterUpdate.Quantity + Convert.ToInt32(txtSQuantity.Text.Trim());
                        success = this.productMasterService.Update(productMasterUpdate);
                    }
                    else
                    {
                        // Add to shop delete from godown
                        sentTo = "Shop";
                        productMasterUpdate.Quantity = (productMasterUpdate.Quantity - Convert.ToInt32(txtSQuantity.Text.Trim()));
                        success = this.productMasterService.Update(productMasterUpdate);
                    }

                    // Update the History Table
                    ProductHistory p = new ProductHistory();
                    p.SentTo = sentTo;
                    p.ProductID = productId;
                    p.Updated_Quantity = Convert.ToInt32(txtSQuantity.Text.Trim());
                    p.Date_Modified = System.DateTime.Now;
                    productHistoryService.Create(p);
                }

                if (success)
                {
                    MessageBox.Show(
                         "Database Updated Successfully, with new modified Quantity for the product!!",
                         "Database Updated",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                }
                //
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private bool validateQuantity(bool flag)
        {
            try
            {
                // TO:DO Validation that u cant add more than godown quantity to the shop
                if (txtSQuantity.Text.Trim() != string.Empty)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                return ex.Message != string.Empty ? false : true;
            }
        }


        private void dgvSearchGridview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    int prodId = 0;
                    if (int.TryParse(id, out prodId) && prodId > 0)
                    {
                        // if Records are not found show dailog no records found else show the summary form
                        var productSummary = this.productHistoryService.GetAllSummaryByProductId(this.productId);

                        if (productSummary != null && productSummary.Rows.Count > 0)
                        {
                            Summary summary = new Summary();
                            summary.summaryData = productSummary;
                            summary.productId = prodId;
                            summary.LoadSummary();
                            summary.ShowDialog(this);
                        }
                        else
                        {
                            MessageBox.Show(
                           "No Summary Information was found for the Product!!",
                           "No History",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void btnSUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateUpdate())
                {
                    ProductMaster productMasterUpdate = this.productMasterService.GetByIdForEdit(this.productId);

                    if (productMasterUpdate != null)
                    {
                        productMasterUpdate.Name = txtSProductName.Text.Trim();
                        productMasterUpdate.HSN = txtSHSNNumber.Text.Trim();
                        productMasterUpdate.Packing = txtSPacking.Text.Trim();
                        productMasterUpdate.Quantity = Convert.ToInt32(txtSQuantity.Text.Trim());
                        productMasterUpdate.Purchase_Rate = Convert.ToDecimal(txtSPurchaseRate.Text.Trim());
                        productMasterUpdate.Sell_Rate = Convert.ToDecimal(txtSSellingRate.Text.Trim());
                        productMasterUpdate.Reminder = Convert.ToInt32(txtSReminderAfter.Text.Trim());
                        productMasterUpdate.Description = Convert.ToString(txtSDescription.Text.Trim());
                        productMasterUpdate.DealerName = Convert.ToString(txtSDealer.Text.Trim());

                    }
                    var flag = this.productMasterService.Update(productMasterUpdate);

                    if (flag)
                    {
                        DataTable data = this.productMasterService.GetAll();
                        this.LoadDataGridView(data, dgvSearchGridview);
                        ResetSearchPage();

                        MessageBox.Show(
                            Resources.Update_Successful_Message,
                            Resources.Update_Successful_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(
                        this.errorMessage,
                        Resources.Registration_Error_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.productHistoryService.DoesHistoryExists(this.productId))
                {

                    this.productHistoryService.Delete(this.productId);

                }

                var flag = this.productMasterService.Delete(this.productId);

                if (flag)
                {
                    DataTable data = this.productMasterService.GetAll();
                    this.LoadDataGridView(data, dgvSearchGridview);
                    MessageBox.Show(
                        Resources.Delete_Successful_Message,
                        Resources.Delete_Successful_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
        
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        #endregion

        #region Reset Section

        /// <summary>
        /// Reset the Text boxes 
        /// </summary>
        private void ResetProductRegistration()
        {
            txtProductName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtHsnNumber.Text = string.Empty;
            txtPurchaseRate.Text = string.Empty;
            txtPacking.Text = string.Empty;
            txtSellingRate.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtReminderAfter.Text = string.Empty;
            txtDealerName.Text = string.Empty;

        }


        /// <summary>
        /// Reset the Text boxes 
        /// </summary>
        private void ResetSearchPage()
        {
            txtSProductName.Text = string.Empty;
            txtSHSNNumber.Text = string.Empty;
            txtSPacking.Text = string.Empty;
            txtSQuantity.Text = string.Empty;
            txtSPurchaseRate.Text = string.Empty;
            txtSSellingRate.Text = string.Empty;
            txtSReminderAfter.Text = string.Empty;
            txtSProductNameSearch.Text = string.Empty;
            txtSDescription.Text = string.Empty;
            txtSDealer.Text = string.Empty;
        }

        private void EnableDisableActions(bool flag)
        {
            btnSDelete.Enabled = flag;
            btnSUpdate.Enabled = flag;
            btnToShop.Enabled = flag;
            btnToGodown.Enabled = flag;
        }


        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgCurrentStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgCurrentStock.Rows)
            {
                if (Convert.ToInt32(row.Cells["Reminder"].Value) >= Convert.ToInt32(row.Cells["Quantity"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

            }
        }

        private void txtSProductNameSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable data = this.productMasterService.Search(txtSProductNameSearch.Text.Trim());
                this.LoadDataGridView(data, dgvSearchGridview);
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Selected Index Changed of Menu Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (mnuTab.SelectedIndex == 0)
                {
                    DataTable data = this.productMasterService.GetAll();
                    this.LoadDataGridView(data, dgCurrentStock);
                }
                // Searh grid View
                if (mnuTab.SelectedIndex == 1)
                {
                    DataTable data = this.productMasterService.GetAll();
                    this.LoadDataGridView(data, dgvSearchGridview);
                }

                // Searh grid View
                if (mnuTab.SelectedIndex == 3)
                {
                    DataTable data = this.productMasterService.GetAllReminders();
                    this.LoadDataGridView(data, dgvReminderGrid);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }
    }
}
