using System;

public class Exercicio
{
    public int n1;
    public bool n2;
    public string nome;
    public void AtribuirN1(int valorn)
    {
        n1=valorn;
    }
    public void LerN1()
    {
        Console.WriteLine("O valor de n1 é: {0}",n1);
    }
    public Exercicio(string nom)
    {
        n1=10;n2=true;
        nome=nom;
    }
    ~Exercicio()
    {
        Console.WriteLine("O objeto {0} foi removido",nome);
    }
}
class Aula28
{
    static void Main()
    {
        string nome;
        Console.WriteLine("Digite o nome do aluno: ");
        nome=Console.ReadLine();

        Exercicio e1=new Exercicio(nome);

        Console.WriteLine("Digite o nome do aluno: ");
        nome=Console.ReadLine();
        Exercicio e2=new Exercicio(nome);
        
        Exercicio e3=new Exercicio("Heloísa");

        Console.WriteLine("O nome do aluno é: {0}",e1.nome);

        /*e1.n1=15;
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
        e3.LerN1();*/
    }
}