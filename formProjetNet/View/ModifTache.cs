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
    public partial class ModifTache : Form
    {

        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");

        public string nomTache;
        public int idProjet;
        public int idUser;
        public int idTache;
        public int idTachePrec;
        public int idJalon;
        public int idExigence;
        

        List<string> listNomExigenceTache = new List<string>();


        public ModifTache()
        {
            InitializeComponent();
        }

        private void ModifTache_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.database1DataSet.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Jalon2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.jalon2TableAdapter.Fill(this.database1DataSet.Jalon2);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.database1DataSet.projet);

            //Affiche la tache
            string queryTache = "SELECT * FROM tache t LEFT JOIN tache t2 ON t2.idTache = t.tacheprecedente WHERE t.libelle = '" + nomTache + "'";
            SqlCommand cmdTache = new SqlCommand(queryTache, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderTache = cmdTache.ExecuteReader();
                while (ReaderTache.Read())
                {
                    idTache = ReaderTache.GetInt32(0);
                    libelle.Text = ReaderTache.GetValue(1).ToString();
                    descOpe.Text = ReaderTache.GetValue(2).ToString();
                    idUser = ReaderTache.GetInt32(3);
                    dateDebutTheo.Value = ReaderTache.GetDateTime(4);
                    nbJours.Value = ReaderTache.GetInt32(5);
                    idProjet = ReaderTache.GetInt32(7);
                    idJalon = ReaderTache.GetInt32(8);
                    tachePrec.Text = ReaderTache.GetValue(10).ToString();

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("tache " + ex.Message);
            }
            bdd.Close();
            //Affiche l'utilisateur
            string queryUser = "SELECT nomUser FROM utilisateur WHERE idUser = " + idUser;
            SqlCommand cmdUser = new SqlCommand(queryUser, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderUser = cmdUser.ExecuteReader();
                while (ReaderUser.Read())
                {
                    user.Text = ReaderUser.GetValue(0).ToString();
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Donnée user" + ex.Message);
            }
            bdd.Close();

            //Affiche le nom du projet
            string queryProjet = "SELECT nomProjet FROM projet WHERE idProjet = " + idProjet;
            SqlCommand cmdProjet = new SqlCommand(queryProjet, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderProjet = cmdProjet.ExecuteReader();
                while (ReaderProjet.Read())
                {
                    projet.Text = ReaderProjet.GetValue(0).ToString();
                }


            }
            catch (Exception ex)
            {
               // MessageBox.Show("Donnée projet" + ex.Message);
            }
            bdd.Close();

            //Affiche la liste des taches
            string queryPrece = "SELECT * FROM tache WHERE idTache != "+ idTache +" and idProjet = " + idProjet;
            SqlCommand cmdPrece = new SqlCommand(queryPrece, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderPrece = cmdPrece.ExecuteReader();
                while (ReaderPrece.Read())
                {
                    tachePrec.Items.Add(ReaderPrece.GetValue(1).ToString());
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Donnée tache prece" + ex.Message);
            }
            bdd.Close();

            //Affiche la liste des jalon
            string queryListeJalon = "SELECT * FROM jalon2 WHERE idProjet = " + idProjet;
            SqlCommand cmdListeJalon = new SqlCommand(queryListeJalon, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderListeJalon = cmdListeJalon.ExecuteReader();
                while (ReaderListeJalon.Read())
                {
                    jalon1.Items.Add(ReaderListeJalon.GetValue(1).ToString());
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Donnée tache prece" + ex.Message);
            }
            bdd.Close();

            //Affiche le nom du jalon
            string queryJalon = "SELECT * FROM jalon2 WHERE idJalon = " + idJalon;
            SqlCommand cmdJalon = new SqlCommand(queryJalon, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderJalon = cmdJalon.ExecuteReader();
                while (ReaderJalon.Read())
                {
                    jalon1.Text = ReaderJalon.GetValue(1).ToString();
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Donnée jalon" + ex.Message);
            }
            bdd.Close();

            //Liste des exigences de la tache
            string queryExigenceTache = "SELECT * FROM tacheExigence te JOIN exigence e ON te.idExigence=e.idExigence WHERE idTache = " + idTache;
            SqlCommand cmdExigenceTache = new SqlCommand(queryExigenceTache, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderExigenceTache = cmdExigenceTache.ExecuteReader();
                while (ReaderExigenceTache.Read())
                {
                    listNomExigenceTache.Add(ReaderExigenceTache.GetValue(3).ToString());
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Donnée jalon" + ex.Message);
            }
            bdd.Close();

            string query = "select * from exigence where idProjet = " + idProjet;
            if (query != null)
            {
                SqlCommand cmd = new SqlCommand(query, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        listExigence.Items.Add(Reader.GetValue(1).ToString());

                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ajout tache" + ex.Message);
                }
                bdd.Close();
            }

            foreach (string exigence in listNomExigenceTache)
            {
                for (int i = 0; i < listExigence.Items.Count; i++)
                {
               
                    //MessageBox.Show(listExigence.Items[i].ToString());
                    if(listExigence.GetItemText(listExigence.Items[i]) == exigence)
                    {
                        listExigence.SetItemChecked(i, true);
                    }
                }
            }
            



        }

        private void projet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projet.SelectedIndex != -1)
            {
                listExigence.Items.Clear();
                string query = "select * from exigence where idProjet = " + (int)projet.SelectedValue;
                if (query != null)
                {
                    SqlCommand cmd = new SqlCommand(query, bdd);
                    try
                    {
                        bdd.Open();
                        SqlDataReader Reader = cmd.ExecuteReader();

                        while (Reader.Read())
                        {
                            listExigence.Items.Add(Reader.GetValue(1).ToString());
                            
                            listExigence.SetItemChecked(1, true);
                        }

                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("ajout tache" + ex.Message);
                    }
                    bdd.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (libelle.Text != "" && descOpe.Text != "" && nbJours.Value > 0)
            {
                //Recuperer l'id de la tache precedente
                string queryTache = "SELECT * FROM tache WHERE libelle = '" + tachePrec.Text + "'";
                SqlCommand cmdTache = new SqlCommand(queryTache, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader ReaderTache = cmdTache.ExecuteReader();
                    while (ReaderTache.Read())
                    {
                        idTachePrec = ReaderTache.GetInt32(0);
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Tache precedent " + ex.Message);
                }
                bdd.Close();

                //Recuperer l'id new id jalon
                string queryJalon = "SELECT * FROM jalon2 WHERE libelle = '" + jalon1.Text + "'";
                SqlCommand cmdJalon = new SqlCommand(queryJalon, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader ReaderJalon = cmdJalon.ExecuteReader();
                    while (ReaderJalon.Read())
                    {
                        idJalon = ReaderJalon.GetInt32(0);
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("new jalon " + ex.Message);
                }
                bdd.Close();

                //Recuperer l'id de la tache precedente
                string queryTachePrec = "SELECT * FROM tache WHERE libelle = '" + tachePrec.Text + "'";
                SqlCommand cmdTachePrec = new SqlCommand(queryTachePrec, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader ReaderTachePrec = cmdTachePrec.ExecuteReader();
                    while (ReaderTachePrec.Read())
                    {
                        idTachePrec = ReaderTachePrec.GetInt32(0);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tache precedent " + ex.Message);
                }
                bdd.Close();


                string queryUpdate = "";
                if (tachePrec.Text != "") {
                    queryUpdate = "UPDATE tache SET libelle = '" + libelle.Text + "', descOperation = '" + descOpe.Text + "',utilisateur = " + (int)user.SelectedValue + ",dateDebutTheo = '" + dateDebutTheo.Value.Date + "', nbJours = " + nbJours.Value + ",tachePrecedente = "+ idTachePrec +" ,idProjet = " + (int)projet.SelectedValue + ",idJalon = "+ idJalon +"WHERE idTache = "+idTache;
                }   else
                {
                    queryUpdate = "UPDATE tache SET libelle = '" + libelle.Text + "', descOperation = '" + descOpe.Text + "',utilisateur = " + (int)user.SelectedValue + ",dateDebutTheo = '" + dateDebutTheo.Value.Date + "', nbJours = " + nbJours.Value + ",tachePrecedente = null ,idProjet = " + (int)projet.SelectedValue + ",idJalon = " + idJalon + "WHERE idTache = " + idTache;
                }           
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdUpdate.ExecuteReader();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ajout tache1" + ex.Message);
                }
                bdd.Close();
                associationTacheExigence();
                

            }
            else
            {

                MessageBox.Show("Merci de remplir tous les champs");
            }
            this.Close();
        }

        public void associationTacheExigence()
        {
            
            if (listExigence.SelectedItems.Count > 0)
            {
                //On delete d'abord ce qui a avant d'ajouter
                string queryDelete = "DELETE FROM tacheExigence WHERE idTache =" + idTache;
                SqlCommand cmdDelete = new SqlCommand(queryDelete, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader ReaderDelete = cmdDelete.ExecuteReader();

                }
                catch (Exception ex)
                {
                   // MessageBox.Show("Delete exigence tache " + ex.Message);
                }
                bdd.Close();
                foreach (object exigenceChecked in listExigence.CheckedItems)
                {
                    //MessageBox.Show(exigence.ToString());
                    string query = "select IdExigence from exigence where idProjet = " + (int)projet.SelectedValue + " and besoin ='" + exigenceChecked.ToString() + "'";
                    if (query != null)
                    {
                        SqlCommand cmd = new SqlCommand(query, bdd);
                        try
                        {
                            bdd.Open();
                            SqlDataReader Reader = cmd.ExecuteReader();

                            while (Reader.Read())
                            {
                                idExigence = Reader.GetInt32(0);

                            }

                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("ajout exigence dans tache " + ex.Message);
                        }
                        bdd.Close();

                        

                        //On ajoute
                        string queryInsertExigence = "insert into tacheExigence values(" + idTache + "," + idExigence + ")";
                        SqlCommand cmdInsertExigence = new SqlCommand(queryInsertExigence, bdd);
                        try
                        {
                            bdd.Open();
                            SqlDataReader ReaderExigence = cmdInsertExigence.ExecuteReader();

                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("ajout tache" + ex.Message);
                        }
                        bdd.Close();
                    }
                }
            }
        }
    }
}
