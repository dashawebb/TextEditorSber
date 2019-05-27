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

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string line = "";
            int i = 0;
            ofd.Filter = "Text Files (.txt)| *.txt";
            ofd.Title = "Выберите файл";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            if (i == 0)
                            {
                                richTextBox1.AppendText(line);
                                richTextBox1.ScrollToCaret();
                                i++;
                            }
                            else
                            {
                                richTextBox1.AppendText("\r\n" + line);
                                richTextBox1.ScrollToCaret();
                            }
                        }

                    }
                    sr.Close();
                }

            }
        }

        public string[] RtbFullText;

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void FilterButton(object sender, EventArgs e)
        {
            RtbFullText = richTextBox1.Text.Split('\n');
            richTextBox1.Text = "";
            foreach (string _s in RtbFullText)
            {
                if (_s.Contains(textBox1.Text))
                    richTextBox1.Text += _s + "\n";
            }

        }

        private void ClearButton(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("\r\n" + RtbFullText);

            richTextBox1.Text += RtbFullText;
        }
    }
}
