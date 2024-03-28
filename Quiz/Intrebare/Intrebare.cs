using System;
using System.IO;
using System.Text;

namespace Quiz
{
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

        public string AfisIntrebare()
        {
            
             return intrebare.Substring(0, intrebare.Length - 2); 
            
        }
        public void Verifica(string str)
        {
            if (str == raspuns)
            {
                raspunsC++;
            }
            else
            {
                raspunsG++;
            }
        }
        public string AfisareScor()
        {
            string sir = String.Format("Ai acumulat: {0} puncte", raspunsC);
            return sir;
        }
        public bool ContineCuvant(string cuvant)
        {

            string intrebareMica = intrebare.ToLower();

            return intrebareMica.Contains(cuvant.ToLower());
        }
    }
}
