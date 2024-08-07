using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model.Context;
using valorant_app_api.Model;
using System.Threading.Tasks;
using Microsoft.Extensions.FileSystemGlobbing;
using Match = valorant_app_api.Model.Match;

namespace valorant_app_api.Repository
{
    public class MatchRepository : IMatchRepository
    {

        private readonly SQLContext _context;
        private IMapper _mapper;

        private readonly ICharacterRepository _characterrepository;
        private readonly IMapRepository _maprepository;


        public MatchRepository(SQLContext context, IMapper mapper, ICharacterRepository characterRepository, IMapRepository mapRepository)
        {
            _context = context;
            _mapper = mapper;
            _characterrepository = characterRepository;
            _maprepository = mapRepository;

        }

        public async Task<Match> Get(int id)
        {

            Match match = new Match();
            Map map = new Map();
            match = await _context.Matches.FirstOrDefaultAsync(x => x.Id == id);

            if (match != null)
            {
                match.Characters = await _context.Characters.AsTracking().FirstOrDefaultAsync(x => x.Id == match.CharactersId);
                match.Map = await _context.Maps.AsTracking().FirstOrDefaultAsync(x => x.Id == match.MapId);    
            }

            return match;
        }

        public async Task<IEnumerable<Match>> GetAll(string uuid)
        {

            var matches = await _context.Matches.Where(x => x.Map.uuid == uuid).ToListAsync();

            foreach (Match match in matches)
            {
                match.Characters = await _context.Characters.FirstOrDefaultAsync(x => x.Id == match.CharactersId);
            }

            return _mapper.Map<List<Match>>(matches);
        }


        public async Task<MatchVO> Create(MatchVO vo)
        {

            Model.Match match = _mapper.Map<Model.Match>(vo);

            match.DateMatch = DateTime.Now;
            _context.Add(match);
            await _context.SaveChangesAsync();


            return _mapper.Map<MatchVO>(vo);

        }

        public async Task<MatchVO> Update(MatchVO vo)
        {
            var map = _mapper.Map<Model.Match>(vo);
            _context.Update(map);
            await _context.SaveChangesAsync();
            return _mapper.Map<MatchVO>(map);
        }

        public async Task<bool> Delete(int id)
        {
            var map = await _context.Maps.FirstOrDefaultAsync(t => t.Id == id);
            if (map == null) return false;
            _context.Remove(map);
            await _context.SaveChangesAsync();
            return true;
        }


    }
}
