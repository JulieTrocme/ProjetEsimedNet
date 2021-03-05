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
    public partial class AjoutJalon : Form
    {
        SqlConnection bdd = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\julie\source\repos\ProjetEsimedNet\DatabaseProjetNet\Database1.mdf;Integrated Security = True");
        public int idJalon;
        public int idTache;
        public AjoutJalon()
        {
            InitializeComponent();
        }

        private void AjoutJalon_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.database1DataSet.projet);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.database1DataSet.utilisateur);
            responsable.Text = "<-- Selectionner un responsable -->";
            projet.Text = "<-- Selectionner le projet associé -->";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (libelle.Text != "" &&  responsable.SelectedIndex != -1 && projet.SelectedIndex != -1 && responsable.Text != "<-- Selectionner un responsable -->" && projet.Text != "<-- Selectionner le projet associé -->")
            {
                string queryInsert = "insert into jalon2 values('" + libelle.Text + "'," + (int)responsable.SelectedValue + ",'" + dateLivrPrevu.Value.Date + "',null,"+ (int)projet.SelectedValue + ")";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, bdd);
                try
                {
                    bdd.Open();
                    SqlDataReader Reader = cmdInsert.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ajout jalon" + ex.Message);
                }
                bdd.Close();
                associationJalonTache();
                
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirListeDesProjets));
                monthread.Start();
                this.Close();
            }
            else
            {

                MessageBox.Show("Merci de remplir tous les champs");
            }
            

        }

        public static void ouvrirListeDesProjets()
        {
            Application.Run(new Accueil());
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projet.SelectedIndex != -1)
            {
                listTache.Items.Clear();
                string query = "select * from tache where idJalon IS NULL AND idProjet = " + (int)projet.SelectedValue;
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
            }
        }

        public void associationJalonTache()
        {
            //L'id du jalon inséré
            string queryLadtInsert = "select MAX(idJalon) from jalon2 where idProjet =" + (int)projet.SelectedValue;
            SqlCommand cmdLastInsertId = new SqlCommand(queryLadtInsert, bdd);
            bdd.Open();
            SqlDataReader ReaderLastInsertId = cmdLastInsertId.ExecuteReader();

            while (ReaderLastInsertId.Read())
            {
                idJalon = ReaderLastInsertId.GetInt32(0);
            }
            bdd.Close();
            if (listTache.SelectedItems.Count > 0)
            {
                foreach (object tache in listTache.CheckedItems)
                {
                    //MessageBox.Show(exigence.ToString());
                    string query = "select idTache from tache where idProjet = " + (int)projet.SelectedValue + " and libelle ='" + tache.ToString() + "'";
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
                            MessageBox.Show("ajout idJalon dans tache " + ex.Message);
                        }
                        bdd.Close();
                        //MessageBox.Show(Reader.GetValue(0).ToString());
                        string queryUpdateTache = "UPDATE tache SET idJalon = " + idJalon +" WHERE idTache = " + idTache;
                        SqlCommand cmdUpdateTache = new SqlCommand(queryUpdateTache, bdd);
                        try
                        {
                            bdd.Open();
                            SqlDataReader ReaderUpdateTache = cmdUpdateTache.ExecuteReader();

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

        private void listTache_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
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
