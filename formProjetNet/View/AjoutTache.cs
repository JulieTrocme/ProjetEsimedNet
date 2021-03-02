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
    public partial class AjoutTache : Form
    {
        public AjoutTache()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirJalon));
            monthread.Start();
            this.Close();
        }

        public static void ouvrirJalon()
        {
            Application.Run(new AjoutJalon());
        }
    }
}
