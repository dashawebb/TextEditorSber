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

        private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)| *.txt";
            ofd.Title = "Выберите файл";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd(); // вот тут надо изменить на чтение построчно
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Click += new EventHandler(ShowMessage);
            Controls.Add(button1);
            richTextBox1.Clear();
            /*   textBox1;
               textBox2;
               comboBox1;
               button1;
               */
           /* InitializeComponent();
            Button button1 = new Button; */
        }
        private void ShowMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Button Click");
        }


       /* private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)| *.txt";
            ofd.Title = "Выберите файл";
            MessageBox.Show("Dynamic button is clicked");
        }


        private void CreateDynamicButton()
        {

            // Create a Button object  
            Button dynamicButton = new Button();

            // Set Button properties  
            dynamicButton.Height = 40;
            dynamicButton.Width = 300;
            dynamicButton.BackColor = Color.Red;
            dynamicButton.ForeColor = Color.Blue;
            dynamicButton.Location = new Point(20, 150);
            dynamicButton.Text = "I am Dynamic Button";
            dynamicButton.Name = "DynamicButton";
            dynamicButton.Font = new Font("Georgia", 16);

            // Add a Button Click Event handler  
            dynamicButton.Click += new EventHandler(DynamicButton_Click);

            // Add Button to the Form. Placement of the Button  
            // will be based on the Location and Size of button  
            Controls.Add(dynamicButton);
        }
        /// <summary>  
        /// Button click event handler  
        /// </summary>  

        /// <param name="sender"></param>  
        /// <param name="e"></param>  

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dynamic button is clicked");
        }
        */
        /* на кнопке висит эвент
         * когда он срабатывает,
         * дата записывается из полей
         * запускается поиск по 4 ключевым словам
         * 
         * richTextBox1.Clear();

         *  StringBuilder sb = new StringBuilder();

        * StreamReader sr = new StreamReader(path);
        * while ((line = sr.ReadLine()) != null)
        {
            line = line.Trim();

            if (codeRegex.IsMatch(line))
                continue;

            if (string.IsNullOrEmpty(line))
            {
                System.Console.Write(sb.ToString().Trim() + Environment.NewLine);
                sb.Clear();
            }
            else
            {
                sb.Append(line);
                sb.Append("\t");
            }
        }
         */
    }


}
