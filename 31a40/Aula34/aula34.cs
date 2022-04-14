using System;
class Veiculo//classe base
{
    public int velmax;
    private bool ligado;
    public int rodas;

    public void Ligar()
    {
        ligado=true;
    }
    public void Desligar()
    {
        ligado=false;
    }
    public string getLigado()
    {
        if(ligado)
        {
            return "Sim";
        }else
        {
            return "Não";
        }
    }
    
}
class Carro:Veiculo//classe derivada
{
    public string nome;
    public string cor;
    public Carro(string nome,string cor)
    {
        Desligar();
        rodas=4;
        velmax=120;
        this.nome=nome;
        this.cor=cor;
    }
    
}
class Aula34
{
    static void Main()
    {
        Carro c1=new Carro("Carrão","Verde");
        
        Console.WriteLine("Nome....: {0}",c1.nome);
        Console.WriteLine("Cor.....: {0}",c1.cor);
        Console.WriteLine("Rodas...: {0}",c1.rodas);
        Console.WriteLine("Vel. Max: {0}",c1.velmax);
        Console.WriteLine("Ligado..: {0}",c1.getLigado());
    }
}