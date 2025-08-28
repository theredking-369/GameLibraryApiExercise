using GameLibraryApi.Interfaces;
using GameLibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameStuffController : ControllerBase
    {
        private IGameService _gameService;

        public GameStuffController(IGameService gameService)
        {
            _gameService = gameService;
        }

        // GET: api/<GameStuffController>
        [HttpGet]
        public IEnumerable<GameInformation> GetAllGames()
        {
            return _gameService.GetAllGames();
        }

        // GET api/<GameStuffController>/5
        [HttpGet("{id}")]
        public GameInformation Get(int id)
        {
            return _gameService.GetGame(id);
        }

        // POST api/<GameStuffController>
        [HttpPost]
        public void Post([FromBody] GameInformation gameInformation)
        {
            _gameService.CreateGame(gameInformation);
        }

        // PUT api/<GameStuffController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GameInformation gameInformation)
        {
            _gameService.EditGame(gameInformation);
        }

        // DELETE api/<GameStuffController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _gameService.DeleteGame(id);
        }
    }
}
