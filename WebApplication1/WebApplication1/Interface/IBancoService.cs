using PublicApi.Dtos;

namespace PublicApi.Interface
{
    public interface IBancoService
    {

        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);

    }
}
