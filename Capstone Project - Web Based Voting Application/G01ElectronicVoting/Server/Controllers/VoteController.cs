using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using G01ElectronicVoting.Shared;
using G01ElectronicVoting.Server.Data;

namespace G01ElectronicVoting.Server.Controllers
{
    [Route("api/Vote")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] Vote v)
        {
            FirestoreDataAccess.SubmitVote(v);
        }

        [HttpGet("{user}")]
        public Task<List<Vote>> Get(string user)
        {
            return FirestoreDataAccess.GetUserVotes(user);
        }
    }
}
