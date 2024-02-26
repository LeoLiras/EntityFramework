using eCommerce.API.Repositories;
using eCommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepos _repos;

        public UsersController(IUserRepos repos)
        {
            _repos = repos;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var userList = _repos.Get();
            return Ok(userList);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _repos.Get(id);

            if(user == null)
            {
                return NotFound("Não encontrado.");
            }
            else
            {
                return Ok(user);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody]User user)
        {
            _repos.Add(user);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody]User user, int id)
        {
            _repos.Update(user);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repos.Delete(id);
            return Ok();
        }
    }
}
