using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.BuildingServiceRef;

namespace eSAR.Settings.ManageBuilding
{
    public partial class frmBuildingDetails : Telerik.WinControls.UI.RadForm
    {
        public string Op { get; set; }
        public Building SelectedBuilding { get; set; }

        List<Room> rooms;
        List<Room> rooms1 = new List<Room>();

        public frmBuildingDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            BuildingServiceClient buildingService = new BuildingServiceClient();
            Boolean ret = false;
            string message = String.Empty;
            Building building = new Building()
            {
                BuildingCode = txtBuildingCode.Text.ToString(),
                Description = txtDescription.Text.ToString(),
                BuildingName = txtName.Text.ToString(),
                Rooms = rooms.ToArray()
                
            };
            if (Op.Equals("edit"))
                ret =buildingService.UpdateBuilding(ref building, ref message);
            else
                ret = buildingService.CreateBuilding(ref building, ref message);

            if (ret)
                MessageBox.Show("Saved Successfully");
            else
                MessageBox.Show("Error Saving");

            Close();
        }

        private void frmBuildingDetails_Load(object sender, EventArgs e)
        {
            if (Op.Equals("edit"))
            {
                SetFields();
                SetRoomGrid();
            }

            if (Op.Equals("new"))
            {
                BuildingServiceClient buildingService = new BuildingServiceClient();
                BindRoomGrid();
            }
        }

        private void SetFields() {
            txtBuildingCode.Text = SelectedBuilding.BuildingCode;
            txtDescription.Text = SelectedBuilding.Description;
            txtName.Text = SelectedBuilding.BuildingName;
        }
        private void BindRoomGrid()
        {
            rooms = new List<Room>();
            gvRooms.DataSource = rooms;
           

        }

        private void SetRoomGrid()
        {
            rooms = new List<Room>(SelectedBuilding.Rooms);
            this.gvRooms.DataSource = rooms;
        }

        private void gvRooms_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            int index = this.gvRooms.RowCount - 1;
            rooms[index].BuildingCode = this.txtBuildingCode.Text;
            rooms[index].RoomCode = this.txtBuildingCode.Text + this.rooms[index].RoomNumber.ToString();
            rooms[index].Deactivated = false;
            gvRooms.DataSource = rooms1;
            gvRooms.DataSource = rooms;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
