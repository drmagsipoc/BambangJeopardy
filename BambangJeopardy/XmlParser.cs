using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BambangJeopardy
{
    class XmlParser
    {
        private int category = 0;
        private int index = 0;
        private XmlDocument xmlDoc = null;
        private XmlElement xmlRoot = null;
        private XmlNodeList xmlNodes = null;
        private string categoryString = "";
        private string questionString = "";
        private string answerString = "";
        private int questionPts = 0;

        public string QuestionString { get => questionString; set => questionString = value; }
        public string AnswerString { get => answerString; set => answerString = value; }
        public int QuestionPts { get => questionPts; set => questionPts = value; }
        public string CategoryString { get => categoryString; set => categoryString = value; }

        public XmlParser()
        {
            this.category = 0;
            this.index = 0;
            this.xmlDoc = new XmlDocument();
            this.xmlDoc.Load("Questions.xml");
            this.xmlRoot = this.xmlDoc.DocumentElement;

        }

        public XmlParser(int category, int index)
        {
            this.category = category;
            this.index = index;
            this.xmlDoc = new XmlDocument();
            this.xmlDoc.Load("Questions.xml");
            this.xmlRoot = this.xmlDoc.DocumentElement;
         }

        public void processIndex(int catIndex, int quesIndex)
        {
            // build xPath String
            string xPath = "/Jeopardy/Category[";
            xPath += catIndex.ToString() + "]";

            this.xmlNodes = this.xmlRoot.SelectNodes(xPath);
            XmlNode questEntry = this.xmlNodes[0];
            this.CategoryString = questEntry.Attributes[1].Value;

            xPath += "/QuestionEntry[" + quesIndex.ToString() + "]";

            this.xmlNodes = this.xmlRoot.SelectNodes(xPath);
            questEntry = this.xmlNodes[0];

            this.QuestionString = questEntry.Attributes[1].Value;
            this.AnswerString = questEntry.Attributes[2].Value;
            string questionPtsStr = questEntry.Attributes[3].Value;
            this.QuestionPts = Convert.ToInt32(questionPtsStr);
        }

    }
    
}
