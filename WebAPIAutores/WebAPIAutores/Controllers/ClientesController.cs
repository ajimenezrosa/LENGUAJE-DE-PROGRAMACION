using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIAutores.Entidades;

namespace WebAPIAutores.Controllers
{

    [ApiController]
    [Route("api/clientes")]
    public class ClientesController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Clientes>>> Get()
        {
            return await context.clientes.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult> Post(Clientes cliente)
        {
            context.Add(cliente);
            await context.SaveChangesAsync();
            return Ok();

        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Clientes cliente, int id)
        {
            if(cliente.Id != id)
            {
                return BadRequest("El id del Cliente no coincide con el id ");
            }

            var existe = await context.clientes.AnyAsync(x => x.Id == id);

            if(!existe)
            {
                return NotFound();
            }

            context.Update(cliente);
            await context.SaveChangesAsync();
            return Ok();



        }



        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.clientes.AnyAsync(x => x.Id == id);

            if(!existe)
            {
                return NotFound();
            }
            context.Remove(new Clientes() { Id = id });
            await context.SaveChangesAsync();
            return Ok();

        }



    }
}
