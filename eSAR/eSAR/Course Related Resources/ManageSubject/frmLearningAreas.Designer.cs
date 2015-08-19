namespace eSAR.Course_Related_Resources.ManageSubject
{
    partial class frmLearningAreas
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gvLearningArea = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnAddBuilding = new Telerik.WinControls.UI.RadButton();
            this.btnEditBuilding = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLearningArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLearningArea.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.gvLearningArea);
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(849, 475);
            this.radPanel1.TabIndex = 0;
            // 
            // gvLearningArea
            // 
            this.gvLearningArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvLearningArea.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gvLearningArea.MasterTemplate.AllowDragToGroup = false;
            gridViewCheckBoxColumn1.FieldName = "Academic";
            gridViewCheckBoxColumn1.HeaderText = "Academic";
            gridViewCheckBoxColumn1.Name = "Academic";
            gridViewCheckBoxColumn1.Width = 100;
            gridViewTextBoxColumn1.FieldName = "LearningAreaCode";
            gridViewTextBoxColumn1.HeaderText = "Learning Area Code";
            gridViewTextBoxColumn1.Name = "LearningAreaCode";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn1.WrapText = true;
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.Width = 300;
            gridViewTextBoxColumn2.WrapText = true;
            gridViewTextBoxColumn3.FieldName = "Units";
            gridViewTextBoxColumn3.HeaderText = "Units";
            gridViewTextBoxColumn3.Name = "Units";
            gridViewTextBoxColumn3.WrapText = true;
            gridViewTextBoxColumn4.FieldName = "RatePerUnit";
            gridViewTextBoxColumn4.HeaderText = "Rate per Unit";
            gridViewTextBoxColumn4.Name = "RatePerUnit";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 100;
            this.gvLearningArea.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.gvLearningArea.MasterTemplate.EnableGrouping = false;
            this.gvLearningArea.Name = "gvLearningArea";
            this.gvLearningArea.Size = new System.Drawing.Size(849, 425);
            this.gvLearningArea.TabIndex = 47;
            this.gvLearningArea.SelectionChanged += new System.EventHandler(this.gvLearningArea_SelectionChanged);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.btnAddBuilding);
            this.radPanel2.Controls.Add(this.btnEditBuilding);
            this.radPanel2.Controls.Add(this.btnCancel);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 425);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(849, 50);
            this.radPanel2.TabIndex = 41;
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBuilding.Location = new System.Drawing.Point(570, 14);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(83, 24);
            this.btnAddBuilding.TabIndex = 46;
            this.btnAddBuilding.Text = "Add";
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // btnEditBuilding
            // 
            this.btnEditBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBuilding.Location = new System.Drawing.Point(659, 14);
            this.btnEditBuilding.Name = "btnEditBuilding";
            this.btnEditBuilding.Size = new System.Drawing.Size(83, 24);
            this.btnEditBuilding.TabIndex = 44;
            this.btnEditBuilding.Text = "Edit";
            this.btnEditBuilding.Click += new System.EventHandler(this.btnEditBuilding_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(748, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 24);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmLearningAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 475);
            this.Controls.Add(this.radPanel1);
            this.Name = "frmLearningAreas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Learning Areas List";
            this.ThemeName = "ControlDefault";
            this.Activated += new System.EventHandler(this.frmLearningAreas_Activated);
            this.Load += new System.EventHandler(this.frmLearningAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvLearningArea.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLearningArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton btnAddBuilding;
        private Telerik.WinControls.UI.RadButton btnEditBuilding;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadGridView gvLearningArea;
    }
}
