using System;
using System.Collections.Generic;

class Aula57
{
    static void Main()
    {
        List<string> carros = new List<string>();
        string[]carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.AddRange(carros);

        //carros.Clear();

        if (carros.Contains("Golf"))
        {
            Console.WriteLine("Cont�m");
        }
        else
        {
            Console.WriteLine("N�o cont�m");
        }

        carros.CopyTo(carros2, 2);

        foreach(string k in carros)
        {
            Console.WriteLine("Carro: {0}",k);
        }

        string c = "Argo";
        int pos = 0;
        pos=carros.IndexOf(c);
        Console.WriteLine("O Carro {0} est� na posi��o {1}", c, pos);
    }
}