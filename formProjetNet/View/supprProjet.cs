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
    public partial class SupprProjet : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");

        public List<int> listExigence = new List<int>();
        public SupprProjet()
        {
            InitializeComponent();
        }

        private void SupprProjet_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.database1DataSet.projet);

        }

        private void deleteProjet_Click(object sender, EventArgs e)
        {
            int idProjet = (int)listProjet.SelectedValue;

            string queryExigence = "SELECT * FROM exigence WHERE idProjet = " + idProjet;
            SqlCommand cmdExigence = new SqlCommand(queryExigence, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderExigence = cmdExigence.ExecuteReader();
                while (ReaderExigence.Read()) { 
                    listExigence.Add(ReaderExigence.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("liste exigence" + ex.Message);
            }
            bdd.Close();


            foreach (int exigence in listExigence)
            {
                string queryDeleteTacheExigence = "DELETE FROM tacheExigence WHERE idExigence = " + exigence;
                SqlCommand cmdDeleteTacheExigence = new SqlCommand(queryDeleteTacheExigence, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader ReaderDeleteTacheExigence = cmdDeleteTacheExigence.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("delete tache exigence" + ex.Message);
                }
                bdd.Close();
            }

            string queryDeleteTache = "DELETE FROM tache WHERE idProjet = " + idProjet;
            SqlCommand cmdDeleteTache = new SqlCommand(queryDeleteTache, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderDeleteTache = cmdDeleteTache.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("delete tache" + ex.Message);
            }
            bdd.Close();

            string queryDeleteExigence = "DELETE FROM exigence WHERE idProjet = " + idProjet;
            SqlCommand cmdDeleteExigence = new SqlCommand(queryDeleteExigence, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderDeleteExigence = cmdDeleteExigence.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("delete exigence " + ex.Message);
            }
            bdd.Close();


            string queryDeleteJalon = "DELETE FROM jalon2 WHERE idProjet = " + idProjet;
            SqlCommand cmdDeleteJalon = new SqlCommand(queryDeleteJalon, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderDeleteJalon = cmdDeleteJalon.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("delete jalon" + ex.Message);
            }
            bdd.Close();

            string queryDeleteProjet = "DELETE FROM projet WHERE idProjet = " + idProjet;
            SqlCommand cmdDeleteProjet = new SqlCommand(queryDeleteProjet, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderDeleteProjet = cmdDeleteProjet.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("delete projet " + ex.Message);
            }
            bdd.Close();

            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(accueil));
            monthread.Start();
            this.Close();
        }

        public static void accueil()
        {
            Application.Run(new Accueil());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(accueil));
            monthread.Start();
            this.Close();
        }
    }
}
