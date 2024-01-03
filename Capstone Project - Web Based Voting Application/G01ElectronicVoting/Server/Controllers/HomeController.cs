using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using G01ElectronicVoting.Shared;
using G01ElectronicVoting.Server.Data;

namespace G01ElectronicVoting.Server.Controllers
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("{user}")]
        public Task<bool> UserMustVote(string user)
        {
            return FirestoreDataAccess.UserMustVote(user);
        }
    }
}
