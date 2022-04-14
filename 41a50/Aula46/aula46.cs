using System;

class Ovo
{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo,string minhaGalinha)
    {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado:{0} - {1}",this.numOvo,this.minhaGalinha);
    }

}
class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    public static int totalOvos=0;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }
    public Ovo Botar()
    {
        totalOvos++;
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}
class Aula46
{
    static void Main()
    {
        Galinha G1 = new Galinha("Cócó");
        Galinha G2 = new Galinha("Ricó");
        Galinha G3 = new Galinha("Póó");

        G1.Botar();
        G1.Botar();
        G1.Botar();
        G2.Botar();
        G3.Botar();
        G3.Botar();

        Console.WriteLine("Total de ovos postos: {0}", Galinha.totalOvos);
    }
}