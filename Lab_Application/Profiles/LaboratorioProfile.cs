using AutoMapper;
using EFTS_Application.DTOs;
using EFTS_Domain.Entities;

namespace EFTS_Application.Profiles
{
    public class LaboratorioProfile : Profile
    {
        public LaboratorioProfile()
        {
            CreateMap<Laboratorio, LaboratorioDTO>().ReverseMap();
        }
    }
}