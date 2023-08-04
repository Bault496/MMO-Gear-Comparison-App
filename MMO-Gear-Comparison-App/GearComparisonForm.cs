using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMO_Gear_Comparison_App
{
    public partial class GearComparisonForm : Form
    {
        public GearComparisonForm()
        {
            InitializeComponent();
        }

        private void btnExitGearComparison_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
