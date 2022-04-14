using System;

public class Calc
{
    public int Somar(params int[] n)
    {
        int s = 0;
        for (int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }

        return s;
    }

    public double Somar(params double[] n)
    {
        double s = 0;
        for (int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }

        return s;
    }

    public int Fatorial(int n)
    {
        int res;
        if (n<=1)
        {
            res = 1;
        }
        else
        {
            res = n * Fatorial(n - 1);
        }

        return res;
    }
}

class Aula47
{
    static void Main()
    {
        //double res;

        Calc calc1 = new Calc();

        var res = calc1.Fatorial(3);

        Console.WriteLine(res);

    }
}