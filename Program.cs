using Explorando_C_.Models;
using System;


Pessoa pessoa = new Pessoa();
Suite suite = new Suite();
Reserva reserva = new Reserva();

Console.Clear();
int escolha;
do
{
    Console.WriteLine("Digite a sua opção:\n1 - Adicionar cliente\n2 - Remover cliente\n3 - Listar clientes\n4 - Encerrar programa");
    int.TryParse(Console.ReadLine(), out escolha);

    switch (escolha)
        {
        case 1:
            pessoa.Adicionar();
            break;

        case 2:
            pessoa.Remover();
            break;
        case 3:
            pessoa.ListarHospedes(); // Chama o método para listar os clientes
            break;
    }
} while (escolha != 4);
Console.Clear();

//Mostra a quantidade de pessoas
pessoa.Contagem();

//Mostra os quartos
suite.Quartos();

//Pedi os dias que o cliente ira permanecer
reserva.ReservaHospede();

//Valor da conta
reserva.ValorPago();




    
    




    



















    // Console.WriteLine("Digite a sua opção: \n 1 - Adicionar cliente \n 2 - Remover cliente \n 3 - Listar clientes \n 4 - Encerrar programa");
    // int.TryParse(Console.ReadLine(), out escolha);

    // switch (escolha)
    // {
    //     case 1:
    //         Console.WriteLine("Digite o nome do cliente que deseja adicionar: ");
    //         string nome = Console.ReadLine();
    //         pessoa.Adicionar(nome);
    //         pessoa.LimparConsole();
    //         break;

    //     case 2:
    //         Console.WriteLine("Digite o nome do cliente que deseja remover: ");
    //         nome = Console.ReadLine();
    //         pessoa.Remover(nome);
    //         pessoa.LimparConsole();
    //         break;

    //     case 3:
    //         pessoa.ListarHospedes(); // Chama o método ListarHospedes() da classe Pessoa
    //         pessoa.LimparConsole();
    //         break;
    