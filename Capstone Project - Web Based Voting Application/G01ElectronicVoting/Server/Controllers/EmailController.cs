using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using G01ElectronicVoting.Server.Data;
using G01ElectronicVoting.Shared;
using Newtonsoft.Json;

namespace G01ElectronicVoting.Server.Controllers
{
    [Route("api/Email/{email}/{title}/{creator}")]
    [ApiController]
    public class EmailController: ControllerBase
    {
        EmailAccess emailAccess = new();
        [HttpGet]
        public bool Get(string email, string title, string creator)
        {
            return emailAccess.EmailElectorate(email, title, creator);
        }

        /*[HttpGet("title")]
        public string Get(string title)
        {
           return emailAccess.SetElection(title);
        }*/
    }
}
