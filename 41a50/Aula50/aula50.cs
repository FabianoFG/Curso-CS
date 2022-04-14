using System;

delegate int Op(params int[]n);

public class Mat
{
    public static int Soma(params int[]n)
    {
        return n[0] + n[1];
    }

    public static int Dobro(int n)
    {
        return n * 2;
    }

    public static int Mult(params int[]n)
    {
        return n[0] * n[1];
    }
}

class Aula50
{
    static void Main()
    {
        int res;

        Op d1 = new Op(Mat.Soma);

        res = d1(10, 50);

        Console.WriteLine(res);

        d1 = new Op(Mat.Mult);

        res = d1(10, 50);

        Console.WriteLine(res);
    }
}