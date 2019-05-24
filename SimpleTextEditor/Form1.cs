using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void PumpumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|.txt";
            ofd.Title = "Выберите файл";
        }

        private void PamPamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Clear(); 
        }
    }
}
