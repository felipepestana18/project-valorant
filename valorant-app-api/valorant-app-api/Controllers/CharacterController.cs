using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Nodes;
using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model;
using valorant_app_api.Repository;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace valorant_app_api.Controllers
{
    [ApiController]
    [Route("api/v1/agent")]
    public class CharacterController : Controller
    {
        readonly ICharacterRepository _characterRepository;

        public CharacterController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<MapVO>> Get(int id)
        {
            var map = await _characterRepository.Get(id);
            if (map == null) return NotFound();
            return Ok(map);
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<MapVO>> GetAll()
        {
            var task = await _characterRepository.GetAll();
            if (task == null) return NotFound();
            return Ok(task);
        }


        [HttpPost("create")]
        public async Task<ActionResult<MapVO>> Create(CharacterVO vo)
        {
            var task = await _characterRepository.Create(vo);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpPut("update")]
        public async Task<ActionResult<MapVO>> Update(CharacterVO vo)
        {
            var task = await _characterRepository.Update(vo);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var status = await _characterRepository.Delete(id);
            if (!status) BadRequest();
            return Ok(status);
        }

        [HttpGet("get-agent")]
        public async Task<ActionResult<JsonObject>> GetAgent()
        {
            var agents = await _characterRepository.GetAgent();
            if (agents == null) BadRequest();
            return Ok(agents);
        }

        [HttpGet("get-agent/{uid}")]
        public async Task<ActionResult<JsonObject>> GetAgentByUid(string uid)
        {
            var agent = await _characterRepository.GetAgentByUid(uid);
            if (agent == null) BadRequest();
            return Ok(agent);
        }
    }
}
