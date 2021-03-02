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
    public partial class AjoutJalon : Form
    {
        public AjoutJalon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirListeDesProjets));
            monthread.Start();
            this.Close();
        }

        public static void ouvrirListeDesProjets()
        {
            Application.Run(new Form1());
        }
    }
}
