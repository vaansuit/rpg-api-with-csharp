using Microsoft.AspNetCore.Mvc;
using DataRPG.Repository;
using DataRPG.Model;

namespace FakeRPGApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController : ControllerBase
    {
        private WeaponRepository repository;

        public WeaponController()
        {
            repository = new WeaponRepository();
        }


        [HttpGet]

        public List<WeaponModel> Get()
        {/*
            Animal a1 = new Animal{Id = 1, Especie = "Cachurros", Peso = 10.2, Sexo = "Mas"};
            //return "Catchurros, o cachorro com gosto de churros";
            return a1;
            */

            //AnimalRepository animalRepository = new AnimalRepository();
            return repository.GetAll();

        }

        [HttpPost]
        public string Post(WeaponModel model)
        {
            //AnimalRepository repo = new AnimalRepository();
            // Animal a1 = new Animal { Id = 1, Especie = "Elefante", Peso = 10.2, Sexo = "Masc" };
            return repository.Create(model);
        }
    }
}
