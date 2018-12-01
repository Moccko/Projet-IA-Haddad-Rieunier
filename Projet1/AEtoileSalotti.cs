using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ProjetIA
{
    public partial class AEtoileSalotti : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;
        public static string ALPHABET { get { return "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; } private set { } }
        private List<char> Ouverts = new List<char>();
        private List<char> Fermes = new List<char>();

        private void CreerBoutons(int nb, ListBox lb, FlowLayoutPanel flb, List<char> noeuds, string name)
        {
            for (int i = 0; i < nb; i++)
            {
                Button bouton = new Button();
                bouton.Name = name + i;
                bouton.Size = new Size(28, 23);
                bouton.TabIndex = 10 + i;
                bouton.Text = ALPHABET[i].ToString();
                bouton.UseVisualStyleBackColor = true;
                bouton.Click += (sender, e) => OuvertFermeBtn_Click(sender, e, lb, noeuds);
                flb.Controls.Add(bouton);
            }
            lb.Items.Add("{  }");
        }
        private void OuvertFermeBtn_Click(object sender, EventArgs e, ListBox lb, List<char> noeuds)
        {
            //int index = ALPHABET.IndexOf(((Button)sender).Text);
            //if (noeuds.Contains(index))
            //    noeuds.Remove(index);
            //else
            //    noeuds.Add(index);
            char letter = ((Button)sender).Text[0];
            if (noeuds.Contains(letter))
                noeuds.Remove(letter);
            else
                noeuds.Add(letter);
            lb.Items[lb.Items.Count - 1] = "{ " + noeuds.Aggregate("", (list, x) => list + (list == "" ? "" : ", ") + x.ToString()) + " }";
        }

        public AEtoileSalotti()
        {
            InitializeComponent();
        }

        private void init_Click(object sender, EventArgs e)
        {
            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            // CREATION DE BOUTONS
            CreerBoutons(nbnodes, UserFermesLB, FermesFLP, Fermes, "FermesBtn");
            CreerBoutons(nbnodes, UserOuvertsLB, OuvertsFLP, Ouverts, "OuvertsBtn");

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a la structure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
        }

        private void AEtoile_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0, OuvertsLB, FermesLB);

            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBox1.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            g.GetSearchTree(treeView1);
        }

        private void ValiderLigneBtn_Click(object sender, EventArgs e)
        {
            int rang = UserOuvertsLB.Items.Count - 1;
            string ouverts = UserOuvertsLB.Items[rang].ToString() == OuvertsLB.Items[rang].ToString() ? "juste" : "faux";
            string fermes = UserFermesLB.Items[rang].ToString() == FermesLB.Items[rang].ToString() ? "juste" : "faux";
            MessageBox.Show($"Fermés : {fermes}     Ouverts : {ouverts}");
            Ouverts.Clear();
            Fermes.Clear();
            UserOuvertsLB.Items.Add("{  }");
            UserFermesLB.Items.Add("{  }");
        }
    }
}
