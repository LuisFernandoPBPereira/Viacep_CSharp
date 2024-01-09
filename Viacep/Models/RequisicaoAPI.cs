using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viacep.Models
{
    public class RequisicaoAPI
    {
        public void Requisicao(string cep) 
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var endpoint = new Uri($"https://viacep.com.br/ws/{cep}/json/");
                    var result = client.GetAsync(endpoint).Result;
                    var json = result.Content.ReadAsStringAsync().Result;

                    Consulta consulta = new Consulta();
                    consulta.ConsultaCEP(json);
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Houve um erro na consulta, tente novamente. ERRO: {ex.Message}\n\n");
            }
             
        }
    }
}
