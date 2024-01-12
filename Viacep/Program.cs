using Viacep.Models;

namespace Viacep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("====== Bem-vindo à Consulta de CEP ======\n\n");
                string opcao = "";

                while (opcao != "3")
                {
                    Console.WriteLine("Selecione a opção desejada:\n1-Consultar endereço com o CEP\n2-Consultar endereço sem o CEP\n3-Sair");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            string cep;
                            RequisicaoAPI novaRequisicao = new RequisicaoAPI();

                            Console.WriteLine("Por favor, informe o CEP:");
                            cep = Console.ReadLine();

                            novaRequisicao.Requisicao(cep);
                            break;

                        case "2":
                            string uf, localidade, logradouro;
                            RequisicaoAPI requisicaoSemCEP = new RequisicaoAPI();

                            Console.WriteLine("Informe a UF do estado:");
                            uf = Console.ReadLine();
                            Console.WriteLine("\nInforme o nome da cidade:");
                            localidade = Console.ReadLine();
                            Console.WriteLine("\nInforme o logradouro:");
                            logradouro = Console.ReadLine();

                            requisicaoSemCEP.RequisicaoSemCEP(uf, localidade, logradouro);
                            break;

                        case "3":
                            break;

                        default:
                            Console.WriteLine("\nOpção incorreta.\n");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex}");
            }
        }
    }
}