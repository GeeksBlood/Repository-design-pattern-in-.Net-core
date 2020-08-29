using AutoMapper;
using Database;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ValidateInlineMaps = false;

            CreateMap<Temployee, EmployeesModel>()
                .ForMember(dest => dest.EmpId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Name)).ReverseMap();
        }
    }
}
