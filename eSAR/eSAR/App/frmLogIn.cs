using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.UserServiceRef;
using System.Security.Cryptography;
using eSAR.Utility_Classes;

namespace eSAR.App
{
    public partial class frmLogIn : Telerik.WinControls.UI.RadForm
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            UserServiceClient userService = new UserServiceClient();
            string message = String.Empty;


            if (userService.AuthenticateUser(txtUsername.Text, txtPassword.Text, ref message))
            {
                User u = new User();
                u=userService.GetUser(txtUsername.Text);
                GlobalClass g = new GlobalClass();
                g.GetUser(u);
            
                Close();
            }
                else MessageBox.Show(this, message, "Login Failed");
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
