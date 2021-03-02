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
    public partial class AjoutProjet : Form
    {
        public AjoutProjet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (nomProjet.Text != "" && userRespProjet.SelectedIndex != -1) {
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirExigence));
                monthread.Start();
                this.Close();

            } else {
               
                MessageBox.Show("Merci de remplir tous les champs");
            }
        }

        public static void ouvrirExigence()
        {
            Application.Run(new AjoutExigence());
        }
    }
}
