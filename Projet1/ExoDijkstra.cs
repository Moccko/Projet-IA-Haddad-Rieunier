using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{

    public partial class ExoDijkstra : Form
    {
        public ExoDijkstra()
        {
            InitializeComponent();

        }

        private void AJouterBtn(string value)
        {
            TreeNode noeud = null;
            if (DijkstraTV.SelectedNode.GetNodeCount(false) > 0)
            {
                foreach (TreeNode tn in DijkstraTV.SelectedNode.Nodes)
                {
                    if (tn.Text == value)
                    {
                        noeud = tn;
                        break;
                    }
                }
            }
            if (noeud == null)
                DijkstraTV.SelectedNode.Nodes.Add(new TreeNode(value));
            else
                DijkstraTV.SelectedNode.Nodes.Remove(noeud);
        }

        private void ABtn_Click(object sender, EventArgs e)
        {
            AJouterBtn(((Button)sender).Text);
        }

        private void BBtn_Click(object sender, EventArgs e)
        {
            AJouterBtn(((Button)sender).Text);
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            AJouterBtn(((Button)sender).Text);
        }

        private void DBtn_Click(object sender, EventArgs e)
        {
            AJouterBtn(((Button)sender).Text);
        }
        private void EBtn_Click(object sender, EventArgs e)
        {
            AJouterBtn(((Button)sender).Text);
        }

        private void FBtn_Click(object sender, EventArgs e)
        {
            AJouterBtn(((Button)sender).Text);
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
                    var nodes2 = t2.Nodes.GetEnumerator();
                    while (nodes1.MoveNext())
                    {
                        nodes2.MoveNext();
                        equals &= CompareTreeViews((TreeNode)nodes1.Current, (TreeNode)nodes2.Current);
                    }
                }
                return equals;
            }
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CompareTreeViews(DijkstraTV.TopNode, CompareTV.TopNode) ? "égaux" : "différents");
        }

    }
}
