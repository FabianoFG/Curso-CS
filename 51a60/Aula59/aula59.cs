using System;
using System.Collections.Generic;

class Aula59
{
	static void Main()
    {
        //string[] vs = { "carro", "moto", "navio", "avião" };// um vetor pode ser usado como argumento
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");//adiciona ao final da fila
        veiculos.Enqueue("Avião");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");

        string v = "Avião";

        if (veiculos.Contains(v))
        {
            Console.WriteLine("Veículo " +v+" encontrado.");
        }
        else
        {
            Console.WriteLine("Veículo "+v+ " não encontrado!");
        }

        //veiculos.Clear();
        //Console.WriteLine("Primeiro veículo: " + veiculos.Dequeue());//lê e remove o primeiro elemento
        //Console.WriteLine("Primeiro veículo: " + veiculos.Dequeue());
        //Console.WriteLine("Primeiro veículo: " + veiculos.Peek());//lê sem remover primeiro elemento

        //foreach(string veic in veiculos)
        //{
        //    Console.WriteLine(veic);
        //}

        Console.WriteLine("Tamanho da fila: "+veiculos.Count);//não é possível usar indexação com queue (fila)

        while(veiculos.Count > 0)
        {
            Console.WriteLine(veiculos.Dequeue());
        }

        Console.WriteLine("Tamanho da fila: " + veiculos.Count);
    }
}