﻿using formProjetNet.View;
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirProjet));
            monthread.Start();
            this.Close();
           
        }
        public static void ouvrirProjet()
        {
            Application.Run(new AjoutProjet());
        }
    }
}
