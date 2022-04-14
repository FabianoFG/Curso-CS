using System;
class Aula09
{
    static void Main()//operaçãoescombitwise (multiplicar eou dividir por dois elevado a x,p/direitaoup/esquerda)
    {
        int num=10;
        num=num<<1;

        Console.WriteLine(num);
        num=num>>1;
        Console.WriteLine(num);
        num=num<<2;
        Console.WriteLine(num);
        num=num>>2;
        Console.WriteLine(num);
    }
}