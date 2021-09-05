using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using Concat_Addin.Forms;


namespace Concat_Addin
{
    public partial class Ribbon1
    {

        private void btnConcat_Click(object sender, RibbonControlEventArgs e)
        {


            Excel.Range rng=  Globals.ThisAddIn.Application.Selection;


            frmConcat fm = new frmConcat(rng.Address);

            fm.ShowDialog();



        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {


            Excel.Range rng = Globals.ThisAddIn.Application.ActiveCell.CurrentRegion;


            frmHideColumns fm = new frmHideColumns(rng.Address);

            fm.ShowDialog();

            

        }
    }
}
