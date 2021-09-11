using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;



namespace Concat_Addin
{
    public static class Concat
    {

        public enum TextTransformation
        {
            ToUpperCase,
            ToLowerCase,
            NoTransformation

        }


        public static string ConcatenateRangeToText(Excel.Range selectedCells, string wrapChar, string delimChar, bool CarriageReturnAfterEachItem,
                            bool DistinctValues, System.Windows.Forms.SortOrder sortOrder, TextTransformation textTransformation, out int ItemCount)

        {

            // this is a useful reference - not used here (as at 4th Aug 2021) but could be useful in future
            // https://stackoverflow.com/questions/5728409/how-to-create-a-1-dimensional-array-in-c-sharp-with-index-starting-at-1



            StringBuilder sbOutput = new StringBuilder();
            string carriageReturnChar = "";



            if (CarriageReturnAfterEachItem)
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

            if (DistinctValues)
            {
                if (sortOrder == System.Windows.Forms.SortOrder.Ascending)
                    itemsToProcess = cellValues.Distinct().OrderBy(s => s);
                else if (sortOrder == System.Windows.Forms.SortOrder.Descending)
                    itemsToProcess = cellValues.Distinct().OrderByDescending(s => s);
                else
                    itemsToProcess = cellValues.Distinct();
            }
            else
            {
                if (sortOrder == System.Windows.Forms.SortOrder.Ascending)
                    itemsToProcess = cellValues.OrderBy(s => s);
                else if (sortOrder == System.Windows.Forms.SortOrder.Descending)
                    itemsToProcess = cellValues.OrderByDescending(s => s);
                else
                    itemsToProcess = cellValues;
            }


            // it's possible that there are no items to process - this would happen if the cells in the selection are null

            ItemCount = itemsToProcess.Count();

            if (itemsToProcess.Count() > 0)
            {

                foreach (string s in itemsToProcess)
                    sbOutput.Append(wrapChar + s + wrapChar + delimChar + carriageReturnChar);


                // remove the trailing comma - https://stackoverflow.com/questions/17215045/best-way-to-remove-the-last-character-from-a-string-built-with-stringbuilder/17215107

                sbOutput.Length = sbOutput.Length - delimChar.Length - carriageReturnChar.Length;


                switch (textTransformation)
                {
                    case TextTransformation.ToLowerCase:
                        return sbOutput.ToString().ToLower();

                    case TextTransformation.ToUpperCase:
                        return sbOutput.ToString().ToUpper();

                    case TextTransformation.NoTransformation:
                        return sbOutput.ToString();

                    default:
                        return String.Empty;

                }

            }
            else
                return String.Empty;


        }



    }
}
