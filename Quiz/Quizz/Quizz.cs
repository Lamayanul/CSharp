using Microsoft.SqlServer.Server;
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
    public void Ultimulscor(int punct, string name)
    {
        int punctajTotal = punct;
        string nume = name;
            string caleFisier = "LastScor.txt";
            using (StreamWriter writer = new StreamWriter(caleFisier))
            {

                writer.WriteLine("-----------------------------------------------");
                writer.WriteLine("Ultimul scor inregistrat: ");
                writer.WriteLine(nume);
                writer.WriteLine(punctajTotal);
                writer.WriteLine("-----------------------------------------------");
            }
            SubmitRaspunsuri();
        }
    }


