using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniqueWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Char[] separators = new Char[] { ' ', '\r', '\n', '\t', ',', '.', ';', '!', '?', '@', '#', '$', '%', '^'};

            SortedSet<String> uniqueWords =
            new SortedSet<String>(textBox1.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries),
                StringComparer.OrdinalIgnoreCase);
            
            textBox2.Text = String.Join(Environment.NewLine, uniqueWords);
            label3.Text = uniqueWords.Count.ToString();

        }
    }
}
