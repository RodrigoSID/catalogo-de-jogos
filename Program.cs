
using System.ComponentModel;
using System.Collections.Generic;

Dictionary <string, List<string>> catalogo = new();

void Mostrar_catalogo()
{
    if (catalogo.Count == 0)
    {
        Console.WriteLine("Lista de jogos vazia!");
    }
    else
    {
        Console.WriteLine(" nome --- genero --- status");
        foreach (var valor in catalogo)
        {
            Console.WriteLine($" {string.Join(" --- ", valor.Value)}");
        }
    }
}

string Pedir_valor(string pedido)
{
    Console.Write(pedido);
    string dados = "";
    do
    {
        dados = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(dados))
        {
            Console.Write($"por favor infome um {pedido}");
        }
    
    } while (string.IsNullOrWhiteSpace(dados));
    
    return dados;
}

void Adicionar_jogo()
{
    List<string> jogo = new();

    jogo.Add(Pedir_valor("Nome do jogo: "));

    jogo.Add(Pedir_valor("Genero do jogo: "));

    jogo.Add(Pedir_valor("Status do jogo: "));

    if (catalogo.ContainsKey(jogo[0]) == true)
    {
        Console.WriteLine($"o jogo {jogo[0]} ja esta no catalogo");
    }
    else
    {
        catalogo.Add($"{jogo[0]}", jogo);
    }

}

bool continuar = true;

do
{
    Console.WriteLine(
        "---------------------------------- \n" +
        "escolha uma das opçoes: \n" +
        "1- Ver catalogo de jogos \n" +
        "2- Cadastra novo jogo \n" +
        "3- Sair \n" +
        "----------------------------------");

    ConsoleKeyInfo escolha = Console.ReadKey(true);

    switch (escolha.Key)
    {
        case ConsoleKey.D1:
            Mostrar_catalogo();
            break;

        case ConsoleKey.D2:
            Adicionar_jogo();
            break;

        case ConsoleKey.D3:
            continuar = false;
            break;

        default:
            Console.WriteLine("por favor escola uma das opçôes abaixo");
            break;


    }

} while (continuar);
