using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.ServiceModel;
using eSAR.SchoolYearServiceRef;

namespace eSAR.Settings.ManageSY
{
    public partial class frmSYList : Telerik.WinControls.UI.RadForm
    {
        private SchoolYear SYSelected;
        private List<SchoolYear> SYList;
        public frmSYList()
        {
            InitializeComponent();
        }

        public void LoadSY()
        {
            SchoolYearServiceClient syService = new SchoolYearServiceClient();
            string message = String.Empty;
            try
            {
                var sy = syService.GetAllSY();
                SYList = new List<SchoolYear>(sy);
                gvSY.DataSource = SYList;
                gvSY.Refresh();

                if (gvSY.RowCount != 0)
                    gvSY.Rows[0].IsSelected = true;
            }
            catch (Exception ex)
            {
                message = "Error Loading List of School Years";
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmSYList_Load(object sender, EventArgs e)
        {
            LoadSY();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SYSelected != null)
            {
                SchoolYearServiceClient syService = new SchoolYearServiceClient();
                string message = String.Empty;

                if (!syService.DeleteSY(SYSelected.SY, ref message))
                {
                    message = "Deletion of School Year Failed";
                }
                else
                {
                    MessageBox.Show("Deleted succesfully!");
                }
            }
        }

        private void gvSY_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = gvSY.CurrentRow.Index;


            if (selectedIndex >= 0)
            {
                string tCode = gvSY.Rows[selectedIndex].Cells["SY"].Value.ToString();
                List<SchoolYear> item = new List<SchoolYear>();
                item = SYList.FindAll(x => x.SY.ToString() == tCode);

                SYSelected = new SchoolYear();
                SYSelected = (SchoolYear)item[0];

            }
        }

        private void txtSY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSY.Text))
            {                
                return;
            }
            else
            {
               
                    if (SYList.Exists(x => x.SY.Substring(0, 4) == txtSY.Text))
                    {
                        MessageBox.Show("SY already exists");
                        txtSY.Text = "";
                        txtSY.Focus();
                    }
                    else
                        SaveSY();
                
            }
        }

        private void SaveSY()
        {
            try
            {
                Boolean ret = false;
                string message = String.Empty;

                int SYto = 0;
                SYto = int.Parse(txtSY.Text) + 1;
                                
                SchoolYearServiceClient syService = new SchoolYearServiceClient();
                SchoolYear schoolyear = new SchoolYear()
                {
                    SY = txtSY.Text + "-" + SYto.ToString(),
                    CurrentSY = false
                };

              
                    ret = syService.CreateSY(ref schoolyear, ref message);


                MessageBox.Show("Saved Successfully!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
