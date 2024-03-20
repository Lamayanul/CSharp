﻿using System;
using namespace Quiz;
namespace Intre { 
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
        return intrebare;
    }
    public void Verifica(string str)
    {
        if (str == "y")
        {
            raspunsC++;
        }
        else
        {
            raspunsG++;
        }
    }
    public void AfisareScor()
    {
        Console.WriteLine("Ai acumulat : {0} puncte", raspunsC);
    }
    public bool ContineCuvant(string cuvant)
    {

        string intrebareMica = intrebare.ToLower();

        return intrebareMica.Contains(cuvant.ToLower());
    }
}

}