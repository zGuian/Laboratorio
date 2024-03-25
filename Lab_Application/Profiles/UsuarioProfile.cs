using AutoMapper;
using EFTS_Application.DTOs;
using EFTS_Domain.Entities;

namespace EFTS_Application.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        }
    }
}