using AutoMapper;
using GameCatalogue.Application.DTOs;
using GameCatalogue.Application.Interfaces;
using GameCatalogue.Domain.Entities;
using GameCatalogue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameCatalogue.Application.Services
{
    public class GameService : IGameService
    {
        private IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GameService(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository ??
                throw new ArgumentException(nameof(gameRepository));

            _mapper = mapper;
        }

        public async Task<IEnumerable<GameDTO>> GetGames()
        {
            var gamesEntity = await _gameRepository.GetGamesAsync();
            return _mapper.Map<IEnumerable<GameDTO>>(gamesEntity);
        }

        public async Task<GameDTO> GetById(int? id)
        {
            var gameEntity = await _gameRepository.GetByIdAsync(id);
            return _mapper.Map<GameDTO>(gameEntity);
        }

        public async Task Add(GameDTO gameDto)
        {
            var gameEntity = _mapper.Map<Game>(gameDto);
            await _gameRepository.CreateAsync(gameEntity);
        }

        public async Task Update(GameDTO gameDto)
        {
            var gameEntity = _mapper.Map<Game>(gameDto);
            await _gameRepository.UpdateAsync(gameEntity);
        }

        public async Task Remove(int? id)
        {
            var gameEntity = _gameRepository.GetByIdAsync(id).Result;
            await _gameRepository.RemoveAsync(gameEntity);
        }
    }
}
