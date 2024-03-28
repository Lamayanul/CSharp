using System;
using System.IO;
using System.Text;

namespace Quiz
{
    public class Tot
    {
        private string[][] IntrebariInceputA_Z = new string[26][];

        public string ExecutaChallenge()
        {

            CitesteSiProceseaza("intrebari.txt");


            return AfiseazaIntrebari();
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

        private string AfiseazaIntrebari()
        {
            StringBuilder mesaj = new StringBuilder();

            for (int i = 0; i < 26; i++)
            {
                mesaj.Append($"Intrebarile care incep cu '{(char)('A' + i)}':\n");
                foreach (string cuvant in IntrebariInceputA_Z[i])
                {
                    mesaj.Append(cuvant + "\n");
                }
            }

            return mesaj.ToString();
        }

        private string[] AdaugaInt(string[] tablou, string intr)
        {

            string[] nouTablou = new string[tablou.Length + 1];
            Array.Copy(tablou, nouTablou, tablou.Length);
            nouTablou[nouTablou.Length - 1] = intr.Substring(0, intr.Length - 2); ;
            return nouTablou;
        }
    }

}
