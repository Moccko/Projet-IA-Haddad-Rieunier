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

namespace Projet1
{
    public partial class CreerQuestion : Form
    {

        public CreerQuestion()
        {
            InitializeComponent();
        }

        private void AjouterReponseBtn_Click(object sender, EventArgs e)
        {
            ReponsesCLB.Items.AddRange(new string[] { ReponseTB.Text });
            ReponseTB.Text = "";
        }

        private void ValiderQuestionBtn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("questions.xml");
            List<Question> questions = (List<Question>)new XmlSerializer(typeof(List<Question>)).Deserialize(reader);
            reader.Close();

            byte[] bimage = null;
            if (ImageBtn.Text != "Choisir image")
            {
                FileStream fs = new FileStream(ImageBtn.Text, FileMode.Open, FileAccess.Read);
                bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();
            }

            Question question = new Question(ConsigneTB.Text, ReponsesCLB.Items.OfType<string>().ToList(), ReponsesCLB.CheckedIndices.OfType<int>().ToList(), CodeTB.Text, bimage);

            questions.Add(question);

            StreamWriter writer = new StreamWriter("questions.xml");
            new XmlSerializer(typeof(List<Question>)).Serialize(writer, questions);
            writer.Close();
            ConsigneTB.Text = "";
            ReponseTB.Text = "";
            CodeTB.Text = "";
            ReponsesCLB.Items.Clear();
        }

        private void ImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ImageBtn.Text = open.FileName;
            }
        }
    }
}
