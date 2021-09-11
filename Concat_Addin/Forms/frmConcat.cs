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
            catch (Exception)
            {

                // don't need to display a message as it's quite possible that the range textbox currently contains an invalid address e.g.
                // if the user is in the middle of entering an address and has not yet completed it.

                // TODO - an indicator on the textbox or near it to show whether the range entered is valid


                SelectionIsValid = false;

            }

            if (SelectionIsValid)

            {

                int ItemCount;

                Concat.TextTransformation transformation;

                if (radioTextTransformToLower.Checked)
                    transformation = Concat.TextTransformation.ToLowerCase;
                else if (radioTextTransformToUpper.Checked)
                    transformation = Concat.TextTransformation.ToUpperCase;
                else
                    transformation = Concat.TextTransformation.NoTransformation;


                SortOrder order;

                if (radioSortAscending.Checked)
                    order = SortOrder.Ascending;
                else if (radioSortDescending.Checked)
                    order = SortOrder.Descending;
                else
                    order = SortOrder.None;


                string results = Concat.ConcatenateRangeToText(selectedCells,
                                    this.txtCharacter.Text,
                                    this.txtDelimiter.Text,
                                    this.chkCRAfterEachItem.Checked,
                                    this.chkDistinctValues.Checked,
                                    order,
                                    transformation,
                                    out ItemCount
                                    );


                this.richTextResults.Text = results;


                if (ItemCount == 1)
                    lblMessage.Text = ItemCount.ToString() + " value in list";
                else
                    lblMessage.Text = ItemCount.ToString() + " values in list";





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



        private void btnCopy_Click(object sender, EventArgs e)
        {

            if (richTextResults.TextLength > 0)
                System.Windows.Forms.Clipboard.SetText(richTextResults.Text);

            this.Close();


        }



        private void chkCRAfterEachItem_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void chkDistinctValues_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void txtSelectedAddress_TextChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void radioSortNone_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void radioSortAscending_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }

        private void radioSortDescending_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOutputText();
        }


    }
}
