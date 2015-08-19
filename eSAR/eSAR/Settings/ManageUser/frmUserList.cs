using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.UserServiceRef;
using System.ServiceModel;

namespace eSAR.Settings.ManageUser
{
    public partial class frmUserList : Telerik.WinControls.UI.RadForm
    {
        private User userSelected;
        private List<User> userList;

        public frmUserList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserDetails fmUserDetails = new frmUserDetails();
            fmUserDetails.Op = "add";
            fmUserDetails.userList = this.userList;
            fmUserDetails.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvUser.CurrentRow.Index >= 0)
            {
                frmUserDetails fmUserDetails = new frmUserDetails();
                fmUserDetails.Op = "edit";
                fmUserDetails.SelectedUser = userSelected;
                fmUserDetails.Show();
            }
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void frmUserList_Activated(object sender, EventArgs e)
        {
            LoadUsers();
        }

        public void LoadUsers() {
            UserServiceClient userService = new UserServiceClient();
            string message = String.Empty;
            try
            {
                var users = userService.GetAllUsers();
                userList = new List<User>(users);
                gvUser.DataSource = users;
                gvUser.Refresh();

                if (gvUser.RowCount != 0)
                    gvUser.Rows[0].IsSelected = true;
            }
            catch (Exception ex)
            {
                message = "Error Loading UserList";
                MessageBox.Show(ex.ToString());
            }

        }

        private void gvUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userSelected != null)
            {
                UserServiceClient userService = new UserServiceClient();
                string message = String.Empty;

                if (!userService.DeleteUser(userSelected.UserId, ref message))
                {
                    message = "Deletion of User Failed";
                }
                else
                {
                    MessageBox.Show("Deleted succesfully!");
                }
            }
        }

        private void gvUser_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex =  gvUser.CurrentRow.Index;
            

            if (selectedIndex >= 0)
            {
                string uID = gvUser.Rows[selectedIndex].Cells["UserId"].Value.ToString();
                List<User> item = new List<User>();
                item = userList.FindAll(x => x.UserId.ToString() == uID);

                userSelected = new User();
                userSelected = (User)item[0];                
           
            }
        }
    }
}
