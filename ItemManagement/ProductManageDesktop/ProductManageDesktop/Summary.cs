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
    public partial class Summary : Form
    {
        public int productId { get; set; }
        public int productHistoryId { get; set; }

        private IProductHistoryService productHistoryService;
        private IProductMasterService productMasterService;
        public DataTable summaryData { get; set; }

        private string errorMessage;

        public Summary()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.productHistoryService = new ProductHistoryService();
            this.productMasterService = new ProductMasterService();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
            this.EnableDisableActions(false);
        }

        public void LoadSummary()
        {
            try
            {
                // if (summaryData != null && summaryData.Rows.Count > 0)
                {
                    LoadDataGridView(summaryData, dgvSummary);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }


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
        private void LoadDataGridView(DataTable data, DataGridView grdView)
        {
            // change datatable column name

            data.Columns[4].ColumnName = "Quantity Updated#";
            data.Columns[3].ColumnName = "Sent to#";
            data.Columns[5].ColumnName = "Date Added #";
            data.Columns[7].ColumnName = "Date Edited #";
            // Data grid view column setting   
            InitilizeDataGridViewStyle(grdView);
            grdView.DataSource = data;
            grdView.DataMember = data.TableName;
            // Hide Columns
            grdView.Columns["ProductHistoryID"].Visible = false;
            grdView.Columns["Products"].Visible = false;
            grdView.Columns["ProductID"].Visible = false;
            grdView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

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

        private void dgvSummary_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    productHistoryId = int.Parse(id);
                    DataRow dataRow = this.productHistoryService.GetById(productHistoryId);

                    txtNote.Text = dataRow["Note"].ToString() == null ? "" : dataRow["Note"].ToString();
                    txtSentTo.Text = dataRow["SentTo"].ToString() == null ? "" : dataRow["SentTo"].ToString();
                    txtSummaryQuantity.Text = dataRow["Updated_Quantity"].ToString() == null ? "" : dataRow["Updated_Quantity"].ToString();

                    this.EnableDisableActions(true);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void EnableDisableActions(bool flag)
        {
            btnDelete.Enabled = flag;
            btnUpdate.Enabled = flag;
           
        }

        private void ResetValues()
        {
            txtSummaryQuantity.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtSentTo.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateUpdate())
                {
                    ProductHistory productHistoryUpdate = this.productHistoryService.GetByIdForEdit(this.productHistoryId);
                    ProductMaster productMasterUpdate = this.productMasterService.GetByIdForEdit(this.productId);

                    if (productHistoryUpdate != null)
                    {
                        // Buisness Logic of Updation Remaining here 
                        productHistoryUpdate.Note = txtNote.Text.Trim();

                        if (productHistoryUpdate.SentTo.Contains("Godown"))
                        {
                            if(productHistoryUpdate.Updated_Quantity < Convert.ToInt32(txtSummaryQuantity.Text.Trim())) // the quantity is updated less , so we have to add more in the stock
                                productMasterUpdate.Quantity = productMasterUpdate.Quantity + (Convert.ToInt32(txtSummaryQuantity.Text.Trim()) - productHistoryUpdate.Updated_Quantity);
                            else
                                productMasterUpdate.Quantity = productMasterUpdate.Quantity - (productHistoryUpdate.Updated_Quantity - Convert.ToInt32(txtSummaryQuantity.Text.Trim()));
                        }
                        else
                        {
                            if (productHistoryUpdate.Updated_Quantity < Convert.ToInt32(txtSummaryQuantity.Text.Trim())) // the quantity is updated Less , Case 1:  we have sent more items to shop
                                productMasterUpdate.Quantity = productMasterUpdate.Quantity - (Convert.ToInt32(txtSummaryQuantity.Text.Trim()) - productHistoryUpdate.Updated_Quantity);
                            else
                                productMasterUpdate.Quantity = productMasterUpdate.Quantity +  (productHistoryUpdate.Updated_Quantity - Convert.ToInt32(txtSummaryQuantity.Text.Trim())); //  Case 1:  we have sent less items to shop
                        }

                        productHistoryUpdate.Updated_Quantity = Convert.ToInt32(txtSummaryQuantity.Text.Trim());
                        this.productMasterService.Update(productMasterUpdate);
                    }
                    var flag = this.productHistoryService.Update(productHistoryUpdate);

                    if (flag)
                    {
                        DataTable data = this.productHistoryService.GetAllSummaryByProductId(this.productId);
                        this.LoadDataGridView(data, dgvSummary);
                        this.EnableDisableActions(false);
                        ResetValues();
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
                        Resources.Update_Error_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private bool ValidateUpdate()
        {
            this.errorMessage = string.Empty;

            if (txtNote.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please add Note / Reason for Updating History");
            }
            if (txtSummaryQuantity.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Please add valid quantity!!");
            }
            return this.errorMessage != string.Empty ? false : true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var flag = this.productHistoryService.DeleteHistory(this.productHistoryId);

                if (flag)
                {
                    DataTable data = this.productHistoryService.GetAllSummaryByProductId(this.productId);
                    this.LoadDataGridView(data, dgvSummary);
                    this.EnableDisableActions(false);
                    ResetValues();
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

        private void txtSummaryQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
