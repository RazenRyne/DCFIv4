using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using eSAR.UserServiceRef;
using eSAR.Utility_Classes;
using eSAR.Settings.ManageBuilding;
using eSAR.Settings.ManageTimeSlot;
using eSAR.Admission_and_Registration;
using eSAR.Course_Related_Resources.ManageTeachers;
using eSAR.Course_Related_Resources.ManageSubject;
using eSAR.Settings.ManageUser;
using eSAR.Settings.ManageSY;
using eSAR.Settings.ManageScholarship;
using eSAR.Settings.ManageCurriculum;

namespace eSAR.App
{
    public partial class FrmMain : Telerik.WinControls.UI.RadRibbonForm
    {
        public User LoggedInUser { get; set; }
        DocumentWindow UserDockWindow;
        DocumentWindow StudentDockWindow;
        DocumentWindow TeacherDockWindow;
        DocumentWindow BuildingDockWindow;
        DocumentWindow LearningAreaDockWindow;
        DocumentWindow TimeslotDockWindow;
        DocumentWindow SYDockWindow;
        DocumentWindow ScholarshipDockWindow;
        DocumentWindow CurriculumDockWindow;

        frmStudentList fmStudentList;
        frmUserList fmUserMain;
        frmTeacherList fmTeacherList;
        frmBuildingList fmBuildingList;
        frmLearningAreas fmLearningAreas;
        frmTimeSlotList fmTimeSlotList;
        frmSYList fmSYList;
        frmScholarshipList fmScholarshipList;
        frmManageCurriculum fmManageCurriculum;

        GlobalClass g = new GlobalClass();

        public FrmMain()
        {
            if (g.UserLoggedIn == null)
            {
                frmLogIn f = new frmLogIn();
                f.ShowDialog();
            }
            InitializeComponent();
            
        }

        //User Settings clicked
        private void btnUser_Click(object sender, EventArgs e)
        {
           
            if (UserDockWindow == null)
            {
                UserDockWindow = new DocumentWindow();
                UserDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmUserMain = new frmUserList();
                fmUserMain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmUserMain.TopLevel = false;
                fmUserMain.Dock = DockStyle.Fill;
                UserDockWindow.Text =  fmUserMain.Text;
                UserDockWindow.Controls.Add(fmUserMain);
                this.radDock1.AddDocument(UserDockWindow);
                fmUserMain.Show();
            }
            else
            {
                UserDockWindow.Show();
            }
            this.radDock1.ActiveWindow = UserDockWindow;
        }

        
      //Student Clicked
        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (StudentDockWindow == null)
            {
                StudentDockWindow = new DocumentWindow();
                StudentDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmStudentList = new frmStudentList();
                fmStudentList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmStudentList.TopLevel = false;
                fmStudentList.Dock = DockStyle.Fill;
                StudentDockWindow.Text = fmStudentList.Text;
                StudentDockWindow.Controls.Add(fmStudentList);
                this.radDock1.AddDocument(StudentDockWindow);
                fmStudentList.Show();
            }
            else
            {
                StudentDockWindow.Show();
            }
            this.radDock1.ActiveWindow = StudentDockWindow;
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            string szActive = string.Empty;
            if (radDock1.ActiveWindow != null)
            {
                szActive = radDock1.ActiveWindow.Text;

                switch (szActive)
                {
                    case "User List":
                        fmUserMain.LoadUsers();
                        break;
                    case "Student List":
                        fmStudentList.LoadStudents();
                        break;
                    case "Teacher List":
                        fmTeacherList.LoadTeachers();
                        break;
                    case "Building List":
                        fmBuildingList.LoadBuildings();
                        break;
                    case "Time Slots":
                        fmTimeSlotList.LoadTimeslots();
                        break;
                    case "Manage School Year":
                        //fmTimeSlotList.LoadTimeslots();
                        break;
                    case "Curriculum":
                        fmManageCurriculum.LoadCurriculums();
                        break;
                    default:
                        break;
                }
                
       
            }
        }

        private void radDock1_DockWindowClosing(object sender, DockWindowCancelEventArgs e)
        {
            string szActive = radDock1.ActiveWindow.Text;

            switch (szActive)
            {

                case "User List":
                    UserDockWindow = null;
                    break;
                case "Student List":
                    StudentDockWindow = null;
                    break;
                case "Teacher List":
                    TeacherDockWindow = null;
                    break;
                case "Building List":
                    BuildingDockWindow = null;
                    break;
                case "Learning Areas List":
                    LearningAreaDockWindow = null;
                    break;
                case "Time Slots":
                    TimeslotDockWindow = null;
                    break;
                case "Manage School Year":
                    SYDockWindow = null;
                    break;
                case "Curriculum":
                    CurriculumDockWindow = null;
                    break;
                default:
                    break;
            }
            //if (szActive.Equals("User List"))
            //    UserDockWindow = null;
            //if (szActive.Equals("Student List"))
            //    StudentDockWindow = null;
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            if (TeacherDockWindow == null)
            {
                TeacherDockWindow = new DocumentWindow();
                TeacherDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmTeacherList = new frmTeacherList();
                fmTeacherList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmTeacherList.TopLevel = false;
                fmTeacherList.Dock = DockStyle.Fill;
                TeacherDockWindow.Text = fmTeacherList.Text;
                TeacherDockWindow.Controls.Add(fmTeacherList);
                this.radDock1.AddDocument(TeacherDockWindow);
                fmTeacherList.Show();
            }
            else
            {
                TeacherDockWindow.Show();
            }
            this.radDock1.ActiveWindow = TeacherDockWindow;
        }

