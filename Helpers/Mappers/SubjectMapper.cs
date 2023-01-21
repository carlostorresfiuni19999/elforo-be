using AutoMapper;
using elforo_be.Models.dto;
using elforo_be.Models.ent;

namespace elforo_be.Helpers.Mappers
{
    public class SubjectMapper : Profile
    {
        public SubjectMapper()
        {
            CreateMap<Subject, SubjectDTO>()
            .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year.ToString()));
        }
    }
}