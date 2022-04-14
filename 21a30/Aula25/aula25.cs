using System;
class Aula25
{
    static void Main()
    {
        int num=10;

        dobrar(num);

        Console.WriteLine(num);

        dobrar2(ref num);

        Console.WriteLine(num);
    }
    static void dobrar(int valor)//passagem por valor (cria outra posição e a utiliza)
    {
        valor*=2;//o mesmo que valor=valor*2;
    }
    static void dobrar2(ref int valor)//passagem por referência (utiliza a própria posição referenciada(ponteiro))
    {
        valor*=2;//o mesmo que valor=valor*2;
    }
}