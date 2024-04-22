using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz;
using NivelStocareDate;
using System.IO;


namespace WindowsFormsApp
{

    public partial class Form1 : Form
    {

        private int indexIntrebareCurenta = 6;
        private int indexIntrebareCurenta1 = 0;
       
        Stocare c1 = new Stocare();
        Quizz ecran = new Quizz();
        Timer timer = new Timer();
        
        int punctajTotal = 0;






        public Form1()
        {
            InitializeComponent();



            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);

            button3.Click += new EventHandler(button3_Click_1);
            button4.Click += new EventHandler(button4_Click_1);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button12.Click += new EventHandler(button12_Click);

            label1.Parent = pictureBox3;
            button1.Parent = pictureBox3;
            button2.Parent = pictureBox3;
            label2.Parent = pictureBox2;
            button9.Parent = pictureBox2;
            label3.Parent = pictureBox1;
            button10.Parent = pictureBox1;
            textBox1.Parent = pictureBox2;
            button11.Parent = pictureBox2;
            label4.Parent = pictureBox2;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox2;
            textBox2.Parent = pictureBox2;
            button12.Parent = pictureBox2;
            button12.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;   
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button3.BringToFront();
            button4.BringToFront();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button3.BringToFront();
            button4.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button5.BringToFront();
            button4.BringToFront();


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button5.BringToFront();
            button7.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button4.BringToFront();
            button6.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();
            button4.BringToFront();
            button3.BringToFront();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button3.BringToFront();
            button8.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();
            button4.BringToFront();
            button3.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string caleFisier5 = "intrebari.txt";

            

            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            button9.Enabled = false;
            if (indexIntrebareCurenta < nrLinii)
            {

                int len = rezultat[indexIntrebareCurenta].Length;
                label2.Text = rezultat[indexIntrebareCurenta].Substring(0, len - 2);
                
                indexIntrebareCurenta++;
            }
            button11.Enabled = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string caleFisier5 = "intrebari.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            if (indexIntrebareCurenta1 < nrLinii-3)
            {

                int len = rezultat[indexIntrebareCurenta1].Length;
                label3.Text = rezultat[indexIntrebareCurenta1].Substring(0, len - 2);

                indexIntrebareCurenta1++;
            }
            
        }
            

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.White;


            timer.Stop();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            string caleFisier5 = "intrebari.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            button11.Enabled = false;
            if (textBox1.Text == rezultat1[indexIntrebareCurenta-1])
            {
                punctajTotal++;
                label4.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");

                textBox1.BackColor = Color.Green;
                timer.Start();

            }
            else
            {
                MessageBox.Show("Răspunsul este incorect!");
                textBox1.BackColor = Color.Red;
                timer.Start();
            }
           
            if (indexIntrebareCurenta >= nrLinii)
            {
                button9.Visible = false;
                button11.Visible = false;
                textBox1.Visible = false;
                label6.Visible = true;
                textBox2.Visible = true;
                label2.Visible = false;
                button12.Visible = true;
            }
            button9.Enabled= true;  
        }
    
            
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            c1.Tabela(punctajTotal, textBox2.Text);

        }
    }
}
