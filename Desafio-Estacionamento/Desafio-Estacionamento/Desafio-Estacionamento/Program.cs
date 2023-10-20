using Desafio_Estacionamento.Models;

Estacionamento estacionamento = new Estacionamento();

Console.WriteLine("Seja bem vindo ao estacionamento!");
Console.WriteLine("Por favor, informe o valor inicial para o pagamento: ");
decimal valorInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora, informe o valor da hora estacionada: ");
decimal valorHora = Convert.ToDecimal(Console.ReadLine());

do
{
    Console.WriteLine("Escolha qual a operação a ser realizada:\n 1. Adicionar veículo\n 2. Remover veículo\n 3. Listar veículo\n 4. Encerrar sessão\n");
    int escolha = Convert.ToInt32(Console.ReadLine());

    if(escolha == 4)
    {
        break;
    }
    else
    {
        switch (escolha)
        {
            case 1:
                estacionamento.AdicionarVeiculo();
                break;
            case 2:
                estacionamento.RemoverVeiculo(valorInicial, valorHora);
                break;
            case 3:
                estacionamento.ListarVeiculo();
                break;
            default:
                Console.WriteLine("Escolha uma opção válida!\n");
                break;
        }
    }
    
} while (true);

