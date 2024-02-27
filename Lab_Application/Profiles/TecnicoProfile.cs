using AutoMapper;
using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Profiles
{
    public class TecnicoProfile : Profile
    {
        public TecnicoProfile()
        {
            CreateMap<Tecnico, TecnicoDTO>().ReverseMap();
        }
    }
}
