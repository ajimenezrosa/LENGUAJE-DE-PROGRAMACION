using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaLP.Entidades;

namespace PracticaLP.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AutoresController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Author>>> Get()
        {
            return await context.Authores.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Author autor)
        {
            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();


        }

    }
}
