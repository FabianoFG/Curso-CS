using System;

public interface Veiculo
{
    void Ligar();
    void desLigar();
    void Info();
}
public interface Combate
{
    public void Disparar();
}
public class Carro : Veiculo
{
    public bool ligado;
    private int municao;

    public Carro()
    {
        setMunicao(100);
    }
    public void Ligar()
    {
        this.ligado = true;
    }
    public void desLigar()
    {
        this.ligado = false;
    }
    public void Disparar()
    {

    }
    public void setMunicao(int qtde)
    {
        this.municao = qtde;
    }
    public void Info()
    {
        Console.WriteLine("{0}",municao);
    }
}

class Aula43{
    static void Main(){
        Carro C1 = new Carro();

        C1.Info();

    }
}