using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.CurriculumServiceRef;
using eSAR.GradeLevelServiceRef;
using Telerik.WinControls.UI;
using System.Linq;

namespace eSAR.Settings.ManageCurriculum
{
    public partial class frmCurriculumDetails : Telerik.WinControls.UI.RadForm
    {
        public string Op { get; set; }
        public Curriculum SelectedCurriculum { get; set; }
        public List<eSAR.GradeLevelServiceRef.GradeLevel> gradeLevels;

        public List<CurriculumSubject> currSub = new List<CurriculumSubject>();
        public List<CurriculumSubject> currSub1 = new List<CurriculumSubject>();
        public List<CurriculumSubject> currSub2 = new List<CurriculumSubject>();

        GradeLevelServiceClient gs = new GradeLevelServiceClient();
        CurriculumServiceClient cs = new CurriculumServiceClient();
        CurriculumSubject addedCurrSub;

        List<SubjectsDetails> subDetails;

        public frmCurriculumDetails()
        {
            InitializeComponent();
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            Boolean ret;
            string message = String.Empty;
            Curriculum c = new Curriculum();
            if (chkCurrent.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                c.CurrentCurr = true;
            }

            c.CurriculumCode = txtCurrCode.Text;
            c.CurriculumSubjects = currSub1.ToArray();
            c.Description = txtDescription.Text;
            if (Op.Equals("edit"))
                ret = cs.UpdateCurriculum(ref c, ref message);
            else
                ret = cs.CreateCurriculum(ref c, ref message);

            if (ret)
                MessageBox.Show(this, message, "Add Successful");
            else
                MessageBox.Show(this, message, "Add Failed");
        }

        private void InitializeGradeLevel()
        {
          
            gradeLevels = new List<eSAR.GradeLevelServiceRef.GradeLevel>(gs.GetAllGradeLevels());
            cmbGradeLevel.DataSource = gradeLevels;
            cmbGradeLevel.ValueMember = "GradeLev";
            cmbGradeLevel.DisplayMember = "Description";
        }

        private void frmCurriculumDetails_Load(object sender, EventArgs e)
        {
            InitializeGradeLevel();
            if (Op.Equals("edit"))
            {
                SetFields();
            }
          
            subDetails = new List<SubjectsDetails>();
            currSub = new List<CurriculumSubject>(cs.GetAllSubjectDetails());
            foreach (CurriculumSubject cs in currSub)
            {
                SubjectsDetails sd = new SubjectsDetails();
                sd.Academic = cs.Academic;
                sd.CurrDescription = cs.CurrDescription;
                sd.CurrentCurr = cs.CurrentCurr;
                sd.CurriculumCode = cs.CurriculumCode;
                sd.CurrSubCode = cs.CurrSubCode;
                sd.Deactivated = cs.Deactivated;
                sd.GradeLevel = cs.GradeLevel;
                sd.LearningAreaCode = cs.LearningAreaCode;
                sd.RatePerUnit = cs.RatePerUnit;
                sd.Subj = cs.Subj;
                sd.SubjectCode = cs.SubjectCode;
                sd.SubjectDescription = cs.SubjectDescription;
                sd.Units = cs.Units;
                if (cs.SubjectCode == "ENG1")
                    Console.WriteLine("shoud be true HERE");
                
                if (currSub1 != null)
                {
                    List<CurriculumSubject> matches = currSub1.Where(p => p.SubjectCode== cs.SubjectCode).ToList<CurriculumSubject>();
                    if (matches.Count>0)
                        sd.Added = true;
                    else
                        sd.Added = false;
                }else

                     sd.Added = false;
               
              
                subDetails.Add(sd);
            }
            gvSubjects.DataSource = subDetails;
           
        }

        private void SetFields()
        {
            txtCurrCode.Text = SelectedCurriculum.CurriculumCode;
            txtDescription.Text = SelectedCurriculum.Description;
            chkCurrent.Checked = SelectedCurriculum.CurrentCurr;
            currSub1 = new List<CurriculumSubject>(cs.GetCurriculumSubjects(SelectedCurriculum.CurriculumCode));
          }

        private void cmbGradeLevel_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            subDetails = new List<SubjectsDetails>();
            int index = cmbGradeLevel.SelectedIndex;
            string gLevel = gradeLevels[index].GradeLev;
            CurriculumServiceClient ss = new CurriculumServiceClient();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvSubjects_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            RadCheckBoxEditor cbEditor = e.ActiveEditor as RadCheckBoxEditor;

            if (cbEditor != null)
            {
                cbEditor.ValueChanged -= cbEditor_ValueChanged;
                cbEditor.ValueChanged += cbEditor_ValueChanged;
            }
        }

        private void cbEditor_ValueChanged(object sender, EventArgs e)
        {
            addedCurrSub = new CurriculumSubject();
            int i = gvSubjects.CurrentRow.Index;
            RadCheckBoxEditor cbEditor = sender as RadCheckBoxEditor;
            if ((Telerik.WinControls.Enumerations.ToggleState)cbEditor.Value == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                subDetails[i].Added = true;
                addedCurrSub.Academic = currSub[i].Academic;
                addedCurrSub.CurrDescription = txtDescription.Text;
                if (chkCurrent.CheckState == 0)
                    addedCurrSub.CurrentCurr = false;
                else
                    addedCurrSub.CurrentCurr = true;
                addedCurrSub.CurriculumCode = txtCurrCode.Text;
                addedCurrSub.CurrSubCode = txtCurrCode.Text.ToString() + currSub[i].SubjectCode;
                addedCurrSub.Deactivated = false;
                addedCurrSub.GradeLevel = currSub[i].GradeLevel;
                addedCurrSub.LearningAreaCode = currSub[i].LearningAreaCode;
                addedCurrSub.RatePerUnit = currSub[i].RatePerUnit;
                addedCurrSub.SubjectCode = currSub[i].SubjectCode;
                addedCurrSub.Subj = currSub[i].Subj;
                addedCurrSub.SubjectDescription = currSub[i].SubjectDescription;
                addedCurrSub.Units = currSub[i].Units;

                currSub1.Add(addedCurrSub);
               
            }
            else if ((Telerik.WinControls.Enumerations.ToggleState)cbEditor.Value == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                subDetails[i].Added = false;
                addedCurrSub.Academic = currSub[i].Academic;
                addedCurrSub.CurrDescription = txtDescription.Text;
                if (chkCurrent.CheckState == 0)
                    addedCurrSub.CurrentCurr = false;
                else
                    addedCurrSub.CurrentCurr = true;
                addedCurrSub.CurriculumCode = txtCurrCode.Text;
                addedCurrSub.CurrSubCode = txtCurrCode.Text.ToString() + currSub[i].SubjectCode;
                addedCurrSub.Deactivated = false;
                addedCurrSub.GradeLevel = currSub[i].GradeLevel;
                addedCurrSub.LearningAreaCode = currSub[i].LearningAreaCode;
                addedCurrSub.RatePerUnit = currSub[i].RatePerUnit;
                addedCurrSub.SubjectCode = currSub[i].SubjectCode;
                addedCurrSub.Subj = currSub[i].Subj;
                addedCurrSub.SubjectDescription = currSub[i].SubjectDescription;
                addedCurrSub.Units = currSub[i].Units;

                currSub1.Remove(addedCurrSub);
             
            }
            addedCurrSub = null;
        }

    }
   }
