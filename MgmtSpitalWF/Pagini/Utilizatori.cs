using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MgmtSpitalWF.Pagini
{
    public partial class Utilizatori : Form
    {
        public Utilizatori()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Module.ModulUtilizator module = new Module.ModulUtilizator(this);
            module.ShowDialog();
        }
    }
}
