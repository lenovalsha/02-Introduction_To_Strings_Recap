using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _02_Introduction_To_Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string input;
        #region Intro
        private void btnLength_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            if (input != string.Empty)
            {
                txtOutput.Text = input.Length.ToString();
            }
        }

        private void btnSubstring4_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            if (input != string.Empty)
            {
                txtOutput.Text = input.Substring(4);
            }
        }

        private void btnSubstring35_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            if (input != string.Empty)
            {
                txtOutput.Text = input.Substring(2, 5);
            }
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            if (input != string.Empty)
            {
                txtOutput.Text = input.StartsWith("S").ToString();
            }
        }

        private void btnIndexof_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            if (input != string.Empty)
            {
                txtOutput.Text = input.IndexOf("A").ToString();
            }
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            if (input != string.Empty)
            {
                txtOutput.Text = input.ToUpper();
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            if (input != string.Empty)
            {
                txtOutput.Text = input.Replace("a", "x");
            }
        }
        #endregion
        #region ListBox Example
        private void btnRegular_Click(object sender, EventArgs e)
        {
            string x;
            x = Microsoft.VisualBasic.Interaction.InputBox("Enter", "Strings", "", 200, 200);
            for (int i = 0; i < x.Length; i++)
            {
                lstOutput.Items.Add(x.Substring(i, 1) + Environment.NewLine);
            }


        }
        private void btnReverse_Click(object sender, EventArgs e)
        {
            string x;
            x = Microsoft.VisualBasic.Interaction.InputBox("Enter", "Strings", "", 200, 200);
            for (int i = x.Length - 1; i >= 0; i--)
            {
                lstOutput.Items.Add(x.Substring(i, 1) + Environment.NewLine);
            }
        }
        private void btnLetter_Click(object sender, EventArgs e)
        {
            //user input
            string x;
            //letter that we want to keep a count on
            string letter = "a";
            //variable to keep the count
            int a = 0;
            x = Microsoft.VisualBasic.Interaction.InputBox("Enter", "Strings", "", 200, 200);
            //one way
            for (int i = 0; i < x.Length; i++)
            {
                if (x.Substring(i, 1) == letter)
                {
                    a++;
                }
            }
            MessageBox.Show(a.ToString());

            //another way -> this is harder...
            //we can have a list of letters
            //List<string> letters = new List<string>();
            //foreach (var s in x)
            //{
            //    letters.Add(s.ToString());
            //}
            //foreach (string s in letters)
            //{
            //    lstOutput.Items.Add(s);
            //    if (s == letter)
            //        a++;
            //}
            //MessageBox.Show(a.ToString());

        }
        #endregion
        #region Practice Problems
        private void btnProblem1_Click(object sender, EventArgs e)
        {
            //store vowels in an array
            string[] vowels = new[] { "a", "e", "i", "o", "u" };
            //get the input from the user
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter", "Strings", "", 200, 200);
            //this is to count the vowels 
            int a = 0;
            foreach (string s in vowels) //foreach vowel in our array
            {
                //if (input.Contains(s))//see if our user input has any of them and if so count
                //    a++; // this doesnt work as its not counting vowels that are being used twice
                for (int i = 0; i < input.Length; i++)
                {
                    string x = input.Substring(i, 1);//see if our user input has any of them and if so count
                    if (x.Contains(s))
                    { a++; }
                }

            }
            MessageBox.Show(a.ToString());


        }
        #endregion

        private void btnProblem2_Click(object sender, EventArgs e)
        {
            //write a program that accept a sentence as data and  will determine the number of times the word "the" appears in it
            //user input
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter", "Strings", "", 200, 200);
            string the = "the";
            string space = " ";
            int a = 0;
            int index = 0;

            //break up the words by space
            char separator = ' ';
            //store the words into an array
            string[] words = input.Split(separator);
            foreach(string word in words)
            {
                if (word == the) 
                { a++; }

            }
            MessageBox.Show(a.ToString());




        }
    }
}
