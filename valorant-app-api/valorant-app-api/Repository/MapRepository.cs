using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model;
using valorant_app_api.Model.Context;
using JsonSerializer = System.Text.Json.JsonSerializer;

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

        public async Task<MapsApi> GetMapsApi()
        {
            HttpClient httpClient = new HttpClient();
            using HttpResponseMessage response = await httpClient.GetAsync("https://valorant-api.com/v1/maps");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var maps = JsonSerializer.Deserialize<MapsApi>(responseBody);
            return maps;
        }

        public async Task<InformationMap> GetMapApiByUid(string uid)
        {
            HttpClient httpClient = new HttpClient();
            using HttpResponseMessage response = await httpClient.GetAsync($"https://valorant-api.com/v1/maps/{uid}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var map = JsonSerializer.Deserialize<InformationMap>(responseBody);
            return map;
        }

 
    }
}
