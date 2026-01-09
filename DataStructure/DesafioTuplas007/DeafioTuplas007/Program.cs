
using DeafioTuplas007.Class;
bool op = true;

while (op)
{
    Console.Clear();
    Menu();

    var input = Console.ReadLine();
    if (input?.ToLower() == "x")
    {
        Console.WriteLine("Encerrando...");
        op = false;
        continue;
    }

    if (int.TryParse(input, out int option))
    {
        if(option == 1)
        {
            try
            {
                Console.WriteLine("Digite uma palavra: ");
                string type = Console.ReadLine() ?? "";
                Palavra palavra = new Palavra(
                    nome: type.ToLower()
                    );
                Console.WriteLine(palavra.ObterVogais());

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    else
    {
        Console.WriteLine("Opcao invalida");
    }
    Console.WriteLine("Digite algo para voltar");
    Console.ReadKey();

    void Menu()
    {
        Console.WriteLine("--------- DIGITE 1 PARA CONTINUAR OU X PARA SAIR ----------");
        Console.WriteLine("1 - Cntinuar");
        Console.Write(" > ");
    } 

}