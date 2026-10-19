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
    public partial class DCreditos : Form
    {
        public DCreditos()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AMenu f1 = new AMenu();
            f1.Show();
            this.Close();
        }
    }
}
