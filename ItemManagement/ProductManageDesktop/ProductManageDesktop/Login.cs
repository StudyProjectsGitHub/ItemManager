﻿using ProductManageDesktop.Properties;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.InitializeResourceString();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }
        /// <summary>
        /// Initializes resource strings
        /// </summary>
        private void InitializeResourceString()
        {
            lblUserName.Text = Resources.Login_Username_Label_Text;
            lblPassword.Text = Resources.Login_Password_Label_Text;
            btnLogin.Text = Resources.Login_Login_Button_Text;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == Settings.Default.Username && txtPassword.Text.Trim() == Settings.Default.Password)
            {
                var frmManage = new MainForm();
                frmManage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    Resources.Login_Validation_Message,
                    Resources.Login_Validation_Message_Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
