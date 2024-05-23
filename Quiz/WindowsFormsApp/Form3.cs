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
using NivelStocareDate;
using static System.Windows.Forms.LinkLabel;
using Quiz;


namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        Stocare s1 = new Stocare();
        Tot t1 = new Tot();
        public Form3()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form3_Load);
            this.Load += new EventHandler(label4_Click);  
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            string caleFisier3 = "C:\\C#\\Proiect_CSharp\\CSharp\\Quiz\\Quiz\\bin\\Debug\\dabela.txt";
            StringBuilder content = new StringBuilder();
            using (StreamReader reader = new StreamReader(caleFisier3))
            {
                string linie;

                while ((linie = reader.ReadLine()) != null)
                {
                    content.AppendLine(linie);
                }
            }
            label40.Text = content.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = s1.ScorMare("C:\\C#\\Proiect_CSharp\\CSharp\\Quiz\\Quiz\\bin\\Debug\\dabela.txt");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
