using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Quizz
{

    public int scor { get; set; }

    public string AfisareDisplay()
    {
        return "Display-ul este consola acum";
    }
    public string SubmitRaspunsuri()
    {
        return "raspunsuri salvate";
    }
    public void Ultimulscor(int punct)
    {
        int punctajTotal = punct;
        Console.WriteLine("Vrei sa iti salvezi scorul?");
        string salvare2 = Console.ReadLine();
        if (salvare2 == "y")
        {
            Console.WriteLine("Introdu numele: ");
            string nume = Console.ReadLine();
            string caleFisier = "LastScor.txt";
            using (StreamWriter writer = new StreamWriter(caleFisier))
            {

                writer.WriteLine("-----------------------------------------------");
                writer.WriteLine("Ultimul scor inregistrat: ");
                writer.WriteLine(nume);
                writer.WriteLine(punctajTotal);
                writer.WriteLine("-----------------------------------------------");
            }
            Console.WriteLine(SubmitRaspunsuri());
            Console.ReadLine();

        }
    }
}

