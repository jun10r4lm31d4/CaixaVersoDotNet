using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace InjecaoDependencia;

internal class Program
{
    public static void Main(string[] args)
    {
        //ICripto cripto = new ComCriptografia();
        //var acesso = new NovosAcessos("login", "senha", cripto);
        //acesso.imprimir();

        //Console.ReadKey();        

        Console.WriteLine("=== Método ===");
        var acessoMetodo = new NovosAcessosMetodo("login", "senha");
        acessoMetodo.DefinirCripto(new MetodoCriptografia());
        acessoMetodo.Imprimir();
        Console.WriteLine();

        Console.WriteLine("=== Propriedade ===");
        var acessoPropriedade = new NovosAcessosPropriedade();
        acessoPropriedade.PropriedadeCripto = new PropriedadeCriptografia();

        acessoPropriedade.Imprimir("login", "senha");
        Console.WriteLine();

        Console.WriteLine("=== FIM ===");
        Console.ReadKey();


        var carrinho = new Carrinho();
        Produto produto = new Produto("Notebook", 2800m, "");
        carrinho.ExibirProduto(produto);

        Produto notebook = new Notebook("Notebook", 5800m, "");
        carrinho.ExibirProduto(notebook);

        
    }
}