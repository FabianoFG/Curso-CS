using System;
class Aula21
{
    static void Main()
    {
        //while testa e depois executa. do while executa e depois testa

        string senha="123";
        string senhadig;
        int tentativas=0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhadig=Console.ReadLine();
            tentativas++;
        }while(senha!=senhadig);

        Console.Clear();
        Console.WriteLine("Senha correta - Tentativas: {0}",tentativas);
    }
}