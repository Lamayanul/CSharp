using Quiz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelStocareDate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        private int index = 0;
        private int index1 = 0;
        private int index2 = 10;
        private int index3 = 40;
        private int index4 = 20;
        private int index5 = 80;

        Stocare c1 = new Stocare();
        Quizz ecran = new Quizz();
        Timer timer = new Timer();

        int punctajTotal = 0;

        public Form4()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button7.Click += new EventHandler(button7_Click);
            button8.Click += new EventHandler(button8_Click);
            radioButton3.CheckedChanged += new EventHandler(radioButton3_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButton4_CheckedChanged);

            label1.Parent = pictureBox1;        // Intrebari
            label2.Parent = pictureBox1;        // Punctaj
            button3.Parent = pictureBox1;       // Submit
            textBox1.Parent = pictureBox1;      // Nume
            checkBox1.Parent = pictureBox1;     //
            checkBox2.Parent = pictureBox1;     //
            checkBox3.Parent = pictureBox1;     //
            checkBox4.Parent = pictureBox1;     //
            button2.Parent = pictureBox1;       // Next
            button1.Parent = pictureBox1;       // Verifica
            radioButton1.Parent = pictureBox1;  // DA
            radioButton2.Parent = pictureBox1;  // NU
            button4.Parent = pictureBox1;
            button5.Parent = pictureBox1;

            button3.Visible = false;       
            textBox1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            
           
            label3.Parent = pictureBox2;        // Intrebari
            label4.Parent = pictureBox2;        // Punctaj
            button6.Parent = pictureBox2;       // Submit
            textBox2.Parent = pictureBox2;      // Nume
            checkBox5.Parent = pictureBox2;     //
            checkBox6.Parent = pictureBox2;     //
            checkBox7.Parent = pictureBox2;     //
            checkBox8.Parent = pictureBox2;     //
            button7.Parent = pictureBox2;       // Next
            button8.Parent = pictureBox2;       // Verifica
            radioButton3.Parent = pictureBox2;  // DA
            radioButton4.Parent = pictureBox2;  // NU
            button9.Parent = pictureBox2;
            button10.Parent = pictureBox2;

            button6.Visible = false;
            textBox2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;


            label5.Parent = pictureBox3;        // Intrebari
            label6.Parent = pictureBox3;        // Punctaj
            button11.Parent = pictureBox3;      // Submit
            textBox3.Parent = pictureBox3;      // Nume
            checkBox9.Parent = pictureBox3;     //
            checkBox10.Parent = pictureBox3;    //
            checkBox11.Parent = pictureBox3;    //
            checkBox12.Parent = pictureBox3;    //
            button12.Parent = pictureBox3;      // Next
            button13.Parent = pictureBox3;      // Verifica
            radioButton5.Parent = pictureBox3;  // NU
            radioButton6.Parent = pictureBox3;  // DA
            button14.Parent =    pictureBox3;
            button15.Parent = pictureBox3;

            button11.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;
            button6.Visible = false;
            button11.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;


            label7.Parent = pictureBox4;        // Label domeniu
            button16.Parent = pictureBox4;      // Domeniu
            button17.Parent = pictureBox4;      // Domeniu
            button18.Parent = pictureBox4;      // Domeniu
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string caleFisier5 = "intrebari1.txt";
                int nrLinii = c1.NumarLinii(caleFisier5);
                Intrebare[] intrebari = new Intrebare[nrLinii];
                string[] rezultat = c1.GetIntr(caleFisier5);
                string[] rezultat1 = c1.GetRasp(caleFisier5);
                string[] rezultat2 = c1.Corect(caleFisier5);
                button1.Enabled = false;

                if (checkBox1.Checked && checkBox1.Text == rezultat2[index1 - 1])
                {
                    punctajTotal++;
                    label2.Text = "Punctaj acumulat: " + punctajTotal;
                    MessageBox.Show("Răspunsul este corect!");

                }
                else if (checkBox2.Checked && checkBox2.Text == rezultat2[index1 - 1])
                {
                    punctajTotal++;
                    label2.Text = "Punctaj acumulat: " + punctajTotal;
                    MessageBox.Show("Răspunsul este corect!");
                }
                else if (checkBox3.Checked && checkBox3.Text == rezultat2[index1 - 1])
                {
                    punctajTotal++;
                    label2.Text = "Punctaj acumulat: " + punctajTotal;
                    MessageBox.Show("Răspunsul este corect!");
                }
                else if (checkBox4.Checked && checkBox4.Text == rezultat2[index1 - 1])
                {
                    punctajTotal++;
                    label2.Text = "Punctaj acumulat: " + punctajTotal;
                    MessageBox.Show("Răspunsul este corect!");
                }
                else
                {
                    MessageBox.Show("Răspunsul este incorect!");
                }

                if (index1 >= nrLinii-20)
                {
                    button2.Visible = false;
                    button1.Visible = false;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                button3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label1.Text = "Salvati scorul?";
                }
                button2.Enabled = true;
            }

        private void button8_Click(object sender, EventArgs e)
        {
            string caleFisier5 = "intrebari1.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntr(caleFisier5);
            string[] rezultat1 = c1.GetRasp(caleFisier5);
            string[] rezultat2 = c1.Corect(caleFisier5);
            button8.Enabled = false;

            if (checkBox5.Checked && checkBox5.Text == rezultat2[index2 - 1])
            {
                punctajTotal++;
                label4.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");

            }
            else if (checkBox6.Checked && checkBox6.Text == rezultat2[index2 - 1])
            {
                punctajTotal++;
                label4.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else if (checkBox7.Checked && checkBox7.Text == rezultat2[index2 - 1])
            {
                punctajTotal++;
                label4.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else if (checkBox8.Checked && checkBox8.Text == rezultat2[index2 - 1])
            {
                punctajTotal++;
                label4.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else
            {
                MessageBox.Show("Răspunsul este incorect!");
            }

            if (index2 >= nrLinii-10)
            {
                button7.Visible = false;
                button8.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;
                checkBox8.Visible = false;
                button6.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                textBox2.Visible = true;
                label3.Text = "Salvati scorul?";
            }
            button7.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string caleFisier5 = "intrebari1.txt";
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntr(caleFisier5);
            string[] rezultat1 = c1.GetRasp(caleFisier5);
            string[] rezultat2 = c1.Corect(caleFisier5);
            button13.Enabled = false;

            if (checkBox9.Checked && checkBox9.Text == rezultat2[index4 - 1])
            {
                punctajTotal++;
                label6.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");

            }
            else if (checkBox10.Checked && checkBox10.Text == rezultat2[index4 - 1])
            {
                punctajTotal++;
                label6.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else if (checkBox11.Checked && checkBox11.Text == rezultat2[index4 - 1])
            {
                punctajTotal++;
                label6.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else if (checkBox12.Checked && checkBox12.Text == rezultat2[index4 - 1])
            {
                punctajTotal++;
                label6.Text = "Punctaj acumulat: " + punctajTotal;
                MessageBox.Show("Răspunsul este corect!");
            }
            else
            {
                MessageBox.Show("Răspunsul este incorect!");
            }

            if (index4 >= nrLinii)
            {
                button12.Visible = false;
                button13.Visible = false;
                checkBox9.Visible = false;
                checkBox10.Visible = false;
                checkBox11.Visible = false;
                checkBox12.Visible = false;
                button11.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                textBox3.Visible = true;
                label5.Text = "Salvati scorul?";
            }
            button12.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cale = "intrebari1.txt";
            int nrLinii = c1.NumarLinii(cale);
            Intrebare1[] intrebari = new Intrebare1[nrLinii];
            string[] rezultat = c1.GetIntr(cale);
            string[] rezultat1 = c1.GetRasp(cale);
            button2.Enabled = false;
            button1.Enabled = false;


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
                    label1.Text = intrebare;
                }
                else
                {

                    label1.Text = "Eroare la citirea întrebării";
                }

                index1++;
            }
            button1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cale = "intrebari1.txt";
            int nrLinii = c1.NumarLinii(cale);
            Intrebare1[] intrebari = new Intrebare1[nrLinii];
            string[] rezultat = c1.GetIntr(cale);
            string[] rezultat1 = c1.GetRasp(cale);
            button7.Enabled = false;
            button8.Enabled = false;


            if (index2 < nrLinii)
            {
                char separator = '?';
                int indexSeparator = rezultat[index2].IndexOf(separator);

                if (indexSeparator >= 0)
                {
                    checkBox5.Text = rezultat1[index3];
                    checkBox6.Text = rezultat1[index3 + 1];
                    checkBox7.Text = rezultat1[index3 + 2];
                    checkBox8.Text = rezultat1[index3 + 3];
                    index3 = index3 + 4;
                    string intrebare = rezultat[index2].Substring(0, indexSeparator + 1);
                    label3.Text = intrebare;
                }
                else
                {

                    label3.Text = "Eroare la citirea întrebării";
                }

                index2++;
            }



            button8.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string cale = "intrebari1.txt";
            int nrLinii = c1.NumarLinii(cale);
            Intrebare1[] intrebari = new Intrebare1[nrLinii];
            string[] rezultat = c1.GetIntr(cale);
            string[] rezultat1 = c1.GetRasp(cale);
            button12.Enabled = false;
            button13.Enabled = false;


            if (index4 < nrLinii)
            {
                char separator = '?';
                int indexSeparator = rezultat[index4].IndexOf(separator);

                if (indexSeparator >= 0)
                {
                    checkBox9.Text = rezultat1[index5];
                    checkBox10.Text = rezultat1[index5 + 1];
                    checkBox11.Text = rezultat1[index5 + 2];
                    checkBox12.Text = rezultat1[index5 + 3];
                    index5 = index5 + 4;
                    string intrebare = rezultat[index4].Substring(0, indexSeparator + 1);
                    label5.Text = intrebare;
                }
                else
                {

                    label5.Text = "Eroare la citirea întrebării";
                }

                index4++;
            }



            button13.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Environment.Exit(0);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Visible = true;
                button3.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Environment.Exit(0);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                textBox2.Visible = true;
                button6.Visible = true;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                Environment.Exit(0);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                textBox3.Visible = true;
                button11.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button9.BringToFront();
            button10.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.BringToFront();
            button19.BringToFront();
            button20.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();
            button14.BringToFront();
            button15.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button5.BringToFront();
            button4.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.BringToFront();
            button19.BringToFront();
            button20.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button9.BringToFront();
            button10.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button4.BringToFront();
            button5.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();
            button15.BringToFront();
            button14.BringToFront();
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            button4.BringToFront();
            button5.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            button10.BringToFront();
            button9.BringToFront();
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();
            button14.BringToFront();
            button15.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void button11_Click(object sender, EventArgs e)
        {
            c1.Tabela(punctajTotal, textBox3.Text, button18.Text);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            c1.Tabela(punctajTotal, textBox2.Text, button17.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            c1.Tabela(punctajTotal, textBox1.Text, button16.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

      
    }
    }

