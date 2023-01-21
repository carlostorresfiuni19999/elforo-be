using AutoMapper;
using elforo_be.Models.ent;
using elforo_be.Models.dto;

namespace elforo_be.Helpers.Mappers
{
    public class CommentMapper : Profile
    {
        public CommentMapper()
        {
            CreateMap<CommentDTO, Comentario>()
                .ForMember(dest => dest.Question, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Comentario, CommentDTO>()
                .ForMember(dest => dest.IdPerson, opt => opt.MapFrom(src =>null == src.User ? "" : src.User.Id))
                .ForMember(dest => dest.IdQuestion, opt => opt.MapFrom(src => null == src.Question ? -1 :  src.Question.Id));

        }
        
    }
}