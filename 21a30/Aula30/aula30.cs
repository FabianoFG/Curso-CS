using System;
public class objeto
{
    public string nome="Fulano";
    public int pontos=100;
    public bool estado=true;

    public objeto()
    {
        
    }
    public objeto(string n)
    {
        nome=n;
    }
    public objeto(string n,int p)
    {
        nome=n;
        pontos=p;
    }
    public objeto(string n,int p,bool e)
    {
        nome=n;
        pontos=p;
        estado=e;
    }
    public void info()
    {
        Console.WriteLine("Nome: {0} - Pontos: {1} - Estado: {2}",nome,pontos,estado);
    }


}
class Aula30
{
    static void Main()
    {
        objeto o1=new objeto();
        objeto o2=new objeto("Cicrano");
        objeto o3=new objeto("Beltrano",100);
        objeto o4=new objeto("Lontrano",50,true);

        o1.info();
        o2.info();
        o3.info();
        o4.info();
    }
}