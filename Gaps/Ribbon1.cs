using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Gaps
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnInsertGaps_Click(object sender, RibbonControlEventArgs e)
        {
            InputBox ipb = new InputBox();
            ipb.ShowDialog();
        }
    }
}
