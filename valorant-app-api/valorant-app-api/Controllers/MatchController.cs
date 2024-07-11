﻿using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model;
using valorant_app_api.Repository;
using Match = valorant_app_api.Model.Match;

namespace valorant_app_api.Controllers
{

    [Route("api/v1/match")]
    public class MatchController : Controller
    {

        readonly IMatchRepository _matchRepository;

        public MatchController(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<MatchVO>> Get(int id)
        {
            var match = await _matchRepository.Get(id);
            if (match == null) return NotFound();
            return Ok(match);
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<MatchVO>> GetAll()
        {
            var match = await _matchRepository.GetAll();
            if (match == null) return NotFound();
            return Ok(match);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Match>> Create(MatchVO vo)
        {
            var match = await _matchRepository.Create(vo);
            if (match == null) return NotFound();
            return Ok(match);
        }

        [HttpPut("update")]
        public async Task<ActionResult<MatchVO>> Update(MatchVO vo)
        {
            var match = await _matchRepository.Update(vo);
            if (match == null) return NotFound();
            return Ok(match);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var status = await _matchRepository.Delete(id);
            if (!status) BadRequest();
            return Ok(status);
        }

    }

}
