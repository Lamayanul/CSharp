using Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Intrebare[] intrebari = new Intrebare[6];
            intrebari[0] = new Intrebare("Cerul este albastru?", "y");
            intrebari[1] = new Intrebare("Romania este cea mai frumoasa tara?", "y");
            intrebari[2] = new Intrebare("Exista munti in Romania?", "y");
            intrebari[3] = new Intrebare("Mancarea romaneasca este buna?", "y");
            intrebari[4] = new Intrebare("Inteligenta artificiala este o amenintare?", "y");
            intrebari[5] = new Intrebare("Ai vrea sa ajungi pe luna?", "y");
            int punctajTotal = 0;
            Console.WriteLine("Esti pregatit pentru QUIZ?   y : n");
            string rasp = Console.ReadLine();

            if (rasp == "y")
            {

                for (int i = 0; i < intrebari.Length; i++)
                {
                    intrebari[i].AfisIntrebare();
                    string ras = Console.ReadLine();
                    intrebari[i].Verifica(ras);
                    intrebari[i].AfisareScor();
                    punctajTotal += intrebari[i].raspunsC;
                }
                Console.WriteLine("Punctaj total acumulat: " + punctajTotal);
                Console.ReadLine();
                Console.WriteLine("Daca vrei intreabri doar cu Romania apasa 's'");
                string s = Console.ReadLine();
                foreach (Intrebare intrebare in intrebari)
                {
                    if (intrebare.ContineCuvant("Romania"))
                    {
                        intrebare.AfisIntrebare();
                    }
                }
                Console.ReadLine();

            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
    public class Intrebare
    {
        public int raspunsC { get; set; }
        public int raspunsG { get; set; }
        string intrebare;
        string raspuns;
        public Intrebare(string intr, string rasp)
        {
            intrebare = intr;
            raspuns = rasp;
        }

        public void AfisIntrebare()
        {
            Console.WriteLine(intrebare);
        }
        public void Verifica(string str)
        {
            if (str == "y")
            {
                raspunsC++;
            }
            else
            {
                raspunsG++;
            }
        }
        public void AfisareScor()
        {
            Console.WriteLine("Ai acumulat : {0} puncte", raspunsC);
        }
        public bool ContineCuvant(string cuvant)
        {

            string intrebareMica = intrebare.ToLower();

            return intrebareMica.Contains(cuvant.ToLower());
        }
    }

}
public class Quizz
{

    public int scor { get; set; }

    public void AfisareDisplay()
    {

    }
    public void SubmitRaspunsuri()
    {
        Console.WriteLine("Raspunsuri salvate");
    }

}


