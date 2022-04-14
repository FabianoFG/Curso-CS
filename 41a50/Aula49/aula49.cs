using System;

class Mat
{
    public static double pi = 3.14;

    public static int Dobro(int n)
    {
        return n * 2;
    }
}

class Aula49
{
    static void Main()
    {
        double vpi = Mat.pi;//pode ser chamado dessa forma porque é "static"
        int num = 10;

        Console.WriteLine(vpi);
        Console.WriteLine(Mat.Dobro(num));
    }
}