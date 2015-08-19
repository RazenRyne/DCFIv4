using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.StudentServiceRef;

namespace eSAR.Admission_and_Registration
{
    public partial class frmStudentList : Telerik.WinControls.UI.RadForm
    {
        private Student studentSelected;
        private List<Student> studentList;
        public frmStudentList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStudentDetails fmStudentDetails = new frmStudentDetails();
            fmStudentDetails.Op = "new";
            fmStudentDetails.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvStudent.CurrentRow.Index >= 0)
            {
                frmStudentDetails fmStudentDetails = new frmStudentDetails();
                fmStudentDetails.Op = "edit";
                fmStudentDetails.SelectedStudent = studentSelected;
                fmStudentDetails.Show();
            }
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        public void LoadStudents()
        {
            StudentServiceClient studentService = new StudentServiceClient();
            string message = String.Empty;
            try
            {
                var students = studentService.GetAllStudents();
                studentList = new List<Student>(students);
                gvStudent.DataSource = students;
                gvStudent.Refresh();

                if (gvStudent.RowCount != 0)
                    gvStudent.Rows[0].IsSelected = true;
            }
            catch (Exception ex)
            {
                message = "Error Loading Student List";
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmStudentList_Activated(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void gvStudent_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = gvStudent.CurrentRow.Index;


            if (selectedIndex >= 0)
            {
                string sID = gvStudent.Rows[selectedIndex].Cells["StudentId"].Value.ToString();
                List<Student> item = new List<Student>();
                item = studentList.FindAll(x => x.StudentId.ToString() == sID);

                studentSelected = new Student();
                studentSelected = (Student)item[0];

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentSelected != null)
            {
                StudentServiceClient studentService = new StudentServiceClient();
                string message = String.Empty;

                if (!studentService.DismissStudent(studentSelected.StudentId, ref message))
                {
                    message = "Dismissal of Student Failed";
                }
                else
                {
                    MessageBox.Show("Dismissed succesfully!");
                }
            }
        }
    }
}
