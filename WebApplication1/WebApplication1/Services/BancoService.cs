using AutoMapper;
using PublicApi.Dtos;
using PublicApi.Interface;

namespace PublicApi.Services
{
    public class BancoService : IBancoService
    {

        private readonly IMapper _mapper;

        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilApi.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);
        }

    }
}
