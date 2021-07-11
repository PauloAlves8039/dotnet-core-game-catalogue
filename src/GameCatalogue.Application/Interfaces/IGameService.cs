using GameCatalogue.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameCatalogue.Application.Interfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameDTO>> GetGames();

        Task<GameDTO> GetById(int? id);

        Task Add(GameDTO gameDto);

        Task Update(GameDTO gameDto);

        Task Remove(int? id);
    }
}
