using Refit;
using System;
using System.Threading.Tasks;

namespace BuscarCEP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepCliente = RestService.For<Interface1>("http://viacep.com.br");
                Console.Write("Informe seu CEP: ");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informações do CEP: " + cepInformado);

                var address = await cepCliente.GetAddressAsync(cepInformado);

                Console.Write($"\nEndereço: {address.Logradouro}" +
                                $"\nBairro: {address.Bairro}" +
                                $"\nCidade: {address.Localidade}" +
                                $"\nUF: {address.UF}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de Cep: " + e.Message);
            }

        }
    }
}
