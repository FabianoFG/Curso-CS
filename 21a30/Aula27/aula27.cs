using System;
class Aula27
{
    static void Main()
    {
        soma(2,5,3,6,7,4,2,4,6,3);
    }

    static void soma(params int[]n)
    {
        int res=0;

        if(n.Length < 1)
        {
            Console.WriteLine("ERRO: Nenhum valor foi fornecido");
        }
        else if(n.Length <2)
        {
            Console.WriteLine("ERRO: Apenas um valor foi fornecido: {0}",n[0]);
        }
        else
        {
            for(int i=0;i<n.Length;i++)
            {
                res+=n[i];
            }
            Console.WriteLine("O resultado da soma é {0}",res);
        }
    }
}