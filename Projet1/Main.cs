﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ProjetIA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questionnaire questionnaire = new Questionnaire();
            DialogResult result = questionnaire.ShowDialog();
            if (result == DialogResult.Cancel || result == DialogResult.OK)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreerQuestion questionnaire = new CreerQuestion();
            DialogResult result = questionnaire.ShowDialog();
            if (result == DialogResult.Cancel || result == DialogResult.OK)
            {

            }
        }

        private void AEtoile_Click(object sender, EventArgs e)
        {
            Dijkstra questionnaire = new Dijkstra();
            DialogResult result = questionnaire.ShowDialog();
            if (result == DialogResult.Cancel || result == DialogResult.OK)
            {

            }
        }
    }
}
