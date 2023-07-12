using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando_C_.Models
{
    public class Suite
    {
        public string Presidencial { get; set; }
        public string Premiun { get; set; }
        public string NormalFamilia { get; set; }
        public string NormalCasal { get; set; }
        public string NormalSolteiro { get; set; }

        public void Quartos()
        {
        int quarto;
        Console.WriteLine("Agora vamos continuar selecionando o tipo e a quantidade de quantos desejados \n Tipo de quarto // Tamanho // Preço da diária");
        Console.WriteLine("Presidencial // 7 pessoas // Custo de 100 reais a diária \n Premium // 5 pessoas // Custo de 75 reais a diária \n NormaF // 3 pessoas // Custo de 50 reais a diária \n NormalC // 2 pessoas // Custo de 35 reais a diária \n NormalS // 1 pessoa // Custo de 20 reais a diária");
        }

        public string EscolhaQuarto()
        {
        Console.WriteLine("Por favor digite a Suíte que deseja:");
        string quartoHospede = Console.ReadLine();

        switch (quartoHospede)
        {
            case "Presidencial":
                Console.WriteLine("Você escolheu a Suíte Presidencial");
                break;
            case "Premium":
                Console.WriteLine("Você escolheu a Suíte Premium");
                break;
            case "NormalF":
                Console.WriteLine("Você escolheu a Suíte Normal Familia");
                break;
            case "NormalC":
                Console.WriteLine("Você escolheu a Suíte Normal Casal");
                break;
            case "NormalS":
                Console.WriteLine("Você escolheu a Suíte Solteiro");
                break;
            default:
                Console.WriteLine("Por favor escolha uma suíte válida");
                quartoHospede = Console.ReadLine();
                break;
            }    
            return quartoHospede;  
        }
    }
}