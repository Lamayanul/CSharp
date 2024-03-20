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

            Intrebare[] intrebari = new Intrebare[8];
            intrebari[0] = new Intrebare("Cerul este albastru?", "y");
            intrebari[1] = new Intrebare("Romania este cea mai frumoasa tara?", "y");
            intrebari[2] = new Intrebare("Exista munti in Romania?", "y");
            intrebari[3] = new Intrebare("Mancarea romaneasca este buna?", "y");
            intrebari[4] = new Intrebare("Inteligenta artificiala este o amenintare?", "y");
            intrebari[5] = new Intrebare("Ai vrea sa ajungi pe luna?", "y");
            intrebari[6] = new Intrebare("Stefan cel Mare era mare?","n");
            intrebari[7] = new Intrebare("Stefan cel Mare a fost domnitor?", "y");
            int punctajTotal = 0;
            Quizz ecran = new Quizz();
            Console.WriteLine(ecran.AfisareDisplay());
            Console.WriteLine("Esti pregatit pentru QUIZ?   y : n");
            string rasp = Console.ReadLine();

            if (rasp == "y")
            {
                Console.WriteLine("Alege un domeniu: ");
                Console.WriteLine("1. Geografie");
                Console.WriteLine("2. Istorie");
                int numar = Int32.Parse(Console.ReadLine());
                switch(numar)
                {
                    case 1: 
                        Console.WriteLine("Geografie sa fie atunci");
                        for (int i = 0; i < intrebari.Length-2; i++)
                        {
                            Console.WriteLine(intrebari[i].AfisIntrebare());
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
                                Console.WriteLine(intrebare.AfisIntrebare());
                            }
                        }
                        Console.ReadLine();

                        break;

                    case 2:
                        Console.WriteLine("Istorie sa fie atunci");
                        for (int i = 6; i < intrebari.Length; i++)
                        {
                            Console.WriteLine(intrebari[i].AfisIntrebare());
                            string ras = Console.ReadLine();
                            intrebari[i].Verifica(ras);
                            intrebari[i].AfisareScor();
                            punctajTotal += intrebari[i].raspunsC;
                        }
                        Console.WriteLine("Punctaj total acumulat: " + punctajTotal);
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}

