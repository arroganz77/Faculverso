using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculverso
{
    public partial class CTutorial : Form
    {
        public CTutorial()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AMenu f1 = new AMenu();
            f1.Show();
            this.Close();
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            lblTV.Visible = true;
            lblQC.Visible = false;
            lblTM.Visible = false;
            lblTQ.Visible = false;
        }

        private void btnTQ_Click(object sender, EventArgs e)
        {
            lblTV.Visible = false;
            lblQC.Visible = false;
            lblTM.Visible = false;
            lblTQ.Visible = true;
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            lblTV.Visible = false;
            lblQC.Visible = false;
            lblTM.Visible = true;
            lblTQ.Visible = false;
        }

        private void btnTQC_Click(object sender, EventArgs e)
        {
            lblTV.Visible = false;
            lblQC.Visible = true;
            lblTM.Visible = false;
            lblTQ.Visible = false;
        }
    }
}
