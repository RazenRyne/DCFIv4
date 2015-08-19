namespace eSAR.App
{
    partial class FrmMain
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnStudent = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnTeacher = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnLearningArea = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup6 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnTimeSlot = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup7 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnManageSY = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnUser = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnBuildings = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup8 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnScholarship = new Telerik.WinControls.UI.RadButtonElement();
            this.LoggedUser = new Telerik.WinControls.UI.RadButtonElement();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.radRibbonBarGroup9 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnCurriculum = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2,
            this.ribbonTab3});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.QuickAccessToolBarItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.LoggedUser});
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(1028, 176);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "DCFI e-SAR";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AccessibleDescription = "Admission and Registration";
            this.ribbonTab1.AccessibleName = "Admission and Registration";
            this.ribbonTab1.IsSelected = false;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Admission and Registration";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "Admission";
            this.radRibbonBarGroup1.AccessibleName = "Admission";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnStudent});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Student";
            // 
            // btnStudent
            // 
            this.btnStudent.AccessibleDescription = "radButtonElement1";
            this.btnStudent.AccessibleName = "radButtonElement1";
            this.btnStudent.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnStudent.Image = global::eSAR.Properties.Resources.StudentAdmission;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Text = "";
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.AccessibleDescription = "Course Related Resources";
            this.ribbonTab2.AccessibleName = "Course Related Resources";
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup5,
            this.radRibbonBarGroup6,
            this.radRibbonBarGroup7});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Course Related Resources";
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnTeacher});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "";
            // 
            // btnTeacher
            // 
            this.btnTeacher.AccessibleDescription = "Manage Teacher";
            this.btnTeacher.AccessibleName = "Manage Teacher";
            this.btnTeacher.Image = global::eSAR.Properties.Resources.users;
            this.btnTeacher.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Text = "Manage Teacher";
            this.btnTeacher.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.AccessibleDescription = "Manage Learning Area";
            this.radRibbonBarGroup5.AccessibleName = "Manage Learning Area";
            this.radRibbonBarGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnLearningArea});
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "Manage Learning Area";
            // 
            // btnLearningArea
            // 
            this.btnLearningArea.AccessibleDescription = "Manage Learning Area";
            this.btnLearningArea.AccessibleName = "Manage Learning Area";
            this.btnLearningArea.Name = "btnLearningArea";
            this.btnLearningArea.Text = "Manage Learning Area";
            this.btnLearningArea.Click += new System.EventHandler(this.btnLearningArea_Click);
            // 
            // radRibbonBarGroup6
            // 
            this.radRibbonBarGroup6.AccessibleDescription = "Manage Timeslot";
            this.radRibbonBarGroup6.AccessibleName = "Manage Timeslot";
            this.radRibbonBarGroup6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnTimeSlot});
            this.radRibbonBarGroup6.Name = "radRibbonBarGroup6";
            this.radRibbonBarGroup6.Text = "Manage Timeslot";
            // 
            // btnTimeSlot
            // 
            this.btnTimeSlot.AccessibleDescription = "Manage Timeslot";
            this.btnTimeSlot.AccessibleName = "Manage Timeslot";
            this.btnTimeSlot.Name = "btnTimeSlot";
            this.btnTimeSlot.Text = "Manage Timeslot";
            this.btnTimeSlot.Click += new System.EventHandler(this.btnTimeSlot_Click);
            // 
            // radRibbonBarGroup7
            // 
            this.radRibbonBarGroup7.AccessibleDescription = "Manage SY";
            this.radRibbonBarGroup7.AccessibleName = "Manage SY";
            this.radRibbonBarGroup7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnManageSY});
            this.radRibbonBarGroup7.Name = "radRibbonBarGroup7";
            this.radRibbonBarGroup7.Text = "Manage SY";
            // 
            // btnManageSY
            // 
            this.btnManageSY.AccessibleDescription = "Manage SY";
            this.btnManageSY.AccessibleName = "Manage SY";
            this.btnManageSY.Name = "btnManageSY";
            this.btnManageSY.Text = "Manage SY";
            this.btnManageSY.Click += new System.EventHandler(this.btnManageSY_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.AccessibleDescription = "Settings";
            this.ribbonTab3.AccessibleName = "Settings";
            this.ribbonTab3.IsSelected = true;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup4,
            this.radRibbonBarGroup6,
            this.radRibbonBarGroup8,
            this.radRibbonBarGroup9});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Settings";
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnUser});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "";
            // 
            // btnUser
            // 
            this.btnUser.AccessibleDescription = "Manage Users";
            this.btnUser.AccessibleName = "Manage Users";
            this.btnUser.Image = global::eSAR.Properties.Resources.users;
            this.btnUser.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUser.Name = "btnUser";
            this.btnUser.Text = "Manage Users";
            this.btnUser.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnBuildings});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "";
            // 
            // btnBuildings
            // 
            this.btnBuildings.AccessibleDescription = "Manage Buildings/Rooms";
            this.btnBuildings.AccessibleName = "Manage Buildings/Rooms";
            this.btnBuildings.Image = global::eSAR.Properties.Resources.building;
            this.btnBuildings.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuildings.Name = "btnBuildings";
            this.btnBuildings.Text = "Manage Buildings";
            this.btnBuildings.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuildings.Click += new System.EventHandler(this.btnBuildings_Click);
            // 
            // radRibbonBarGroup8
            // 
            this.radRibbonBarGroup8.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnScholarship});
            this.radRibbonBarGroup8.Name = "radRibbonBarGroup8";
            this.radRibbonBarGroup8.Text = "";
            // 
            // btnScholarship
            // 
            this.btnScholarship.AccessibleDescription = "Manage Scholarship";
            this.btnScholarship.AccessibleName = "Manage Scholarship";
            this.btnScholarship.Name = "btnScholarship";
            this.btnScholarship.Text = "Manage Scholarship";
            this.btnScholarship.Click += new System.EventHandler(this.btnScholarship_Click);
            // 
            // LoggedUser
            // 
            this.LoggedUser.AccessibleDescription = "Name";
            this.LoggedUser.AccessibleName = "Name";
            this.LoggedUser.Name = "LoggedUser";
            this.LoggedUser.StretchHorizontally = false;
            this.LoggedUser.StretchVertically = false;
            this.LoggedUser.Text = "";
            // 
            // radDock1
            // 
            this.radDock1.AutoDetectMdiChildren = true;
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 176);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.MdiChildrenDockType = Telerik.WinControls.UI.Docking.DockType.ToolWindow;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radDock1.Size = new System.Drawing.Size(1028, 541);
            this.radDock1.TabIndex = 7;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            this.radDock1.DockWindowClosing += new Telerik.WinControls.UI.Docking.DockWindowCancelEventHandler(this.radDock1_DockWindowClosing);
            // 
            // documentContainer1
            // 
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            // 
            // radRibbonBarGroup9
            // 
            this.radRibbonBarGroup9.AccessibleDescription = "Manage Curriculum";
            this.radRibbonBarGroup9.AccessibleName = "Manage Curriculum";
            this.radRibbonBarGroup9.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnCurriculum});
            this.radRibbonBarGroup9.Name = "radRibbonBarGroup9";
            this.radRibbonBarGroup9.Text = "Manage Curriculum";
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.AccessibleDescription = "Manage Curriculum";
            this.btnCurriculum.AccessibleName = "Manage Curriculum";
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.Text = "Manage Curriculum";
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 717);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radRibbonBar1);
            this.MainMenuStrip = null;
            this.Name = "FrmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCFI e-SAR";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement btnUser;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.RadButtonElement btnStudent;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement btnTeacher;
        private Telerik.WinControls.UI.RadButtonElement LoggedUser;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadButtonElement btnBuildings;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadButtonElement btnLearningArea;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup6;
        private Telerik.WinControls.UI.RadButtonElement btnTimeSlot;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup7;
        private Telerik.WinControls.UI.RadButtonElement btnManageSY;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup8;
        private Telerik.WinControls.UI.RadButtonElement btnScholarship;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup9;
        private Telerik.WinControls.UI.RadButtonElement btnCurriculum;
    }
}
