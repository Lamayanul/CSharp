using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelStocareDate;
using Quiz;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form1 Form1Instance { get; set; }

        string caleFisier5 = "intrebari.txt";

        Stocare c1 = new Stocare();
        Tot t1 = new Tot();
        public Form2()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            this.Load += new EventHandler(label4_Click);
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);
            for (int i = 0; i < nrLinii; i++)
            {
                intrebari[i] = new Intrebare(rezultat[i], rezultat1[i]);
            }
            string s = textBox1.Text;
            StringBuilder textConcatenat = new StringBuilder();

            foreach (Intrebare intrebare in intrebari)
            {
                if (intrebare.ContineCuvant(s))
                {
                    textConcatenat.AppendLine(intrebare.AfisIntrebare());
                }
            }
            label2.Text = textConcatenat.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = t1.ExecutaChallenge();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
