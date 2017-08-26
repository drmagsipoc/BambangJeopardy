namespace BambangJeopardy
{
    partial class QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.buttonVerify = new System.Windows.Forms.Button();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.buttonWrong = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonVerify
            // 
            this.buttonVerify.AutoSize = true;
            this.buttonVerify.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerify.Location = new System.Drawing.Point(238, 211);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(162, 75);
            this.buttonVerify.TabIndex = 0;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.ButtonVerify_Click);
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.AutoSize = true;
            this.buttonCorrect.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCorrect.Location = new System.Drawing.Point(132, 310);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(162, 75);
            this.buttonCorrect.TabIndex = 1;
            this.buttonCorrect.Text = "Correct";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.ButtonCorrect_Click);
            // 
            // buttonWrong
            // 
            this.buttonWrong.AutoSize = true;
            this.buttonWrong.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrong.Location = new System.Drawing.Point(322, 310);
            this.buttonWrong.Name = "buttonWrong";
            this.buttonWrong.Size = new System.Drawing.Size(162, 75);
            this.buttonWrong.TabIndex = 2;
            this.buttonWrong.Text = "Wrong";
            this.buttonWrong.UseVisualStyleBackColor = true;
            this.buttonWrong.Click += new System.EventHandler(this.ButtonWrong_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxCategory.Location = new System.Drawing.Point(79, 25);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(162, 22);
            this.textBoxCategory.TabIndex = 4;
            this.textBoxCategory.Text = "Category";
            this.textBoxCategory.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxPoints.Location = new System.Drawing.Point(482, 25);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.ReadOnly = true;
            this.textBoxPoints.Size = new System.Drawing.Size(136, 22);
            this.textBoxPoints.TabIndex = 5;
            this.textBoxPoints.Text = "Points";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(100, 100);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(420, 91);
            this.textBoxQuestion.TabIndex = 6;
            this.textBoxQuestion.Text = "Question?";
            this.textBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.buttonWrong);
            this.Controls.Add(this.buttonCorrect);
            this.Controls.Add(this.buttonVerify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuestionForm";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Button buttonWrong;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.TextBox textBoxQuestion;
    }
}