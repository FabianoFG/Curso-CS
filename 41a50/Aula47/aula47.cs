using System;

public class Calc
{
    public int Somar(params int[]n)
    {
        int s = 0;
        for (int i=0;i<n.Length;i++)
        {
            s += n[i];
        }

        return s;
    }

    public double Somar(params double[]n)
    {
        double s = 0;
        for (int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }

        return s;
    }
}

class Aula47
{
    static void Main()
    {
        //double res;

        Calc calc1 = new Calc();

        var res = calc1.Somar(10.3, 5.2,4.5,6.2,8.1);

        Console.WriteLine(res);

    }
}