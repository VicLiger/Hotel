using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando_C_.Models
{
    public class Pessoa
    {
        public string Hospede { get; set; }
        public List<string> ListaHospede { get; set; }

        public Pessoa()
        {
            ListaHospede = new List<string>();
        }

        public void Adicionar()
        {
            Console.WriteLine("Digite o nome do hospede que você deseja inserir: ");
            string hospede = Console.ReadLine();
            ListaHospede.Add(hospede);
            Console.WriteLine("Hospede adicionado com sucesso");
            Console.WriteLine("Aperte enter para continuar");
            Console.ReadLine();
            Console.Clear();
            
        }
        
        public void Remover()
        {
            Console.WriteLine("Digite o nome do hospede que você deseja remover: ");
            string hospede = Console.ReadLine();
            ListaHospede.Remove(hospede);
            Console.WriteLine("Hospede removido com sucesso");
            Console.WriteLine("Aperte enter para continuar");
            Console.ReadLine();
            Console.Clear();

        }

        public void ListarHospedes()
        {
            foreach (string cliente in ListaHospede)
            {
                Console.WriteLine(cliente);
            }
            Console.WriteLine(ListaHospede.Count()+" Hospedes");
            Console.WriteLine("Aperte enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        public void Contagem()
        {
            Console.WriteLine($"A quantidade de pessoas selecionada é: "+ ListaHospede.Count());
            Console.WriteLine("Aperte enter para continuar");
            Console.ReadLine();
        }
    }
}