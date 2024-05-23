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

        

        private int indexIntrebareCurenta = 10;
        private int indexIntrebareCurenta1 = 0;
        private int indexIntrebareCurenta2 = 20;


        Stocare c1 = new Stocare();
        Quizz ecran = new Quizz();
        Timer timer = new Timer();
        Timer timer1 = new Timer();

        int punctajTotal = 0;

        public Form1()
        {
            InitializeComponent();
            button12.Click += new EventHandler(button12_Click);
            button13.Click += new EventHandler(button13_Click);
            button16.Click += new EventHandler(button16_Click);
            radioButton1.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);


            label8.Parent = pictureBox1;        // Salvare
            label3.Parent = pictureBox1;        // Intrebari
            label5.Parent = pictureBox1;        // Punctaj
            textBox3.Parent = pictureBox1;      // Raspuns
            button14.Parent = pictureBox1;      // Next
            button15.Parent = pictureBox1;      // Verifica
            radioButton3.Parent = pictureBox1;  // DA
            radioButton4.Parent = pictureBox1;  // NU
            textBox4.Parent = pictureBox1;      // Nume
            button10.Parent = pictureBox1;      // Submit
            label5.Visible = true;              // 
            label8.Visible = false;             //
            button10.Visible = false;           //
            textBox4.Visible = false;           //
            radioButton3.Visible = false;       //
            radioButton4.Visible = false;       //
           


            label6.Parent = pictureBox2;        // Salvare
            label2.Parent = pictureBox2;        // Intrebari
            label4.Parent = pictureBox2;        // Punctaj
            textBox2.Parent = pictureBox2;      // Raspuns
            button9.Parent = pictureBox2;       // Next
            button11.Parent = pictureBox2;      // Verifica
            radioButton1.Parent = pictureBox2;  // DA
            radioButton2.Parent = pictureBox2;  // NU
            textBox1.Parent = pictureBox2;      // Nume
            button12.Parent = pictureBox2;      // Submit
            button12.Visible = false;           //
            label6.Visible = false;             //
            textBox2.Visible = false;           //
            radioButton1.Visible = false;       //
            radioButton2.Visible = false;       //
            label4.Visible = true;              //


            label10.Parent = pictureBox4;       // Salvare
            label9.Parent = pictureBox4;        // Intrebari
            label11.Parent = pictureBox4;       // Punctaj
            textBox6.Parent = pictureBox4;      // Raspuns
            button13.Parent = pictureBox4;      // Next
            button16.Parent = pictureBox4;      // Verifica
            radioButton5.Parent = pictureBox4;  // DA
            radioButton6.Parent = pictureBox4;  // NU
            textBox5.Parent = pictureBox4;      // Nume
            button17.Parent = pictureBox4;      // Submit
            button17.Visible = false;           //
            label10.Visible = false;            //
            textBox5.Visible = false;           //
            radioButton5.Visible = false;       //
            radioButton6.Visible = false;       //
            label11.Visible = true;             //

            label1.Parent = pictureBox3;        // Meniu
            button1.Parent = pictureBox3;       // Domeniu
            button2.Parent = pictureBox3;       // Domeniu
            button20.Parent = pictureBox3;      // Domeniu
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox6.BackColor = Color.White;


            timer.Stop();
        }

        private void button9_Click(object sender, EventArgs e)                         //
        {
            string caleFisier5 = "intrebari.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            button9.Enabled = false;
            if (indexIntrebareCurenta < nrLinii-10)                                     //next
            {

                int len = rezultat[indexIntrebareCurenta].Length;
                label2.Text = rezultat[indexIntrebareCurenta].Substring(0, len - 2);   

                indexIntrebareCurenta++;
            }
            button11.Enabled = true;
        }                                                                                 //
        private void button11_Click(object sender, EventArgs e)                           //
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            string caleFisier5 = "intrebari.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            button11.Enabled = false;
            if (textBox1.Text == rezultat1[indexIntrebareCurenta - 1])                   
            {
                punctajTotal++;
                label4.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");

                textBox1.BackColor = Color.Green;
                timer.Start();

            }
            else
            {
                MessageBox.Show("Răspunsul este incorect!");                      //verifica
                textBox1.BackColor = Color.Red;
                timer.Start();
            }

            if (indexIntrebareCurenta >= nrLinii-10)
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
            button9.Enabled = true;
        }                                                                          //
        private void button14_Click(object sender, EventArgs e)                    //
        {
            string caleFisier5 = "intrebari.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            button14.Enabled = false;
            if (indexIntrebareCurenta1 < nrLinii-20)
            {

                int len = rezultat[indexIntrebareCurenta1].Length;
                label3.Text = rezultat[indexIntrebareCurenta1].Substring(0, len - 2);  // next

                indexIntrebareCurenta1++;
            }
            button15.Enabled = true;
        }                                                                              //

        private void button15_Click(object sender, EventArgs e)                        // 
        {
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
            string caleFisier5 = "intrebari.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            button15.Enabled = false;
            if (textBox3.Text == rezultat1[indexIntrebareCurenta1 - 1])
            {
                punctajTotal++;
                label5.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");

                textBox3.BackColor = Color.Green;
                timer.Start();

            }
            else
            {
                MessageBox.Show("Răspunsul este incorect!");                     //verifica
                textBox3.BackColor = Color.Red;
                timer1.Start();
            }

            if (indexIntrebareCurenta1 >= nrLinii-20)
            {
                button14.Visible = false;
                button15.Visible = false;
                textBox3.Visible = false;
                radioButton3.Visible = true;
                textBox3.Visible = false;
                radioButton4.Visible = true;
                label3.Visible = false;

                label8.Visible = true;
            }
            button14.Enabled = true;
        }                                                                        //

        private void button13_Click(object sender, EventArgs e)                    //
        {
            string caleFisier5 = "intrebari.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            button13.Enabled = false;
            if (indexIntrebareCurenta2 < nrLinii)
            {

                int len = rezultat[indexIntrebareCurenta2].Length;
                label9.Text = rezultat[indexIntrebareCurenta2].Substring(0, len - 2);  //next

                indexIntrebareCurenta2++;
            }
            button16.Enabled = true;

        }                                                                             //
        private void button16_Click(object sender, EventArgs e)                      //
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            string caleFisier5 = "intrebari.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1 = c1.GetRaspunsuri(caleFisier5);

            button16.Enabled = false;
            if (textBox6.Text == rezultat1[indexIntrebareCurenta2 - 1])
            {
                punctajTotal++;
                label11.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");

                textBox6.BackColor = Color.Green;
                timer.Start();

            }
            else
            {
                MessageBox.Show("Răspunsul este incorect!");                    // verifica
                textBox6.BackColor = Color.Red;
                timer.Start();
            }

            if (indexIntrebareCurenta2 >= nrLinii )
            {
                button13.Visible = false;
                button16.Visible = false;

                radioButton5.Visible = true;
                textBox6.Visible = false;
                radioButton6.Visible = true;
                label9.Visible = false;
                
                label10.Visible = true;
            }
            button13.Enabled = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Visible = true;
                button12.Visible = true;
            }
        }                                                                            //

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Environment.Exit(0);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            c1.Tabela(punctajTotal, textBox4.Text, button1.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox4.Visible = true;
                button10.Visible = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                Environment.Exit(0);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            c1.Tabela(punctajTotal, textBox2.Text, button2.Text);

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                textBox5.Visible = true;
                button17.Visible = true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                Environment.Exit(0);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            c1.Tabela(punctajTotal, textBox5.Text, button20.Text);
            Form3 Form3 = new Form3();
            Form3.Form3_Load(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button6.BringToFront();
            button8.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button7.BringToFront();
            button5.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.BringToFront();
            button18.BringToFront();
            button19.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button5.BringToFront();
            button7.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.BringToFront();
            button19.BringToFront();
            button18.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button6.BringToFront();
            button8.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.BringToFront();
            button18.BringToFront();
            button19.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();
            button3.BringToFront();
            button4.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button5.BringToFront();
            button7.BringToFront();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();
            button3.BringToFront();
            button4.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button8.BringToFront();
            button6.BringToFront();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click_2(object sender, EventArgs e)
        {

        }
    }
}
