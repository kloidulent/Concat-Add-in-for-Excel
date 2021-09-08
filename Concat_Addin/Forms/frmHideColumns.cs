using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concat_Addin.Forms
{
    public partial class frmHideColumns : Form
    {

        private int _columnsHiddenCount = 0;

        public int ColumnsHiddenCount
        {
            get => _columnsHiddenCount;

            set => _columnsHiddenCount = value;
        }


        public frmHideColumns(string InitialSelection)
        {
            InitializeComponent();
            this.txtSelectedAddress.Text = InitialSelection;

        }



        public frmHideColumns()
        {
            InitializeComponent();
        }

        private void btnSelectRange_Click(object sender, EventArgs e)
        {
            string address = Utilities.PromptForExcelRange(txtSelectedAddress.Text);

            if (address.Length > 0)
            {
                txtSelectedAddress.Text = address;
            }

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

            if (txtSelectedAddress.Text.Length > 0)
                ColumnCleaner.CleanColumns(this.txtSelectedAddress.Text,  chkTreatZerosAsBlank.Checked);

            this.Close();

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
