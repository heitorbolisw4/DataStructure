// crie um programa que tenha uma tupla unica com nomes
// de produtos e seus respectivos precos na sequencia
// No final, mostre uma listagem de preços organzando os dados em forma tabular 


using ListaDePreco.Class;
using System.Linq.Expressions;
Estoque estoque = new();



bool op = true;

while (op)
{
    Console.Clear();
    Menu();
    var input = Console.ReadLine();


    if(input?.ToLower() == "x")
    {
        Console.WriteLine("Encerrando...");
        op = false;
        continue;
    }
    if(int.TryParse(input, out var option))
    {
        switch (option)
        {
            case 1:
                Console.WriteLine("Adcionar um produto");
                Console.Write("Nome do produto:");
                string? _nomeProduto = Console.ReadLine();
                Console.Write("Valor do produto:");
                decimal _valorProduto = Convert.ToDecimal(Console.ReadLine());



                Produto produto = new(
                    
                    nome: _nomeProduto ?? "",
                    preco: _valorProduto


                    );
                estoque.AddProduct(produto);
                break;
            case 2:
                Console.WriteLine("-------- Lista de produtos --------");
                List<string>listaRelatorio = estoque.SeeAllProducts();
                foreach(string linha in listaRelatorio)
                {
                    Console.WriteLine(linha);
                }
                Console.WriteLine("----------------------------------\n");

                break;
            case 3:
                
                
                Console.Write("Digite o novo Id: ");
                int newId = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Digite o novo Nome: ");
                string? newName = Console.ReadLine();

                Console.Write("Digite o novo Valor: ");
                decimal newValor = Convert.ToDecimal(Console.ReadLine());
                estoque.EditProduct(
                    id: newId,
                    newName: newName ?? "",
                    newValue: newValor 
                    );
                break;
            case 4:

                Console.WriteLine("----- Remover Produto -----");
                Console.WriteLine("Digite o Id para remover");
                Console.Write(">");

                try
                {
                    int idDeletar = Convert.ToInt32(Console.ReadLine());
                    estoque.RemoveProduct(idDeletar);
                    
                    Console.WriteLine(" ------ Produto removido com sucesso -------");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro {ex.Message}");
                }
                break;
        }
    }
    else
    {
        Console.WriteLine("Opcao invalida");
    }
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.Write(" > ");
    Console.ReadKey();
}



void Menu()
{
    Console.WriteLine("------ ESCOLHA UMA OPÇÃO OU DIGITE X PARA SAIR --------");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Ver produto");
    Console.WriteLine("3 - Editar produto");
    Console.WriteLine("4 - Deletar produto");
    Console.WriteLine("----- opcao ----");
    Console.Write(" > ");

}

