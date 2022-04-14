using System;

public struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    //public Carro(string marca, string modelo, string cor)
    //{
    //    this.marca = marca;
    //    this.modelo = modelo;
    //    this.cor = cor;
    //}
    public void Info()
    {
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
        Console.WriteLine("--------------------------------");
    }
}

class Aula44
{
    static void Main()
    {
        Carro[] carros = new Carro[5];

        carros[0].marca = "FIAT";
        carros[0].modelo = "Chronos";
        carros[0].cor = "vermelho";

        carros[1].marca = "Chevrolet";
        carros[1].modelo = "Prisma";
        carros[1].cor = "Branco";

        carros[2].marca = "Ford";
        carros[2].modelo = "Focus";
        carros[2].cor = "prata";

        carros[3].marca = "Renault";
        carros[3].modelo = "Symbol";
        carros[3].cor = "Branco";

        for (int i = 0; i < carros.Length; i++) 
        {
            carros[i].Info();
        }
    }
}