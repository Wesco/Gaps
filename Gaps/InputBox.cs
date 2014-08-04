using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gaps
{
    public partial class gapsDialog : Form
    {
        public gapsDialog()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            this.cbBranch.DataSource = new object[] { "3615", "3605", "3625", "3640" };
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string branch;

            try
            {
                branch = cbBranch.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                branch = "3615";
            }

            bool imported = oApp.thisAddin.ImportGaps(this.dtPicker.Value, radTxt.Checked, branch);

            if (imported)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
