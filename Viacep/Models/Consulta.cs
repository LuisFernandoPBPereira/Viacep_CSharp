using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viacep.Models
{
    public class Consulta
    {
        public void ConsultaCEP(dynamic json)
        {
            var novaConsulta = JsonConvert.DeserializeObject<Endereco>(json);

            Console.WriteLine("\n");
            Console.WriteLine($"CEP: {novaConsulta.Cep}");
            Console.WriteLine($"Rua: {novaConsulta.Logradouro}");
            Console.WriteLine($"Complemento: {novaConsulta.Complemento}");
            Console.WriteLine($"Bairro: {novaConsulta.Bairro}");
            Console.WriteLine($"Localidade: {novaConsulta.Localidade}");
            Console.WriteLine($"UF: {novaConsulta.Uf}");
            Console.WriteLine($"IBGE: {novaConsulta.Ibge}");
            Console.WriteLine($"GIA: {novaConsulta.Gia}");
            Console.WriteLine($"DDD: {novaConsulta.Ddd}");
            Console.WriteLine($"SIAFI: {novaConsulta.Siafi}");
            Console.WriteLine("\n");
        }
    }
}
