using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MgmtSpitalWF
{
    public partial class ModulPrincipal : Form
    {
        public ModulPrincipal()
        {
            InitializeComponent();
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ieșire Aplicație?", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
