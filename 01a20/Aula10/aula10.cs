using System;
class Aula10
{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main()
    {
        DiasSemana ds=DiasSemana.Domingo;
        Console.WriteLine("\n"+ds);
        DiasSemana ds2=(DiasSemana)3;
        Console.WriteLine("\n"+ds2);
        int ds3=(int)DiasSemana.Sexta;
        Console.WriteLine("\n"+ds3);
    }
}