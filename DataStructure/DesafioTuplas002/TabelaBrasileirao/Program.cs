//Crie um tupla com os 20 colocados na tabela do Brasileirão na ordem de colocacao
// Depois mostre -> 
// A - Os 5 primeiros colocados
// B - Os 4 ultimos colocados
// C - Uma lista com o nome dos times em ordem alfabetica
// D - Em que posicao esta o time Botafogo


using TabelaBrasileirao;

Brasileirao tabela = new();

Console.WriteLine("Vamos aos dados do Brasileirao 2025");

bool op = true;

while (op)
{
    Console.Clear();

    Console.WriteLine("1 - Todos times");
    Console.WriteLine("2 - Ver G5");
    Console.WriteLine("3 - Ver Z4");
    Console.WriteLine("4 - Ver posicao do meu time");
    Console.WriteLine("x - Para sair");
    Console.Write("\n > ");


    var input = Console.ReadLine();

    if (input?.ToLower() == "x")
    {
        op = false;
        continue;
    }
    if(int.TryParse(input, out int opcao))
    {
        try
        {
            switch (opcao)
            {
                case 1:
                    string[] AllTimes = tabela.TimesOrdemAlf();
                    Console.WriteLine("Os times participantes do campeonato Brasileiro 2025");
                    foreach(string times in AllTimes)
                    {
                        Console.WriteLine(times); 
                    }
                    break;
                case 2:
                    Console.WriteLine("G5 - Times classificados para Libertadores");
                    string[] TheFives = tabela.CincoPrimeiros();
                    foreach(string times in TheFives)
                    {
                        Console.WriteLine(times);
                    }
                    break;
                case 3:
                    Console.WriteLine("Z4 - Veja as times rebaixados para a Segunda Divisao:");
                    string[] ZfourTeams = tabela.Rebaixamento();
                    foreach(string times in ZfourTeams)
                    {
                        Console.WriteLine(times);
                    }
                    break;
                case 4:
                    // usuario passa o nome do time
                    // retorno esperado é a posicao do time informeado ( ou seja o index )


                    Console.WriteLine("Digite o nome do seu time");
                    var time = Console.ReadLine() ?? "";

                    int posicao = tabela.WhatPosition(time);
                    
                    if(posicao == -1)
                    {
                        Console.WriteLine("O nome do time foi digitado incorretamente..");
                    }
                    else
                    {
                        Console.WriteLine($"O time {time} esta na posicao {posicao + 1} da tabela");
                    }

                        break;
                
                case 5:
                    Console.WriteLine("Limpando...");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Opcao invalida");
                    break;

            }
        }
        //if(opcao != "0")
        //{
        //    Console.WriteLine("Digite algo para sair");
        //    Console.ReadLine();
        //};

        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString()); 
        }
    }
    if (op)
    {
        Console.WriteLine("\n ---------------------------------------");
        Console.WriteLine("Digite qualquer coisa para voltar ao menu");
        Console.Write(">");
        Console.ReadKey();
    }

}


