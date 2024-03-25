using AutoMapper;
using EFTS_Application.DTOs;
using EFTS_Domain.Entities;

namespace EFTS_Application.Profiles
{
    public class TecnicoProfile : Profile
    {
        public TecnicoProfile()
        {
            CreateMap<Tecnico, TecnicoDTO>().ReverseMap();
        }
    }
}