using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MgmtSpitalWF.Module
{
    public partial class ModulSpital : Form
    {
        public ModulSpital()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            picLogo.Image = null;
            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtPhone.Clear();
            dtCreate.Value = DateTime.Now;
        }
    }
}
