using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalculoDePesoPelaMassa.Models;

namespace CalculoDePesoPelaMassa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversaoMassaController : ControllerBase
    {
        [HttpPost]
        public ConversaoMassa Post(ConversaoMassa item)
        {
            return item;
        }
    }
}