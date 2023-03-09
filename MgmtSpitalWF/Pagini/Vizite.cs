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
    public partial class Vizite : Form
    {
        SqlCommand cm = new SqlCommand();
        BazaDeDate dbcon = new BazaDeDate();
        SqlDataReader dr;
        string title = "MgmtSpitalWF";

        public Vizite()
        {
            InitializeComponent();
            loadVisits();
            doctorList();
            cbDoctor.SelectedIndex = 0;
            dtFrom.Value = DateTime.Now.AddDays(-7);
        }

        public void doctorList()
        {
            cbDoctor.Items.Add("Doctor (All)");
            cm = new SqlCommand("SELECT * FROM tbDoctors", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbDoctor.Items.Add(dr["nume"]);
            }
            dbcon.close();
        }
        #region method
        public void loadVisits()
        {
            string sql = "";
            string doctor = cbDoctor.Text;
            if (doctor == "Doctor (All)")
                sql = "SELECT v.id, reason, date, pid, P.name, did, D.name, weight, temperature, systolic, diastolic FROM tbVisits AS V JOIN tbDoctors AS D ON v.did = d.id JOIN tbPatients AS P ON v.pid = p.id WHERE CONCAT(reason, p.name) LIKE '%" + txtSearch.Text + "%'AND date BETWEEN '" + dtFrom.Value + "' AND '" + dtTo.Value + "'";
            else sql = "SELECT v.id, reason, date, pid, p.name, did, d.name, weight, temperature, systolic, diastolic FROM tbVisits AS V JOIN tbDoctors AS D ON v.did = d.id JOIN tbPatients AS P ON v.pid = p.id WHERE CONCAT(reason,p.name) LIKE '%" + txtSearch.Text + "%'and d.name='" + doctor + "'" +
                    " AND date BETWEEN '" + dtFrom.Value + "' AND '" + dtTo.Value + "'";
            try
            {
                int i = 0;
                dgvVisits.Rows.Clear();
                cm = new SqlCommand(sql, dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // to add data to the datagridview from the database
                    dgvVisits.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        #endregion method

        private void dgvVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvVisits.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                //to to sent doctor data to the module 
                Module.ModulProgramari module = new Module.ModulProgramari();
                module.(dgvVisits.Rows[e.RowIndex].Cells[1].Value.ToString());
                module.ShowDialog();
            }
            else if (colName == "Pacient")
            {
                //to to sent doctor data to the module 
                Module.ModulPacient module = new Module.ModulProgramari(new Pagini.Pacienti());
                module.loadPacienti(dgvVisits.Rows[e.RowIndex].Cells[4].Value.ToString());
                module.View();
                module.ShowDialog();
            }
            else if (colName == "Doctor")
            {
                //to to sent doctor data to the module 
                Module.ModulDoctor module = new Module.ModulDoctor(new Pagini.Doctori());
                module.loadDoctor(dgvVisits.Rows[e.RowIndex].Cells[6].Value.ToString());
                module.View();
                module.ShowDialog();
            }
            else if (colName == "Delete") // if you want to delete the record to click the delete icon on the datagridview
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM tbVisits WHERE id LIKE'" + dgvVisits.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Record has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadVisits();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
        }

        private void dgvVisits_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dgvVisits.Columns[e.ColumnIndex].Name;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            loadVisits();
        }
    }
}
