using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Estacionamento.Models
{
    public class Estacionamento
    {
        /*private decimal precoInicial = 0;
        private decimal precoPorHora = 0;*/

        private List<string> veiculos = new List<string>();

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Por favor, informe a placa do veículo que deseja adicionar: ");
            string veiculo = Console.ReadLine();

            veiculos.Add(veiculo);

            Console.WriteLine("Veículo adicionado com sucesso!");
            Console.Clear();
        }

        public void RemoverVeiculo(decimal precoInicial, decimal precoPorHora)
        {
            
            Console.WriteLine("Por favor, informe a placa do veículo que deseja remover: ");
            string veiculo = Console.ReadLine();
            Console.WriteLine("Agora, informe a quantidade de horas que o veículo ficou estacionado: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            veiculos.Remove(veiculo);

            decimal valorAPagar = precoInicial + (precoPorHora * horas);

            Console.WriteLine($"O veículo foi removido com sucesso, tendo como valor a pagar: R${valorAPagar}\n");
            
        }

        public void ListarVeiculo()
        {
            Console.Clear();
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há carros no estacionamento\n");
            }
            else
            {
                Console.WriteLine("Carros no estacionamento: ");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
                Console.WriteLine("\n");
                
            }
        }
    }
}
