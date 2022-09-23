using Microsoft.AspNetCore.Mvc;
using PracticaLP.Entidades;

namespace PracticaLP.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Author>> Get()
        {
            return new List<Author>()
            {
                new Author() { Id = 1, nombre = "Alejandro Jimenez"},
                new Author() { Id = 2, nombre = "Jose Miguel Fernandez"}

            };

        }

    }
}
