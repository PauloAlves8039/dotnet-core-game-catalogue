using GameCatalogue.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameCatalogue.Application.Interfaces
{
    public interface IPlatformService
    {
        Task<IEnumerable<PlatformDTO>> GetPlatforms();

        Task<PlatformDTO> GetById(int? id);

        Task Add(PlatformDTO platformDto);

        Task Update(PlatformDTO platformDto);

        Task Remove(int? id);
    }
}
