using System;
class Veiculo
{
    public int velatual;
    private int velmax;
    protected bool ligado;

    public Veiculo(int velmax)
    {
        velatual=0;
        this.velmax=velmax;
        ligado=false;
    }
    public int getVelmax()
    {
        return velmax;
    }
    public bool getLigado()
    {
        return ligado;
    }
}
class Carro:Veiculo
{
    public string nome;

    public Carro(string nome,int velmax):base(velmax)
    {
        this.nome=nome;
        ligado=true;
    }
}
class Aula36
{
    static void Main()
    {
        Carro c1=new Carro("Carrão",220);
        Console.WriteLine("Nome....: {0}",c1.nome);
        Console.WriteLine("Vel. Max: {0}",c1.getVelmax());
        Console.WriteLine("Vel. Max: {0}",c1.getLigado());
    }
}