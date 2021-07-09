using AutoMapper;
using GameCatalogue.Application.DTOs;
using GameCatalogue.Domain.Entities;

namespace GameCatalogue.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Platform, PlatformDTO>().ReverseMap();
            CreateMap<Game, GameDTO>().ReverseMap();
        }
    }
}
