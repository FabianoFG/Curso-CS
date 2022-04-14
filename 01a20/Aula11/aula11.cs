using System;
class Aula11
{
    static void Main()
    {
        int n1=10;
        float n2=n1;//conversão implícita
        float n3=5;
        int n4=(int)n3;//typecast (conversão explícita)
        int vint=15;
        short vshort=(short)vint;
        Console.WriteLine(n2);
        Console.WriteLine(n4);
        Console.WriteLine(vshort);
    }
}