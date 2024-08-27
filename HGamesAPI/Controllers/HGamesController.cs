using HGamesAPI.Models;
using HGamesAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HGamesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

    public class HGamesController : Controller
    {

        private readonly IHGames_InformationRepositories _hgames;

        public HGamesController(IHGames_InformationRepositories hGames_InformationRepositories)
        {
            _hgames = hGames_InformationRepositories;
        }

        [HttpGet]
        public async Task<IEnumerable<HGames_Information>> GetGames()
        {
            return await _hgames.Get();
        }


        [HttpGet("{id}")]
        
        public async Task<ActionResult<HGames_Information>> GetGames(int id)
        {
            return await _hgames.Get(id);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<HGames_Information>>> FindGamesByName(string name)
        {
            var games = await _hgames.GetByName(name);
            if (games == null || !games.Any())
            {
                return NotFound();
            }
            return Ok(games);
        }


        [HttpPost]
        public async Task<ActionResult<IEnumerable<HGames_Information>>> PostGames([FromBody] IEnumerable<HGames_Information> hGamesList)
        {
            var newGames = new List<HGames_Information>();

            foreach (var hGames_Information in hGamesList)
            {
                var newGame = await _hgames.Create(hGames_Information);
                newGames.Add(newGame);
            }

            return CreatedAtAction(nameof(PostGames), new { count = newGames.Count }, newGames);
        }

    }
}
