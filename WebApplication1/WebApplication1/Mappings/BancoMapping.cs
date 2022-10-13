using AutoMapper;
using PublicApi.Dtos;
using PublicApi.Models;

namespace WebApplication1.Mappings
{
    public class BancoMapping : Profile
    {

        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>(); 
        }
    }
}
