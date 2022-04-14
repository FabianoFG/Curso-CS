using System;
public class Coisa
{
    int valor=0;
    
    public void defineprop()
    {   
        Console.WriteLine("Digite um valor para a propriedade");
        valor=int.Parse(Console.ReadLine()); 
    }
    public void lerprop()
    {
        Console.WriteLine("O valor de coisinha é: {0}",valor);
    }

}
class Teste
{
    static void Main()
    {
        bool executar=true;
        String comando="funcionando";
        Coisa coisinha=new Coisa();

        do
        {   
            Console.WriteLine("Digite um comando:");
            comando=Console.ReadLine();

            if(comando=="definirprop")
            {
                coisinha.defineprop();
            }else if(comando=="lerprop"){
                coisinha.lerprop();
            }else if(comando=="fechar"){
                executar=false;
            }else{
                Console.Clear();
                Console.WriteLine("Comando inválido\nLista de comandos:\ndefinirprop\nlerprop\nfechar\n");
            }
            
            

        }while(executar);
        Console.WriteLine("O programa foi encerrado");
    }
}