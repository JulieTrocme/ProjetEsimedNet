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
    public partial class ModifProjet : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");

        public int idProjet;
        public int idUser;

        ModifExigence modifExigence = new ModifExigence();
        ModifTache modifTache = new ModifTache();
        ModifJalon modifJalon = new ModifJalon();

        public ModifProjet(/* string ancienNomProjet, string ancienDateFinProjet, string ancienDateDebutProjet, string ancienUserProjet*/)
        {
            InitializeComponent();
            
        }

        private void ModifProjet_Load(object sender, EventArgs e)
        {
            listExigence.Text = "<-- Selectionner l'exigence de ce projet que vous voulez modifier -->";
            listTache.Text = "<-- Selectionner la tache de ce projet que vous voulez modifier -->";
            listJalon.Text = "<-- Selectionner le jalon de ce projet que vous voulez modifier -->";
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.database1DataSet.utilisateur);

            //Affiche les données du projet 
            string queryProjet = "SELECT * FROM projet WHERE idprojet = " + idProjet;
            SqlCommand cmdProjet = new SqlCommand(queryProjet, bdd);
            try
            {
                bdd.Open();
                SqlDataReader Reader = cmdProjet.ExecuteReader();
                while (Reader.Read())
                {
                    nomProjet.Text = Reader.GetValue(1).ToString();
                    dateDebutProjet.Text = Reader.GetDateTime(3).ToString("dd-MM-yyyy");
                    dateFinProjet.Text = Reader.GetDateTime(4).ToString("dd-MM-yyyy");
                    idUser = Reader.GetInt32(2);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Donnée projet" + ex.Message);
            }
            bdd.Close();
            //Affiche les données du projet 
            string queryUser = "SELECT * FROM utilisateur WHERE idUser = " + idUser;
            SqlCommand cmdUser = new SqlCommand(queryUser, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderUser = cmdUser.ExecuteReader();
                while (ReaderUser.Read())
                {
                    userRespProjet.Text = ReaderUser.GetValue(1).ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Donnée projet" + ex.Message);
            }
            bdd.Close();

            //Affiche la liste des exigences
            string queryExigence = "SELECT * FROM exigence e JOIN projet p ON e.idProjet = p.idProjet  WHERE e.idProjet = " + idProjet;
            SqlCommand cmdExigence = new SqlCommand(queryExigence, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderExigence = cmdExigence.ExecuteReader();
                while (ReaderExigence.Read())
                {
                    listExigence.Items.Add(ReaderExigence.GetValue(1).ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("liste exigence" + ex.Message);
            }
            bdd.Close();

            //Affiche la liste des taches
            string queryTache = "SELECT * FROM tache t JOIN projet p ON t.idProjet = p.idProjet  WHERE t.idProjet = " + idProjet;
            SqlCommand cmdTache = new SqlCommand(queryTache, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderTache = cmdTache.ExecuteReader();
                while (ReaderTache.Read())
                {
                    listTache.Items.Add(ReaderTache.GetValue(1).ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("liste tache " + ex.Message);
            }
            bdd.Close();

            //Affiche la liste des jalons
            string queryJalon = "SELECT * FROM jalon2 j JOIN projet p ON j.idProjet = p.idProjet  WHERE j.idProjet = " + idProjet;
            SqlCommand cmdJalon = new SqlCommand(queryJalon, bdd);
            try
            {
                bdd.Open();
                SqlDataReader ReaderJalon = cmdJalon.ExecuteReader();
                while (ReaderJalon.Read())
                {
                    listJalon.Items.Add(ReaderJalon.GetValue(1).ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("liste jalon " + ex.Message);
            }
            bdd.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE projet SET nomProjet = '" + nomProjet.Text + "', userResp = " + (int)userRespProjet.SelectedValue + ", dateDebutProjet = '" + dateDebutProjet.Value.Date + "',dateFinProjet = '" + dateFinProjet.Value.Date + "' WHERE idProjet = "+ idProjet ;
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Envoie de l'exigence selectionné
            if (listExigence.SelectedIndex != -1 && listExigence.Text != "<-- Selectionner l'exigence de ce projet que vous voulez modifier -->")
            {
                modifExigence.nomExigence = listExigence.Text;


                modifExigence.ShowDialog(this);
                modifExigence.Dispose();
                this.Close();

            }
            else
            {
                MessageBox.Show("Merci de selectionner une exigence");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Envoie de la tache selectionné
            if (listTache.SelectedIndex != -1 && listTache.Text != "<-- Selectionner la tache de ce projet que vous voulez modifier -->")
            {
                modifTache.nomTache = listTache.Text;
                modifTache.ShowDialog(this);
                modifTache.Dispose();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Merci de selectionner une tache");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Envoie du jalon selectionné
            if (listJalon.SelectedIndex != -1 && listJalon.Text != "<-- Selectionner le jalon de ce projet que vous voulez modifier -->")
            {
                modifJalon.nomJalon = listJalon.Text;
                modifJalon.ShowDialog(this);
                modifJalon.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Merci de selectionner un jalon");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
