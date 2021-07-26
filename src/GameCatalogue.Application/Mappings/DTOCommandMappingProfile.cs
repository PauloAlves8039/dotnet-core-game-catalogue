using AutoMapper;
using GameCatalogue.Application.DTOs;
using GameCatalogue.Application.Games.Commands;

namespace GameCatalogue.Application.Mappings
{
    public class DTOCommandMappingProfile : Profile
    {
        public DTOCommandMappingProfile()
        {
            CreateMap<GameDTO, GameCreateCommand>();
            CreateMap<GameDTO, GameUpdateCommand>();
        }
    }
}
