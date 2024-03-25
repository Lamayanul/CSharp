using System;
using System.IO;

namespace Quiz
{
    public class Tot
    {
        private string[][] IntrebariInceputA_Z = new string[26][];

        public void ExecutaChallenge()
        {
            
            CitesteSiProceseaza("intrebari.txt");

            
            AfiseazaIntrebari();
        }

        private void CitesteSiProceseaza(string caleFisier)
        {
            using (StreamReader reader = new StreamReader(caleFisier))
            {
               
                for (int i = 0; i < 26; i++)
                {
                    IntrebariInceputA_Z[i] = new string[0];
                }

                
                string linie;
                while ((linie = reader.ReadLine()) != null)
                {
                    
                    if (!string.IsNullOrWhiteSpace(linie))
                    {
                       
                        char primaLitera = char.ToUpper(linie[0]);

                        
                        int index = primaLitera - 'A';

                      
                        IntrebariInceputA_Z[index] = AdaugaInt(IntrebariInceputA_Z[index], linie);
                    }
                }
            }
        }

        private void AfiseazaIntrebari()
        {
            
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine($"Intrebarile care incep cu '{(char)('A' + i)}':");
                foreach (string cuvant in IntrebariInceputA_Z[i])
                {
                    Console.WriteLine(cuvant);
                }
            }
        }

        private string[] AdaugaInt(string[] tablou, string intr)
        {
            
            string[] nouTablou = new string[tablou.Length + 1];
            Array.Copy(tablou, nouTablou, tablou.Length);

            
            nouTablou[nouTablou.Length - 1] = intr;
            return nouTablou;
        }
    }

}
