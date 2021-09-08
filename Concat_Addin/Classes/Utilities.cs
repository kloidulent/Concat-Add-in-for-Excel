using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Concat_Addin
{
    public static class Utilities
    {


        public static void MsgboxInfoOnly(string MessageText, MessageBoxIcon IconDisplay, string Title = "Concat Add-in"   )
        {

            MessageBox.Show(MessageText, Title, MessageBoxButtons.OK, IconDisplay);
        }


        public static string PromptForExcelRange(string SelectedAddress="")
        {
            Excel.Application xlapp = Globals.ThisAddIn.Application;

            object sel = xlapp.InputBox("Select range to be concatenated", "Select Range", SelectedAddress, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 8);

            // if cancel is pressed then object will be a bool (with a value of false).  Otherwise it will be an Excel Range object

            if (sel.GetType().Equals(typeof(bool)) == false)
            {
                Excel.Range rng = (Excel.Range)sel;
                return rng.Address;
            }
            else
                return "";


        }




    }
}
