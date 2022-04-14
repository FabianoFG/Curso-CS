using System;
class Aula15
{
    static void Main()
    {
        int tempo=0;
        char escolha;

        Console.WriteLine("Viagem");
        Console.WriteLine("Opções [a] | [b] | [c]");
        escolha=char.Parse(Console.ReadLine());

        switch(escolha)
        {
            case 'a':
            case 'A':
                tempo=50;
                break;
            case 'b':
            case 'B':
                tempo=30;
                break;
            case 'c':
            case 'C':
                tempo=10;
                break;        
            default:
                tempo=-1;
                break;
        }
        if(tempo<0)
        {
            Console.WriteLine("Indisponível");
        }else
        {
            Console.WriteLine("Tempo de viagem: {0}",tempo);
        }

    }
}