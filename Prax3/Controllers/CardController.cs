using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Prax3.Model;

namespace Prax3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        // GET: CardController 
        [HttpGet]
        public Card GetCard([FromQuery] int cardNumber, int API_TOKEN)
        {
            if (cardNumber == 1234 && API_TOKEN == 12345)
            {
                return new Card("VALID", "VISA");
            }
            else
            {
                return new Card("INVALID", "NONE");
            }

        }
    }
}
