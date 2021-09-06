using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;


namespace Concat_Addin
{
    public partial class frmConcat : Form
    {


        public frmConcat(string initialSelection)
        {
            InitializeComponent();
            txtSelectedAddress.Text = initialSelection;

            PopulateOutputText();


        }

        public frmConcat()
        {
            InitializeComponent();
        }


        private void PopulateOutputText()
        {

            // this is a useful reference - not used here (as at 4th Aug 2021) but could be useful in future
            // https://stackoverflow.com/questions/5728409/how-to-create-a-1-dimensional-array-in-c-sharp-with-index-starting-at-1


            bool SelectionIsValid;

            Excel.Application xlapp = Globals.ThisAddIn.Application;
            Excel.Range selectedCells = null;



            try
            {


                selectedCells = xlapp.Range[this.txtSelectedAddress.Text].SpecialCells(Excel.XlCellType.xlCellTypeVisible);


                if (selectedCells.Cells.Count > 0)
                    SelectionIsValid = true;
                else
                    SelectionIsValid = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.ToString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                SelectionIsValid = false;

            }

            if (SelectionIsValid)

            {


                StringBuilder sbOutput = new StringBuilder();
                string wrapChar = "";
                string carriageReturnChar = "";


                if (this.chkAddCharacter.Checked)
                    wrapChar = txtCharacter.Text;

                string delimChar = this.txtDelimiter.Text;

                if (this.chkCRAfterEachItem.Checked)
                    carriageReturnChar = "\r\n";


                List<object> areas = new List<object>();


                for (int i = 1; i <= selectedCells.Areas.Count; i++)
                {
                    if (selectedCells.Areas[i].Rows.Count == 1 && selectedCells.Areas[i].Columns.Count == 1)
                    {
                        // if the selection, or area of a selection includes one value only then an array will not be returned.  Create a 2 dimensional array
                        // in this case and populate it with the single value and can then treat all areas in the same way
                        object[,] singleValue = new object[1, 1];
                        singleValue[0, 0] = selectedCells.Areas[i].Value2;
                        areas.Add(singleValue);
                    }
                    else
                    {
                        object[,] cellsArray = selectedCells.Areas[i].Value2;
                        areas.Add(cellsArray);
                    }
                }


                // if the user has selected more than one column loop through rows first and then columns.
                // A future enhancement could be to allow the user to choose if they want rows first or columns first.

                List<string> cellValues = new List<string>();

                foreach (object[,] cells in areas)

                    for (int column = cells.GetLowerBound(1); column <= cells.GetUpperBound(1); column++)
                        for (int row = cells.GetLowerBound(0); row <= cells.GetUpperBound(0); row++)
                            if (cells[row, column] != null)
                                cellValues.Add(cells[row, column].ToString());

                IEnumerable<string> itemsToProcess;

                if (this.chkDistinctValues.Checked)
                {
                    itemsToProcess = cellValues.Distinct();
                }
                else
                {
                    itemsToProcess = cellValues;
                }


                // it's possible that there are no items to process - this would happen if the cells in the selection are null

                if (itemsToProcess.Count() > 0)
                {

                    foreach (string s in itemsToProcess)
                        sbOutput.Append(wrapChar + s + wrapChar + delimChar + carriageReturnChar);


                    // remove the trailing comma - https://stackoverflow.com/questions/17215045/best-way-to-remove-the-last-character-from-a-string-built-with-stringbuilder/17215107

                    sbOutput.Length = sbOutput.Length - delimChar.Length - carriageReturnChar.Length;


                    if (radioTextTransformNone.Checked)
                        richTextResults.Text = sbOutput.ToString();
                    else if (radioTextTransformToLower.Checked)
                        richTextResults.Text = sbOutput.ToString().ToLower();
                    else if (radioTextTransformToUpper.Checked)
                        richTextResults.Text = sbOutput.ToString().ToUpper();

                }


                if (itemsToProcess.Count()==1)
                    lblMessage.Text = itemsToProcess.Count().ToString() + " value in list";
                else
                    lblMessage.Text = itemsToProcess.Count().ToString() + " values in list";





            }



        }


        private void btnSelectRange_Click(object sender, EventArgs e)
        {

            string address = Utilities.PromptForExcelRange(txtSelectedAddress.Text);

            if (address.Length > 0)
            {
                txtSelectedAddress.Text = address;
                PopulateOutputText();
            }


        }

        private void chkAddCharacter_CheckedChanged(object sender, EventArgs e)
        {

            PopulateOutputText();

        }

        private void txtCharacter_TextChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void txtDelimiter_TextChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void radioTextTransformNone_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();

        }

        private void radioTextTransformToUpper_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void radioTextTransformToLower_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void frmConcat_Load(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            if (richTextResults.TextLength > 0)
                System.Windows.Forms.Clipboard.SetText(richTextResults.Text);

            this.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkCRAfterEachItem_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void chkDistinctValues_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }
    }
}
