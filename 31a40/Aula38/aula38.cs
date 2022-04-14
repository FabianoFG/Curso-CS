using System;
class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void Info(){}
}
class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe derivada1");
    }
    override public void Info(){
        Console.WriteLine("Derivada 1");
    }
}
class Derivada2:Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe derivada2");
    }
    override public void Info(){
        Console.WriteLine("Derivada 2");
    }
}
class Aula37
{
    static void Main()
    {
        Base Ref;
        Derivada1 d1=new Derivada1();//ordem de execução de classes de mútiplas heranças: base->derivada1->derivada2->etc...
        Derivada2 d2=new Derivada2();

        Ref=d2;
        Ref.Info();
    }
}