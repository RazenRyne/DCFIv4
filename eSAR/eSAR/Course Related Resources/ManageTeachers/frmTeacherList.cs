using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.ServiceModel;
using eSAR.TeacherServiceRef;

namespace eSAR.Course_Related_Resources.ManageTeachers
{
    public partial class frmTeacherList : Telerik.WinControls.UI.RadForm
    {
        private Teacher teacherSelected;
        private List<Teacher> teacherList;

        public frmTeacherList()
        {
            InitializeComponent();
        }


        public void LoadTeachers()
        {
            TeacherServiceClient teacherService = new TeacherServiceClient();
            string message = String.Empty;
            try
            {
                var teachers = teacherService.GetAllTeachers();
                teacherList = new List<Teacher>(teachers);
                gvTeacher.DataSource = teachers;
                gvTeacher.Refresh();

                if (gvTeacher.RowCount != 0)
                    gvTeacher.Rows[0].IsSelected = true;
            }
            catch (Exception ex)
            {
                message = "Error Loading Teacher List";
                MessageBox.Show(ex.ToString());
            }

        }

        public void LoadFilteredTeachers()
        {
            TeacherServiceClient teacherService = new TeacherServiceClient();
            string message = String.Empty;
            try
            {
                var teachers = teacherService.GetFilteredTeachers(cmbSearch.Text, txtSearch.Text);
                teacherList = new List<Teacher>(teachers);
                gvTeacher.DataSource = teachers;
                gvTeacher.Refresh();

                if (gvTeacher.RowCount != 0)
                    gvTeacher.Rows[0].IsSelected = true;
            }
            catch (Exception ex)
            {
                message = "Error Loading Teacher List";
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmTeacherList_Activated(object sender, EventArgs e)
        {
            //LoadTeachers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTeacherDetails fmTeacherDetails = new frmTeacherDetails();
            fmTeacherDetails.Op = "new";
            fmTeacherDetails.Show();
        }

        private void frmTeacherList_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvTeacher.CurrentRow.Index >= 0)
            {
                frmTeacherDetails fmTeacherDetails = new frmTeacherDetails();
                fmTeacherDetails.Op = "edit";
                fmTeacherDetails.SelectedTeacher = teacherSelected;
                fmTeacherDetails.Show();
            }
        }

        private void gvTeacher_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = gvTeacher.CurrentRow.Index;


            if (selectedIndex >= 0)
            {
                string tID = gvTeacher.Rows[selectedIndex].Cells["TeacherId"].Value.ToString();
                List<Teacher> item = new List<Teacher>();
                item = teacherList.FindAll(x => x.TeacherId.ToString() == tID);

                teacherSelected = new Teacher();
                teacherSelected = (Teacher)item[0];

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (teacherSelected != null)
            {
                TeacherServiceClient teacherService = new TeacherServiceClient();
                string message = String.Empty;

                if (!teacherService.DeactivateTeacher(teacherSelected.TeacherId, ref message))
                {
                    message = "Deactivation of User Failed";
                }
                else
                {
                    MessageBox.Show("Deactivated succesfully!");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                if (txtSearch.Text.Length >= 3)
                {
                    gvTeacher.DataSource = null;
                    LoadFilteredTeachers();
                }
                else
                {
                    MessageBox.Show("Enter at least 3 charachters");
                    return;
                }
            }
        }
    }
}
