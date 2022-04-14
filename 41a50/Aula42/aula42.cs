using System;
class Carro{
    private int[] velmax=new int[5]{40,80,120,240,280};
    public int this[int i]{// indexador
        get{
            return velmax[i];
        }
        set{
            if(value < 0){
                velmax[i]=0;
            }else if(value > 300){
                velmax[i]=300;
            }else{
                velmax[i]=value;
            }
        }
    }
    public Carro(){
    }
}
class Aula41{
    static void Main(){
        Carro c1=new Carro();
        //c1[2]=200;// pode ser tratado como vetor, por possuir um indexador
        Console.WriteLine("Velocidade: {0}",c1[2]);
    }
}