using System;
using System.Collections.Generic;

class Aula57
{
    static void Main()
    {
        List<string> carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        //carros2.AddRange(carros);

        //carros.Clear();

        //carros.Remove("Argo");
        //carros.RemoveAt(2);
        //carros.Reverse();
        //carros.Sort();

        Console.WriteLine("Total de carros: {0}",carros.Count);
        Console.WriteLine("Capacidade de carros: {0}", carros.Capacity);
        carros.Capacity = 15;
        Console.WriteLine("Nova capacidade de carros: {0}", carros.Capacity);


        if (carros.Contains("Golf"))
        {
            Console.WriteLine("Cont�m");
        }
        else
        {
            Console.WriteLine("N�o cont�m");
        }

        carros.CopyTo(carros2, 2);
        carros.Insert(1, "Cruze");

        foreach (string k in carros)
        {
            Console.WriteLine("Carro: {0}", k);
        }

        string c = "HRV";
        int pos = 0;
        int pos2 = 0;
        pos = carros.IndexOf(c);
        pos2 = carros.LastIndexOf(c);
        Console.WriteLine("O Carro {0} est� na posi��o {1}", c, pos);
        Console.WriteLine("O �ltimo {0} est� na posi��o {1}", c, pos2);
    }
}