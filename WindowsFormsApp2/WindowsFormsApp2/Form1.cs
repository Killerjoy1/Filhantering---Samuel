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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = Environment.CurrentDirectory + "/" + "SamuelsText.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            { 
                File.CreateText(path);
                MessageBox.Show("Filen Skapades utan problem");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Tjena Tim");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadLine();
                richTextBox1.Text = text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show("Radera Fil");
            }
        }
    }
}
