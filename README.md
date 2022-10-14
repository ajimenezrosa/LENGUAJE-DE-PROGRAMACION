# LENGUAJE-DE-PROGRAMACION" 

### Creamos la Clase MaestroController
#### simpre los controladores se crean con el nombre del controlador seguido de la palabra controller todo pegado


debase heredar de la clase **controllerBase** para que el mismo sea un controlador
~~~C#
    public class AutoresController: ControllerBase
    {
    }
~~~    

#### Luego de esto debemos importar una clase

#### en el area de import colocamos lo siguiente
    using Microsoft.AspNetCore.Mvc;


Ademas colocamos lo siguiente en nuestra casa para poder usar las funcionalidades de los controladores.

    [ApiController]

Después de esto, nuestra clase debería verse así.
~~~c#
using Microsoft.AspNetCore.Mvc;

namespace PracticaLP.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
    }
}

~~~

## [Route("api/autores")]
#### Con este código definimos nuestra Ruta.
#### El mismo que me permite hacer? que si hacemos un Get request a nuestra api/authors nos devuelva una lista de autores.

#
#### Luego debemos crear nuestra clase de autores que sería nuestra representación de los autores.

#### Esta clase estará en una carpeta de Entidades que creamos anteriormente

##### El mismo deber se ve así

~~~c#
namespace PracticaLP.Entidades
{
    public class Author
    {
        public int  id { get; set; }
        public string nombre { get; set; }
    }
}
~~~

## Completando el codigo de nuestra classe Authores controller.

#### Agregaremos código a nuestra clase y se verá así
~~~c#
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

~~~
####   recuerda que este código se agrega en este repositorio para que te sea más fácil crear el programa.
####   Analízalo míralo detenidamente y recuerda:
####   ***La clave del éxito es la constancia***



## Configurar la Clase startup

#### Net.core 6 no crea la clase de inicio para nosotros, procederemos a crearla nosotros mismos.
   #### Cabe señalar que el programa funciona correctamente sin esto, pero por un tema de organización voy a crear esta clase y mover los códigos de nuestra clase de programas

~~~C#
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

~~~

## Crearemos la clase de inicio

#### Al final de la misma debe ser como sigue.
~~~C#
namespace PracticaLP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            service.AddEndpointsApiExplorer();
            service.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();


            app.UseAuthorization();

            //app.MapControllers();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }

        internal void ConfigureServicces(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}

~~~

y nuestra Clase de programs debe quedar asi.
~~~C#

using PracticaLP;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.

startup.Configure(app, app.Environment);

app.Run();

~~~