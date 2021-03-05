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
    public partial class AjoutExigence : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");
        public AjoutExigence()
        {
            InitializeComponent();
            
        }

        private void AjoutExigence_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.database1DataSet.projet);
            specExigence.Items.Add("Sur les données");
            specExigence.Items.Add("Sur les performances");
            specExigence.Items.Add("Sur les interfaces utilisateur");
            specExigence.Items.Add("Sur la qualité");
            specExigence.Items.Add("Sur les services");
            
            specExigence.Text = "<-- Selectionner la spécialité de cette exigence -->";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            specExigence.Visible = false;

            this.Update();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            specExigence.Visible = true;

            this.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (besoin.Text != "" && fonctRadio.Checked == true)
            {
                if(projetSelect.Text != "<-- Selectionner le projet pour cette exigence -->") { 
                    string queryInsert = "insert into exigence values('" + besoin.Text + "','" + fonctRadio.Text + "','',"+ (int)projetSelect.SelectedValue + ")";
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                    try
                    {
                        bdd.Open();
                        SqlDataReader Reader = cmdInsert.ExecuteReader();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ajout exigence" + ex.Message);
                    }
                    bdd.Close();
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirTache));
                    monthread.Start();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Merci de remplir tous les champs");
                }



            }
            else if (besoin.Text != "" && nonFonctRadio.Checked == true && specExigence.SelectedIndex != -1)
            {
                if (specExigence.Text != "<-- Selectionner le projet pour cette exigence -->")
                {
                    string queryInsert = "insert into exigence values('" + besoin.Text + "','" + nonFonctRadio.Text + "','" + specExigence.Text + "'," + (int)projetSelect.SelectedValue + ")";
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                    try
                    {
                        bdd.Open();
                        SqlDataReader Reader = cmdInsert.ExecuteReader();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ajout exigence" + ex.Message);
                    }
                    bdd.Close();
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirTache));
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

        public static void ouvrirTache()
        {
            Application.Run(new AjoutTache());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (besoin.Text != "" && fonctRadio.Checked == true)
            {
                string queryInsert = "insert into exigence values('" + besoin.Text + "','" + fonctRadio.Text + "',''," + (int)projetSelect.SelectedValue + ")";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdInsert.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ajout exigence" + ex.Message);
                }
                bdd.Close();
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouvelExigence));
                monthread.Start();
                this.Close();



            }
            else if (besoin.Text != "" && nonFonctRadio.Checked == true && specExigence.SelectedIndex != -1)
            {
                string queryInsert = "insert into exigence values('" + besoin.Text + "','" + nonFonctRadio.Text + "','" + specExigence.Text + "'," + (int)projetSelect.SelectedValue + ")";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdInsert.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ajout exigence" + ex.Message);
                }
                bdd.Close();
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouvelExigence));
                monthread.Start();
                this.Close();
            }
            else
            {

                MessageBox.Show("Merci de remplir tous les champs");
            }
        }

        public static void nouvelExigence()
        {
            Application.Run(new AjoutExigence());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (besoin.Text != "" && fonctRadio.Checked == true)
            {
                if (projetSelect.Text != "<-- Selectionner le projet pour cette exigence -->")
                {
                    string queryInsert = "insert into exigence values('" + besoin.Text + "','" + fonctRadio.Text + "',''," + (int)projetSelect.SelectedValue + ")";
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                    try
                    {
                        bdd.Open();
                        SqlDataReader Reader = cmdInsert.ExecuteReader();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ajout exigence" + ex.Message);
                    }
                    bdd.Close();
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirTache));
                    monthread.Start();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Merci de remplir tous les champs");
                }



            }
            else if (besoin.Text != "" && nonFonctRadio.Checked == true && specExigence.SelectedIndex != -1)
            {
                if (specExigence.Text != "<-- Selectionner le projet pour cette exigence -->")
                {
                    string queryInsert = "insert into exigence values('" + besoin.Text + "','" + nonFonctRadio.Text + "','" + specExigence.Text + "'," + (int)projetSelect.SelectedValue + ")";
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                    try
                    {
                        bdd.Open();
                        SqlDataReader Reader = cmdInsert.ExecuteReader();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ajout exigence" + ex.Message);
                    }
                    bdd.Close();
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(accueil));
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

        public static void accueil()
        {
            Application.Run(new Accueil());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(accueil));
            monthread.Start();
            this.Close();
        }

       
    }
}
