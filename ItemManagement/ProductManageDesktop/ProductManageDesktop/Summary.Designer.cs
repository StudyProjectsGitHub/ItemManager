namespace ProductManageDesktop
{
    partial class Summary
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
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSentTo = new System.Windows.Forms.TextBox();
            this.txtSummaryQuantity = new System.Windows.Forms.TextBox();
            this.lbl2NoOfChildren = new System.Windows.Forms.Label();
            this.lbl2HealthStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSummary
            // 
            this.dgvSummary.Location = new System.Drawing.Point(7, 12);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.Size = new System.Drawing.Size(796, 364);
            this.dgvSummary.TabIndex = 46;
            this.dgvSummary.SelectionChanged += new System.EventHandler(this.dgvSummary_SelectionChanged);
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(151, 450);
            this.txtNote.MaxLength = 150;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(652, 20);
            this.txtNote.TabIndex = 6;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(15, 454);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(76, 13);
            this.lblBrand.TabIndex = 59;
            this.lblBrand.Text = "Updation Note";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(258, 493);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 27);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSentTo
            // 
            this.txtSentTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSentTo.Location = new System.Drawing.Point(147, 410);
            this.txtSentTo.MaxLength = 12;
            this.txtSentTo.Name = "txtSentTo";
            this.txtSentTo.ReadOnly = true;
            this.txtSentTo.Size = new System.Drawing.Size(152, 20);
            this.txtSentTo.TabIndex = 2;
            // 
            // txtSummaryQuantity
            // 
            this.txtSummaryQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryQuantity.Location = new System.Drawing.Point(469, 409);
            this.txtSummaryQuantity.MaxLength = 12;
            this.txtSummaryQuantity.Name = "txtSummaryQuantity";
            this.txtSummaryQuantity.Size = new System.Drawing.Size(149, 20);
            this.txtSummaryQuantity.TabIndex = 4;
            this.txtSummaryQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSummaryQuantity_KeyPress);
            // 
            // lbl2NoOfChildren
            // 
            this.lbl2NoOfChildren.AutoSize = true;
            this.lbl2NoOfChildren.Location = new System.Drawing.Point(358, 412);
            this.lbl2NoOfChildren.Name = "lbl2NoOfChildren";
            this.lbl2NoOfChildren.Size = new System.Drawing.Size(86, 13);
            this.lbl2NoOfChildren.TabIndex = 57;
            this.lbl2NoOfChildren.Text = "Change Quantity";
            // 
            // lbl2HealthStatus
            // 
            this.lbl2HealthStatus.AutoSize = true;
            this.lbl2HealthStatus.Location = new System.Drawing.Point(12, 410);
            this.lbl2HealthStatus.Name = "lbl2HealthStatus";
            this.lbl2HealthStatus.Size = new System.Drawing.Size(45, 13);
            this.lbl2HealthStatus.TabIndex = 56;
            this.lbl2HealthStatus.Text = "Sent To";
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 535);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSentTo);
            this.Controls.Add(this.txtSummaryQuantity);
            this.Controls.Add(this.lbl2NoOfChildren);
            this.Controls.Add(this.lbl2HealthStatus);
            this.Controls.Add(this.dgvSummary);
            this.Name = "Summary";
            this.Text = "Summary";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSentTo;
        private System.Windows.Forms.TextBox txtSummaryQuantity;
        private System.Windows.Forms.Label lbl2NoOfChildren;
        private System.Windows.Forms.Label lbl2HealthStatus;
    }
}