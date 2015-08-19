using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.LearningAreaServiceRef;
using Telerik.WinControls.UI;
using eSAR.GradeLevelServiceRef;

namespace eSAR.Course_Related_Resources.ManageSubject
{
    public partial class frmManageSubject : Telerik.WinControls.UI.RadForm
    {
        public string Op { get; set; }
        public LearningArea SelectedLearningArea { get; set; }
        List<GradeLevel> gradeLevel = new List<GradeLevel>();
        List<Subject> subjects;
        List<Subject> subjects1 = new List<Subject>();
        GridViewComboBoxColumn colGradeLevel;
        GradeLevel gLevelSelected = new GradeLevel();

        string oldGL = string.Empty;
        

        private int oldIndex = -1;
        public frmManageSubject()
        {
            InitializeComponent();

        }

        private void gvSubjects_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Row is GridViewNewRowInfo)
            {
                var editor = e.ActiveEditor as RadDropDownListEditor;
                if (editor != null)
                {
                    editor.ValueChanged -= new EventHandler(editor_ValueChanged);
                    editor.ValueChanged += new EventHandler(editor_ValueChanged);
                }
            }
        }

        void editor_ValueChanged(object sender, EventArgs e)
        {
            var editor = gvSubjects.ActiveEditor as RadDropDownListEditor;
            if (editor != null)
            {
                var editorElement = editor.EditorElement as RadDropDownListEditorElement;
                if (editorElement.SelectedIndex == -1)
                {

                    MessageBox.Show(this, "Please select a grade level.", "Grade Level Required");
                    gvSubjects.CancelEdit();
                }
                else
                {
                    gLevelSelected = gradeLevel[editorElement.SelectedIndex];
                    gvSubjects.EndEdit();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            LearningAreaServiceClient laService = new LearningAreaServiceClient();
            Boolean ret = false;
            string message = String.Empty;
            LearningArea learningArea = new LearningArea()
            {
                LearningAreaCode = txtLearningAreaCode.Text.ToString(),
                Description = txtDescription.Text.ToString(),
                Units = Double.Parse(txtUnits.Text.ToString()),
                Subjects = subjects.ToArray(),
                RatePerUnit = Double.Parse(txtRate.Text.ToString()),
                Academic = checkAcademic.Checked
            };
            if (Op.Equals("edit"))
                ret = laService.UpdateLearningArea(ref learningArea, ref message);
            else
                ret = laService.CreateLearningArea(ref learningArea, ref message);

            if (ret)
                MessageBox.Show("Saved Successfully");
            else
                MessageBox.Show("Error Saving");

            Close();

        }

        private void frmManageSubject_Load(object sender, EventArgs e)
        {

            LearningAreaServiceClient laService = new LearningAreaServiceClient();
            GradeLevelServiceClient glService = new GradeLevelServiceClient();
            gradeLevel = new List<GradeLevel>(glService.GetAllGradeLevels());

            if (gradeLevel.Count < 1)
                gvSubjects.Enabled = false;

            colGradeLevel = new GridViewComboBoxColumn("GradeLevel");
            //colGradeLevel
            colGradeLevel.HeaderText = "Grade Level";
            colGradeLevel.FieldName = "GradeLevel";
            colGradeLevel.ValueMember = "GradeLev";
            colGradeLevel.DisplayMember = "Description";
            colGradeLevel.Width = 115;

            colGradeLevel.DataSource = gradeLevel;

            gvSubjects.Columns.Add(colGradeLevel);


            if (Op.Equals("edit"))
            {
                SetFields();
                SetSubjectGrid();
            }

            if (Op.Equals("new"))
            {
                BindSubjectGrid();
            }
        }

        private void SetFields()
        {

            txtLearningAreaCode.Text = SelectedLearningArea.LearningAreaCode;
            txtDescription.Text = SelectedLearningArea.Description;
            txtUnits.Text = SelectedLearningArea.Units.ToString();
            txtRate.Text = SelectedLearningArea.RatePerUnit.ToString();
            checkAcademic.Checked = (bool)SelectedLearningArea.Academic;
        }

        private void BindSubjectGrid()
        {
            subjects = new List<Subject>();
            gvSubjects.DataSource = subjects;
        }

        private void SetSubjectGrid()
        {
            subjects = new List<Subject>(SelectedLearningArea.Subjects);
            this.gvSubjects.DataSource = subjects;
        }


        private void gvSubjects_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            int index = this.gvSubjects.RowCount - 1;

            subjects[index].LearningAreaCode = this.txtLearningAreaCode.Text;
            subjects[index].SubjectCode = this.txtLearningAreaCode.Text + gLevelSelected.GradeLev;
            subjects[index].GradeLevel = gLevelSelected.GradeLev;
            gvSubjects.DataSource = subjects1;
            gvSubjects.DataSource = subjects;
            gLevelSelected = null;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void gvSubjects_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
        {
            var newGL = new object();
            newGL = e.Rows[0].Cells["GradeLevel"].Value;

            if (newGL == null)
            {
                MessageBox.Show("Grade Level should not be empty");
                e.Cancel = true;
            }
            else
            {
                if (subjects.FindAll(x => x.GradeLevel == newGL.ToString()).Count > 0)
                {
                    MessageBox.Show("Subject for this Grade Level already exist");
                    e.Cancel = true;
                }
            }

        }


        private void gvSubjects_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    oldGL = gvSubjects.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }
        }

        private void gvSubjects_ValueChanging(object sender, ValueChangingEventArgs e)
        {
            if (gvSubjects.CurrentRow.Index >= 0)
            {
                if (e.NewValue != e.OldValue)
                {
                    if (gvSubjects.CurrentColumn.Index == 2)
                    {
                        if (subjects.FindAll(x => x.GradeLevel == e.NewValue.ToString()).Count <= 0)
                        {
                            subjects[gvSubjects.CurrentRow.Index].SubjectID = 0;
                            subjects[gvSubjects.CurrentRow.Index].LearningAreaCode = this.txtLearningAreaCode.Text;
                            subjects[gvSubjects.CurrentRow.Index].SubjectCode = this.txtLearningAreaCode.Text + e.NewValue.ToString();
                            gvSubjects.Rows[gvSubjects.CurrentRow.Index].Cells[0].Value = this.txtLearningAreaCode.Text + e.NewValue.ToString();
                            subjects[gvSubjects.CurrentRow.Index].GradeLevel = e.NewValue.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Subject for this Grade Level already exist");
                            e.Cancel = true;
                        }
                    }
                }
            }
        }
    }
}
