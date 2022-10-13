using AutoMapper;
using PublicApi.Dtos;
using PublicApi.Models;

namespace PublicApi.Mappings
{
    public class EnderecoMapping : Profile
    {

        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }

    }
}
