using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using G01ElectronicVoting.Shared;
using G01ElectronicVoting.Server.Data;

namespace G01ElectronicVoting.Server.Controllers
{
    [Route("api/Result")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        [HttpGet("{userId}")]
        public Task<List<Result>> Get(string userId)
        {
            return FirestoreDataAccess.GetResultsForUser(userId);
        }
    }
}
