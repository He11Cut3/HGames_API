using HGamesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HGamesAPI.Repositories
{
    public class HGames_InformationRepository : IHGames_InformationRepositories
    {
        private readonly HGames_Context _context; 


        public HGames_InformationRepository(HGames_Context context)
        {
            _context = context;
        }

        public async Task<HGames_Information> Create(HGames_Information hgames_Information)
        {
            _context.HGames_Information.Add(hgames_Information);
            await _context.SaveChangesAsync();

            return hgames_Information;
        }

        public async Task<IEnumerable<HGames_Information>> GetByName(string name)
        {
            return await _context.HGames_Information
                                 .Where(g => g.Name.Contains(name))
                                 .ToListAsync();
        }



        public async Task<IEnumerable<HGames_Information>> CreateRange(IEnumerable<HGames_Information> hgames_InformationList)
        {
            _context.HGames_Information.AddRange(hgames_InformationList);
            await _context.SaveChangesAsync();

            return hgames_InformationList;
        }



        public async Task Delete(int Id)
        {
            var HGames_Delete = await _context.HGames_Information.FindAsync(Id);
            _context.HGames_Information.Remove(HGames_Delete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<HGames_Information>> Get()
        {
            return await _context.HGames_Information.ToListAsync();
        }

        public async Task<HGames_Information> Get(int Id)
        {
            return await _context.HGames_Information.FindAsync(Id);
        }

        public async Task Update(HGames_Information hgames_Information)
        {
            _context.Entry(hgames_Information).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
