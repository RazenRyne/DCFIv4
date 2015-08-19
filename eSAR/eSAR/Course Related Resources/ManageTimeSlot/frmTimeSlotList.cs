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
    public partial class frmTimeSlotList : Telerik.WinControls.UI.RadForm
    {
        private Timeslot timeslotSelected;
        private List<Timeslot> timeslotList;
        public frmTimeSlotList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTimeSlotDetails fmTimeslotDetails = new frmTimeSlotDetails();
            fmTimeslotDetails.timeslotList = timeslotList;
            fmTimeslotDetails.Op = "new";
            fmTimeslotDetails.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmTimeSlotDetails fmTimeslotDetails = new frmTimeSlotDetails();
            fmTimeslotDetails.timeslotList = timeslotList;
            fmTimeslotDetails.SelectedTimeslot = timeslotSelected;
            fmTimeslotDetails.Op = "edit";
            fmTimeslotDetails.Show();
        }

        public void LoadTimeslots()
        {
            TimeslotServiceClient tService = new TimeslotServiceClient();
            string message = String.Empty;
            try
            {
                var timeslot = tService.GetAllTimeslots();
                timeslotList = new List<Timeslot>(timeslot);
                gvTimeSlot.DataSource = timeslotList;
                gvTimeSlot.Refresh();

                if (gvTimeSlot.RowCount != 0)
                    gvTimeSlot.Rows[0].IsSelected = true;
            }
            catch (Exception ex)
            {
                message = "Error Loading List of Timeslots";
                MessageBox.Show(ex.ToString());
            }

        }

        private void gvTimeSlot_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = gvTimeSlot.CurrentRow.Index;


            if (selectedIndex >= 0)
            {
                string tCode = gvTimeSlot.Rows[selectedIndex].Cells["TimeslotCode"].Value.ToString();
                List<Timeslot> item = new List<Timeslot>();
                item = timeslotList.FindAll(x => x.TimeSlotCode.ToString() == tCode);

                timeslotSelected = new Timeslot();
                timeslotSelected = (Timeslot)item[0];

            }
        }

        private void frmTimeSlotList_Load(object sender, EventArgs e)
        {
            LoadTimeslots();
        }

        private void frmTimeSlotList_Activated(object sender, EventArgs e)
        {
            LoadTimeslots();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (timeslotSelected != null)
            {
                TimeslotServiceClient tService = new TimeslotServiceClient();
                string message = String.Empty;

                if (!tService.DeleteTimeslot(timeslotSelected.TimeSlotCode, ref message))
                {
                    message = "Deletion of Timeslot Failed";
                }
                else
                {
                    MessageBox.Show("Deleted succesfully!");
                }
            }
        }
    }
}

