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
                .ForMember(dest => dest.Comments, opt => opt.Ignore())
                .ForMember(dest => dest.Tags, opt => opt.Ignore())
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateOnly.FromDateTime(DateTime.Now)));
                

            CreateMap<Question, QuestionDTO>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Person == null ? "" : 
                    src.Anonymous ? "Anonimo" : src.Person.Email))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.ConvertAll(t => t.TagName)))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToString()))
                .ForMember(dest => dest.CantComment, opt => opt.MapFrom(src => src.Comments == null ? 0 : src.Comments.Count));
        
        }
    }
}