using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetIA
{
    [Serializable]
    public class Question
    {
        [XmlAttribute]
        public string Consigne { get; set; }
        [XmlElement]
        public string Code { get; set; }
        [XmlArray]
        public List<string> Reponses { get; set; }
        [XmlArray]
        public List<int> Solutions { get; set; }
        [XmlArray]
        public byte[] Image { get; set; }

        public Question()
        {
            Consigne = null;
            Code = null;
            Reponses = null;

        }

        public Question(string consigne, List<string> reponses, List<int> solutions, string code = null, byte[] image = null)
        {
            Consigne = consigne;
            Code = code;
            Image = image;
            Reponses = reponses;
            Solutions = solutions;
        }
    }
}
