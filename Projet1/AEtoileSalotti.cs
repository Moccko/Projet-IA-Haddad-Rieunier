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
        private Random Random = new Random();

        private int ScoreOF = 0;
        private int ScoreAF = 0;

        public int Score { get { return ScoreOF + ScoreAF; } private set { Score = value; } }

        private int Points = 0;

        public AEtoileSalotti()
        {
            InitializeComponent();
            Init();
            AEtoile();
        }

        private void Init()
        {
            int noGraphe = Random.Next(2);
            StreamReader monStreamReader = new StreamReader($"graphe{noGraphe}.txt");
            GraphePB.Image = noGraphe == 0 ? Projet1.Resources.Dijkstra0 : Projet1.Resources.Dijkstra1;
            GraphePB.Refresh();

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

            // 2ème ligne : noeud de départ
            ligne = monStreamReader.ReadLine();
            i = 0;
            while (ligne[i] != ':') i++;
            string strninitial = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strninitial += ligne[i];
                i++;
            }
            numinitial = Convert.ToInt32(strninitial);

            // 3ème ligne : noeud de fin
            ligne = monStreamReader.ReadLine();
            i = 0;
            while (ligne[i] != ':') i++;
            string strnfinal = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnfinal += ligne[i];
                i++;
            }
            numfinal = Convert.ToInt32(strnfinal);

            // CREATION DE BOUTONS
            CreerBoutons(nbnodes, UserFermesLB, FermesFLP, Fermes, "FermesBtn");
            CreerBoutons(nbnodes, UserOuvertsLB, OuvertsFLP, Ouverts, "OuvertsBtn", ALPHABET[numinitial].ToString());
            CreerBoutons(nbnodes, DijkstraTV, DijkstraFLP, "DijkstraBtn", ALPHABET[numinitial].ToString());

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // 4ème ligne : lecture des arcs
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
                    strN1 += ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 += ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal += ligne[i];
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

        private void AEtoile()
        {
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

        private void CreerBoutons(int nb, ListBox lb, FlowLayoutPanel flb, List<char> noeuds, string name, string nInit = null)
        {
            for (int i = 0; i < nb; i++)
            {
                Button bouton = new Button();
                bouton.Name = name + i;
                bouton.Size = new Size(30, 20);
                bouton.TabIndex = 10 + i;
                bouton.Text = ALPHABET[i].ToString();
                bouton.UseVisualStyleBackColor = true;
                bouton.Click += (sender, e) => OuvertFermeBtn_Click(sender, e, lb, noeuds);
                flb.Controls.Add(bouton);
            }
            lb.Items.Add($"{{ {nInit} }}");
            lb.Items.Add("{  }");
        }

        private void CreerBoutons(int nb, TreeView tv, FlowLayoutPanel flb, string name, string nInit)
        {
            for (int i = 0; i < nb; i++)
            {
                Button bouton = new Button();
                bouton.Name = name + i;
                bouton.Size = new Size(30, 20);
                bouton.TabIndex = 30 + i;
                bouton.Text = ALPHABET[i].ToString();
                bouton.UseVisualStyleBackColor = true;
                bouton.Click += (sender, e) => TreeViewBtn_Click(sender, e, ref tv);
                flb.Controls.Add(bouton);
            }
            //tv = new TreeView();
            //tv.Nodes.Add(new TreeNode(nInit));
            tv.SelectedNode = tv.Nodes[0];
        }

        private void TreeViewBtn_Click(object sender, EventArgs e, ref TreeView tv)
        {
            TreeNode noeud = null;
            string value = ((Button)sender).Text;
            if (tv.SelectedNode.GetNodeCount(false) > 0)
            {
                foreach (TreeNode tn in tv.SelectedNode.Nodes)
                {
                    if (tn.Text == value)
                    {
                        noeud = tn;
                        break;
                    }
                }
            }
            if (noeud == null)
                tv.SelectedNode.Nodes.Add(new TreeNode(value));
            else
                tv.SelectedNode.Nodes.Remove(noeud);
            tv.ExpandAll();
        }

        private void OuvertFermeBtn_Click(object sender, EventArgs e, ListBox lb, List<char> noeuds)
        {
            char letter = ((Button)sender).Text[0];
            if (noeuds.Contains(letter))
                noeuds.Remove(letter);
            else
                noeuds.Add(letter);
            lb.Items[lb.Items.Count - 1] = "{ " + noeuds.Aggregate("", (list, x) => list + (list == "" ? "" : ", ") + x.ToString()) + " }";
        }

        private void ValiderLigneBtn_Click(object sender, EventArgs e)
        {
            int rang = UserOuvertsLB.Items.Count - 1;
            string ouverts = UserOuvertsLB.Items[rang].ToString() == OuvertsLB.Items[rang].ToString() ? "juste" : "faux";
            string fermes = UserFermesLB.Items[rang].ToString() == FermesLB.Items[rang].ToString() ? "juste" : "faux";

            if (fermes == "juste" && ouverts == "juste")
            {
                MessageBox.Show("Bien joué, à la suivante maintenant.");
                Points += 2;
            }
            else if (fermes == "juste")
            {
                MessageBox.Show($"Les nœuds ouverts sont faux, correction :\nFermés : {OuvertsLB.Items[rang].ToString()}\nBon courage pour la ligne suivante !");
                Points++;
            }
            else if (ouverts == "juste")
            {
                MessageBox.Show($"Les nœuds fermés sont faux, correction :\nFermés : {FermesLB.Items[rang].ToString()}\nBon courage pour la ligne suivante !");
                Points++;
            }
            else
            {
                MessageBox.Show($"Tout est faux, correction :\nFermés : {FermesLB.Items[rang].ToString()}\nOuverts : {OuvertsLB.Items[rang].ToString()}\nBon courage pour la ligne suivante !");
            }

            UserFermesLB.Items[rang] = FermesLB.Items[rang].ToString();
            UserOuvertsLB.Items[rang] = OuvertsLB.Items[rang].ToString();

            Ouverts.Clear();
            Fermes.Clear();

            if (UserFermesLB.Items.Count == FermesLB.Items.Count)
            {
                ValiderLigneBtn.Enabled = false;
            }
            else
            {
                UserOuvertsLB.Items.Add("{  }");
                UserFermesLB.Items.Add("{  }");
            }
        }

        private void ValiderArbreBtn_Click(object sender, EventArgs e)
        {
            bool juste = CompareTreeViews(DijkstraTV.TopNode, treeView1.TopNode);
            MessageBox.Show(juste ? "égaux" : "différents");
            ScoreAF += juste ? 1 : 0;
            ((Button)sender).Enabled = false;
        }

        private bool CompareTreeViews(TreeNode t1, TreeNode t2)
        {
            if (t1.GetNodeCount(false) == 0 && t2.GetNodeCount(false) == 0)
            {
                return t1.Text == t2.Text;
            }
            else if (t1.GetNodeCount(false) != t2.GetNodeCount(false))
            {
                return false;
            }
            else
            {
                bool equals = t1.Text == t2.Text;
                if (equals && t1.GetNodeCount(false) == t2.GetNodeCount(false))
                {
                    var nodes1 = t1.Nodes.GetEnumerator();
                    while (nodes1.MoveNext())
                    {
                        var nodes2 = t2.Nodes.GetEnumerator();
                        bool equals1 = false;
                        while (nodes2.MoveNext() && !equals1)
                        {
                            equals1 = CompareTreeViews((TreeNode)nodes1.Current, (TreeNode)nodes2.Current);
                            Console.WriteLine($"N1 : {((TreeNode)nodes1.Current).Text}   N2 : {((TreeNode)nodes2.Current).Text}   E : {equals1}");
                        }
                        if (!equals1) return false;
                        equals &= equals1;
                    }
                }
                return equals;
            }
        }

        private void ValiderLigneBtn_EnabledChanged(object sender, EventArgs e)
        {
            if (!ValiderArbreBtn.Enabled)
            {
                ValiderBtn.Enabled = true;
            }

            ScoreOF += (int)Math.Ceiling((double)(ScoreOF / FermesLB.Items.Count));
        }

        private void ValiderArbreBtn_EnabledChanged(object sender, EventArgs e)
        {
            if (!ValiderLigneBtn.Enabled)
            {
                ValiderBtn.Enabled = true;
            }
        }

        private void ValiderBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
