using System;
class Aula17
{
    static void Main()
    {
        //int n1,n2,n3,n4,n5,n6;
        int[] n=new int[6];
        int[] num=new int[4]{23,34,45,56};
        int[] num1={11,22,33,44,55,66,77};
        string[] letras=new string[10];
        
        n[0]=123;
        n[1]=124;
        n[2]=125;
        n[3]=126;
        n[4]=127;
        n[5]=128;

        letras[0]="dasdasda";
        letras[2]="dfdsfdsfsf";
        letras[3]="isso";
        letras[4]="sdfsgsgsd";
        letras[5]="sgsfgdfgd";
        letras[6]="dfsfdsfsdf";

        Console.WriteLine(n[4]);
        Console.WriteLine(num[3]);
        Console.WriteLine(num1[6]);
        Console.WriteLine(letras[3]);
    }
}