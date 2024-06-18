namespace _02_Introduction_To_Strings
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnSubstring4 = new System.Windows.Forms.Button();
            this.btnSubstring35 = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnIndexof = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegular = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnLetter = new System.Windows.Forms.Button();
            this.btnProblem1 = new System.Windows.Forms.Button();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(75, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(210, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(75, 179);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(210, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(16, 38);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(110, 41);
            this.btnLength.TabIndex = 2;
            this.btnLength.Text = ".Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnSubstring4
            // 
            this.btnSubstring4.Location = new System.Drawing.Point(132, 38);
            this.btnSubstring4.Name = "btnSubstring4";
            this.btnSubstring4.Size = new System.Drawing.Size(110, 41);
            this.btnSubstring4.TabIndex = 3;
            this.btnSubstring4.Text = ".Substring(4)";
            this.btnSubstring4.UseVisualStyleBackColor = true;
            this.btnSubstring4.Click += new System.EventHandler(this.btnSubstring4_Click);
            // 
            // btnSubstring35
            // 
            this.btnSubstring35.Location = new System.Drawing.Point(248, 38);
            this.btnSubstring35.Name = "btnSubstring35";
            this.btnSubstring35.Size = new System.Drawing.Size(110, 41);
            this.btnSubstring35.TabIndex = 4;
            this.btnSubstring35.Text = ".Substring(3,5)";
            this.btnSubstring35.UseVisualStyleBackColor = true;
            this.btnSubstring35.Click += new System.EventHandler(this.btnSubstring35_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(16, 85);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(110, 41);
            this.btnStartsWith.TabIndex = 5;
            this.btnStartsWith.Text = ".StartsWith";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(132, 85);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(110, 41);
            this.btnEndsWith.TabIndex = 6;
            this.btnEndsWith.Text = ".EndsWith";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            // 
            // btnIndexof
            // 
            this.btnIndexof.Location = new System.Drawing.Point(248, 85);
            this.btnIndexof.Name = "btnIndexof";
            this.btnIndexof.Size = new System.Drawing.Size(110, 41);
            this.btnIndexof.TabIndex = 7;
            this.btnIndexof.Text = ".IndexOf";
            this.btnIndexof.UseVisualStyleBackColor = true;
            this.btnIndexof.Click += new System.EventHandler(this.btnIndexof_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(16, 132);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(110, 41);
            this.btnToUpper.TabIndex = 8;
            this.btnToUpper.Text = ".ToUpper()";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(132, 132);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(110, 41);
            this.btnToLower.TabIndex = 9;
            this.btnToLower.Text = ".ToLower()";
            this.btnToLower.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(248, 132);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(110, 41);
            this.btnReplace.TabIndex = 10;
            this.btnReplace.Text = ".Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReplace);
            this.groupBox1.Controls.Add(this.btnToLower);
            this.groupBox1.Controls.Add(this.btnToUpper);
            this.groupBox1.Controls.Add(this.btnIndexof);
            this.groupBox1.Controls.Add(this.btnEndsWith);
            this.groupBox1.Controls.Add(this.btnStartsWith);
            this.groupBox1.Controls.Add(this.btnSubstring35);
            this.groupBox1.Controls.Add(this.btnSubstring4);
            this.groupBox1.Controls.Add(this.btnLength);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 269);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnRegular
            // 
            this.btnRegular.Location = new System.Drawing.Point(12, 306);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(75, 23);
            this.btnRegular.TabIndex = 12;
            this.btnRegular.Text = "Regular";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(117, 287);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.ScrollAlwaysVisible = true;
            this.lstOutput.Size = new System.Drawing.Size(212, 238);
            this.lstOutput.TabIndex = 13;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(12, 354);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 14;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.Location = new System.Drawing.Point(12, 404);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.Size = new System.Drawing.Size(75, 23);
            this.btnLetter.TabIndex = 15;
            this.btnLetter.Text = "Letter \"a\"";
            this.btnLetter.UseVisualStyleBackColor = true;
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnProblem1
            // 
            this.btnProblem1.Location = new System.Drawing.Point(53, 570);
            this.btnProblem1.Name = "btnProblem1";
            this.btnProblem1.Size = new System.Drawing.Size(75, 23);
            this.btnProblem1.TabIndex = 16;
            this.btnProblem1.Text = "Vowel count";
            this.btnProblem1.UseVisualStyleBackColor = true;
            this.btnProblem1.Click += new System.EventHandler(this.btnProblem1_Click);
            // 
            // btnProblem2
            // 
            this.btnProblem2.Location = new System.Drawing.Point(146, 570);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(75, 23);
            this.btnProblem2.TabIndex = 17;
            this.btnProblem2.Text = "button1";
            this.btnProblem2.UseVisualStyleBackColor = true;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 649);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.btnProblem1);
            this.Controls.Add(this.btnLetter);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnRegular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnSubstring4;
        private System.Windows.Forms.Button btnSubstring35;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnIndexof;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegular;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnLetter;
        private System.Windows.Forms.Button btnProblem1;
        private System.Windows.Forms.Button btnProblem2;
    }
}

