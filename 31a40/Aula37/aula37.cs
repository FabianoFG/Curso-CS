using System;
class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe base");
    }
}
class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe derivada1");
    }
}
class Derivada2:Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe derivada2");
    }
}
class Aula37
{
    static void Main()
    {
        Derivada2 d2=new Derivada2();//ordem de execução de classes de mútiplas heranças: base->derivada1->derivada2->etc...
    }
}