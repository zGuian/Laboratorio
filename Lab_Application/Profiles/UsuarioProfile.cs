using AutoMapper;
using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        }
    }
}
