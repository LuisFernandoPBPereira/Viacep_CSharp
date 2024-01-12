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
        public void ConsultaCEP(string json)
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

        public void ConsultaSemCEP(string json)
        {
            var list = new List<Endereco>();
            list = JsonConvert.DeserializeObject<List<Endereco>>(json);

            if(list.Count() == 0)
            {
                Console.WriteLine("\nEndereço não encontrado.\n");
            }
            else
            {
                Console.WriteLine("\nEste foi o resultado da consulta:\n");

                foreach(var item in list)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"CEP: {item.Cep}");
                    Console.WriteLine($"Rua: {item.Logradouro}");
                    Console.WriteLine($"Complemento: {item.Complemento}");
                    Console.WriteLine($"Bairro: {item.Bairro}");
                    Console.WriteLine($"Localidade: {item.Localidade}");
                    Console.WriteLine($"UF: {item.Uf}");
                    Console.WriteLine($"IBGE: {item.Ibge}");
                    Console.WriteLine($"GIA: {item.Gia}");
                    Console.WriteLine($"DDD: {item.Ddd}");
                    Console.WriteLine($"SIAFI: {item.Siafi}");
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
