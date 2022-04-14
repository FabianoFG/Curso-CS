using System;

public struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca,string modelo,string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void Info()
    {
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
    }
}

class Aula44
{
    static void Main()
    {
        Carro C1 = new Carro("FIAT","Chronos","vermelho");
        Carro C2 = new Carro("Chevrolet", "Prisma", "Branco");

        C1.Info();
        C2.Info();
    }
}