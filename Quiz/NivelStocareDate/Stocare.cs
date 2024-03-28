using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace NivelStocareDate
{
    public class Stocare
    {
        public string[] GetIntrebari(string caleFisier)
        {
            string[] linii = File.ReadAllLines(caleFisier); 

            return linii; 
        }
        public string[] GetRaspunsuri(string caleFisier)
        {
            string[] linii = File.ReadAllLines(caleFisier); 
            string[] raspunsuri = new string[linii.Length]; 

            for (int i = 0; i < linii.Length; i++)
            {
                string[] parts = linii[i].Split(';'); 
                if (parts.Length > 1) 
                {
                    raspunsuri[i] = parts[1]; 
                }
                
            }

            return raspunsuri; 
        }
        public int NumarLinii(string calefisier)
        {
            int numarLinii = 0;
            using (StreamReader reader = new StreamReader(calefisier))
            {
                while (reader.ReadLine() != null)
                {
                    numarLinii++; 
                }
            }
            return numarLinii;
        }
        public void Tabela(int punct,string name)
        {
            int punctajTotal = punct;
            string nume = name;
            string caleFisier = "tabela.txt";
            using (StreamWriter writer = new StreamWriter(caleFisier,true))
            {
                writer.WriteLine("-----------------------------------------------");
                writer.WriteLine("Tabela cu rezultate: ");
                writer.WriteLine(nume);
                writer.WriteLine(punctajTotal);
                writer.WriteLine("-----------------------------------------------");
            }
            
        }
        public string ScorMare(string caleFisier)
        {
            int celMaiMareScor = -1; 
            string numeCelMaiMareScor = "";
            string cale = caleFisier;
            using (StreamReader reader = new StreamReader(cale))
            {
                string linieNume;
                string linieScor;

                while ((linieNume = reader.ReadLine()) != null && (linieScor = reader.ReadLine()) != null)
                {
                    string nume = linieNume;
                    int scor;
                    if (int.TryParse(linieScor, out scor))
                    {
                        if (scor > celMaiMareScor)
                        {
                            celMaiMareScor = scor;
                            numeCelMaiMareScor = nume;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(numeCelMaiMareScor))
            {
               return $"Cel mai mare scor: {celMaiMareScor}, obținut de către {numeCelMaiMareScor}.";
            }
            else
            {
               return "Nu s-a găsit niciun scor în fișierul specificat.";
            }
        }
        
    }
}
