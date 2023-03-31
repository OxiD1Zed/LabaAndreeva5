using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5лаба_Андреева
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Смена положения";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 399)
            {
                textBox1.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                textBox1.ScrollBars = ScrollBars.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> words = new List<string>();
            string str = textBox1.Text.Trim();

            string word = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                    if (i == (str.Length - 1) && word.Length != 1)
                        words.Add(Program.ReplaceStartEnd(word));
                    else if (i == (str.Length - 1))
                    {
                        words.Add(word);
                    }
                }
                else if (word.Length == 1)
                {
                    words.Add(word);
                    word = "";
                }
                else
                {
                    if (word.Length != 0)
                    {
                        words.Add(Program.ReplaceStartEnd(word));
                        word = "";
                    }
                }
            }

            textBox2.Text = String.Join(" ", words);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 399)
            {
                textBox2.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                textBox2.ScrollBars = ScrollBars.None;
            }
        }
    }
}
