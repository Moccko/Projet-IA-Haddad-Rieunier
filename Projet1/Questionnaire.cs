using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjetIA
{

    public partial class Questionnaire : Form
    {
        public int BonnesReponses { get; set; }
        private Queue<Question> Questions { get; set; }
        private Question QuestionEnCours { get; set; }

        private int NoQuestion = 0, NbQuestions;

        private bool Correction = true;

        private Bitmap Image;

        private MemoryStream ImageStream;

        private Random Random = new Random();

        private int NumeroQuestionDijkstra;

        public Questionnaire()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader("questions.xml");
            List<Question> questions = (List<Question>)new XmlSerializer(typeof(List<Question>)).Deserialize(reader);
            questions.Shuffle();
            Questions = new Queue<Question>(questions);
            reader.Close();

            BonnesReponses = 0;
            NbQuestions = Questions.Count + 1;

            NumeroQuestionDijkstra = Random.Next(1, NbQuestions - 1);

            BonnesReponsesLb.Text += $" / {NbQuestions}";

            UpdateScore();

            UpdateView();
        }

        private List<int> Erreurs(List<int> reponses, List<int> solutions)
        {
            List<int> correction = reponses;

            foreach (int juste in solutions)
            {
                if (correction.Contains(juste))
                    correction.Remove(juste);
                else
                    correction.Add(juste);
            }

            return correction;
        }

        private void ValiderReponse()
        {
            if (Erreurs(ReponsesCLB.CheckedIndices.OfType<int>().ToList(), QuestionEnCours.Solutions).Count() == 0)
                BonnesReponses++;

            for (int i = QuestionEnCours.Reponses.Count - 1; i >= 0; i--)
            {
                if (QuestionEnCours.Solutions.IndexOf(i) == -1)
                {
                    ReponsesCLB.Items.RemoveAt(i);
                }
            }

            UpdateScore();

            if (Questions.Count == 0)
            {
                ValiderBtn.Text = "Terminer";
            }
        }

        private void UpdateScore()
        {
            // +2 pour l'exo Dijkstra
            BonnesReponsesLb.Text = (BonnesReponses > 1 ? $"{BonnesReponses} bonnes réponses" : $"{BonnesReponses} bonne réponse") + $" / {NbQuestions + 3}";
        }

        private void QuestionSuivante()
        {
            // On retire les données de la question précédente
            ReponsesCLB.Items.Clear();
            if (QuestionEnCours != null && QuestionEnCours.Image != null)
            {
                ImageStream.Close();
                ImagePB.Image = null;
            }

            if (NoQuestion == NumeroQuestionDijkstra)
            {
                Dijkstra dijkstra = new Dijkstra();
                if (dijkstra.ShowDialog() == DialogResult.OK)
                {
                    NoQuestionLb.Text = $"Question {NoQuestion += 2} sur {NbQuestions}";
                    BonnesReponses += dijkstra.Score;
                    UpdateScore();
                }
                NoQuestion++;
            }

            // On affiche la question suivante
            QuestionEnCours = Questions.Dequeue();
            NoQuestionLb.Text = $"Question {++NoQuestion} sur {NbQuestions}";
            ConsigneLb.Text = QuestionEnCours.Consigne;
            ReponsesCLB.Items.AddRange(QuestionEnCours.Reponses.ToArray());
            CodeLb.Text = QuestionEnCours.Code;

            if (QuestionEnCours.Image != null)
            {
                ImageStream = new MemoryStream(QuestionEnCours.Image);
                Image = new Bitmap(ImageStream);
                float scaleHeight = ImagePB.Height / (float)Image.Height;
                float scaleWidth = ImagePB.Width / (float)Image.Width;
                float scale = Math.Min(scaleHeight, scaleWidth);

                ImagePB.Image = new Bitmap(Image, (int)(Image.Width * scale), (int)(Image.Height * scale));
            }
        }

        private void UpdateView()
        {
            if (Correction)
            {
                if (Questions.Count > 0)
                {
                    QuestionSuivante();
                }
                else
                {
                    string greeting;
                    if ((double)BonnesReponses / NbQuestions > 0.75)
                    {
                        greeting = "C'est du beau jeu ça !";
                    }
                    else if ((double)BonnesReponses / NbQuestions > 0.5)
                    {
                        greeting = "Mouais, pas mal, peut mieux faire.";
                    }
                    else
                    {
                        greeting = "Qu'est-ce que c'est que ça ?! Tu vas me faire le plaisir de relire le cours de M. Salotti.";
                    }
                    MessageBox.Show($"{greeting} Votre score est de {BonnesReponses}/{NbQuestions}.");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                ValiderReponse();
            }

            Correction = !Correction;
            StatutLb.Text = Correction ? "Correction" : "";
        }

        private void ValiderBtn_Click(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
