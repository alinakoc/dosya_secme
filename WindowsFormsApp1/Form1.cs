using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "";
        public OpenFileDialog ofd;

        private void DosyaAc_Click(object sender, EventArgs e)
        {
        ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.FileName= path; 

        }

        private void DosyaOku_Click(object sender, EventArgs e)
        {
            if (ofd == null || string.IsNullOrEmpty(ofd.FileName))
                MessageBox.Show("Dosya Seçmelisiniz"); 
            
            
            else
            {
                var dosya = new StreamReader(ofd.InitialDirectory + ofd.FileName);
                richTextBox1.Text = dosya.ReadToEnd();
                dosya.Close();
            }
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (ofd == null || string.IsNullOrEmpty(ofd.FileName))
                MessageBox.Show("Dosya Seçmelisiniz");


            else
            {
                TextWriter writer = new StreamWriter(ofd.InitialDirectory + ofd.FileName);
                writer.WriteLine(richTextBox1.Text);
                writer.Close();
                MessageBox.Show("dosya değiştirildi");
            }
        }
    }
}