        private void btnBuildings_Click(object sender, EventArgs e)
        {

            if (BuildingDockWindow == null)
            {
                BuildingDockWindow = new DocumentWindow();
                BuildingDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmBuildingList = new frmBuildingList();
                fmBuildingList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmBuildingList.TopLevel = false;
                fmBuildingList.Dock = DockStyle.Fill;
                BuildingDockWindow.Text = fmBuildingList.Text;
                BuildingDockWindow.Controls.Add(fmBuildingList);
                this.radDock1.AddDocument(BuildingDockWindow);
                fmBuildingList.Show();
            }
            else
            {
                BuildingDockWindow.Show();
            }
            this.radDock1.ActiveWindow = BuildingDockWindow;
        }

        private void btnLearningArea_Click(object sender, EventArgs e)
        {
            if (LearningAreaDockWindow == null)
            {
                LearningAreaDockWindow = new DocumentWindow();
                LearningAreaDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmLearningAreas = new frmLearningAreas();
                fmLearningAreas.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmLearningAreas.TopLevel = false;
                fmLearningAreas.Dock = DockStyle.Fill;
                LearningAreaDockWindow.Text = fmLearningAreas.Text;
                LearningAreaDockWindow.Controls.Add(fmLearningAreas);
                this.radDock1.AddDocument(LearningAreaDockWindow);
                fmLearningAreas.Show();
            }
            else
            {
                LearningAreaDockWindow.Show();
            }
            this.radDock1.ActiveWindow = LearningAreaDockWindow;
        }

        private void btnTimeSlot_Click(object sender, EventArgs e)
        {
            if (TimeslotDockWindow == null)
            {
                TimeslotDockWindow = new DocumentWindow();
                TimeslotDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmTimeSlotList = new frmTimeSlotList();
                fmTimeSlotList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmTimeSlotList.TopLevel = false;
                fmTimeSlotList.Dock = DockStyle.Fill;
                TimeslotDockWindow.Text = fmTimeSlotList.Text;
                TimeslotDockWindow.Controls.Add(fmTimeSlotList);
                this.radDock1.AddDocument(TimeslotDockWindow);
                fmTimeSlotList.Show();
            }
            else
            {
                TimeslotDockWindow.Show();
            }
            this.radDock1.ActiveWindow = TimeslotDockWindow;
        }

        private void btnManageSY_Click(object sender, EventArgs e)
        {
            if (SYDockWindow == null)
            {
                SYDockWindow = new DocumentWindow();
                SYDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmSYList = new frmSYList();
                fmSYList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmSYList.TopLevel = false;
                fmSYList.Dock = DockStyle.Fill;
                SYDockWindow.Text = fmSYList.Text;
                SYDockWindow.Controls.Add(fmSYList);
                this.radDock1.AddDocument(SYDockWindow);
                fmSYList.Show();
            }
            else
            {
                SYDockWindow.Show();
            }
            this.radDock1.ActiveWindow = SYDockWindow;
        }

        private void btnScholarship_Click(object sender, EventArgs e)
        {
            if (ScholarshipDockWindow == null)
            {
                ScholarshipDockWindow = new DocumentWindow();
                ScholarshipDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmScholarshipList = new frmScholarshipList();
                fmScholarshipList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmScholarshipList.TopLevel = false;
                fmScholarshipList.Dock = DockStyle.Fill;
                ScholarshipDockWindow.Text = fmScholarshipList.Text;
                ScholarshipDockWindow.Controls.Add(fmScholarshipList);
                this.radDock1.AddDocument(ScholarshipDockWindow);
                fmScholarshipList.Show();
            }
            else
            {
                ScholarshipDockWindow.Show();
            }
            this.radDock1.ActiveWindow = ScholarshipDockWindow;
        }

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            if (CurriculumDockWindow == null)
            {
                CurriculumDockWindow = new DocumentWindow();
                CurriculumDockWindow.CloseAction = DockWindowCloseAction.Close;
                fmManageCurriculum = new frmManageCurriculum();
                fmManageCurriculum.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmManageCurriculum.TopLevel = false;
                fmManageCurriculum.Dock = DockStyle.Fill;
                CurriculumDockWindow.Text = fmManageCurriculum.Text;
                CurriculumDockWindow.Controls.Add(fmManageCurriculum);
                this.radDock1.AddDocument(CurriculumDockWindow);
                fmManageCurriculum.Show();
            }
            else
            {
                CurriculumDockWindow.Show();
            }
            this.radDock1.ActiveWindow = CurriculumDockWindow;
        }
    }
}

