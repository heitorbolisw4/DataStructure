
using DesafioTuplas001;

Contador contador = new();
Console.WriteLine("Vamos comecar?");
bool op = true;

while (op)
{

    Console.WriteLine("Digite um numero de 1 a 20 ou aperte x para sair");
    var input = Console.ReadLine();
    if(int.TryParse(input, out int option))
    {
        try
        { 
            Console.WriteLine(contador.WhatNumber(option));
            Console.WriteLine("-------------------");
        }
        catch(Exception)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Digite um numero inteiro entre 0 e 20");
            Console.WriteLine("------------------------------------------------");
        }

    }
    else if (input == ("x").ToLower())
    {
        op = false;
    }
    else
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Voce deve digitar um numero inteiro entre 1 e 20");
        Console.WriteLine("------------------------------------------------");
    }



}