using System;
using System.Windows.Forms;

namespace BambangJeopardy
{
    public partial class CategoryForm : Form
    {
        private XmlParser xmlParse;
        private int points = 0;

        public CategoryForm()
        {
            InitializeComponent();

            xmlParse = new XmlParser();

            // Initialize Category1 Texts
            xmlParse.processIndex(1, 1);
            this.textBoxCategory1.Text = xmlParse.CategoryString;
            this.buttonC1Q1.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(1, 2);
            this.buttonC1Q2.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(1, 3);
            this.buttonC1Q3.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(1, 4);
            this.buttonC1Q4.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(1, 5);
            this.buttonC1Q5.Text = "$" + xmlParse.QuestionPts.ToString();

            // Initialize Category2 Texts
            xmlParse.processIndex(2, 1);
            this.textBoxCategory2.Text = xmlParse.CategoryString;
            this.buttonC2Q1.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(2, 2);
            this.buttonC2Q2.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(2, 3);
            this.buttonC2Q3.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(2, 4);
            this.buttonC2Q4.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(2, 5);
            this.buttonC2Q5.Text = "$" + xmlParse.QuestionPts.ToString();

            // Initialize Category3 Texts
            xmlParse.processIndex(3, 1);
            this.textBoxCategory3.Text = xmlParse.CategoryString;
            this.buttonC3Q1.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(3, 2);
            this.buttonC3Q2.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(3, 3);
            this.buttonC3Q3.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(3, 4);
            this.buttonC3Q4.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(3, 5);
            this.buttonC3Q5.Text = "$" + xmlParse.QuestionPts.ToString();

            // Initialize Category4 Texts
            xmlParse.processIndex(4, 1);
            this.textBoxCategory4.Text = xmlParse.CategoryString;
            this.buttonC4Q1.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(4, 2);
            this.buttonC4Q2.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(4, 3);
            this.buttonC4Q3.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(4, 4);
            this.buttonC4Q4.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(4, 5);
            this.buttonC4Q5.Text = "$" + xmlParse.QuestionPts.ToString();

            // Initialize Category5 Texts
            xmlParse.processIndex(5, 1);
            this.textBoxCategory5.Text = xmlParse.CategoryString;
            this.buttonC5Q1.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(5, 2);
            this.buttonC5Q2.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(5, 3);
            this.buttonC5Q3.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(5, 4);
            this.buttonC5Q4.Text = "$" + xmlParse.QuestionPts.ToString();
            xmlParse.processIndex(5, 5);
            this.buttonC5Q5.Text = "$" + xmlParse.QuestionPts.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        public void AddPoints(int points)
        {
            this.points += points;
            this.textBoxPoints.Text = "Points: $" + this.points.ToString();
        }

        private void ButtonC1Q1_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(1, 1, this, this.buttonC1Q1);
            frm.Show();
        }

        private void ButtonC1Q2_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(1, 2, this, this.buttonC1Q2);
            frm.Show();
        }

        private void ButtonC1Q3_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(1, 3, this, this.buttonC1Q3);
            frm.Show();
        }

        private void ButtonC1Q4_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(1, 4, this, this.buttonC1Q4);
            frm.Show();
        }

        private void ButtonC1Q5_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(1, 5, this, this.buttonC1Q5);
            frm.Show();
        }

        private void ButtonC2Q1_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(2, 1, this, this.buttonC2Q1);
            frm.Show();
        }

        private void ButtonC2Q2_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(2, 2, this, this.buttonC2Q2);
            frm.Show();
        }

        private void ButtonC2Q3_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(2, 3, this, this.buttonC2Q3);
            frm.Show();
        }

        private void ButtonC2Q4_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(2, 4, this, this.buttonC2Q4);
            frm.Show();
        }

        private void ButtonC2Q5_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(2, 5, this, this.buttonC2Q5);
            frm.Show();
        }

        private void buttonC3Q1_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(3, 1, this, this.buttonC3Q1);
            frm.Show();
        }

        private void ButtonC3Q2_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(3, 2, this, this.buttonC3Q2);
            frm.Show();
        }

        private void ButtonC3Q3_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(3, 3, this, this.buttonC3Q3);
            frm.Show();
        }

        private void buttonC3Q4_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(3, 4, this, this.buttonC3Q4);
            frm.Show();
        }

        private void ButtonC3Q5_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(3, 5, this, this.buttonC3Q5);
            frm.Show();
        }

        private void ButtonC4Q1_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(4, 1, this, this.buttonC4Q1);
            frm.Show();
        }

        private void ButtonC4Q2_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(4, 2, this, this.buttonC4Q2);
            frm.Show();
        }

        private void ButtonC4Q3_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(4, 3, this, this.buttonC4Q3);
            frm.Show();
        }

        private void ButtonC4Q4_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(4, 4, this, this.buttonC4Q4);
            frm.Show();
        }

        private void ButtonC4Q5_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(4, 5, this, this.buttonC4Q5);
            frm.Show();
        }

        private void ButtonC5Q1_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(5, 1, this, this.buttonC5Q1);
            frm.Show();
        }

        private void ButtonC5Q2_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(5, 2, this, this.buttonC5Q2);
            frm.Show();
        }

        private void ButtonC5Q3_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(5, 3, this, this.buttonC5Q3);
            frm.Show();
        }

        private void ButtonC5Q4_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(5, 4, this, this.buttonC5Q4);
            frm.Show();
        }

        private void ButtonC5Q5_Click(object sender, EventArgs e)
        {
            QuestionForm frm = new QuestionForm(5, 5, this, this.buttonC5Q5);
            frm.Show();
        }
    }
}
