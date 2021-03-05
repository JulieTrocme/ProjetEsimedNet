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
    public partial class AjoutProjet : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security=True");
        public AjoutProjet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.database1DataSet.utilisateur);
            userRespProjet.Text = "<-- Selectionner un chef de projet-->";
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if(userRespProjet.Text != "<-- Selectionner un chef de projet-->") { 
                if (nomProjet.Text != "" && userRespProjet.SelectedIndex != -1)
                {
                        
                        string queryInsert = "insert into projet values('" + nomProjet.Text + "'," + (int)userRespProjet.SelectedValue + ",'"+ dateDebutProjet.Value.Date + "','" + dateFinProjet.Value.Date + "')";
                        SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                        try
                        {
                            bdd.Open();
                            SqlDataReader Reader = cmdInsert.ExecuteReader();
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("bouton clic" + ex.Message);
                        }
                        bdd.Close();

                        System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirExigence));
                        monthread.Start();
                        this.Close();
                    
                }
                else
                {

                    MessageBox.Show("Merci de remplir tous les champs");
                }
            }else
                {

                    MessageBox.Show("Merci de remplir tous les champs");
                }


        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (userRespProjet.Text != "<-- Selectionner un chef de projet-->")
            {
                if (nomProjet.Text != "" && userRespProjet.SelectedIndex != -1)
                {

                    string queryInsert = "insert into projet values('" + nomProjet.Text + "'," + (int)userRespProjet.SelectedValue + ",'" + dateDebutProjet.Value.Date + "','" + dateFinProjet.Value.Date + "')";
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                    try
                    {
                        bdd.Open();
                        SqlDataReader Reader = cmdInsert.ExecuteReader();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("bouton clic" + ex.Message);
                    }
                    bdd.Close();

                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirAccueil));
                    monthread.Start();
                    this.Close();

                }
                else
                {

                    MessageBox.Show("Merci de remplir tous les champs");
                }
            }
            else
            {

                MessageBox.Show("Merci de remplir tous les champs");
            }

        }

        public static void ouvrirExigence()
        {
            Application.Run(new AjoutExigence());
        }
        public static void ouvrirAccueil()
        {
            Application.Run(new Accueil());
        }


    }
}
