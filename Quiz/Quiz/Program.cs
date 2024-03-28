using NivelStocareDate;
using Quiz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

            string caleFisier5 = "intrebari.txt";

            Stocare c1 = new Stocare();
            
            int nrLinii = c1.NumarLinii(caleFisier5);
            Intrebare[] intrebari = new Intrebare[nrLinii];
            string[] rezultat = c1.GetIntrebari(caleFisier5);
            string[] rezultat1= c1.GetRaspunsuri(caleFisier5);
            Console.WriteLine(rezultat[0]); 
            for(int i = 0;i<nrLinii;i++)
            {
                intrebari[i] = new Intrebare(rezultat[i], rezultat1[i]);
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
                Console.WriteLine("6. Tabela");

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
                            Console.WriteLine(intrebari[i].AfisareScor());
                            punctajTotal += intrebari[i].raspunsC;
                        }
                        Console.WriteLine("Punctaj total acumulat: " + punctajTotal);
                        Console.ReadLine();
                        Console.ReadLine();
                        Console.WriteLine("Vrei sa iti salvezi scorul?");
                        string salvare2 = Console.ReadLine();
                        if (salvare2 == "y")
                        {
                            Console.WriteLine("Introdu numele: ");
                            string nume = Console.ReadLine();
                            ecran.Ultimulscor(punctajTotal, nume);
                            c1.Tabela(punctajTotal, nume);
                            Console.WriteLine(ecran.SubmitRaspunsuri());
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
                            Console.WriteLine(intrebari[i].AfisareScor());
                            punctajTotal += intrebari[i].raspunsC;
                        }
                        Console.WriteLine("Punctaj total acumulat: " + punctajTotal);
                        Console.ReadLine();
                        Console.WriteLine("Vrei sa iti salvezi scorul?");
                        string salvare3 = Console.ReadLine();
                        if (salvare3 == "y")
                        {
                            Console.WriteLine("Introdu numele: ");
                            string nume = Console.ReadLine();
                            ecran.Ultimulscor(punctajTotal,nume);
                            c1.Tabela(punctajTotal, nume);
                            Console.WriteLine(ecran.SubmitRaspunsuri());
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        {
                            Tot challenge = new Tot();
                            Console.WriteLine(challenge.ExecutaChallenge());
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
                                Console.WriteLine(intrebari[numarAleatoriu].AfisareScor());
                                punctajTotal += intrebari[numarAleatoriu].raspunsC;
                            }
                            Console.WriteLine("Punctaj total acumulat: " + punctajTotal);
                            Console.ReadLine();
                            Console.WriteLine("Vrei sa iti salvezi scorul?");
                            string salvare4 = Console.ReadLine();
                            if (salvare4 == "y")
                            {
                                Console.WriteLine("Introdu numele: ");
                                string nume = Console.ReadLine();
                                ecran.Ultimulscor(punctajTotal, nume);
                                c1.Tabela(punctajTotal, nume);
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Vrei sa cauti in 1-intrebari sau in 2-tabela?");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            if (opt == 1)
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
                            }

                            else
                            {
                                string caleFisier6 = "tabela.txt";
                                Console.WriteLine(c1.ScorMare(caleFisier6));
                                Console.ReadLine();
                            }
                            break;
                        }
                    case 6:
                        {
                            string caleFisier3 = "tabela.txt";
                            using (StreamReader reader = new StreamReader(caleFisier3))
                            {
                                string linie;

                                while ((linie = reader.ReadLine()) != null)
                                {
                                    Console.WriteLine(linie);
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

