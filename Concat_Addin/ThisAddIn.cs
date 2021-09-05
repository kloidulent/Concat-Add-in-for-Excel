using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Concat_Addin
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {


            Globals.ThisAddIn.Application.WorkbookOpen += Application_WorkbookOpen;

            Globals.ThisAddIn.Application.WorkbookNewSheet += Application_WorkbookNewSheet;

            


        }

        private void Application_WorkbookNewSheet(Excel.Workbook Wb, object Sh)
        {
            ProvideWorkbookInfo();
        }

        private void Application_WorkbookOpen(Excel.Workbook Wb)
        {
            ProvideWorkbookInfo();

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void ProvideWorkbookInfo()
        {

            //System.Windows.Forms.MessageBox.Show("You added a new workbook.  There are " + Globals.ThisAddIn.Application.Workbooks.Count.ToString() + " workbooks open.");


        }








        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
