using System;
class Aula06
{
    static void Main()
    {
        int num1,num2,num3;
        num1=10;num2=20;num3=30;
        Console.Write("Num1="+num1+", "+"Num2="+num2+", "+"Num3="+num3);
        Console.Write("\nNum1={0}, Num2={1}, Num3={2}",num1,num2,num3);

        double valorcompra=5.50;
        double valorvenda;
        double lucro=0.1;
        string produto="Pastel";

        valorvenda=valorcompra+(valorcompra*lucro);

        Console.WriteLine("\nProduto...........:{0,15}",produto);
        Console.WriteLine("Val.Compra........:{0,15:c}",valorcompra);
        Console.WriteLine("Lucro.............:{0,15:p}",lucro);
        Console.WriteLine("Val.Venda.........:{0,15:c}\n",valorvenda);
    }
}