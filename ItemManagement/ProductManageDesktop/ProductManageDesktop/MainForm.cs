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

        /// <summary>
        /// Member id
        /// </summary>
        private int productId;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            this.productMasterService = new ProductMasterService();
            this.InitilizeDataGridViewStyle();
        }


        private void InitilizeDataGridViewStyle()
        {
            // Setting the style of the DataGridView control
            dgCurrentStock.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgCurrentStock.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgCurrentStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgCurrentStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgCurrentStock.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgCurrentStock.DefaultCellStyle.BackColor = Color.Empty;
            dgCurrentStock.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            dgCurrentStock.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgCurrentStock.GridColor = SystemColors.ControlDarkDark;
        }

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
                if (Convert.ToInt32(txtSellingRate.Text.Trim()) < Convert.ToInt32(txtPurchaseRate.Text.Trim()))
                {
                    this.AddErrorMessage("Seling Rate Can't be Less then Purchase rate");
                }
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
        /// Interface of ClubMemberService
        /// </summary>

        private void btnEditItem_Click(object sender, EventArgs e)
        {

        }
        private void mnuTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (mnuTab.SelectedIndex == 0)
                {
                    DataTable data = this.productMasterService.GetAll();
                    this.LoadDataGridView(data);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Method to load data grid view
        /// </summary>
        /// <param name="data">data table</param>
        private void LoadDataGridView(DataTable data)
        {
            // Data grid view column setting            
            dgCurrentStock.DataSource = data;
            dgCurrentStock.DataMember = data.TableName;
            dgCurrentStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

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

                    txt2Name.Text = dataRow["Name"].ToString();
                    //dt2DateOfBirth.Value = Convert.ToDateTime(dataRow["DateOfBirth"]);
                    //cmb2Occupation.SelectedItem = (Occupation)dataRow["Occupation"];
                    //cmb2MaritalStatus.SelectedItem = (MaritalStatus)dataRow["MaritalStatus"];
                    //cmb2HealthStatus.SelectedItem = (HealthStatus)dataRow["HealthStatus"];
                    //txt2Salary.Text = dataRow["Salary"].ToString() == "0.0000" ? string.Empty : dataRow["Salary"].ToString();
                    //txt2NoOfChildren.Text = dataRow["NumberOfChildren"].ToString();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void dgvSearchGridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //if (e.ColumnIndex == 2)
                //{
                //    e.Value = string.Format("{0:dd/MM/yyyy}", (DateTime)e.Value);
                //}

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        #endregion
    }
}
