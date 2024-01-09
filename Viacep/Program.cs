using Viacep.Models;

namespace Viacep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Bem-vindo à Consulta de CEP ======\n\n");

            RequisicaoAPI novaRequisicao = new RequisicaoAPI();
            string cep;

            do
            {
                Console.WriteLine("Digite 'sair' para fechar a aplicação.");

                Console.WriteLine("Por favor, informe o CEP:");
                cep = Console.ReadLine();

                if (cep.ToUpper() == "SAIR")
                    break;

                novaRequisicao.Requisicao(cep);
            } while (cep.ToUpper() != "SAIR");
            
        }
    }
}