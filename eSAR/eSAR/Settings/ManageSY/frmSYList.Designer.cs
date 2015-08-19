namespace eSAR.Settings.ManageSY
{
    partial class frmSYList
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.gvSY = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.txtSY = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSY.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 452);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(736, 50);
            this.radPanel1.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(637, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gvSY
            // 
            this.gvSY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSY.Location = new System.Drawing.Point(0, 69);
            // 
            // 
            // 
            this.gvSY.MasterTemplate.AllowAddNewRow = false;
            this.gvSY.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.FieldName = "SY";
            gridViewTextBoxColumn1.HeaderText = "School Year";
            gridViewTextBoxColumn1.Name = "SY";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.FieldName = "CurrentSY";
            gridViewTextBoxColumn2.HeaderText = "Current";
            gridViewTextBoxColumn2.Name = "CurrentSY";
            gridViewTextBoxColumn2.Width = 75;
            this.gvSY.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gvSY.MasterTemplate.EnableGrouping = false;
            this.gvSY.Name = "gvSY";
            this.gvSY.Size = new System.Drawing.Size(736, 383);
            this.gvSY.TabIndex = 2;
            this.gvSY.SelectionChanged += new System.EventHandler(this.gvSY_SelectionChanged);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.txtSY);
            this.radPanel2.Controls.Add(this.radLabel1);
            this.radPanel2.Controls.Add(this.btnAdd);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(736, 69);
            this.radPanel2.TabIndex = 5;
            // 
            // txtSY
            // 
            this.txtSY.Location = new System.Drawing.Point(67, 28);
            this.txtSY.MaxLength = 4;
            this.txtSY.Name = "txtSY";
            this.txtSY.Size = new System.Drawing.Size(100, 20);
            this.txtSY.TabIndex = 0;
            this.txtSY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSY_KeyPress);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(43, 29);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(18, 18);
            this.radLabel1.TabIndex = 15;
            this.radLabel1.Text = "SY";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSYList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 502);
            this.Controls.Add(this.gvSY);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "frmSYList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manage School Year";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmSYList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSY.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadGridView gvSY;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadTextBox txtSY;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
