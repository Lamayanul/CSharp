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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp
{

    public partial class Form1 : Form
    {

        private int indexIntrebareCurenta = 6;
        private int indexIntrebareCurenta1 = 0;
        private int index = 0;
        private int index1 = 0;

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
            button13.Click += new EventHandler(button13_Click);
            button15.Click += new EventHandler(button15_Click);
            radioButton1.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);

            label1.Parent = pictureBox3;
            button1.Parent = pictureBox3;
            button2.Parent = pictureBox3;
            label2.Parent = pictureBox2;
            button9.Parent = pictureBox2;
            Intrebari.Visible = false;
            label7.Parent = pictureBox1;
            textBox1.Parent = pictureBox2;
            button11.Parent = pictureBox2;
            label4.Parent = pictureBox2;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox2;
            textBox2.Parent = pictureBox2;
            button12.Parent = pictureBox2;
            radioButton1.Parent = pictureBox2;
            radioButton2.Parent = pictureBox2;
            checkBox1.Parent = pictureBox1;
            checkBox2.Parent = pictureBox1;
            checkBox3.Parent = pictureBox1;
            checkBox4.Parent = pictureBox1;
            button14.Parent = pictureBox1;
            button15.Parent = pictureBox1;
            button12.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
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
        private void button14_Click(object sender, EventArgs e)
        {
            string cale = "intrebari1.txt";
            int nrLinii = c1.NumarLinii(cale);
            Intrebare1[] intrebari = new Intrebare1[nrLinii];
            string[] rezultat = c1.GetIntr(cale);
            string[] rezultat1 = c1.GetRasp(cale);
            button14.Enabled = false;


            if (index1 < nrLinii)
            {
                char separator = '?';
                int indexSeparator = rezultat[index1].IndexOf(separator);

                if (indexSeparator >= 0)
                {
                    checkBox1.Text = rezultat1[index];
                    checkBox2.Text = rezultat1[index + 1];
                    checkBox3.Text = rezultat1[index + 2];
                    checkBox4.Text = rezultat1[index + 3];
                    index = index + 4;
                    string intrebare = rezultat[index1].Substring(0, indexSeparator + 1);
                    label7.Text = intrebare;
                }
                else
                {

                    label7.Text = "Eroare la citirea întrebării";
                }

                index1++;
            }
        
    
            
            button15.Enabled = true;
    }
        private void button15_Click(object sender, EventArgs e)
        {
          
            string caleFisier5 = "intrebari1.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntr(caleFisier5);
            string[] rezultat1 = c1.GetRasp(caleFisier5);
            string[] rezultat2 = c1.Corect(caleFisier5);
            button15.Enabled = false;
           
            if (checkBox1.Checked && checkBox1.Text  == rezultat2[index1-1])
            {
                punctajTotal++;
                label5.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");

            }
            else if(checkBox2.Checked && checkBox2.Text == rezultat2[index1-1])
            {
                punctajTotal++;
                label5.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else if(checkBox3.Checked && checkBox3.Text == rezultat2[index1 - 1])
            {
                punctajTotal++;
                label5.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else if(checkBox4.Checked && checkBox4.Text == rezultat2[index1 - 1])
            {
                punctajTotal++;
                label5.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else
            {
                MessageBox.Show("Răspunsul este incorect!");
            }

            if (index1 >= nrLinii)
            {
               button15.Visible= false;
               button14.Visible= false;
               checkBox1.Visible= false;
               checkBox2.Visible= false;
               checkBox3.Visible= false;
               checkBox4.Visible= false;
            }
            button14.Enabled = true;
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
                Intrebari.Text = rezultat[indexIntrebareCurenta1].Substring(0, len - 2);

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
                textBox2.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label2.Visible = false;
                button12.Visible = false;
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

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Form1Instance = this; 
            form2.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Visible = true;
                button12.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Environment.Exit(0);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
