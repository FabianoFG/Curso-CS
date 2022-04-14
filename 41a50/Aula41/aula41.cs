using System;
class Carro{
    private int velmax;
    public int vm{// acessors:
        get{
            return velmax;
        }
        set{
            if(value < 0){
                velmax=0;
            }else if(value > 300){
                velmax=300;
            }else{
                velmax=value;
            }
        }
    }
    public Carro(){
        velmax=120;
    }
}
class Aula41{
    static void Main(){
        Carro c1=new Carro();
        c1.vm=200;
        Console.WriteLine("Velocidade: {0}",c1.vm);
    }
}