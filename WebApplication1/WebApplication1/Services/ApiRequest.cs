using PublicApi.Models;
using Refit;
using System.Text.Json;
using System.Text.Json.Serialization;

/*
namespace PublicApi.ApiRequest
{
    internal class ApiRequest
    {
        static async Task<CepResponse> ApiResponse(string Cep)
        {


            HttpClient httpClient = new HttpClient();
            var address = await httpClient.GetAsync($"http://viacep.com.br/ws/{Cep}/json");

            var jsonString = await address.Content.ReadAsStringAsync();

            CepResponse jsonObject = JsonSerializer.Deserialize<CepResponse>(jsonString);

            return jsonObject;
            /*
            try
            {
                var CepClient = RestService.For<ApiRequest>("http://viacep.com.br/");
                Console.WriteLine("Infome algum CEP:");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando API.... com o CEP:" + cepInformado);

                var address = await CepClient.GetAddressAsync(cepInformado);

                Console.Write($"\nLogradouro:{address.Logradouro}, \nBairro:{address.Bairro}, \nLocalidade:{address.Localidade}, \nUf:{address.Uf}, \nIbge:{address.Ibge}, \nGia:{address.Gia}, \n Ddd:{address.Ddd}, \nSiafi:{address.Siafi},");

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro! O CEP inserido não existe");
            }
        }
    }
}
*/