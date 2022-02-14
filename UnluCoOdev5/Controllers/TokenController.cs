using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCoWeek5.Generator;
using UnluCoWeek5.Models;

namespace UnluCoWeek5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        private readonly TokenGenerator _tokenGenerator;

        public TokenController(TokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }
        [HttpPost]
        public Token Login([FromBody]Member member)
        {
            Token token = new();
            if(member.Email=="test@test"&& member.Phone == "333-333-4444")
            {
                token = _tokenGenerator.CreateToken(member);
            }
            return token;
        }
    }
}
