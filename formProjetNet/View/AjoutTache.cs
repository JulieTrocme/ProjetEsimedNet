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
    public partial class AjoutTache : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");
        public int idTache;
        public int idExigence;

        public int idTachePrece;
        public AjoutTache()
        {
            InitializeComponent();
        }

        private void AjoutTache_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.database1DataSet.projet);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.tache'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tacheTableAdapter.Fill(this.database1DataSet.tache);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.database1DataSet.utilisateur);
            user.Text = "<-- Selectionner un utilisateur -->";
            projet.Text = "<-- Selectionner la spécialité de cette exigence -->";
            tachePrec.Text = "<-- Selectionner la tâche précédente si elle en possède -->";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(libelle.Text != "" && descOpe.Text != "" && nbJours.Value > 0 && user.Text != "<-- Selectionner un utilisateur -->" && projet.Text != "<-- Selectionner la spécialité de cette exigence -->")
            {
                string queryInsert = "";
                
                if (tachePrec.SelectedIndex != -1 && tachePrec.Text != "<-- Selectionner la tâche précédente si elle en possède -->")
                {

                    //Recuperer l'id de la tache precedente
                    string queryTache = "SELECT * FROM tache WHERE libelle = '" +  tachePrec.Text+"'";
                    SqlCommand cmdTache = new SqlCommand(queryTache, bdd);
                    try
                    {
                        bdd.Open();
                        SqlDataReader ReaderTache = cmdTache.ExecuteReader();
                        while (ReaderTache.Read())
                        {
                            idTachePrece = ReaderTache.GetInt32(0);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("liste exigence" + ex.Message);
                    }
                    bdd.Close();

                    queryInsert = "insert into tache values('" + libelle.Text + "','" + descOpe.Text + "'," + (int)user.SelectedValue + ",'" + dateDebutTheo.Value.Date + "'," + nbJours.Value + "," + idTachePrece + "," + (int)projet.SelectedValue + ",null)";
                } else
                {
                     queryInsert = "insert into tache values('" + libelle.Text + "','" + descOpe.Text + "'," + (int)user.SelectedValue + ",'" + dateDebutTheo.Value.Date + "'," + nbJours.Value + ",null," + (int)projet.SelectedValue + ",null)";
                }
                SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdInsert.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ajout tache1" + ex.Message);
                }
                bdd.Close();
                associationTacheExigence();
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirJalon));
                monthread.Start();
                this.Close();
            }
            else
            {

                MessageBox.Show("Merci de remplir tous les champs");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (libelle.Text != "" && descOpe.Text != "" && nbJours.Value > 0 && user.Text != "<-- Selectionner un utilisateur -->" && projet.Text != "<-- Selectionner la spécialité de cette exigence -->")
            {
                string queryInsert = "";

                if (tachePrec.SelectedIndex != -1 && tachePrec.Text != "<-- Selectionner la tâche précédente si elle en possède -->")
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
                            idTachePrece = ReaderTache.GetInt32(0);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("liste exigence" + ex.Message);
                    }
                    bdd.Close();

                    queryInsert = "insert into tache values('" + libelle.Text + "','" + descOpe.Text + "'," + (int)user.SelectedValue + ",'" + dateDebutTheo.Value.Date + "'," + nbJours.Value + "," + idTachePrece + "," + (int)projet.SelectedValue + ",null)";
                }
                else
                {
                    queryInsert = "insert into tache values('" + libelle.Text + "','" + descOpe.Text + "'," + (int)user.SelectedValue + ",'" + dateDebutTheo.Value.Date + "'," + nbJours.Value + ",null," + (int)projet.SelectedValue + ",null)";
                }
                SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdInsert.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ajout tache1" + ex.Message);
                }
                bdd.Close();
                associationTacheExigence();
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouvelTache));
                monthread.Start();
                this.Close();
            }
            else
            {

                MessageBox.Show("Merci de remplir tous les champs");
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouvelExigence));
            monthread.Start();
            this.Close();
        }

        public static void ouvrirJalon()
        {
            Application.Run(new AjoutJalon());
        }

        public static void nouvelTache()
        {
            Application.Run(new AjoutTache());
        }
        public static void nouvelExigence()
        {
            Application.Run(new AjoutExigence());
        }


        private void projet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(projet.SelectedIndex != -1)
            {
                listExigence.Items.Clear();
                string query = "select besoin from exigence where idProjet = " + (int)projet.SelectedValue;
                if (query != null)
                {
                    SqlCommand cmd = new SqlCommand(query, bdd);
                    try
                    {
                        bdd.Open();
                        SqlDataReader Reader = cmd.ExecuteReader();

                        while (Reader.Read())
                        {
                            listExigence.Items.Add(Reader.GetValue(0).ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ajout tache" + ex.Message);
                    }
                    bdd.Close();
                }

                //Affiche la liste des taches
                tachePrec.Items.Clear();
                string queryTache = "SELECT * FROM tache WHERE idProjet = " + (int)projet.SelectedValue;
                SqlCommand cmdTache = new SqlCommand(queryTache, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader ReaderTache = cmdTache.ExecuteReader();
                    while (ReaderTache.Read())
                    {
                        tachePrec.Items.Add(ReaderTache.GetValue(1).ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("liste tache " + ex.Message);
                }
                bdd.Close();
            }
           
            
            
            
        }

        public void associationTacheExigence()
        {
            //L'id de la tache inséré
            string queryLadtInsert = "select MAX(idTache) from tache where idProjet ="+ (int)projet.SelectedValue;
            SqlCommand cmdLastInsertId = new SqlCommand(queryLadtInsert, bdd);
            bdd.Open();
            SqlDataReader ReaderLastInsertId = cmdLastInsertId.ExecuteReader();

            while (ReaderLastInsertId.Read())
            {
                 idTache = ReaderLastInsertId.GetInt32(0);
            }
            bdd.Close();
            if (listExigence.SelectedItems.Count > 0)
            {
                foreach(object exigence in listExigence.CheckedItems)
                {
                    //MessageBox.Show(exigence.ToString());
                    string query = "select IdExigence from exigence where idProjet = " + (int)projet.SelectedValue + " and besoin ='"+ exigence.ToString()+"'";
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
                            MessageBox.Show("ajout exigence dans tache " + ex.Message);
                        }
                        bdd.Close();
                        //MessageBox.Show(Reader.GetValue(0).ToString());
                        string queryInsertExigence = "insert into tacheExigence values(" + idTache + "," + idExigence + ")";
                        SqlCommand cmdInsertExigence = new SqlCommand(queryInsertExigence, bdd);
                        try
                        {
                            bdd.Open();
                            SqlDataReader ReaderExigence = cmdInsertExigence.ExecuteReader();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ajout tache" + ex.Message);
                        }
                        bdd.Close();
                    }
                }
            }
        }

        private void listExigence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (libelle.Text != "" && descOpe.Text != "" && nbJours.Value > 0 && user.Text != "<-- Selectionner un utilisateur -->" && projet.Text != "<-- Selectionner la spécialité de cette exigence -->")
            {
                string queryInsert = "";

                if (tachePrec.SelectedIndex != -1 && tachePrec.Text != "<-- Selectionner la tâche précédente si elle en possède -->")
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
                            idTachePrece = ReaderTache.GetInt32(0);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("liste exigence" + ex.Message);
                    }
                    bdd.Close();

                    queryInsert = "insert into tache values('" + libelle.Text + "','" + descOpe.Text + "'," + (int)user.SelectedValue + ",'" + dateDebutTheo.Value.Date + "'," + nbJours.Value + "," + idTachePrece + "," + (int)projet.SelectedValue + ",null)";
                }
                else
                {
                    queryInsert = "insert into tache values('" + libelle.Text + "','" + descOpe.Text + "'," + (int)user.SelectedValue + ",'" + dateDebutTheo.Value.Date + "'," + nbJours.Value + ",null," + (int)projet.SelectedValue + ",null)";
                }
                SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdInsert.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ajout tache1" + ex.Message);
                }
                bdd.Close();
                associationTacheExigence();
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(accueil));
                monthread.Start();
                this.Close();
            }
            else
            {

                MessageBox.Show("Merci de remplir tous les champs");
            }
        }

        public static void accueil()
        {
            Application.Run(new Accueil());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(accueil));
            monthread.Start();
            this.Close();
        }

       
    }
}
