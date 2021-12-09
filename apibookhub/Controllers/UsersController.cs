using apibookhub.Models;
using apibookhub.viewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apibookhub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IMapper _mapper;
        public readonly Dbookhub _context;
        public UsersController(Dbookhub context)
        {
            _context = context;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            try
            {
                var lista_users = await _context.Users.ToListAsync();
                return Ok(lista_users);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Add(UserVM Vm)
        {
            User user = _mapper.Map<User>(Vm);
            return Ok();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
