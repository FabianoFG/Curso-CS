using System;
class Coisas
{
    private int cosa;
    private string coisinha;

    public Coisas(string coisinha)
    {
        cosa=100;
        this.coisinha=coisinha;
    }
    public int getCosa()
    {
        return cosa;
    }
    public string getCoisinha()
    {
        return coisinha;
    }
    public void setcosa(int sc)
    {
        if(cosa+sc < 0)
        {
            cosa=0;
        }else if(cosa+sc > 100)
        {
            cosa=100;
        }else
        {
            cosa+=sc;
        }
    }
}
class Aula33
{
    static void Main()
    {
        int valor;

        Coisas c1=new Coisas("Cacareco");
        
        valor=int.Parse(Console.ReadLine());
        c1.setcosa(valor);

        Console.WriteLine("Coisinha: {0}",c1.getCoisinha());
        Console.WriteLine("Cosa: {0}",c1.getCosa());

        valor=int.Parse(Console.ReadLine());
        c1.setcosa(valor);

        Console.WriteLine("Coisinha: {0}",c1.getCoisinha());
        Console.WriteLine("Cosa: {0}",c1.getCosa());

        valor=int.Parse(Console.ReadLine());
        c1.setcosa(valor);

        Console.WriteLine("Coisinha: {0}",c1.getCoisinha());
        Console.WriteLine("Cosa: {0}",c1.getCosa());
        
    }
}