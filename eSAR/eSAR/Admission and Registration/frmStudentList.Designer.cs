namespace eSAR.Admission_and_Registration
{
    partial class frmStudentList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.gvStudent = new Telerik.WinControls.UI.RadGridView();
            this.pnFooter = new Telerik.WinControls.UI.RadPanel();
            this.btnRegister = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.pnSearch = new Telerik.WinControls.UI.RadPanel();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.cmbSearch = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnFooter)).BeginInit();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStudent
            // 
            this.gvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStudent.Location = new System.Drawing.Point(0, 65);
            // 
            // 
            // 
            gridViewTextBoxColumn1.FieldName = "StudentId";
            gridViewTextBoxColumn1.HeaderText = "Student ID";
            gridViewTextBoxColumn1.MaxLength = 50;
            gridViewTextBoxColumn1.Name = "StudentId";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.FieldName = "LastName";
            gridViewTextBoxColumn2.HeaderText = "Last Name";
            gridViewTextBoxColumn2.MaxLength = 50;
            gridViewTextBoxColumn2.Name = "LastName";
            gridViewTextBoxColumn2.Width = 257;
            gridViewTextBoxColumn3.FieldName = "FirstName";
            gridViewTextBoxColumn3.HeaderText = "First Name";
            gridViewTextBoxColumn3.MaxLength = 50;
            gridViewTextBoxColumn3.Name = "FirstName";
            gridViewTextBoxColumn3.Width = 260;
            gridViewTextBoxColumn4.FieldName = "MiddleName";
            gridViewTextBoxColumn4.HeaderText = "Middle Name";
            gridViewTextBoxColumn4.MaxLength = 50;
            gridViewTextBoxColumn4.Name = "MiddleName";
            gridViewTextBoxColumn4.Width = 270;
            this.gvStudent.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.gvStudent.MasterTemplate.EnableGrouping = false;
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.Size = new System.Drawing.Size(955, 369);
            this.gvStudent.TabIndex = 3;
            this.gvStudent.Text = "radGridView1";
            this.gvStudent.SelectionChanged += new System.EventHandler(this.gvStudent_SelectionChanged);
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btnRegister);
            this.pnFooter.Controls.Add(this.btnAdd);
            this.pnFooter.Controls.Add(this.btnEdit);
            this.pnFooter.Controls.Add(this.btnDelete);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 434);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(955, 50);
            this.pnFooter.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(12, 14);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(83, 24);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(682, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(771, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 24);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(860, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 24);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.cmbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(955, 65);
            this.pnSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 24);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 25);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Visible = false;
            // 
            // cmbSearch
            // 
            radListDataItem1.Text = "Student ID";
            radListDataItem2.Text = "Name";
            radListDataItem3.Text = "Grade Level";
            radListDataItem4.Text = "Home Address";
            this.cmbSearch.Items.Add(radListDataItem1);
            this.cmbSearch.Items.Add(radListDataItem2);
            this.cmbSearch.Items.Add(radListDataItem3);
            this.cmbSearch.Items.Add(radListDataItem4);
            this.cmbSearch.Location = new System.Drawing.Point(13, 26);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(110, 20);
            this.cmbSearch.TabIndex = 0;
            this.cmbSearch.Visible = false;
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 484);
            this.Controls.Add(this.gvStudent);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.pnFooter);
            this.Name = "frmStudentList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Student List";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnFooter)).EndInit();
            this.pnFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvStudent;
        private Telerik.WinControls.UI.RadPanel pnFooter;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadPanel pnSearch;
        private Telerik.WinControls.UI.RadDropDownList cmbSearch;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadButton btnRegister;
    }
}
