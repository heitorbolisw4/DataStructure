// desenvolva um programa que leia 4 valores e os guarde em uma tupla no final mostre:
// A - Quantas vezes o valor 9 apareceu 
// B - Em que posição foi digitado o primeiro valor 3
// C - Quais foram os numeros pares
using System.Threading;
using DesafioTuplas.Class;

Numbers numbers = new Numbers();

int n1;
bool op = true;

while (op)
{
    Console.Clear();
    Menu();

    var input = Console.ReadLine();

    if (input?.ToLower() == "x")
    {
        Console.WriteLine("Encerrando");
        op = false;
        continue;
    }

    if (int.TryParse(input, out int option))
    {

        try
        {
            
            switch (option)
            {
                case 1:
                    Console.WriteLine("Digite os numeros para salvar");
                    numbers.LerNumeros();
                    break;
                case 2:
                    Console.WriteLine("Mostrar numeros");
                    Console.WriteLine(numbers.TuplaNumeros);
                    break;
                case 3:
                    Console.WriteLine("Quantas vezes este numero apareceu?");
                    Console.Write(" > ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    numbers.ContarOcorrencias(n1);
                    Console.WriteLine($"O numero {n1} aparece {numbers.ContarOcorrencias(n1)} vez(es)");
                    break;
                case 4:
                    Console.WriteLine("Em qual posicao este numero aparece?");
                    Console.Write(" > ");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    int posicao = numbers.SeachPosition(n1);
                    if(posicao == -1)
                    {
                        Console.WriteLine($"O numero {n1} nao existe na busca");
                    }
                    else
                    {
                        Console.WriteLine($"O numero {n1} aparece na posicao {posicao}");
                    }
                    break;
                case 5:
                    List<int> listadePares = numbers.Divisible();
                    Console.WriteLine($"Numeros de pares: {string.Join(", ", listadePares)}");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    else
    {
        Console.WriteLine("Opcao invalida");
    }
    Console.WriteLine("\n Pressione qualquer tecla para continuar");
    Console.ReadKey();
}





void Menu()
{
    Console.WriteLine("--------- SELECIONE UMA OPCAO OU DIGITE X PARA SAIR ----------");
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine("1- Digitar numeros");
    Console.WriteLine("2- Mostrar todos");
    Console.WriteLine("3- Digite um numero para quantas vezes ele apareceu");
    Console.WriteLine("4- Digite um numero para saber em qual posicao ele apareceu");
    Console.WriteLine("5 -Quer saber se digitou algum numero par?");
    Console.WriteLine("------------------");
    Thread.Sleep(1000);
    Console.WriteLine("Escolha uma opcao do menu");
    Console.Write(" > ");
}