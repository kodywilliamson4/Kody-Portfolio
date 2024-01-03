using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using G01ElectronicVoting.Shared;
using G01ElectronicVoting.Server.Data;

namespace G01ElectronicVoting.Server.Controllers
{
    [Route("api/Election")]
    [ApiController]
    public class ElectionController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] Election e)
        {
            FirestoreDataAccess.CreateElection(e);
        }

        [HttpGet]
        public Task<List<Election>> Get()
        {
            return FirestoreDataAccess.GetAllElections();
        }

        [HttpGet("{id}")]
        public Task<Election> Get(string id)
        {
            return FirestoreDataAccess.GetElectionFromId(id);
        }

        [HttpPut]
        public void Put([FromBody] Election e)
        {
            FirestoreDataAccess.UpdateElection(e);
        }

        [HttpDelete("{electionId}")]
        public void Delete(string electionId)
        {
            FirestoreDataAccess.DeleteElection(electionId);
        }
    }
}
