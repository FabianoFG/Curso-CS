using System;

namespace Calc1
{

    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não pode ser igual a 0");//"gera" uma exceção - sinaliza
            }
            return bas * alt;
        }
    }
}

namespace Calc2
{

    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não pode ser igual a 0");//"gera" uma exceção - sinaliza
            }
            return bas * alt;
        }
    }
}

class Aula52
{
    static void Main()
    {
        float area = 0;

        try//bloco a ser testado
        {
            area = Calc1.Area.Quad(0, 5F);
            Console.WriteLine("Área do quadrado: {0}", area);
            //throw new Exception("EXCEÇÃO FORÇADA");// força uma exceção
        }
        catch (Exception e)//descrição do erro
        {
            Console.WriteLine("ERRO..: {0}", e.Message);
            Console.WriteLine("SOURCE: {0}", e.Source);
            Console.WriteLine("TIPO..: {0}", e.GetType());
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("EX....: {0}", e);
        }
        finally//sinalizador de final de execussão
        {
            Console.WriteLine("FIM DO PROCESSO");
        }
    }
}