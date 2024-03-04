using AutoMapper;
using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Profiles
{
    public class LaboratorioProfile : Profile
    {
        public LaboratorioProfile()
        {
            CreateMap<Laboratorio, LaboratorioDTO>().ReverseMap();
        }
    }
}
