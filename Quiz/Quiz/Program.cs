using Quiz;
using System;
using System.Collections.Generic;
using System.IO;
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
            string caleFisier2 = "intrebari.txt";
            using (StreamWriter writer = new StreamWriter(caleFisier2))
            {
                
                for (int i=0;i<intrebari.Length;i++)
                {
                    writer.WriteLine(intrebari[i].AfisIntrebare());
                }
            }
            int punctajTotal = 0;
            Quizz ecran = new Quizz();
            Console.WriteLine(ecran.AfisareDisplay());
            Console.WriteLine("Esti pregatit pentru QUIZ?   y : n");
            string rasp = Console.ReadLine();
            string caleFisier1 = "LastScor.txt";
            using (StreamReader reader = new StreamReader(caleFisier1))
            {
                string linie;
                
                while ((linie = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linie);
                }
            }
            
            string caleFisier3 = "tabela.txt";
            using (StreamReader reader = new StreamReader(caleFisier3))
            {
                string linie;

                while ((linie = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linie);
                }
            }
            if (rasp == "y")
            {
                Console.WriteLine("Alege un domeniu: ");
                Console.WriteLine("1. Geografie");
                Console.WriteLine("2. Istorie");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Extra");
                Console.WriteLine("3. Toate intrebarile");
                Console.WriteLine("4. Challenge");
                Console.WriteLine("5. Intrebari ce contin ce cuvinte vrei");
                int numar = Int32.Parse(Console.ReadLine());
                switch (numar)
                {
                    case 1:
                        Console.WriteLine("Geografie sa fie atunci");
                        for (int i = 0; i < intrebari.Length - 2; i++)
                        {
                            Console.WriteLine(intrebari[i].AfisIntrebare());
                            string ras = Console.ReadLine();
                            intrebari[i].Verifica(ras);
                            intrebari[i].AfisareScor();
                            punctajTotal += intrebari[i].raspunsC;
                        }
                        Console.WriteLine("Punctaj total acumulat: " + punctajTotal);
                        Console.ReadLine();
                        Console.ReadLine();
                        ecran.Ultimulscor(punctajTotal);
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
                        ecran.Ultimulscor(punctajTotal);

                        break;
                    case 3:
                        {
                            Tot challenge = new Tot();
                            challenge.ExecutaChallenge();
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Random rnd = new Random();
                            Console.WriteLine("Cate intrebari vrei?");
                            int nr = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < nr; i++)
                            {
                                int numarAleatoriu = rnd.Next(0, intrebari.Length);
                                Console.WriteLine(intrebari[numarAleatoriu].AfisIntrebare());
                                string ras = Console.ReadLine();
                                intrebari[numarAleatoriu].Verifica(ras);
                                intrebari[numarAleatoriu].AfisareScor();
                                punctajTotal += intrebari[numarAleatoriu].raspunsC;
                            }
                            Console.WriteLine("Punctaj total acumulat: " + punctajTotal);
                            Console.ReadLine();
                            ecran.Ultimulscor(punctajTotal);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Cauta intrebari cu cuvantul: ");
                            string s = Console.ReadLine();
                            foreach (Intrebare intrebare in intrebari)
                            {
                                if (intrebare.ContineCuvant(s))
                                {
                                    Console.WriteLine(intrebare.AfisIntrebare());
                                }
                            }
                            Console.ReadLine();
                            break;
                        }
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}

