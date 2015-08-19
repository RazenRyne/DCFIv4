namespace eSAR.Settings.ManageCurriculum
{
    partial class frmManageCurriculum
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gvCurriculum = new Telerik.WinControls.UI.RadGridView();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurriculum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurriculum.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnAdd);
            this.radPanel1.Controls.Add(this.btnEdit);
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Controls.Add(this.gvCurriculum);
            this.radPanel1.Location = new System.Drawing.Point(-4, -2);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(817, 369);
            this.radPanel1.TabIndex = 1;
            // 
            // gvCurriculum
            // 
            this.gvCurriculum.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.gvCurriculum.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn10.FieldName = "CurriculumCode";
            gridViewTextBoxColumn10.HeaderText = "Curriculum";
            gridViewTextBoxColumn10.Name = "CurriculumCode";
            gridViewTextBoxColumn10.Width = 150;
            gridViewTextBoxColumn11.FieldName = "Description";
            gridViewTextBoxColumn11.HeaderText = "Description";
            gridViewTextBoxColumn11.Name = "Description";
            gridViewTextBoxColumn11.Width = 300;
            gridViewTextBoxColumn12.FieldName = "CurrentCurr";
            gridViewTextBoxColumn12.HeaderText = "Current";
            gridViewTextBoxColumn12.Name = "Current";
            gridViewTextBoxColumn12.Width = 244;
            this.gvCurriculum.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.gvCurriculum.MasterTemplate.EnableGrouping = false;
            this.gvCurriculum.Name = "gvCurriculum";
            this.gvCurriculum.Size = new System.Drawing.Size(797, 298);
            this.gvCurriculum.TabIndex = 35;
            this.gvCurriculum.SelectionChanged += new System.EventHandler(this.gvCurriculum_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(541, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 24);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(630, 332);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 24);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(719, 332);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(83, 24);
            this.radButton1.TabIndex = 36;
            this.radButton1.Text = "Delete";
            // 
            // frmManageCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 386);
            this.Controls.Add(this.radPanel1);
            this.Name = "frmManageCurriculum";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manage Curriculum";
            this.ThemeName = "ControlDefault";
            this.Activated += new System.EventHandler(this.frmManageCurriculum_Activated);
            this.Load += new System.EventHandler(this.frmManageCurriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCurriculum.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurriculum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gvCurriculum;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
