using System;
using System.Collections.Generic;

class Aula59
{
	static void Main()
    {
        //string[] vs = { "carro", "moto", "navio", "avi�o" };// um vetor pode ser usado como argumento
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");//adiciona ao final da fila
        veiculos.Enqueue("Avi�o");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");

        string v = "Avi�o";

        if (veiculos.Contains(v))
        {
            Console.WriteLine("Ve�culo " +v+" encontrado.");
        }
        else
        {
            Console.WriteLine("Ve�culo "+v+ " n�o encontrado!");
        }

        //veiculos.Clear();
        //Console.WriteLine("Primeiro ve�culo: " + veiculos.Dequeue());//l� e remove o primeiro elemento
        //Console.WriteLine("Primeiro ve�culo: " + veiculos.Dequeue());
        //Console.WriteLine("Primeiro ve�culo: " + veiculos.Peek());//l� sem remover primeiro elemento

        //foreach(string veic in veiculos)
        //{
        //    Console.WriteLine(veic);
        //}

        Console.WriteLine("Tamanho da fila: "+veiculos.Count);//n�o � poss�vel usar indexa��o com queue (fila)

        while(veiculos.Count > 0)
        {
            Console.WriteLine(veiculos.Dequeue());
        }

        Console.WriteLine("Tamanho da fila: " + veiculos.Count);
    }
}