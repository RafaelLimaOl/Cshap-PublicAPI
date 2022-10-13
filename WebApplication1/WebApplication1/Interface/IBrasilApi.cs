using PublicApi.Dtos;
using PublicApi.Models;

namespace PublicApi.Interface
{
    public interface IBrasilApi
    {

        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);

        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

    }
}
