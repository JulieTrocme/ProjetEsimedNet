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
    public partial class SupprTache : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");

        public SupprTache()
        {
            InitializeComponent();
        }

        private void SupprTache_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.tache'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tacheTableAdapter.Fill(this.database1DataSet.tache);

        }

        private void deleteProjet_Click(object sender, EventArgs e)
        {

            string queryDeleteTacheExigence = "DELETE FROM tacheExigence WHERE idTache = " + (int)listTache.SelectedValue;
            SqlCommand cmdDeleteTacheExigence = new SqlCommand(queryDeleteTacheExigence, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderDeleteTacheExigence = cmdDeleteTacheExigence.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("delete tache Exigence " + ex.Message);
            }
            bdd.Close();

            string queryDeleteTache = "DELETE FROM tache WHERE idTache = " + (int)listTache.SelectedValue;
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

            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(accueil));
            monthread.Start();
            this.Close();
        }

        public static void accueil()
        {
            Application.Run(new Accueil());
        }
    }
}
