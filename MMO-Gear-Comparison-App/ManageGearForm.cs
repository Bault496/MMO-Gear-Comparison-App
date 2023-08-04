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
    public partial class ManageGearForm : Form
    {
        public ManageGearForm()
        {
            InitializeComponent();
        }

        private void btnCreateGear_Click(object sender, EventArgs e)
        {
            CreateGearForm createGearForm = new CreateGearForm();
            createGearForm.ShowDialog();
        }

        private void btnEditGear_Click(object sender, EventArgs e)
        {
            EditGearForm editGearForm = new EditGearForm();
            editGearForm.ShowDialog();
        }

        private void btnDeleteGear_Click(object sender, EventArgs e)
        {
            DeleteGearForm deleteGearForm = new DeleteGearForm();
            deleteGearForm.ShowDialog();
        }

        private void btnExitManageGear_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
