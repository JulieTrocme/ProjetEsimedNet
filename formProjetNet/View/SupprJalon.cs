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
    public partial class SupprJalon : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");

        public SupprJalon()
        {
            InitializeComponent();
        }

        private void SupprJalon_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Jalon2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.jalon2TableAdapter.Fill(this.database1DataSet.Jalon2);

        }

        private void deleteProjet_Click(object sender, EventArgs e)
        {

            string queryUpdateTache = "UPDATE tache SET idJalon = null WHERE idJalon = " + (int)listJalon.SelectedValue;
            SqlCommand cmdUpdateTache = new SqlCommand(queryUpdateTache, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderUpdateTache = cmdUpdateTache.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("upd tache" + ex.Message);
            }
            bdd.Close();

            string queryDeleteJalon = "DELETE FROM jalon2 WHERE idJalon = " + (int)listJalon.SelectedValue;
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
