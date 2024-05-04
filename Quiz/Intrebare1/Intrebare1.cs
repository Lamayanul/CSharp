using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz;
using NivelStocareDate;


namespace Quiz
{
    public class Intrebare1
    {
        public int raspunsC { get; set; }
        public int raspunsG { get; set; }
        string intrebare;
        string raspuns;
       
        Intrebare1(string intr, string rasp)
        {
            intrebare = intr;
            raspuns= rasp;
          
        }
        public string Afisare()
        {
            char separator = ';';
            int indexSeparator = intrebare.IndexOf(separator);
            string DoarIntrebare = intrebare.Substring(0, indexSeparator);
            return DoarIntrebare;
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
    }
}
