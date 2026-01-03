// crie um programa que gere numeros aleatorios e coloque-os dentro de uma tupla
// depois disso, mostre a listagem dos numeros gerados
// e também indique o menor e o maior valor que estão na tupla

using ConsoleApp1.Class;

CarregarNumeros carregarNumeros = new();
Numbers numbers = new Numbers();
Numbers _numbers = new Numbers();


bool op = true;


while (op)
{

    Console.Clear();

    Console.WriteLine("1 - Ver numeros Aleatorios");
    Console.WriteLine("2 - Listar numeros gerados");
    Console.WriteLine("3 - Mostrar o menor numero");
    Console.WriteLine("4 - Mostrar o maior numero");
    Console.WriteLine("X - Sair do programa");
    Console.WriteLine("---------------Nao, eu nao vou jogar CS hoje-------------------");
    Console.WriteLine("Escolha sua opcao");
    Console.Write("> ");
    var input = Console.ReadLine();

    if(input?.ToLower() == "x")
    {
        op = false;
        continue;
    }
    if(int.TryParse(input, out int opcao))

        switch (opcao)
        {
            case 1:

                Console.WriteLine(_numbers.NumerosGerados);
                break;

            case 2:

                for (int i = 0; i < _numbers.ArrayNumbers.Length; i++)
                {
                    Console.WriteLine($"{i}° {_numbers.ArrayNumbers[i]}");
                }
                break;

            case 3:
                Console.WriteLine($"Menor Valor {_numbers.ArrayNumbers.Min()}");

                break;

            case 4:
                Console.WriteLine($"Maior Valor {_numbers.ArrayNumbers.Max()}");
                break;
            case 5:
                numbers.CarregarNumeros();
                Console.WriteLine("Os novos numeros foram gerados com SUCESSO!!");
                Console.WriteLine(_numbers.NumerosGerados);
                break;

            default:
                Console.WriteLine("Opcao desconhecida");
                break;

        }
    if (op)
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.Write("> ");
        Console.ReadKey();
    }


}