using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.ScholarshipServiceRef;

namespace eSAR.Settings.ManageScholarship
{
    public partial class frmScholarshipDetails : Telerik.WinControls.UI.RadForm
    {
        public string Op { get; set; }
        public Scholarship SelectedScholarship { get; set; }

        List<ScholarshipDiscount> scholarshipDiscount;
        List<ScholarshipDiscount> scholarshipDiscount1 = new List<ScholarshipDiscount>();

        public frmScholarshipDetails()
        {
            InitializeComponent();
        }

        private void btnSaveScholarship_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            ScholarshipServiceClient scholarshipService = new ScholarshipServiceClient();
            Boolean ret = false;
            string message = String.Empty;
            Scholarship scholarship = new Scholarship()
            {
                ScholarshipCode = txtScholarshipCode.Text.ToString(),
                Privilege = txtPrivilege.Text.ToString(),
                Condition = txtCondition.Text.ToString(),
                Description = txtDescription.Text.ToString()
                //StopRightHere
            };
        }
    }
}
