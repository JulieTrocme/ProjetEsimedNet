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

namespace formProjetNet
{
    public partial class Accueil : Form
    {
       
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");
        public int idJalon;
        public int idTache;
        public int idUser;
        ModifProjet modifProjet = new ModifProjet();
        public Accueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.database1DataSet.projet);
            projet.Text = "<-- Selectionner le projet -->";

        }

        private void projet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(projet.SelectedIndex != -1) {

                //Affiche les données du projet 
                string queryProjet = "SELECT * FROM projet WHERE idprojet = " + (int)projet.SelectedValue;
                SqlCommand cmdProjet = new SqlCommand(queryProjet, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdProjet.ExecuteReader();
                    while (Reader.Read())
                    {
                        nomProjet.Text = Reader.GetValue(1).ToString();
                        dateDebutProjet.Text = Reader.GetDateTime(3).ToString("MM-dd-yyyy");
                        dateFinProjet.Text = Reader.GetDateTime(4).ToString("MM-dd-yyyy");
                        idUser = Reader.GetInt32(2);
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Donnée projet" + ex.Message);
                }
                bdd.Close();

                //Affiche le chef de projet 
                string queryUser = "SELECT * FROM utilisateur WHERE idUser = " + idUser;
                SqlCommand cmdUser = new SqlCommand(queryUser, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader ReaderUser = cmdUser.ExecuteReader();
                    while (ReaderUser.Read())
                    {
                        ChefProjet.Text = ReaderUser.GetValue(1).ToString();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Donnée projet" + ex.Message);
                }
                bdd.Close();

                //Affiche la liste des exigences
                string queryExigence = "SELECT besoin,type,specification,nomProjet FROM exigence e LEFT JOIN projet p ON e.idProjet = p.idProjet  WHERE e.idProjet = " + (int)projet.SelectedValue;
                SqlCommand cmdExigence = new SqlCommand(queryExigence, bdd);
                try
                {
                    bdd.Open();
                    SqlDataAdapter sqlDataAdapteurExigence = new SqlDataAdapter(cmdExigence);
                    DataTable dataTableExigence = new DataTable();
                    sqlDataAdapteurExigence.Fill(dataTableExigence);
                    
                    listExigence.DataSource = dataTableExigence;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("liste exigence" + ex.Message);
                }
                bdd.Close();

                //Affiche la liste des taches 
                string queryTache = "SELECT t.libelle as NomTâche, t.descOperation as Description, u.nomUser as Utilisateur,t.dateDebutTheo as DateDébutThéorique,t.nbJours as Durée,t2.libelle as TâchePrécédente,p.nomProjet,j.libelle AS Jalon FROM tache t JOIN projet p ON t.idProjet = p.idProjet LEFT JOIN jalon2 j ON j.idJalon=t.idJalon JOIN utilisateur u ON idUser = t.utilisateur LEFT JOIN tache t2 ON t2.idTache = t.tachePrecedente WHERE t.idprojet = " + (int)projet.SelectedValue+"ORDER BY t.idTache DESC ";
                SqlCommand cmdTache = new SqlCommand(queryTache, bdd);
                try
                {
                    bdd.Open();
                    SqlDataAdapter sqlDataAdapteurTache = new SqlDataAdapter(cmdTache);
                    DataTable dataTableTache = new DataTable();
                    sqlDataAdapteurTache.Fill(dataTableTache);
                    
                    listTache.DataSource = dataTableTache;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("liste tâche" + ex.Message);
                }
                bdd.Close();

                //Affiche la liste des jalons
                string queryJalon = "SELECT libelle as Jalon,u.nomUser,dateLivrPrevu,dateLivrReel,p.nomProjet FROM jalon2 j JOIN projet p ON j.idProjet = p.idProjet JOIN utilisateur u ON u.idUser=j.utilisateur  WHERE j.idprojet = " + (int)projet.SelectedValue;
                SqlCommand cmdJalon = new SqlCommand(queryJalon, bdd);
                try
                {
                    bdd.Open();
                    SqlDataAdapter sqlDataAdapteurJalon = new SqlDataAdapter(cmdJalon);
                    DataTable dataTableJalon = new DataTable();
                    sqlDataAdapteurJalon.Fill(dataTableJalon);
                    
                    listJalon.DataSource = dataTableJalon;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("liste jalon" + ex.Message);
                }
                bdd.Close();

                //Affiche la liste des exigences relier au tache
                string queryExigenceTache = "SELECT t.libelle as nomTache,e.besoin as Exigence FROM tacheExigence te JOIN tache t ON t.idTache = te.idTache JOIN exigence e ON e.idExigence = te.idExigence  WHERE t.idprojet = " + (int)projet.SelectedValue+"ORDER BY t.idTache ASC";
                SqlCommand cmdExigenceTache = new SqlCommand(queryExigenceTache, bdd);
                try
                {
                    bdd.Open();
                    SqlDataAdapter sqlDataAdapteurExigenceTache = new SqlDataAdapter(cmdExigenceTache);
                    DataTable dataTableExigenceTache = new DataTable();
                    sqlDataAdapteurExigenceTache.Fill(dataTableExigenceTache);

                    listTacheExigence.DataSource = dataTableExigenceTache;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("liste exigence tache " + ex.Message);
                }
                bdd.Close();
            }
        }

        private void buttonProjet_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirProjet));
            monthread.Start();
            this.Close();
        }
        private void buttonExigence_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirExigence));
            monthread.Start();
            this.Close();
        }
        private void buttonTache_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirTache));
            monthread.Start();
            this.Close();
        }
        private void buttonJalon_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirJalon));
            monthread.Start();
            this.Close();
        }

        

        private void buttonModifProjet_Click(object sender, EventArgs e)
        {
            if (projet.SelectedIndex != -1 && projet.Text != "<-- Selectionner le projet -->")
            {
                
               
                modifProjet.idProjet = (int)projet.SelectedValue;


                modifProjet.ShowDialog(this);
                modifProjet.Dispose();
                this.Dispose();
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirAccueil));
                monthread.Start();

            } else
            {
                MessageBox.Show("Merci de selectionner un projet");
            }
        }

        public static void ouvrirProjet()
        {
            Application.Run(new AjoutProjet());
        }

        public static void ouvrirExigence()
        {
            Application.Run(new AjoutExigence());
        }

        public static void ouvrirTache()
        {
            Application.Run(new AjoutTache());
        }

        public static void ouvrirJalon()
        {
            Application.Run(new AjoutJalon());
        }
        public static void ouvrirAccueil()
        {
            Application.Run(new Accueil());
        }

        private void deleteProjet_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(supprProjet));
            monthread.Start();
            this.Close();
        }

        private void deleteTache_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(supprTache));
            monthread.Start();
            this.Close();
        }

        private void deleteExig_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(supprExigence));
            monthread.Start();
            this.Close();
        }

        private void deleteJalon_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(supprJalon));
            monthread.Start();
            this.Close();
        }

        public static void supprProjet()
        {
            Application.Run(new SupprProjet());
        }

        public static void supprTache()
        {
            Application.Run(new SupprTache());
        }

        public static void supprExigence()
        {
            Application.Run(new SupprExigence());
        }

        public static void supprJalon()
        {
            Application.Run(new SupprJalon());
        }
    }
}
