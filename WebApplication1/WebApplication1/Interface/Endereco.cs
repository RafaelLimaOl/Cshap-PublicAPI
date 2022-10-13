using PublicApi.Dtos;

namespace PublicApi.Interface
{
    public interface Endereco
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);

    }
}
