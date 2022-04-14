using System;
using System.Collections.Generic;

class Aula56
{
    static void Main()
    {
        LinkedList<string> transp = new LinkedList<string>();
        transp.AddFirst("Carro");
        transp.AddFirst("Avi�o");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta");

        LinkedListNode<string>no;
        no = transp.FindLast("Navio");
        transp.AddAfter(no,"Patinete");
        transp.AddBefore(no, "Patins");
        //no = transp.FindLast("Navio").Value;

        //transp.Remove("Navio");
        //transp.RemoveFirst();
        //transp.RemoveLast();

        //transp.Clear();//limpa cole��o
        
        foreach (string t in transp)
        {
            Console.WriteLine("Transporte: {0}", t);                        
        }
                
        if (transp.Find("Navio") == null)
        {
            Console.WriteLine("Transporte encontrado.");
        }
        else
        {
            Console.WriteLine("Transporte N�O encontrado.");
        }


        
    }
}