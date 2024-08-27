using HGamesAPI.Models;

namespace HGamesAPI.Repositories
{
    public interface IHGames_InformationRepositories
    {
        Task<IEnumerable<HGames_Information>> Get();

        Task<HGames_Information> Get(int Id);

        Task<HGames_Information> Create(HGames_Information hgames_Information);

        Task<IEnumerable<HGames_Information>> CreateRange(IEnumerable<HGames_Information> hgames_InformationList);


        Task<IEnumerable<HGames_Information>> GetByName(string name);

        Task Update(HGames_Information hgames_Information);

        Task Delete(int Id);

    }
}
