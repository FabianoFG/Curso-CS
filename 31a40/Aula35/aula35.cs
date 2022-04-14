using System;
class Veiculo//classe base
{
    public int velmax;
    private bool ligado;
    private int rodas;

    public Veiculo(int rodas)
    {
        this.rodas=rodas;
    }

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
        return (ligado?"Sim":"Não");//pode ser usado um operador ternário 
        
    }
    public void setRodas(int rodas)
    {
        if(rodas < 0)
        {
            this.rodas=0;
        }
        else if(rodas > 20)
        {
            this.rodas=20;
        }
        else
        {
            this.rodas=rodas;
        }
    }
    public int getRodas()
    {
        return rodas;
    }
    
}
class Carro:Veiculo//classe derivada
{
    public string nome;
    public string cor;
    public Carro(string nome,string cor):base(4)
    {
        Desligar();
        velmax=120;
        this.nome=nome;
        this.cor=cor;
    }
    
}
class CarroCombate:Carro
{
    public int municao;
    public CarroCombate():base("Carro de Combate","Camuflado")
    {
        municao=100;
        setRodas(8);
    }
}
class Aula34
{
    static void Main()
    {
        Carro c1=new Carro("Carrão","Verde");
        CarroCombate cc1=new CarroCombate();

        c1.Ligar();
        
        Console.WriteLine("Nome....: {0}",c1.nome);
        Console.WriteLine("Cor.....: {0}",c1.cor);
        Console.WriteLine("Rodas...: {0}",c1.getRodas());
        Console.WriteLine("Vel. Max: {0}",c1.velmax);
        Console.WriteLine("Ligado..: {0}",c1.getLigado());
        Console.WriteLine("-------------");
        Console.WriteLine("Nome....: {0}",cc1.nome);
        Console.WriteLine("Cor.....: {0}",cc1.cor);
        Console.WriteLine("Rodas...: {0}",cc1.getRodas());
        Console.WriteLine("Vel. Max: {0}",cc1.velmax);
        Console.WriteLine("Ligado..: {0}",cc1.getLigado());
    }
}