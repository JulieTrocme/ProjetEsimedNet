using formProjetNet.View;
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
    public partial class ModifJalon : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");
        public string nomJalon;
        public int idJalon;
        public int idProjet;
        public int idUser;
        public int idTache;

        List<string> listNomTache = new List<string>();
        public ModifJalon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.database1DataSet.projet);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.database1DataSet.utilisateur);

            //Affiche les données du jalon 
            string queryJalon = "SELECT * FROM jalon2 WHERE libelle = '" + nomJalon + "'";
            SqlCommand cmdJalon = new SqlCommand(queryJalon, bdd);
            try
            {
                bdd.Open();
                SqlDataReader Reader = cmdJalon.ExecuteReader();
                while (Reader.Read())
                {
                    idJalon = Reader.GetInt32(0);
                    libelle.Text = Reader.GetValue(1).ToString();
                    idUser = Reader.GetInt32(2);
                    dateLivrPrevu.Text = Reader.GetDateTime(3).ToString("dd-MM-yyyy");
                    idProjet = Reader.GetInt32(5);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Donnée jalon" + ex.Message);
            }
            bdd.Close();

            //Affiche les données du responsable 
            string queryUser = "SELECT * FROM utilisateur WHERE idUser = " + idUser;
            SqlCommand cmdUser = new SqlCommand(queryUser, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderUser = cmdUser.ExecuteReader();
                while (ReaderUser.Read())
                {
                    responsable.Text = ReaderUser.GetValue(1).ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Donnée responsable " + ex.Message);
            }
            bdd.Close();

            //Affiche les données du projet 
            string queryProjet = "SELECT * FROM projet WHERE idProjet = " + idProjet;
            SqlCommand cmdProjet = new SqlCommand(queryProjet, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderProjet = cmdProjet.ExecuteReader();
                while (ReaderProjet.Read())
                {
                    projet.Text = ReaderProjet.GetValue(1).ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Donnée projet" + ex.Message);
            }
            bdd.Close();


            //Liste des taches du jalon
            string queryExigenceTache = "SELECT * FROM tache WHERE idJalon = " + idJalon;
            SqlCommand cmdExigenceTache = new SqlCommand(queryExigenceTache, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderExigenceTache = cmdExigenceTache.ExecuteReader();
                while (ReaderExigenceTache.Read())
                {
                    listNomTache.Add(ReaderExigenceTache.GetValue(1).ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Donnée tache" + ex.Message);
            }
            bdd.Close();


            //On ajout toute les taches dans la listeBox
            string query = "select * from tache where idProjet = " + idProjet;
            if (query != null)
            {
                SqlCommand cmd = new SqlCommand(query, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        listTache.Items.Add(Reader.GetValue(1).ToString());

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ajout tache" + ex.Message);
                }
                bdd.Close();
            }

            foreach (string exigence in listNomTache)
            {
                for (int i = 0; i < listTache.Items.Count; i++)
                {

                    //MessageBox.Show(listExigence.Items[i].ToString());
                    if (listTache.GetItemText(listTache.Items[i]) == exigence)
                    {
                        listTache.SetItemChecked(i, true);
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (libelle.Text != "" )
            {
               
                

                string queryUpdate = "UPDATE Jalon2 SET libelle = '" + libelle.Text +"',utilisateur = " + (int)responsable.SelectedValue + ",dateLivrPrevu = '" + dateLivrPrevu.Value.Date + "', dateLivrReel = '" + dateLivrReel.Value.Date + "',idProjet = " + (int)projet.SelectedValue + "WHERE idJalon = " + idJalon;

                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdUpdate.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("update jalon " + ex.Message);
                }
                bdd.Close();


            }
            else
            {

                MessageBox.Show("Merci de remplir tous les champs");
            }
            modifTache();
            this.Close();
        }


        public void modifTache()
        {

            if (listTache.SelectedItems.Count > 0)
            {
                //On update les taches
                string queryUpdateTacheJalon = "UPDATE tache SET idJalon = null WHERE idJalon = " + idJalon;
                SqlCommand cmdUpdateTacheJalon = new SqlCommand(queryUpdateTacheJalon, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader ReaderUpdateTacheJalon = cmdUpdateTacheJalon.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("delete jalon de tache " + ex.Message);
                }
                bdd.Close();

                foreach (object tacheChecked in listTache.CheckedItems)
                {
                    //MessageBox.Show(exigence.ToString());
                    string query = "select IdTache from tache where idProjet = " + (int)projet.SelectedValue + " and libelle ='" + tacheChecked.ToString() + "'";
                    if (query != null)
                    {
                        SqlCommand cmd = new SqlCommand(query, bdd);
                        try
                        {
                            bdd.Open();
                            SqlDataReader Reader = cmd.ExecuteReader();

                            while (Reader.Read())
                            {
                                idTache = Reader.GetInt32(0);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("recherche id tache " + ex.Message);
                        }
                        bdd.Close();



                        //On update la tache
                        string queryUpdateTache = "UPDATE tache SET idJalon = " + idJalon + "WHERE idTache = "+ idTache;
                        SqlCommand cmdUpdateTache = new SqlCommand(queryUpdateTache, bdd);
                        try
                        {
                            bdd.Open();
                            SqlDataReader ReaderUpdateTache = cmdUpdateTache.ExecuteReader();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("update tache " + ex.Message);
                        }
                        bdd.Close();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
