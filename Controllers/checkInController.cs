using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class checkInController : ControllerBase
    {
    


        private readonly ILogger<string> _logger;

        public checkInController(ILogger<string> logger)
        {
            _logger = logger;
        }

        [HttpGet]
         public string Get()
        {
          
            return ("check in");

            
           
        }
    }
}

//Server=tcp:erazevertracksqld1.database.windows.net,1433;Authentication=Active Directory Integrated;Database=EverTrack;