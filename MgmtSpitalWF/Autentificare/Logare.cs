using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MgmtSpitalWF.Autentificare
{
    public partial class Logare : Form
    {

        SqlCommand cm = new SqlCommand();
        BazaDeDate dbcon = new BazaDeDate();
        SqlDataReader dr;
        string title = "MgmtSpitalWF";

        public Logare()
        {
            InitializeComponent();
        }




        private void btnAnulare_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool pass = true;
        private void txtParola_TrailingIconClick(object sender, EventArgs e)
        {
            if (pass)
            {
                txtParola.TrailingIcon = Properties.Resources.eye_20px;
                txtParola.Password = false;
                pass = false;
            }

            else
            {
                txtParola.TrailingIcon = Properties.Resources.hide_20px;
                txtParola.Password = true;
                pass = true;
            }

        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT nume FROM tbUtilizatori WHERE email='" + txtEmail.Text + " ' AND parola ='" + txtParola.Text + "'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Bun venit, " + dr["nume"].ToString() + "!", "ACCESS PERMIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ModulPrincipal main = new ModulPrincipal();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Email sau parolă invalidă", "ACCESS RESPINS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dbcon.close();
                dr.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }
    }
 }

