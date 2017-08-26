using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BambangJeopardy
{
    public partial class QuestionForm : Form
    {
        private XmlParser xmlParse;
        private CategoryForm categoryForm;
        private Button srcButton;
        private int points;

        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionForm(int catIndex, int quesIdx, CategoryForm categoryForm, Button srcButton)
        {
            InitializeComponent();

            this.categoryForm = categoryForm;
            this.srcButton = srcButton;

            xmlParse = new XmlParser();
            xmlParse.processIndex(catIndex, quesIdx);

            this.textBoxQuestion.Text = xmlParse.QuestionString;
            this.textBoxCategory.Text = "Question: " + xmlParse.CategoryString;
            this.points = xmlParse.QuestionPts;
            this.textBoxPoints.Text = "$" + this.points.ToString() + " Reward";
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCorrect_Click(object sender, EventArgs e)
        {
            this.categoryForm.AddPoints(this.points);
            this.srcButton.BackColor = Color.Green;
            this.Close();
        }

        private void ButtonWrong_Click(object sender, EventArgs e)
        {
            this.categoryForm.AddPoints(-this.points);
            this.srcButton.BackColor = Color.Red;
            this.Close();
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            string message = xmlParse.AnswerString;
            string caption = "Answer";
            MessageBox.Show(message, caption);
        }
    }
}
