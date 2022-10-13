using PublicApi.Dtos;
using PublicApi.Interface;
using PublicApi.Models;
using System.Dynamic;
using System.Text.Json;

namespace PublicApi.Rest
{
    public class ApiBrasilRest : IBrasilApi
    {
       
        public async Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1");

            var response = new ResponseGenerico<List<BancoModel>>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);

                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

                var objectResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResponse);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objectResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);

                }
            }
            return response;
        }

        public async Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");

            var response = new ResponseGenerico<BancoModel>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);

                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

                var objectResponse = JsonSerializer.Deserialize<BancoModel>(contentResponse);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objectResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);

                }
            }
            return response;
        } 

        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            // Requisição dos Dados Da API através do Link com o Parâmetro CEP: 

            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGenerico<EnderecoModel>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);

                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

                var objectResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResponse);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objectResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);

                }
            }
            return response;
        }
    }
}
