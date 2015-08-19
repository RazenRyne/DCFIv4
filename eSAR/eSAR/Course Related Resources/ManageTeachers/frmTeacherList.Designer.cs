namespace eSAR.Course_Related_Resources.ManageTeachers
{
    partial class frmTeacherList
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.pnSearch = new Telerik.WinControls.UI.RadPanel();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.cmbSearch = new Telerik.WinControls.UI.RadDropDownList();
            this.gvTeacher = new Telerik.WinControls.UI.RadGridView();
            this.pnFooter = new Telerik.WinControls.UI.RadPanel();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnFooter)).BeginInit();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Visible = false;
            // 
            // cmbSearch
            // 
            radListDataItem1.Text = "Teacher ID";
            radListDataItem2.Text = "First Name";
            radListDataItem3.Text = "Middle Name";
            radListDataItem4.Text = "Last Name";
            this.cmbSearch.Items.Add(radListDataItem1);
            this.cmbSearch.Items.Add(radListDataItem2);
            this.cmbSearch.Items.Add(radListDataItem3);
            this.cmbSearch.Items.Add(radListDataItem4);
            this.cmbSearch.Location = new System.Drawing.Point(13, 26);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(110, 20);
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.Text = "Teacher ID";
            // 
            // gvTeacher
            // 
            this.gvTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTeacher.Location = new System.Drawing.Point(0, 65);
            // 
            // 
            // 
            this.gvTeacher.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.FieldName = "TeacherId";
            gridViewTextBoxColumn1.HeaderText = "Teacher ID";
            gridViewTextBoxColumn1.Name = "TeacherId";
            gridViewTextBoxColumn1.Width = 128;
            gridViewTextBoxColumn2.FieldName = "FirstName";
            gridViewTextBoxColumn2.HeaderText = "First Name";
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 220;
            gridViewTextBoxColumn3.FieldName = "MiddleName";
            gridViewTextBoxColumn3.HeaderText = "Middle Name";
            gridViewTextBoxColumn3.Name = "MiddleName";
            gridViewTextBoxColumn3.Width = 220;
            gridViewTextBoxColumn4.FieldName = "LastName";
            gridViewTextBoxColumn4.HeaderText = "Last Name";
            gridViewTextBoxColumn4.Name = "LastName";
            gridViewTextBoxColumn4.Width = 220;
            gridViewTextBoxColumn5.FieldName = "MobileNo";
            gridViewTextBoxColumn5.HeaderText = "Contact No.";
            gridViewTextBoxColumn5.Name = "ContactNo";
            gridViewTextBoxColumn5.Width = 150;
            this.gvTeacher.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gvTeacher.Name = "gvTeacher";
            this.gvTeacher.ShowGroupPanel = false;
            this.gvTeacher.Size = new System.Drawing.Size(955, 369);
            this.gvTeacher.TabIndex = 3;
            this.gvTeacher.Text = "radGridView1";
            this.gvTeacher.SelectionChanged += new System.EventHandler(this.gvTeacher_SelectionChanged);
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btnDelete);
            this.pnFooter.Controls.Add(this.btnEdit);
            this.pnFooter.Controls.Add(this.btnAdd);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 434);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(955, 50);
            this.pnFooter.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(860, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Deactivate";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(771, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 24);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(682, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 24);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmTeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 484);
            this.Controls.Add(this.gvTeacher);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnSearch);
            this.Name = "frmTeacherList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Teacher List";
            this.ThemeName = "ControlDefault";
            this.Activated += new System.EventHandler(this.frmTeacherList_Activated);
            this.Load += new System.EventHandler(this.frmTeacherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnFooter)).EndInit();
            this.pnFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel pnSearch;
        private Telerik.WinControls.UI.RadGridView gvTeacher;
        private Telerik.WinControls.UI.RadPanel pnFooter;
        private Telerik.WinControls.UI.RadDropDownList cmbSearch;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDelete;
    }
}
