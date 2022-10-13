using PublicApi.Dtos;
using AutoMapper;
using PublicApi.Interface;

namespace PublicApi.Services
{
    public class CepService : Endereco
    {

        private readonly IMapper _mapper;

        private readonly IBrasilApi _brasilApi;

        public CepService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCEP(cep);

            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}
