using System;
class Aula19
{
    static void Main()
    {
        int[] num=new int[10];

        for(int i=0;i<num.Length;i++)
        {
            num[i]=i;
            Console.WriteLine("num{0}: {1}",i,num[i]);
        }

        for(int i=0;i<10;i++)
        {
            Console.WriteLine("Lorem ipsum");
        }
    }
}