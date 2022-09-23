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
