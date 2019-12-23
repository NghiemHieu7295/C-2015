using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculations
{
    public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

        private void mnuNewFutureValue_Click(object sender, EventArgs e)
        {
            frmFutureValue futureValueForm = new frmFutureValue();
            futureValueForm.MdiParent = this;
            futureValueForm.Show();
        }

        private void mnuNewDepreciation_Click(object sender, EventArgs e)
        {
            frmDepreciation depreciationForm = new frmDepreciation();
            depreciationForm.MdiParent = this;
            depreciationForm.Show();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (null != activeChild)
                activeChild.Close();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuToolbar_Click(object sender, EventArgs e)
        {
            if (mnuToolbar.Checked == true)
            {
                mnuToolbar.Checked = false;
                toolStrip1.Visible = false;
            }
            else if (mnuToolbar.Checked == false)
            {
                mnuToolbar.Checked = true;
                toolStrip1.Visible = true;
            }
        }

        private void btnFutureValue_Click(object sender, EventArgs e)
        {
            this.mnuNewFutureValue.PerformClick();
        }

        private void btnDepreciation_Click(object sender, EventArgs e)
        {
            this.mnuNewDepreciation.PerformClick();
        }
    }
}