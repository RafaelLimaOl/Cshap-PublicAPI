using PublicApi.Dtos;

namespace PublicApi.Interface
{
    public interface IBancoService
    {

        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();

        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);

    }
}
