using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

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
                this.Dispose();
                Application.Restart();
            }
        }


        // Creare funcție pentru panelChild

        private Form activeForm = null; 
        
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnVisit.Width;
            panelSlide.Left = btnVisit.Left;
            openChildForm(new Pagini.Vizite());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnUsers.Width;
            panelSlide.Left = btnUsers.Left;
            openChildForm(new Pagini.Utilizatori());
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnUsers.Width;
            panelSlide.Left = btnUsers.Left;
            openChildForm(new Pagini.Dashboard());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnUsers.Width;
            panelSlide.Left = btnUsers.Left;
            openChildForm(new Pagini.Pacienti());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnUsers.Width;
            panelSlide.Left = btnUsers.Left;
            openChildForm(new Pagini.Doctori());
        }

        private void btnSpital_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnSpital.Width;
            panelSlide.Left = btnSpital.Left;
            Module.ModulSpital module = new Module.ModulSpital();
            module.ShowDialog();
        }
    }
}
