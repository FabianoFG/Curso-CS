using System;

public class Exercicio
{
    public int n1=10;
    public bool n2=true;
    public void AtribuirN1(int valorn)
    {
        n1=valorn;
    }
    public void LerN1()
    {
        Console.WriteLine("O valor de n1 é: {0}",n1);
    }
}
class Aula28
{
    static void Main()
    {
        Exercicio e1=new Exercicio();
        Exercicio e2=new Exercicio();
        Exercicio e3=new Exercicio();

        e1.n1=15;
        e2.n1=20;
        e3.n1=25;

        Console.WriteLine("O valor é:{0}",e1.n1);
        Console.WriteLine("O valor é:{0}",e2.n1);
        Console.WriteLine("O valor é:{0}",e3.n1);

        e1.AtribuirN1(int.Parse(Console.ReadLine()));
        e2.AtribuirN1(int.Parse(Console.ReadLine()));
        e3.AtribuirN1(int.Parse(Console.ReadLine()));

        e1.LerN1();
        e2.LerN1();
        e3.LerN1();
    }
}