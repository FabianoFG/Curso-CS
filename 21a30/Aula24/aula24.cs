using System;
class Aula24
{
    static void Main()
    {
        int v1,v2;
        v1=int.Parse(Console.ReadLine());
        v2=int.Parse(Console.ReadLine());
        lorem();

        int res=soma2(v1,v2);

        Console.WriteLine("A soma de {0} com {1} é igual a {2}",v1,v2,res);
        Console.WriteLine("A soma de {0} com {1} é igual a {2}",v1,v2,soma2(v1,v2));

        //soma(v1,v2);
    }
    static void lorem()
    {
        Console.WriteLine("Lorem Ipsum");
    }
    /*
    static void soma1(int n1,int n2)
    {
        int res=n1+n2;
        Console.WriteLine("Soma: {0}",res);
    }
    */
    static int soma2(int n1,int n2)
    {
        int res=n1+n2;
        return res;
    }
}