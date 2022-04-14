using System;
class Aula15
{
    static void Main()
    {
        int tempo=0;
        char escolha;

        inicio:
        Console.Clear();

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

        repetir:

        Console.WriteLine("Fazer nova escolha? [s/n]");
        escolha=char.Parse(Console.ReadLine());
        
        switch(escolha)
        {
            case 's':
            case 'S':
                goto inicio;
            case 'n':
            case 'N':
                Console.Clear();
                Console.WriteLine("Programa finalizado");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Letra inválida\nPor favor, digite 's' para sim ou 'n' para não");
                goto repetir;
        }

    }
}