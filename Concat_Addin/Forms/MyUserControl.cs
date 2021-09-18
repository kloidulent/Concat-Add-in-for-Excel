using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concat_Addin
{
    public partial class MyUserControl : UserControl
    {

        private string _taskPaneTitle = "";
        private string _currentCell="";

        public string TaskPaneTitle
        {

            get => _taskPaneTitle;

            set
            {
                _taskPaneTitle = value;
                this.lblInfo.Text = _taskPaneTitle;

            }

        }

        public string TaskPaneCurrentCell
        {

            get => _currentCell;

            set
            {
                _currentCell = value;
                this.lblCurrentCell.Text = _currentCell;

            }

        }

        public MyUserControl()
        {
            InitializeComponent();
        }
    }
}
