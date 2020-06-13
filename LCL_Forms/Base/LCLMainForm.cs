using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.Base
{
    public partial class LCLMainForm : LCLForm
    {

        [Browsable(true)]
        public string StatusString { get { return labStatusInfo.Text; }set { labStatusInfo.Text = value; } }

        public LCLMainForm()
        {
            InitializeComponent();
        }
    }
}
