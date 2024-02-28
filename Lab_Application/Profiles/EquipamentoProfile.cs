using AutoMapper;
using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Profiles
{
    public class EquipamentoProfile : Profile
    {
        public EquipamentoProfile()
        {
            CreateMap<Equipamento, EquipamentoDTO>().ReverseMap();
        }
    }
}
