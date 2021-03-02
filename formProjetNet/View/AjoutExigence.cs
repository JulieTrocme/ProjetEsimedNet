using formProjetNet.View;
using System;
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
        public AjoutExigence()
        {
            InitializeComponent();
            
        }

        private void AjoutExigence_Load(object sender, EventArgs e)
        {
            specExigence.Items.Add("Sur les données");
            specExigence.Items.Add("Sur les performances");
            specExigence.Items.Add("Sur les interfaces utilisateur");
            specExigence.Items.Add("Sur la qualité");
            specExigence.Items.Add("Sur les services");

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
            if (besoinCl.Text != "" && fonctRadio.Checked == true)
            {
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirTache));
                monthread.Start();
                this.Close();
               


            }else if(besoinCl.Text != "" && nonFonctRadio.Checked == true && specExigence.SelectedIndex != -1)
            {
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirTache));
                monthread.Start();
                this.Close();
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


    }
}
