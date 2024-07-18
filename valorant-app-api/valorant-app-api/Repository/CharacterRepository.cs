using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model.Context;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace valorant_app_api.Repository
{
    public class CharacterRepository : ICharacterRepository
    {

        private readonly SQLContext _context;
        private IMapper _mapper;

        public CharacterRepository(SQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<IEnumerable<CharacterVO>> Get(int id)
        {
            var character = await _context.Characters.Where(x => x.Id == id).ToListAsync();
            return _mapper.Map<List<CharacterVO>>(character);
        }

        public async Task<IEnumerable<CharacterVO>> GetAll()
        {
            var character = await _context.Characters.ToListAsync();
            return _mapper.Map<List<CharacterVO>>(character);
        }

        public async Task<CharacterVO> Create(CharacterVO vo)
        {
            var character = _mapper.Map<Model.Character>(vo);
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();
            return _mapper.Map<CharacterVO>(character);
        }

        public async Task<CharacterVO> Update(CharacterVO vo)
        {
            var character = _mapper.Map<Model.Character>(vo);
            _context.Update(character);
            await _context.SaveChangesAsync();
            return _mapper.Map<CharacterVO>(character);
        }

        public async Task<bool> Delete(int id)
        {
            var map = await _context.Characters.FirstOrDefaultAsync(t => t.Id == id);
            if (map == null) return false;
            _context.Remove(map);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Rootobject> GetAgent()
        {
            HttpClient httpClient = new HttpClient();
            using HttpResponseMessage response = await httpClient.GetAsync("https://valorant-api.com/v1/agents");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var agents = JsonSerializer.Deserialize<Rootobject>(responseBody);
            return agents;
        }

        public async Task<Rootobject> GetAgentByUid(string uid)
        {
            HttpClient httpClient = new HttpClient();
            using HttpResponseMessage response = await httpClient.GetAsync($"https://valorant-api.com/v1/agents/{uid}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var agent = JsonSerializer.Deserialize<Rootobject>(responseBody);
            return agent;
        }
    }
}
