using System;
class Aula20
{
    static void Main()
    {
        int[] num=new int[10];
        int i=0;
        while(i<num.Length)
        {
            Console.WriteLine("Número de voltas: {0}",i);
            i++;
        }
        Console.WriteLine("Fim do loop");
    }
}