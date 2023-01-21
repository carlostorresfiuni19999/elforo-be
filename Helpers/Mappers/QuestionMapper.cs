using AutoMapper;
using elforo_be.Models.dto;
using elforo_be.Models.ent;

namespace elforo_be.Helpers.Mappers
{
    public class QuestionMapper : Profile
    {
        public QuestionMapper()
        {
            CreateMap<QuestionDTO, Question>()
                .ForMember(dest => dest.Person, opt => opt.Ignore())
                .ForMember(dest => dest.Comments, opt => opt.Ignore());

            CreateMap<Question, QuestionDTO>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Person == null ? "" : 
                    src.Anonymous ? "Anonimo" : src.Person.Email))
                .ForMember(dest => dest.CantComment, opt => opt.MapFrom(src => src.Comments == null ? 0 : src.Comments.Count));
        
        }
    }
}