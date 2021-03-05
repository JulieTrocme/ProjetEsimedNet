using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProjetNet.View
{

    public partial class ModifExigence : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");

        public string nomExigence;
        public int idProjet;
        public int idExigence;
        public ModifExigence()
        {
            InitializeComponent();
        }

        private void ModifExigence_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.database1DataSet.projet);
            specExigence.Items.Add("Sur les données");
            specExigence.Items.Add("Sur les performances");
            specExigence.Items.Add("Sur les interfaces utilisateur");
            specExigence.Items.Add("Sur la qualité");
            specExigence.Items.Add("Sur les services");
            //Affiche l'exigence
            string queryExigence = "SELECT * FROM exigence WHERE besoin = '" + nomExigence+"'";
            SqlCommand cmdExigence = new SqlCommand(queryExigence, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderExigence = cmdExigence.ExecuteReader();
                while (ReaderExigence.Read())
                {
                    besoin.Text = ReaderExigence.GetValue(1).ToString();
                    idProjet = ReaderExigence.GetInt32(4);
                    idExigence = ReaderExigence.GetInt32(0);
                    if (ReaderExigence.GetValue(2).ToString() == "Fonctionnel")
                    {
                        fonctRadio.Checked = true;

                    } else
                    {
                        nonFonctRadio.Checked = true;
                        specExigence.Visible = true;
                        specExigence.Text = ReaderExigence.GetValue(3).ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("exigence " + ex.Message);
            }
            bdd.Close();
            //Affiche nom projet
            string queryProjet = "SELECT * FROM projet WHERE idProjet = " + idProjet;
            SqlCommand cmdProjet = new SqlCommand(queryProjet, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderProjet = cmdProjet.ExecuteReader();
                while (ReaderProjet.Read())
                {
                    projetSelect.Text = ReaderProjet.GetValue(1).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("liste exigence" + ex.Message);
            }
            bdd.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (besoin.Text != "" && fonctRadio.Checked == true)
            {
                string queryUpdate = "UPDATE Exigence SET besoin = '"+besoin.Text+"',type = '"+fonctRadio.Text+ "',specification = null, idProjet =" + (int)projetSelect.SelectedValue + "WHERE idExigence = " + idExigence;
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdUpdate.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update projet" + ex.Message);
                }
                bdd.Close();
                this.Close();
            } else if (besoin.Text != "" && nonFonctRadio.Checked == true)
            {
                string queryUpdate = "UPDATE Exigence SET besoin = '" + besoin.Text + "',type = '" + nonFonctRadio.Text + "',specification = '"+ specExigence.Text + "', idProjet =" + (int)projetSelect.SelectedValue + "WHERE idExigence = " + idExigence;
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdUpdate.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update projet" + ex.Message);
                }
                bdd.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Merci de remplir tout les champs");
            }
        }

        private void fonctRadio_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            specExigence.Visible = false;

            this.Update();
        }

        private void nonFonctRadio_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            specExigence.Visible = true;

            this.Update();
        }
    }
}
