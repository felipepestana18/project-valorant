using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model;
using valorant_app_api.Repository;

namespace valorant_app_api.Controllers
{

    [ApiController]
    [Route("api/v1/map")]
    public class MapController : Controller
    {
        readonly IMapRepository _mapRepository;

        public MapController(IMapRepository mapRepository)
        {
            _mapRepository = mapRepository;
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<MapVO>> Get(int id)
        {
            var map = await _mapRepository.Get(id);
            if (map == null) return NotFound();
            return Ok(map);
        }

        [HttpGet("find-all")]
        public async Task<ActionResult<MapVO>> GetAll()
        {
            var task = await _mapRepository.GetAll();
            if (task == null) return NotFound();
            return Ok(task);
        }


        [HttpPost("create")]
        public async Task<ActionResult<MapVO>> Create(MapVO vo)
        {
            var task = await _mapRepository.Create(vo);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpPut("update")]
        public async Task<ActionResult<MapVO>> Update(MapVO vo)
        {
            var task = await _mapRepository.Update(vo);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var status = await _mapRepository.Delete(id);
            if (!status) BadRequest();
            return Ok(status);
        }

        [HttpGet("get-maps-api")]
        public async Task<ActionResult<MapsApi>> GetMapApi()
        {
            var agents = await _mapRepository.GetMapsApi();
            if (agents == null) BadRequest();
            return Ok(agents);
        }

        [HttpGet("get-maps-api/{uid}")]
        public async Task<ActionResult<MapsApi>> GetMapApiByUid(string uid)
        {
            var agent = await _mapRepository.GetMapApiByUid(uid);
            if (agent == null) BadRequest();
            return Ok(agent);
        }

    }

}
