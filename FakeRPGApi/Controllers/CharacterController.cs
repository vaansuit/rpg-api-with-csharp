using Microsoft.AspNetCore.Mvc;
using DataRPG.Model;
using DataRPG.Repository;

namespace FakeRPGApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private CharacterRepository repo;

        public CharacterController()
        {
            this.repo = new CharacterRepository();
        }

        [HttpGet]
        public List<Character> Get()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public string Post(Character model)
        {
            return repo.Create(model);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }

        [HttpPut]
        public string Update(Character model)
        {
            return repo.Update(model);
        }
    }
}
