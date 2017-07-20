namespace ProductManageDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuTab = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.dgCurrentStock = new System.Windows.Forms.DataGridView();
            this.tabSearchManage = new System.Windows.Forms.TabPage();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSUpdate = new System.Windows.Forms.Button();
            this.txtSHSNNumber = new System.Windows.Forms.TextBox();
            this.txtSPacking = new System.Windows.Forms.TextBox();
            this.txtSPurchaseRate = new System.Windows.Forms.TextBox();
            this.txtSSellingRate = new System.Windows.Forms.TextBox();
            this.txtSReminderAfter = new System.Windows.Forms.TextBox();
            this.lbl2NoOfChildren = new System.Windows.Forms.Label();
            this.lbl2HealthStatus = new System.Windows.Forms.Label();
            this.lbl2MaritalStatus = new System.Windows.Forms.Label();
            this.lbl2Salary = new System.Windows.Forms.Label();
            this.txtSQuantity = new System.Windows.Forms.TextBox();
            this.lbl2Occupation = new System.Windows.Forms.Label();
            this.txtSProductName = new System.Windows.Forms.TextBox();
            this.lbl2DateOfBirth = new System.Windows.Forms.Label();
            this.lbl2Name = new System.Windows.Forms.Label();
            this.btnToShop = new System.Windows.Forms.Button();
            this.btnToGodown = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSProductNameSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtSToDate = new System.Windows.Forms.DateTimePicker();
            this.dtSFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSearchGridview = new System.Windows.Forms.DataGridView();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.txtHsnNumber = new System.Windows.Forms.TextBox();
            this.txtPacking = new System.Windows.Forms.TextBox();
            this.txtReminderAfter = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.txtSellingRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHealthStatusRequired = new System.Windows.Forms.Label();
            this.lblMaritalStatusRequired = new System.Windows.Forms.Label();
            this.lblOccupationRequired = new System.Windows.Forms.Label();
            this.lblDOBRequired = new System.Windows.Forms.Label();
            this.lblNameRequired = new System.Windows.Forms.Label();
            this.lblNoOfChildren = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblHealthStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabViewSummary = new System.Windows.Forms.TabPage();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReminderGrid = new System.Windows.Forms.DataGridView();
            this.mnuTab.SuspendLayout();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentStock)).BeginInit();
            this.tabSearchManage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGridview)).BeginInit();
            this.tabRegistration.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tabViewSummary.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuTab
            // 
            this.mnuTab.Controls.Add(this.tabStock);
            this.mnuTab.Controls.Add(this.tabSearchManage);
            this.mnuTab.Controls.Add(this.tabRegistration);
            this.mnuTab.Controls.Add(this.tabViewSummary);
            this.mnuTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTab.Location = new System.Drawing.Point(19, 10);
            this.mnuTab.Name = "mnuTab";
            this.mnuTab.SelectedIndex = 0;
            this.mnuTab.Size = new System.Drawing.Size(1035, 519);
            this.mnuTab.TabIndex = 1;
            this.mnuTab.SelectedIndexChanged += new System.EventHandler(this.mnuTab_SelectedIndexChanged);
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.dgCurrentStock);
            this.tabStock.Location = new System.Drawing.Point(4, 24);
            this.tabStock.Name = "tabStock";
            this.tabStock.Size = new System.Drawing.Size(1027, 491);
            this.tabStock.TabIndex = 2;
            this.tabStock.Text = "Products";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // dgCurrentStock
            // 
            this.dgCurrentStock.Location = new System.Drawing.Point(0, 0);
            this.dgCurrentStock.Name = "dgCurrentStock";
            this.dgCurrentStock.Size = new System.Drawing.Size(1024, 488);
            this.dgCurrentStock.TabIndex = 0;
            this.dgCurrentStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCurrentStock_CellFormatting);
            // 
            // tabSearchManage
            // 
            this.tabSearchManage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabSearchManage.Controls.Add(this.btnSDelete);
            this.tabSearchManage.Controls.Add(this.btnSUpdate);
            this.tabSearchManage.Controls.Add(this.txtSHSNNumber);
            this.tabSearchManage.Controls.Add(this.txtSPacking);
            this.tabSearchManage.Controls.Add(this.txtSPurchaseRate);
            this.tabSearchManage.Controls.Add(this.txtSSellingRate);
            this.tabSearchManage.Controls.Add(this.txtSReminderAfter);
            this.tabSearchManage.Controls.Add(this.lbl2NoOfChildren);
            this.tabSearchManage.Controls.Add(this.lbl2HealthStatus);
            this.tabSearchManage.Controls.Add(this.lbl2MaritalStatus);
            this.tabSearchManage.Controls.Add(this.lbl2Salary);
            this.tabSearchManage.Controls.Add(this.txtSQuantity);
            this.tabSearchManage.Controls.Add(this.lbl2Occupation);
            this.tabSearchManage.Controls.Add(this.txtSProductName);
            this.tabSearchManage.Controls.Add(this.lbl2DateOfBirth);
            this.tabSearchManage.Controls.Add(this.lbl2Name);
            this.tabSearchManage.Controls.Add(this.btnToShop);
            this.tabSearchManage.Controls.Add(this.btnToGodown);
            this.tabSearchManage.Controls.Add(this.tabControl1);
            this.tabSearchManage.Controls.Add(this.dgvSearchGridview);
            this.tabSearchManage.Location = new System.Drawing.Point(4, 24);
            this.tabSearchManage.Name = "tabSearchManage";
            this.tabSearchManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchManage.Size = new System.Drawing.Size(1027, 491);
            this.tabSearchManage.TabIndex = 1;
            this.tabSearchManage.Text = "Search / Update Stocks";
            // 
            // btnSDelete
            // 
            this.btnSDelete.Location = new System.Drawing.Point(874, 404);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(103, 27);
            this.btnSDelete.TabIndex = 47;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.UseVisualStyleBackColor = true;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // btnSUpdate
            // 
            this.btnSUpdate.Location = new System.Drawing.Point(746, 404);
            this.btnSUpdate.Name = "btnSUpdate";
            this.btnSUpdate.Size = new System.Drawing.Size(97, 27);
            this.btnSUpdate.TabIndex = 46;
            this.btnSUpdate.Text = "Update";
            this.btnSUpdate.UseVisualStyleBackColor = true;
            this.btnSUpdate.Click += new System.EventHandler(this.btnSUpdate_Click);
            // 
            // txtSHSNNumber
            // 
            this.txtSHSNNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSHSNNumber.Location = new System.Drawing.Point(843, 167);
            this.txtSHSNNumber.MaxLength = 12;
            this.txtSHSNNumber.Name = "txtSHSNNumber";
            this.txtSHSNNumber.Size = new System.Drawing.Size(152, 21);
            this.txtSHSNNumber.TabIndex = 44;
            // 
            // txtSPacking
            // 
            this.txtSPacking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPacking.Location = new System.Drawing.Point(843, 206);
            this.txtSPacking.MaxLength = 12;
            this.txtSPacking.Name = "txtSPacking";
            this.txtSPacking.Size = new System.Drawing.Size(152, 21);
            this.txtSPacking.TabIndex = 43;
            // 
            // txtSPurchaseRate
            // 
            this.txtSPurchaseRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPurchaseRate.Location = new System.Drawing.Point(843, 275);
            this.txtSPurchaseRate.MaxLength = 12;
            this.txtSPurchaseRate.Name = "txtSPurchaseRate";
            this.txtSPurchaseRate.Size = new System.Drawing.Size(152, 21);
            this.txtSPurchaseRate.TabIndex = 42;
            // 
            // txtSSellingRate
            // 
            this.txtSSellingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSellingRate.Location = new System.Drawing.Point(843, 316);
            this.txtSSellingRate.MaxLength = 12;
            this.txtSSellingRate.Name = "txtSSellingRate";
            this.txtSSellingRate.Size = new System.Drawing.Size(152, 21);
            this.txtSSellingRate.TabIndex = 41;
            // 
            // txtSReminderAfter
            // 
            this.txtSReminderAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSReminderAfter.Location = new System.Drawing.Point(846, 349);
            this.txtSReminderAfter.MaxLength = 12;
            this.txtSReminderAfter.Name = "txtSReminderAfter";
            this.txtSReminderAfter.Size = new System.Drawing.Size(149, 21);
            this.txtSReminderAfter.TabIndex = 40;
            // 
            // lbl2NoOfChildren
            // 
            this.lbl2NoOfChildren.AutoSize = true;
            this.lbl2NoOfChildren.Location = new System.Drawing.Point(726, 355);
            this.lbl2NoOfChildren.Name = "lbl2NoOfChildren";
            this.lbl2NoOfChildren.Size = new System.Drawing.Size(89, 15);
            this.lbl2NoOfChildren.TabIndex = 37;
            this.lbl2NoOfChildren.Text = "Reminder After";
            // 
            // lbl2HealthStatus
            // 
            this.lbl2HealthStatus.AutoSize = true;
            this.lbl2HealthStatus.Location = new System.Drawing.Point(725, 315);
            this.lbl2HealthStatus.Name = "lbl2HealthStatus";
            this.lbl2HealthStatus.Size = new System.Drawing.Size(74, 15);
            this.lbl2HealthStatus.TabIndex = 36;
            this.lbl2HealthStatus.Text = "Selling Rate";
            // 
            // lbl2MaritalStatus
            // 
            this.lbl2MaritalStatus.AutoSize = true;
            this.lbl2MaritalStatus.Location = new System.Drawing.Point(725, 275);
            this.lbl2MaritalStatus.Name = "lbl2MaritalStatus";
            this.lbl2MaritalStatus.Size = new System.Drawing.Size(88, 15);
            this.lbl2MaritalStatus.TabIndex = 33;
            this.lbl2MaritalStatus.Text = "Purchase Rate";
            // 
            // lbl2Salary
            // 
            this.lbl2Salary.AutoSize = true;
            this.lbl2Salary.Location = new System.Drawing.Point(727, 241);
            this.lbl2Salary.Name = "lbl2Salary";
            this.lbl2Salary.Size = new System.Drawing.Size(51, 15);
            this.lbl2Salary.TabIndex = 28;
            this.lbl2Salary.Text = "Quantity";
            // 
            // txtSQuantity
            // 
            this.txtSQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQuantity.Location = new System.Drawing.Point(843, 238);
            this.txtSQuantity.MaxLength = 12;
            this.txtSQuantity.Name = "txtSQuantity";
            this.txtSQuantity.Size = new System.Drawing.Size(152, 21);
            this.txtSQuantity.TabIndex = 26;
            // 
            // lbl2Occupation
            // 
            this.lbl2Occupation.AutoSize = true;
            this.lbl2Occupation.Location = new System.Drawing.Point(726, 206);
            this.lbl2Occupation.Name = "lbl2Occupation";
            this.lbl2Occupation.Size = new System.Drawing.Size(51, 15);
            this.lbl2Occupation.TabIndex = 27;
            this.lbl2Occupation.Text = "Packing";
            // 
            // txtSProductName
            // 
            this.txtSProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSProductName.Location = new System.Drawing.Point(843, 138);
            this.txtSProductName.Name = "txtSProductName";
            this.txtSProductName.Size = new System.Drawing.Size(152, 21);
            this.txtSProductName.TabIndex = 23;
            // 
            // lbl2DateOfBirth
            // 
            this.lbl2DateOfBirth.AutoSize = true;
            this.lbl2DateOfBirth.Location = new System.Drawing.Point(726, 173);
            this.lbl2DateOfBirth.Name = "lbl2DateOfBirth";
            this.lbl2DateOfBirth.Size = new System.Drawing.Size(39, 15);
            this.lbl2DateOfBirth.TabIndex = 22;
            this.lbl2DateOfBirth.Text = "H.S.N";
            // 
            // lbl2Name
            // 
            this.lbl2Name.AutoSize = true;
            this.lbl2Name.Location = new System.Drawing.Point(723, 140);
            this.lbl2Name.Name = "lbl2Name";
            this.lbl2Name.Size = new System.Drawing.Size(86, 15);
            this.lbl2Name.TabIndex = 21;
            this.lbl2Name.Text = "Product Name";
            // 
            // btnToShop
            // 
            this.btnToShop.Location = new System.Drawing.Point(746, 449);
            this.btnToShop.Name = "btnToShop";
            this.btnToShop.Size = new System.Drawing.Size(97, 27);
            this.btnToShop.TabIndex = 10;
            this.btnToShop.Text = "Send To Shop";
            this.btnToShop.UseVisualStyleBackColor = true;
            this.btnToShop.Click += new System.EventHandler(this.btnToShop_Click);
            // 
            // btnToGodown
            // 
            this.btnToGodown.Location = new System.Drawing.Point(874, 449);
            this.btnToGodown.Name = "btnToGodown";
            this.btnToGodown.Size = new System.Drawing.Size(103, 27);
            this.btnToGodown.TabIndex = 9;
            this.btnToGodown.Text = "Add To Godown";
            this.btnToGodown.UseVisualStyleBackColor = true;
            this.btnToGodown.Click += new System.EventHandler(this.btnToGodown_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 105);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtSProductNameSearch);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dtSToDate);
            this.tabPage3.Controls.Add(this.dtSFromDate);
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1006, 77);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSProductNameSearch
            // 
            this.txtSProductNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSProductNameSearch.Location = new System.Drawing.Point(352, 35);
            this.txtSProductNameSearch.MaxLength = 12;
            this.txtSProductNameSearch.Name = "txtSProductNameSearch";
            this.txtSProductNameSearch.Size = new System.Drawing.Size(114, 21);
            this.txtSProductNameSearch.TabIndex = 27;
            this.txtSProductNameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSProductNameSearch_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Product Name";
            // 
            // dtSToDate
            // 
            this.dtSToDate.Location = new System.Drawing.Point(193, 35);
            this.dtSToDate.Name = "dtSToDate";
            this.dtSToDate.Size = new System.Drawing.Size(143, 21);
            this.dtSToDate.TabIndex = 11;
            // 
            // dtSFromDate
            // 
            this.dtSFromDate.Location = new System.Drawing.Point(32, 35);
            this.dtSFromDate.Name = "dtSFromDate";
            this.dtSFromDate.Size = new System.Drawing.Size(143, 21);
            this.dtSFromDate.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(859, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(744, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "To Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "From Date";
            // 
            // dgvSearchGridview
            // 
            this.dgvSearchGridview.Location = new System.Drawing.Point(6, 118);
            this.dgvSearchGridview.Name = "dgvSearchGridview";
            this.dgvSearchGridview.Size = new System.Drawing.Size(711, 358);
            this.dgvSearchGridview.TabIndex = 45;
            this.dgvSearchGridview.SelectionChanged += new System.EventHandler(this.dgvSearchGridview_SelectionChanged);
            this.dgvSearchGridview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSearchGridview_MouseDoubleClick);
            // 
            // tabRegistration
            // 
            this.tabRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabRegistration.Controls.Add(this.tabControl2);
            this.tabRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistration.Location = new System.Drawing.Point(4, 24);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(1027, 491);
            this.tabRegistration.TabIndex = 0;
            this.tabRegistration.Text = "Add Product";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRegister);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(8, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(998, 267);
            this.tabControl2.TabIndex = 5;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.txtHsnNumber);
            this.tabRegister.Controls.Add(this.txtPacking);
            this.tabRegister.Controls.Add(this.txtReminderAfter);
            this.tabRegister.Controls.Add(this.txtProductDescription);
            this.tabRegister.Controls.Add(this.txtPurchaseRate);
            this.tabRegister.Controls.Add(this.txtDealerName);
            this.tabRegister.Controls.Add(this.txtSellingRate);
            this.tabRegister.Controls.Add(this.label7);
            this.tabRegister.Controls.Add(this.label6);
            this.tabRegister.Controls.Add(this.lblHealthStatusRequired);
            this.tabRegister.Controls.Add(this.lblMaritalStatusRequired);
            this.tabRegister.Controls.Add(this.lblOccupationRequired);
            this.tabRegister.Controls.Add(this.lblDOBRequired);
            this.tabRegister.Controls.Add(this.lblNameRequired);
            this.tabRegister.Controls.Add(this.lblNoOfChildren);
            this.tabRegister.Controls.Add(this.lblSalary);
            this.tabRegister.Controls.Add(this.txtQuantity);
            this.tabRegister.Controls.Add(this.lblHealthStatus);
            this.tabRegister.Controls.Add(this.btnAdd);
            this.tabRegister.Controls.Add(this.lblMaritalStatus);
            this.tabRegister.Controls.Add(this.lblOccupation);
            this.tabRegister.Controls.Add(this.txtProductName);
            this.tabRegister.Controls.Add(this.lblDateOfBirth);
            this.tabRegister.Controls.Add(this.lblName);
            this.tabRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegister.Location = new System.Drawing.Point(4, 25);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(990, 238);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Product";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // txtHsnNumber
            // 
            this.txtHsnNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHsnNumber.Location = new System.Drawing.Point(174, 49);
            this.txtHsnNumber.MaxLength = 12;
            this.txtHsnNumber.Name = "txtHsnNumber";
            this.txtHsnNumber.Size = new System.Drawing.Size(152, 21);
            this.txtHsnNumber.TabIndex = 32;
            // 
            // txtPacking
            // 
            this.txtPacking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacking.Location = new System.Drawing.Point(174, 84);
            this.txtPacking.MaxLength = 12;
            this.txtPacking.Name = "txtPacking";
            this.txtPacking.Size = new System.Drawing.Size(152, 21);
            this.txtPacking.TabIndex = 31;
            // 
            // txtReminderAfter
            // 
            this.txtReminderAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReminderAfter.Location = new System.Drawing.Point(538, 122);
            this.txtReminderAfter.MaxLength = 5;
            this.txtReminderAfter.Name = "txtReminderAfter";
            this.txtReminderAfter.Size = new System.Drawing.Size(152, 21);
            this.txtReminderAfter.TabIndex = 30;
            this.txtReminderAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReminderAfter_KeyPress);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductDescription.Location = new System.Drawing.Point(538, 13);
            this.txtProductDescription.MaxLength = 50;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(152, 21);
            this.txtProductDescription.TabIndex = 29;
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchaseRate.Location = new System.Drawing.Point(538, 49);
            this.txtPurchaseRate.MaxLength = 12;
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(152, 21);
            this.txtPurchaseRate.TabIndex = 28;
            this.txtPurchaseRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseRate_KeyPress);
            // 
            // txtDealerName
            // 
            this.txtDealerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDealerName.Location = new System.Drawing.Point(538, 158);
            this.txtDealerName.MaxLength = 40;
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(152, 21);
            this.txtDealerName.TabIndex = 27;
            // 
            // txtSellingRate
            // 
            this.txtSellingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSellingRate.Location = new System.Drawing.Point(538, 84);
            this.txtSellingRate.MaxLength = 12;
            this.txtSellingRate.Name = "txtSellingRate";
            this.txtSellingRate.Size = new System.Drawing.Size(152, 21);
            this.txtSellingRate.TabIndex = 26;
            this.txtSellingRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellingRate_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Dealer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Reminder After";
            // 
            // lblHealthStatusRequired
            // 
            this.lblHealthStatusRequired.AutoSize = true;
            this.lblHealthStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblHealthStatusRequired.Location = new System.Drawing.Point(696, 54);
            this.lblHealthStatusRequired.Name = "lblHealthStatusRequired";
            this.lblHealthStatusRequired.Size = new System.Drawing.Size(21, 25);
            this.lblHealthStatusRequired.TabIndex = 22;
            this.lblHealthStatusRequired.Text = "*";
            // 
            // lblMaritalStatusRequired
            // 
            this.lblMaritalStatusRequired.AutoSize = true;
            this.lblMaritalStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblMaritalStatusRequired.Location = new System.Drawing.Point(696, 92);
            this.lblMaritalStatusRequired.Name = "lblMaritalStatusRequired";
            this.lblMaritalStatusRequired.Size = new System.Drawing.Size(21, 25);
            this.lblMaritalStatusRequired.TabIndex = 21;
            this.lblMaritalStatusRequired.Text = "*";
            // 
            // lblOccupationRequired
            // 
            this.lblOccupationRequired.AutoSize = true;
            this.lblOccupationRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupationRequired.ForeColor = System.Drawing.Color.Red;
            this.lblOccupationRequired.Location = new System.Drawing.Point(332, 126);
            this.lblOccupationRequired.Name = "lblOccupationRequired";
            this.lblOccupationRequired.Size = new System.Drawing.Size(21, 25);
            this.lblOccupationRequired.TabIndex = 20;
            this.lblOccupationRequired.Text = "*";
            // 
            // lblDOBRequired
            // 
            this.lblDOBRequired.AutoSize = true;
            this.lblDOBRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDOBRequired.Location = new System.Drawing.Point(696, 126);
            this.lblDOBRequired.Name = "lblDOBRequired";
            this.lblDOBRequired.Size = new System.Drawing.Size(21, 25);
            this.lblDOBRequired.TabIndex = 19;
            this.lblDOBRequired.Text = "*";
            // 
            // lblNameRequired
            // 
            this.lblNameRequired.AutoSize = true;
            this.lblNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblNameRequired.Location = new System.Drawing.Point(332, 16);
            this.lblNameRequired.Name = "lblNameRequired";
            this.lblNameRequired.Size = new System.Drawing.Size(21, 25);
            this.lblNameRequired.TabIndex = 18;
            this.lblNameRequired.Text = "*";
            // 
            // lblNoOfChildren
            // 
            this.lblNoOfChildren.AutoSize = true;
            this.lblNoOfChildren.Location = new System.Drawing.Point(391, 90);
            this.lblNoOfChildren.Name = "lblNoOfChildren";
            this.lblNoOfChildren.Size = new System.Drawing.Size(74, 15);
            this.lblNoOfChildren.TabIndex = 17;
            this.lblNoOfChildren.Text = "Selling Rate";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(17, 126);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(51, 15);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(174, 122);
            this.txtQuantity.MaxLength = 12;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(152, 21);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblHealthStatus
            // 
            this.lblHealthStatus.AutoSize = true;
            this.lblHealthStatus.Location = new System.Drawing.Point(392, 51);
            this.lblHealthStatus.Name = "lblHealthStatus";
            this.lblHealthStatus.Size = new System.Drawing.Size(88, 15);
            this.lblHealthStatus.TabIndex = 12;
            this.lblHealthStatus.Text = "Purchase Rate";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(383, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 28);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(392, 16);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(114, 15);
            this.lblMaritalStatus.TabIndex = 6;
            this.lblMaritalStatus.Text = "Product Description";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(16, 86);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(51, 15);
            this.lblOccupation.TabIndex = 5;
            this.lblOccupation.Text = "Packing";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(174, 13);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(152, 21);
            this.txtProductName.TabIndex = 2;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(16, 51);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(39, 15);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "H.S.N";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product Name";
            // 
            // tabViewSummary
            // 
            this.tabViewSummary.Controls.Add(this.lblHeader);
            this.tabViewSummary.Controls.Add(this.panel1);
            this.tabViewSummary.Location = new System.Drawing.Point(4, 24);
            this.tabViewSummary.Name = "tabViewSummary";
            this.tabViewSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewSummary.Size = new System.Drawing.Size(1027, 491);
            this.tabViewSummary.TabIndex = 3;
            this.tabViewSummary.Text = "View Reminders";
            this.tabViewSummary.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(383, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(243, 15);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Stocks Need to Be Updated Soon!!!!!!";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvReminderGrid);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 439);
            this.panel1.TabIndex = 0;
            // 
            // dgvReminderGrid
            // 
            this.dgvReminderGrid.Location = new System.Drawing.Point(3, 3);
            this.dgvReminderGrid.Name = "dgvReminderGrid";
            this.dgvReminderGrid.Size = new System.Drawing.Size(1008, 434);
            this.dgvReminderGrid.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 541);
            this.Controls.Add(this.mnuTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Hardware";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mnuTab.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentStock)).EndInit();
            this.tabSearchManage.ResumeLayout(false);
            this.tabSearchManage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGridview)).EndInit();
            this.tabRegistration.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.tabViewSummary.ResumeLayout(false);
            this.tabViewSummary.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminderGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mnuTab;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Label lblHealthStatusRequired;
        private System.Windows.Forms.Label lblMaritalStatusRequired;
        private System.Windows.Forms.Label lblOccupationRequired;
        private System.Windows.Forms.Label lblDOBRequired;
        private System.Windows.Forms.Label lblNameRequired;
        private System.Windows.Forms.Label lblNoOfChildren;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblHealthStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabSearchManage;
        private System.Windows.Forms.Label lbl2NoOfChildren;
        private System.Windows.Forms.Label lbl2HealthStatus;
        private System.Windows.Forms.Label lbl2MaritalStatus;
        private System.Windows.Forms.Label lbl2Salary;
        private System.Windows.Forms.TextBox txtSQuantity;
        private System.Windows.Forms.Label lbl2Occupation;
        private System.Windows.Forms.TextBox txtSProductName;
        private System.Windows.Forms.Label lbl2DateOfBirth;
        private System.Windows.Forms.Label lbl2Name;
        private System.Windows.Forms.Button btnToShop;
        private System.Windows.Forms.Button btnToGodown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSearchGridview;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.DataGridView dgCurrentStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHsnNumber;
        private System.Windows.Forms.TextBox txtPacking;
        private System.Windows.Forms.TextBox txtReminderAfter;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtPurchaseRate;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.TextBox txtSellingRate;
        private System.Windows.Forms.DateTimePicker dtSFromDate;
        private System.Windows.Forms.DateTimePicker dtSToDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSProductNameSearch;
        private System.Windows.Forms.TextBox txtSHSNNumber;
        private System.Windows.Forms.TextBox txtSPacking;
        private System.Windows.Forms.TextBox txtSPurchaseRate;
        private System.Windows.Forms.TextBox txtSSellingRate;
        private System.Windows.Forms.TextBox txtSReminderAfter;
        private System.Windows.Forms.TabPage tabViewSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvReminderGrid;
        private System.Windows.Forms.Button btnSUpdate;
        private System.Windows.Forms.Button btnSDelete;
    }
}

