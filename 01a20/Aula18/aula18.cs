using System;
class Aula18
{
    static void Main()
    {
        int[,] coisa=new int[4,7];

        coisa[0,0]=3;
        coisa[0,1]=9;
        coisa[0,2]=27;
        coisa[0,3]=81;
        coisa[1,0]=247;
        coisa[1,1]=233;
        coisa[3,0]=2342;

        Console.WriteLine(coisa[1,1]);
    }
}