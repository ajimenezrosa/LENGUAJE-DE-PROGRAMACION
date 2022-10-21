# LENGUAJE-DE-PROGRAMACION" 




[ - Configurar la Clase startup](#startup)




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



## Configurar la Clase startup <a name="startup"></a>

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

 
#

## Vamos a instalar Entity Framework Core en nuestra aplicación.
#### Con Entity Framework core podemos crear una base de datos a partir de código C#

#### No solo eso a través de este podemos conectarnos a bases de datos existentes.
#### También podemos usar el DBcontext, que es donde podemos configurar el entityframework Core.
#### También podemos configurar la cadena de conexión, que es lo que dice a que base de datos nos estamos conectando, además de esto nos permito colocar  validación para nuestras tablas entre otras cosas.



    Instalando en el proyecto...

       Microsoft.EntityFrameworkCore.SqlServer
       Microsoft.EntityFrameworkCore.tool

<!-- ###### Esto solo las personas que estan utilizando Visual Studio. Si estas utilizando Visual Studio Code no debes intalar este paquete.
     
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
      -->


#### Procederemos a usarlo, Lo primero que debemos hacer es crear una Clase.  Yo Creare la Clase ApplicationDbContext.cs



~~~c#
using Microsoft.EntityFrameworkCore;

namespace PracticaLP
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

~~~

Esta seria nuestra clase ApplicationDbContext
con ella podemos hacer las diferentes configuraciones de nuestro DBContext.  pero ademas podemos colocar las tablas que se crearan en nuestra base de datos.
#


## Como ejemplo crearemos una tabla a partir del esquema Maestro
~~~C#
        public DbSet<Maestro> Maestros { get; set; }
~~~        


#### Lo que le digo al sistema en este caso es que se creará una tabla a partir de la Clase Maestro  con sus valores.
#

##### En este punto del programa, nuestra clase ApplicationDbContext se vería así
~~~C#
using Microsoft.EntityFrameworkCore;
using PracticaLP.Entidades;

namespace PracticaLP
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Maestro> Maestros { get; set; }
    }
}

~~~

esto quiere decir que se creara una tabla con los valores que tenemos en nuestra clase de Maestro. Clara que para esto primero debemos configurar nuestra conexion a base de datos y esto lo haremos en **appsettings.json**

~~~json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "defaultConnection": "Data Souce=(localdb)\\mssqllocaldb;Initial Catalog=WebApis;Integrated Security=True"
  },
  "AllowedHosts": "*"
}

~~~

Explicaremos un poco lo que hicimos:

El **Data Source** Serial el nombre del servidor de Base de Datos
El **Initial Catalog** Seria el nombre de la base de datos que utilizarmos
el **Integrated Security** se refiere a que utilizarmos la claves del sistema operativo Windows para autenticarnos en la DB.

Nota: Tambien podemos colocar en este caso un usuario y password si lo deseamos.

#
## Ahora volvemos a la clase Startup al método configure services en el cual configuraremos nuestra conexión a la base de datos, que en nuestro caso es sql server


~~~c#
using Microsoft.EntityFrameworkCore;
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

            service.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));

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


## Migracion de Base de datos:
#### Luego de configurar nuestro conxion String y de tener nuestras clases configuradas. 
#
#### A este punto debe ser posible para nosotros hacer una migracion a nuestras bases de datos.

    Add-Migration Inicial

#### Si digitamos este codigo en el **Package Manager Console** realizaremos una migracion de nuestros modelos a nuestras bases de datos.

# 