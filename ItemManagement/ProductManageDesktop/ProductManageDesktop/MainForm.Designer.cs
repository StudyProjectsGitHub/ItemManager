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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuTab = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.dgCurrentStock = new System.Windows.Forms.DataGridView();
            this.tabSearchManage = new System.Windows.Forms.TabPage();
            this.txtSSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDealer = new System.Windows.Forms.TextBox();
            this.lblDealer = new System.Windows.Forms.Label();
            this.txtSBrandName = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
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
            this.txtSizeSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrandSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSProductNameSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearchGridview = new System.Windows.Forms.DataGridView();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHsnNumber = new System.Windows.Forms.TextBox();
            this.txtPacking = new System.Windows.Forms.TextBox();
            this.txtReminderAfter = new System.Windows.Forms.TextBox();
            this.txtProductBrand = new System.Windows.Forms.TextBox();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtSellingRate = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
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
            this.mnuTab.Location = new System.Drawing.Point(17, 10);
            this.mnuTab.Name = "mnuTab";
            this.mnuTab.SelectedIndex = 0;
            this.mnuTab.Size = new System.Drawing.Size(1035, 580);
            this.mnuTab.TabIndex = 1;
            this.mnuTab.SelectedIndexChanged += new System.EventHandler(this.mnuTab_SelectedIndexChanged);
            // 
            // tabStock
            // 
            this.tabStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabStock.Controls.Add(this.dgCurrentStock);
            this.tabStock.Location = new System.Drawing.Point(4, 24);
            this.tabStock.Name = "tabStock";
            this.tabStock.Size = new System.Drawing.Size(1027, 552);
            this.tabStock.TabIndex = 2;
            this.tabStock.Text = "Products";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // dgCurrentStock
            // 
            this.dgCurrentStock.Location = new System.Drawing.Point(0, 0);
            this.dgCurrentStock.Name = "dgCurrentStock";
            this.dgCurrentStock.Size = new System.Drawing.Size(1024, 549);
            this.dgCurrentStock.TabIndex = 0;
            this.dgCurrentStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCurrentStock_CellFormatting);
            // 
            // tabSearchManage
            // 
            this.tabSearchManage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabSearchManage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabSearchManage.Controls.Add(this.txtSSize);
            this.tabSearchManage.Controls.Add(this.label1);
            this.tabSearchManage.Controls.Add(this.txtSDealer);
            this.tabSearchManage.Controls.Add(this.lblDealer);
            this.tabSearchManage.Controls.Add(this.txtSBrandName);
            this.tabSearchManage.Controls.Add(this.lblBrand);
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
            this.tabSearchManage.Size = new System.Drawing.Size(1027, 552);
            this.tabSearchManage.TabIndex = 1;
            this.tabSearchManage.Text = "Search / Update Stocks";
            // 
            // txtSSize
            // 
            this.txtSSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSize.Location = new System.Drawing.Point(852, 445);
            this.txtSSize.MaxLength = 12;
            this.txtSSize.Name = "txtSSize";
            this.txtSSize.Size = new System.Drawing.Size(149, 21);
            this.txtSSize.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Size";
            // 
            // txtSDealer
            // 
            this.txtSDealer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDealer.Location = new System.Drawing.Point(852, 409);
            this.txtSDealer.MaxLength = 12;
            this.txtSDealer.Name = "txtSDealer";
            this.txtSDealer.Size = new System.Drawing.Size(149, 21);
            this.txtSDealer.TabIndex = 48;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(732, 415);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(44, 15);
            this.lblDealer.TabIndex = 49;
            this.lblDealer.Text = "Dealer";
            // 
            // txtSBrandName
            // 
            this.txtSBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSBrandName.Location = new System.Drawing.Point(852, 372);
            this.txtSBrandName.MaxLength = 12;
            this.txtSBrandName.Name = "txtSBrandName";
            this.txtSBrandName.Size = new System.Drawing.Size(149, 21);
            this.txtSBrandName.TabIndex = 46;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(732, 378);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(77, 15);
            this.lblBrand.TabIndex = 47;
            this.lblBrand.Text = "Brand Name";
            // 
            // btnSDelete
            // 
            this.btnSDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSDelete.Image")));
            this.btnSDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSDelete.Location = new System.Drawing.Point(892, 481);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(103, 27);
            this.btnSDelete.TabIndex = 13;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.UseVisualStyleBackColor = true;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // btnSUpdate
            // 
            this.btnSUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnSUpdate.Image")));
            this.btnSUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSUpdate.Location = new System.Drawing.Point(765, 481);
            this.btnSUpdate.Name = "btnSUpdate";
            this.btnSUpdate.Size = new System.Drawing.Size(97, 27);
            this.btnSUpdate.TabIndex = 12;
            this.btnSUpdate.Text = "Update";
            this.btnSUpdate.UseVisualStyleBackColor = true;
            this.btnSUpdate.Click += new System.EventHandler(this.btnSUpdate_Click);
            // 
            // txtSHSNNumber
            // 
            this.txtSHSNNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSHSNNumber.Location = new System.Drawing.Point(848, 153);
            this.txtSHSNNumber.MaxLength = 12;
            this.txtSHSNNumber.Name = "txtSHSNNumber";
            this.txtSHSNNumber.Size = new System.Drawing.Size(152, 21);
            this.txtSHSNNumber.TabIndex = 6;
            // 
            // txtSPacking
            // 
            this.txtSPacking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPacking.Location = new System.Drawing.Point(849, 186);
            this.txtSPacking.MaxLength = 12;
            this.txtSPacking.Name = "txtSPacking";
            this.txtSPacking.Size = new System.Drawing.Size(152, 21);
            this.txtSPacking.TabIndex = 7;
            // 
            // txtSPurchaseRate
            // 
            this.txtSPurchaseRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPurchaseRate.Location = new System.Drawing.Point(848, 261);
            this.txtSPurchaseRate.MaxLength = 12;
            this.txtSPurchaseRate.Name = "txtSPurchaseRate";
            this.txtSPurchaseRate.Size = new System.Drawing.Size(152, 21);
            this.txtSPurchaseRate.TabIndex = 9;
            this.txtSPurchaseRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSPurchaseRate_KeyPress);
            // 
            // txtSSellingRate
            // 
            this.txtSSellingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSellingRate.Location = new System.Drawing.Point(848, 299);
            this.txtSSellingRate.MaxLength = 12;
            this.txtSSellingRate.Name = "txtSSellingRate";
            this.txtSSellingRate.Size = new System.Drawing.Size(152, 21);
            this.txtSSellingRate.TabIndex = 10;
            this.txtSSellingRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSSellingRate_KeyPress);
            // 
            // txtSReminderAfter
            // 
            this.txtSReminderAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSReminderAfter.Location = new System.Drawing.Point(851, 335);
            this.txtSReminderAfter.MaxLength = 12;
            this.txtSReminderAfter.Name = "txtSReminderAfter";
            this.txtSReminderAfter.Size = new System.Drawing.Size(149, 21);
            this.txtSReminderAfter.TabIndex = 11;
            this.txtSReminderAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSReminderAfter_KeyPress);
            // 
            // lbl2NoOfChildren
            // 
            this.lbl2NoOfChildren.AutoSize = true;
            this.lbl2NoOfChildren.Location = new System.Drawing.Point(731, 341);
            this.lbl2NoOfChildren.Name = "lbl2NoOfChildren";
            this.lbl2NoOfChildren.Size = new System.Drawing.Size(89, 15);
            this.lbl2NoOfChildren.TabIndex = 37;
            this.lbl2NoOfChildren.Text = "Reminder After";
            // 
            // lbl2HealthStatus
            // 
            this.lbl2HealthStatus.AutoSize = true;
            this.lbl2HealthStatus.Location = new System.Drawing.Point(730, 301);
            this.lbl2HealthStatus.Name = "lbl2HealthStatus";
            this.lbl2HealthStatus.Size = new System.Drawing.Size(74, 15);
            this.lbl2HealthStatus.TabIndex = 36;
            this.lbl2HealthStatus.Text = "Selling Rate";
            // 
            // lbl2MaritalStatus
            // 
            this.lbl2MaritalStatus.AutoSize = true;
            this.lbl2MaritalStatus.Location = new System.Drawing.Point(730, 261);
            this.lbl2MaritalStatus.Name = "lbl2MaritalStatus";
            this.lbl2MaritalStatus.Size = new System.Drawing.Size(88, 15);
            this.lbl2MaritalStatus.TabIndex = 33;
            this.lbl2MaritalStatus.Text = "Purchase Rate";
            // 
            // lbl2Salary
            // 
            this.lbl2Salary.AutoSize = true;
            this.lbl2Salary.Location = new System.Drawing.Point(732, 227);
            this.lbl2Salary.Name = "lbl2Salary";
            this.lbl2Salary.Size = new System.Drawing.Size(51, 15);
            this.lbl2Salary.TabIndex = 28;
            this.lbl2Salary.Text = "Quantity";
            // 
            // txtSQuantity
            // 
            this.txtSQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQuantity.Location = new System.Drawing.Point(848, 224);
            this.txtSQuantity.MaxLength = 12;
            this.txtSQuantity.Name = "txtSQuantity";
            this.txtSQuantity.Size = new System.Drawing.Size(152, 21);
            this.txtSQuantity.TabIndex = 8;
            this.txtSQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSQuantity_KeyPress);
            // 
            // lbl2Occupation
            // 
            this.lbl2Occupation.AutoSize = true;
            this.lbl2Occupation.Location = new System.Drawing.Point(731, 192);
            this.lbl2Occupation.Name = "lbl2Occupation";
            this.lbl2Occupation.Size = new System.Drawing.Size(51, 15);
            this.lbl2Occupation.TabIndex = 27;
            this.lbl2Occupation.Text = "Packing";
            // 
            // txtSProductName
            // 
            this.txtSProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSProductName.Location = new System.Drawing.Point(848, 124);
            this.txtSProductName.Name = "txtSProductName";
            this.txtSProductName.Size = new System.Drawing.Size(152, 21);
            this.txtSProductName.TabIndex = 5;
            // 
            // lbl2DateOfBirth
            // 
            this.lbl2DateOfBirth.AutoSize = true;
            this.lbl2DateOfBirth.Location = new System.Drawing.Point(731, 159);
            this.lbl2DateOfBirth.Name = "lbl2DateOfBirth";
            this.lbl2DateOfBirth.Size = new System.Drawing.Size(39, 15);
            this.lbl2DateOfBirth.TabIndex = 22;
            this.lbl2DateOfBirth.Text = "H.S.N";
            // 
            // lbl2Name
            // 
            this.lbl2Name.AutoSize = true;
            this.lbl2Name.Location = new System.Drawing.Point(728, 126);
            this.lbl2Name.Name = "lbl2Name";
            this.lbl2Name.Size = new System.Drawing.Size(86, 15);
            this.lbl2Name.TabIndex = 21;
            this.lbl2Name.Text = "Product Name";
            // 
            // btnToShop
            // 
            this.btnToShop.Location = new System.Drawing.Point(768, 518);
            this.btnToShop.Name = "btnToShop";
            this.btnToShop.Size = new System.Drawing.Size(97, 27);
            this.btnToShop.TabIndex = 14;
            this.btnToShop.Text = "Send To Shop";
            this.btnToShop.UseVisualStyleBackColor = true;
            this.btnToShop.Click += new System.EventHandler(this.btnToShop_Click);
            // 
            // btnToGodown
            // 
            this.btnToGodown.Location = new System.Drawing.Point(892, 519);
            this.btnToGodown.Name = "btnToGodown";
            this.btnToGodown.Size = new System.Drawing.Size(103, 27);
            this.btnToGodown.TabIndex = 15;
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
            this.tabPage3.Controls.Add(this.txtSizeSearch);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtBrandSearch);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtSProductNameSearch);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1006, 77);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSizeSearch
            // 
            this.txtSizeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSizeSearch.Location = new System.Drawing.Point(461, 36);
            this.txtSizeSearch.MaxLength = 12;
            this.txtSizeSearch.Name = "txtSizeSearch";
            this.txtSizeSearch.Size = new System.Drawing.Size(181, 21);
            this.txtSizeSearch.TabIndex = 15;
            this.txtSizeSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSizeSearch_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Size";
            // 
            // txtBrandSearch
            // 
            this.txtBrandSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandSearch.Location = new System.Drawing.Point(245, 35);
            this.txtBrandSearch.MaxLength = 12;
            this.txtBrandSearch.Name = "txtBrandSearch";
            this.txtBrandSearch.Size = new System.Drawing.Size(181, 21);
            this.txtBrandSearch.TabIndex = 13;
            this.txtBrandSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBrandSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Brand Name";
            // 
            // txtSProductNameSearch
            // 
            this.txtSProductNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSProductNameSearch.Location = new System.Drawing.Point(17, 35);
            this.txtSProductNameSearch.MaxLength = 12;
            this.txtSProductNameSearch.Name = "txtSProductNameSearch";
            this.txtSProductNameSearch.Size = new System.Drawing.Size(181, 21);
            this.txtSProductNameSearch.TabIndex = 1;
            this.txtSProductNameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSProductNameSearch_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Product Name";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(859, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(744, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearchGridview
            // 
            this.dgvSearchGridview.Location = new System.Drawing.Point(6, 118);
            this.dgvSearchGridview.Name = "dgvSearchGridview";
            this.dgvSearchGridview.Size = new System.Drawing.Size(711, 428);
            this.dgvSearchGridview.TabIndex = 45;
            this.dgvSearchGridview.TabStop = false;
            this.dgvSearchGridview.SelectionChanged += new System.EventHandler(this.dgvSearchGridview_SelectionChanged);
            this.dgvSearchGridview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSearchGridview_MouseDoubleClick);
            // 
            // tabRegistration
            // 
            this.tabRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabRegistration.Controls.Add(this.tabControl2);
            this.tabRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistration.Location = new System.Drawing.Point(4, 24);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(1027, 552);
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
            this.tabControl2.Size = new System.Drawing.Size(971, 266);
            this.tabControl2.TabIndex = 5;
            // 
            // tabRegister
            // 
            this.tabRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabRegister.Controls.Add(this.txtDealerName);
            this.tabRegister.Controls.Add(this.label4);
            this.tabRegister.Controls.Add(this.txtHsnNumber);
            this.tabRegister.Controls.Add(this.txtPacking);
            this.tabRegister.Controls.Add(this.txtReminderAfter);
            this.tabRegister.Controls.Add(this.txtProductBrand);
            this.tabRegister.Controls.Add(this.txtPurchaseRate);
            this.tabRegister.Controls.Add(this.txtSize);
            this.tabRegister.Controls.Add(this.txtSellingRate);
            this.tabRegister.Controls.Add(this.lblSize);
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
            this.tabRegister.Size = new System.Drawing.Size(963, 237);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Product";
            // 
            // txtDealerName
            // 
            this.txtDealerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDealerName.Location = new System.Drawing.Point(538, 160);
            this.txtDealerName.MaxLength = 25;
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(152, 21);
            this.txtDealerName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Dealer Name";
            // 
            // txtHsnNumber
            // 
            this.txtHsnNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHsnNumber.Location = new System.Drawing.Point(174, 49);
            this.txtHsnNumber.MaxLength = 10;
            this.txtHsnNumber.Name = "txtHsnNumber";
            this.txtHsnNumber.Size = new System.Drawing.Size(152, 21);
            this.txtHsnNumber.TabIndex = 3;
            // 
            // txtPacking
            // 
            this.txtPacking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacking.Location = new System.Drawing.Point(174, 84);
            this.txtPacking.MaxLength = 12;
            this.txtPacking.Name = "txtPacking";
            this.txtPacking.Size = new System.Drawing.Size(152, 21);
            this.txtPacking.TabIndex = 5;
            // 
            // txtReminderAfter
            // 
            this.txtReminderAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReminderAfter.Location = new System.Drawing.Point(538, 122);
            this.txtReminderAfter.MaxLength = 9;
            this.txtReminderAfter.Name = "txtReminderAfter";
            this.txtReminderAfter.Size = new System.Drawing.Size(152, 21);
            this.txtReminderAfter.TabIndex = 8;
            this.txtReminderAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReminderAfter_KeyPress);
            // 
            // txtProductBrand
            // 
            this.txtProductBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductBrand.Location = new System.Drawing.Point(538, 13);
            this.txtProductBrand.MaxLength = 50;
            this.txtProductBrand.Name = "txtProductBrand";
            this.txtProductBrand.Size = new System.Drawing.Size(152, 21);
            this.txtProductBrand.TabIndex = 2;
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchaseRate.Location = new System.Drawing.Point(538, 49);
            this.txtPurchaseRate.MaxLength = 10;
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(152, 21);
            this.txtPurchaseRate.TabIndex = 4;
            this.txtPurchaseRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseRate_KeyPress);
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSize.Location = new System.Drawing.Point(172, 158);
            this.txtSize.MaxLength = 50;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(152, 21);
            this.txtSize.TabIndex = 9;
            // 
            // txtSellingRate
            // 
            this.txtSellingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSellingRate.Location = new System.Drawing.Point(538, 84);
            this.txtSellingRate.MaxLength = 10;
            this.txtSellingRate.Name = "txtSellingRate";
            this.txtSellingRate.Size = new System.Drawing.Size(152, 21);
            this.txtSellingRate.TabIndex = 6;
            this.txtSellingRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellingRate_KeyPress);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(16, 158);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(31, 15);
            this.lblSize.TabIndex = 25;
            this.lblSize.Text = "Size";
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
            this.txtQuantity.MaxLength = 10;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(152, 21);
            this.txtQuantity.TabIndex = 7;
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
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(383, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 28);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(392, 16);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(85, 15);
            this.lblMaritalStatus.TabIndex = 6;
            this.lblMaritalStatus.Text = "Product Brand";
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
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(152, 21);
            this.txtProductName.TabIndex = 1;
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
            this.tabViewSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabViewSummary.Controls.Add(this.lblHeader);
            this.tabViewSummary.Controls.Add(this.panel1);
            this.tabViewSummary.Location = new System.Drawing.Point(4, 24);
            this.tabViewSummary.Name = "tabViewSummary";
            this.tabViewSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewSummary.Size = new System.Drawing.Size(1027, 552);
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
            this.lblHeader.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvReminderGrid);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 525);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // dgvReminderGrid
            // 
            this.dgvReminderGrid.Location = new System.Drawing.Point(3, 3);
            this.dgvReminderGrid.Name = "dgvReminderGrid";
            this.dgvReminderGrid.ReadOnly = true;
            this.dgvReminderGrid.Size = new System.Drawing.Size(1008, 515);
            this.dgvReminderGrid.TabIndex = 1;
            this.dgvReminderGrid.TabStop = false;
            this.dgvReminderGrid.UseWaitCursor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 602);
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
        private System.Windows.Forms.DataGridView dgvSearchGridview;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.DataGridView dgCurrentStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtHsnNumber;
        private System.Windows.Forms.TextBox txtPacking;
        private System.Windows.Forms.TextBox txtReminderAfter;
        private System.Windows.Forms.TextBox txtProductBrand;
        private System.Windows.Forms.TextBox txtPurchaseRate;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtSellingRate;
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
        private System.Windows.Forms.TextBox txtSDealer;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.TextBox txtSBrandName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtSSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSizeSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrandSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label label4;
    }
}

