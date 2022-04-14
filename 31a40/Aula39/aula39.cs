using System;
abstract class Veiculo{
    protected int v1;
    protected int v2;
    protected bool v3;
    public Veiculo(){
        v1=0;
        v3=true;
    }
    public void setv3(bool v3){
        this.v3=v3;
    }
    public int getv1(){
        return v1;
    }
    abstract public void acel(int mult);
}
class Carro:Veiculo{
    public Carro(){
        v2=120;
    }
    override public void acel(int mult){
        v1+=10*mult;
    }
}
class Aula38
{
    static void Main()
    {
        Carro Carro1=new Carro();
        Carro1.setv3(true);
        Carro1.acel(1);
        Console.WriteLine(Carro1.getv1());
        Carro1.acel(-1);
        Console.WriteLine(Carro1.getv1());
    }
}