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
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool imported = oApp.thisAddin.ImportGaps(this.dtPicker.Value, radTxt.Checked);

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
