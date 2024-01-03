using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using G01ElectronicVoting.Shared;
using G01ElectronicVoting.Server.Data;

namespace G01ElectronicVoting.Server.Controllers
{
    [Route("api/ElectionMgmt")]
    [ApiController]
    public class ElectionMgmtController : ControllerBase
    {
        [HttpGet("{user}")]
        public Task<List<Election>> Get(string user)
        {
            return FirestoreDataAccess.GetElectionsCreatedBy(user);
        }
    }
}
