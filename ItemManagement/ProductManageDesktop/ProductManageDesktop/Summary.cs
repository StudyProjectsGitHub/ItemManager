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
        public DataTable summaryData { get; set; }

        public Summary()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
            //this.LoadSummary();
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
            data.Columns[5].ColumnName = "Updated Date Time #";

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
    }
}
