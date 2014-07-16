namespace Gaps
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpGaps = this.Factory.CreateRibbonGroup();
            this.btnInsertGaps = this.Factory.CreateRibbonButton();
            this.Gaps = this.Factory.CreateRibbonTab();
            this.grpGaps.SuspendLayout();
            this.Gaps.SuspendLayout();
            // 
            // grpGaps
            // 
            this.grpGaps.Items.Add(this.btnInsertGaps);
            this.grpGaps.Label = "Gaps";
            this.grpGaps.Name = "grpGaps";
            // 
            // btnInsertGaps
            // 
            this.btnInsertGaps.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnInsertGaps.Description = "Import the latest gaps file";
            this.btnInsertGaps.Image = global::Gaps.Properties.Resources.add;
            this.btnInsertGaps.Label = "Insert Gaps";
            this.btnInsertGaps.Name = "btnInsertGaps";
            this.btnInsertGaps.ShowImage = true;
            this.btnInsertGaps.SuperTip = "Import the latest gaps file";
            this.btnInsertGaps.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInsertGaps_Click);
            // 
            // Gaps
            // 
            this.Gaps.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Gaps.ControlId.OfficeId = "TabData";
            this.Gaps.Groups.Add(this.grpGaps);
            this.Gaps.Label = "TabData";
            this.Gaps.Name = "Gaps";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.Gaps);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.grpGaps.ResumeLayout(false);
            this.grpGaps.PerformLayout();
            this.Gaps.ResumeLayout(false);
            this.Gaps.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpGaps;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsertGaps;
        private Microsoft.Office.Tools.Ribbon.RibbonTab Gaps;

    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
