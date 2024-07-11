using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model.Context;

namespace valorant_app_api.Repository
{
    public class MapRepository : IMapRepository
    {

        private readonly SQLContext _context;
        private IMapper _mapper;


        public MapRepository(SQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<IEnumerable<MapVO>> GetAll()
        {
            var map = await _context.Maps.ToListAsync();
            return _mapper.Map<List<MapVO>>(map);
        }

        public async Task<IEnumerable<MapVO>> Get(int id)
        {
            var task = await _context.Maps.Where(x => x.Id == id).ToListAsync();
            return _mapper.Map<List<MapVO>>(task);
        }

        public async Task<MapVO> Create(MapVO vo)
        {
            var map = _mapper.Map<Model.Map>(vo);
            _context.Maps.Add(map);
            await _context.SaveChangesAsync();
            return _mapper.Map<MapVO>(map);
        }

        public async Task<MapVO> Update(MapVO vo)
        {
            var map = _mapper.Map<Model.Map>(vo);
            _context.Update(map);
            await _context.SaveChangesAsync();
            return _mapper.Map<MapVO>(map);
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
