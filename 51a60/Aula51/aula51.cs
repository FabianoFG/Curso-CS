using System;

class Aula51
{
	static void Main(string[] args)
    {
        int res=0;

        if (args.Length > 0)
        {
            Console.WriteLine("Quantidade de argumentos: {0}", args.Length);
            //for (int i=0;i < args.Length;i++)
            //{
            //    Console.WriteLine("Argumento {0}: {1}", i, args[i]);
            //}
            for (int i = 0; i < args.Length; i++)
            {
                res += int.Parse(args[i]);
            }

            Console.WriteLine("Soma: {0}", res);

        }
        else
        {
            Console.WriteLine("Nenhum argumento foi passado");
        }
    }
}