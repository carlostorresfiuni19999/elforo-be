using AutoMapper;
using elforo_be.Models.dto;

namespace elforo_be.Helpers.Mappers
{
    public class Tag : Profile
    {
        public Tag()
        {
            CreateMap<Tag, TagDTO>();
        }
    }
}