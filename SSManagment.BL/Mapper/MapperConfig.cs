using AutoMapper;
using SSManagment.BL.DTOs;
using SSManagment.Data.Entities;


namespace SSManagment.BL.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Student,StudentDTO>().ReverseMap();
            CreateMap<University,UniversityDTO>().ReverseMap();
        }
    }
}
