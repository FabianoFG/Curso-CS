using System;
static public class Classe
{
    static public string nome="Fulano";
    static public int pontos=100;
    static public bool estado=true;

    static public void iniciar()
    {
        nome="Cicrano";pontos=100;estado=false;
    }
    static public void info()
    {
        Console.WriteLine("Nome: {0} - Pontos: {1} - Estado: {2}",nome,pontos,estado);
    }


}
public class Inimigo
{
    static public bool alerta;
    public int vida;
    public string nome;

    public Inimigo(int v,string n)
    {
        
        vida=v;
        nome=n;
    }
    public void info()
    {
        Console.WriteLine("Nome..: {0}",nome);
        Console.WriteLine("Alerta: {0}",alerta);
        Console.WriteLine("---------------------");
        
    }
}
class Aula30
{
    static void Main()
    {
        Classe.iniciar();
        Classe.info();

        Inimigo i1=new Inimigo(100,"Doido");
        Inimigo i2=new Inimigo(150,"Maluco");
        Inimigo i3=new Inimigo(200,"locão");

        Inimigo.alerta=true;

        i1.info();
        i2.info();
        i3.info();

    }
}