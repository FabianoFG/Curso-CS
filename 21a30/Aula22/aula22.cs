using System;
class Aula22
{
    static void Main()
    {
        int[] num=new int[6]{11,22,33,44,55,66};

        /*for(int i=0;i<num.Length;i++)
        {
            Console.WriteLine(num[i]);
        }
        */
        foreach(int n in num)// foreach só pode ler o vetor, mas não atribuir
        {
            Console.WriteLine(n);
        }
    }
}