using eSAR.TimeslotServiceRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eSAR.Settings.ManageTimeSlots
{
    public partial class frmTimeSlotDetails : Telerik.WinControls.UI.RadForm
    {
        public string Op { get; set; }
        public Timeslot SelectedTimeslot { get; set; }
        public List<Timeslot> timeslotList { get; set; }


        public frmTimeSlotDetails()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTimeSlotDetails_Load(object sender, EventArgs e)
        {
            string[] stringArray = new string[7];

            if (Op.Equals("edit"))
            {
                txtTimeslotCode.Enabled = false;
                txtTimeslotCode.Text = SelectedTimeslot.TimeSlotCode;
                tPStart.Value = DateTime.ParseExact(SelectedTimeslot.TimeStart, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
                tpEnd.Value = DateTime.ParseExact(SelectedTimeslot.TimeEnd, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);

                stringArray = SelectedTimeslot.Days.Split(',');

                chkSunday.Checked = SelectedTimeslot.Days.Contains("Su");
                chkMonday.Checked = SelectedTimeslot.Days.Contains("M");
                chkTuesday.Checked = SelectedTimeslot.Days.Contains("Tu");
                chkWednesday.Checked = SelectedTimeslot.Days.Contains("W");
                chkThursday.Checked = SelectedTimeslot.Days.Contains("Th");
                chkFriday.Checked = SelectedTimeslot.Days.Contains("F");
                chkSaturday.Checked = SelectedTimeslot.Days.Contains("S");

          
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtTimeslotCode.Text))
            {
                MessageBox.Show("Please fill up Timeslot Code");
                return;
            }
            else
            {
                if (tPStart.Value < tpEnd.Value)
                    SaveUser();
                else
                {
                    MessageBox.Show("Time End should be greater than Time Start");
                    tPStart.Focus();
                }
            }
        }

        private void SaveUser()
        {
            try
            {
                Boolean ret = false;
                string message = String.Empty;

                List<String> list = new List<String>();
                if (chkSunday.Checked == true) list.Add("Su");
                if (chkMonday.Checked == true) list.Add("M");
                if (chkTuesday.Checked == true) list.Add("Tu");
                if (chkWednesday.Checked == true) list.Add("W");
                if (chkThursday.Checked == true) list.Add("Th");
                if (chkFriday.Checked == true) list.Add("F");
                if (chkSaturday.Checked == true) list.Add("S");

                string szDays = string.Empty;
                szDays = string.Join(",", list.ToArray());

                DateTime? dtTimeStart = DateTime.Now;
                DateTime? dtTimeEnd = DateTime.Now;

                dtTimeStart = tPStart.Value;
                dtTimeEnd = tpEnd.Value;

                TimeslotServiceClient tService = new TimeslotServiceClient();
                Timeslot timeslot = new Timeslot()
                {
                    TimeSlotCode = txtTimeslotCode.Text,
                    TimeStart = dtTimeStart.Value.ToString("hh:mm tt"),
                    TimeEnd = dtTimeEnd.Value.ToString("hh:mm tt"),
                    Days = szDays
                };

                if (Op.Equals("edit"))
                {
                    timeslot.TimeSlotCode = SelectedTimeslot.TimeSlotCode;
                    ret = tService.UpdateTimeslot(ref timeslot, ref message);
                }
                else
                    ret = tService.CreateTimeslot(ref timeslot, ref message);


                MessageBox.Show("Saved Successfully!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void txtTimeslotCode_Leave(object sender, EventArgs e)
        {
            if (!Op.Equals("edit"))
            {
                if (timeslotList.Exists(x => x.TimeSlotCode == txtTimeslotCode.Text))
                {
                    MessageBox.Show("Code already exists");
                    txtTimeslotCode.Text = "";
                    txtTimeslotCode.Focus();
                }
            }
        }
    }
}

