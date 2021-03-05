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
    public partial class SupprExigence : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");


        public SupprExigence()
        {
            InitializeComponent();
        }

        private void SupprExigence_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.exigence'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.exigenceTableAdapter.Fill(this.database1DataSet.exigence);

        }

        private void deleteProjet_Click(object sender, EventArgs e)
        {

            string queryDeleteTacheExigence = "DELETE FROM tacheExigence WHERE idExigence = " + (int)listExigence.SelectedValue;
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

            string queryDeleteTache = "DELETE FROM exigence WHERE idExigence = " + (int)listExigence.SelectedValue;
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(accueil));
            monthread.Start();
            this.Close();
        }
    }
}
