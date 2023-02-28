![](https://res.cloudinary.com/practicaldev/image/fetch/s--AHI0Pqi0--/c_imagga_scale,f_auto,fl_progressive,h_900,q_auto,w_1600/https://dev-to-uploads.s3.amazonaws.com/i/qt1l5zhbmh6gnyk1qluh.jpg)

| Alejandro Jimenez | UCSD |
|---------------------|------------------------|
|![](https://avatars.githubusercontent.com/u/7384546?v=4)|![](https://pbs.twimg.com/profile_images/901546652091252736/6Clcdv1L_400x400.jpg)|


# Lenguaje de programación  REST API C#


# [UNIDADES DE APRENDIZAJES	CONTENIDOS](#unidad1)
## [UNIDAD I.- Introducción al diseño y desarrollo de API REST](#unidad1)	
### [1.1.	  Descripción General de las API REST y sus casos de uso](#11)
### [1.2.	  Comprensión de los principios del diseño de API REST.](#12)
### [1.3.	  Configuración de un entorno de desarrollo para C# y .NET](#13)
#
## UNIDAD II.- Conceptos Básicos de C#  y .NET
### [2.1	 Tipos de datos y Variables](#21)
### [2.2	  Declaraciones condicionales y bucles](#22)
### [2.3	  Clases y Objetos](#23)
### [2.4	  Manejo básico de Excepciones](#24)
### [2.5	   Ejercicios](#25)
#

## UNIDAD III.- Crear una API REST simple utilizando el marco ASP.NET Core
### 3.2	    Implementación de Operaciones CRUD
### 3.3	    Manejo de solicitudes y respuestas de API
### 3.4	    autenticación y autorización básica
### 3.5	    Ejercicios
#
## UNIDAD IV.- Desarrollo avanzado de API REST
### 4.1	    Diseño e implementación de terminales API
### 4.2	     Usar encabezados y parámetros de consultas
### 4.3	    Manejo de paginación y filtrado
### 4.4	    Versiones de API
### 4.5	    Ejercicios
#
## UNIDAD V.- Pruebas e implementación	
### 5.2	    Pruebas unitarias para REST API
### 5.3	    Pruebas funcionales para REST API
### 5.4	    implementación de una API REST en la nube ejemplos
### 5.5	    Creación de un proyecto REST API completo
#
#


## Introducción a ASP.NET Web API (C#)<a name="unidad1"></a>
#### En este tutorial, usará ASP.NET Web API para crear una API web que devuelva una lista de productos.

#### HTTP no es solo para servir páginas web. HTTP también es una plataforma eficaz para compilar API que exponen servicios y datos. HTTP es simple, flexible y omnipresente. Casi cualquier plataforma que se pueda considerar tiene una biblioteca HTTP, por lo que los servicios HTTP pueden llegar a una amplia gama de clientes, incluidos exploradores, dispositivos móviles y aplicaciones de escritorio tradicionales.

### ASP.NET Web API es un marco para compilar API web sobre .NET Framework.




### 1.1.	  Descripción General de las API REST y sus casos de uso<a name="11"></a>
#
### ¿Qué son las APIs?
#### Las Interfaces de Programacion de Aplicaciones (APIs por sus siglas en inglés) son construcciones disponibles en los lenguajes de programación que permiten a los desarrolladores crear funcionalidades complejas de una manera simple. Estas abstraen el código más complejo para proveer una sintaxis más fácil de usar en su lugar.
#
#### Como ejemplo, piensa en el suministro de electricidad de tu casa, apartamento, o cualquier otro edificio. Si quieres usar un electrodoméstico, simplemente lo conectas en un enchufe y funciona. No intentas conectarlo directamente a la fuente de alimentación — hacerlo sería muy ineficiente y, si no eres electricista, dificil y peligroso.
#
![](https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Client-side_web_APIs/Introduction/plug-socket.png)

#### De la misma manera, si quisieras programar gráficos 3D, sería mucho más facil hacerlo usando una API escrita en un lenguaje de alto nivel como c#, JavaScript o Python, en lugar de intentar escribir código de bajo nivel (por ejemplo: C o C++) que controle directamente la [GPU](https://es.wikipedia.org/wiki/Unidad_de_procesamiento_gr%C3%A1fico) del equipo u otras funciones gráficas.

    Nota: Consulta también la entrada API en el glosario para una descripción más detallada.


#
#
### 1.2.	  Comprensión de los principios del diseño de API REST.<a name="12"></a>
#### Una API (interfaz del programa de aplicación) es un conjunto de reglas que permite que diferentes programas se comuniquen entre sí. Describe la manera apropiada para que un desarrollador de software componga un programa en un servidor que se comunica con varias aplicaciones cliente.
#
#### Las API de diferentes aplicaciones se pueden integrar juntas para intercambiar datos y realizar una función específica, lo que permite la interacción entre aplicaciones. Varios sitios web como Amazon, Google, Facebook, LinkedIn y Twitter utilizan API basadas en REST que permiten a los usuarios comunicarse con estos servicios en la nube.
#
<!-- #### Este blog profundizará en la definición de la API REST y cubrirá todos sus aspectos básicos, incluido el significado de la API REST, sus principios, métodos y más. -->
### ¿Qué es la API REST?
#### En 2000, Roy Fielding definió REST como un estilo arquitectónico y una metodología de uso frecuente en el desarrollo de servicios de Internet, como los sistemas hipermedia distribuidos.
    La forma completa de REST API es la interfaz de programación de aplicaciones de transferencia de estado representacional, más comúnmente conocida como servicio web REST API. Significa que cuando se llama a una API RESTful, el servidor transferir a representación de los recursos solicitados estado al sistema del cliente.

#### Por ejemplo, cuando un desarrollador solicita a la API de Twitter que busque el objeto de un usuario (un recurso), la API devolverá el estado de ese usuario, su nombre, seguidores y publicaciones compartidas en Twitter. Esto es posible gracias a los proyectos de integración de API.

#### Esta representación de estado puede estar en formato JSON, XML o HTML.

#
![](https://cdn-ajfbi.nitrocdn.com/GuYcnotRkcKfJXshTEEKnCZTOtUwxDnm/assets/images/optimized/rev-5a429f7/wp-content/uploads/2020/01/rest-768x580.png)
#

#### Los protocolos típicos de transferencia de datos, como SOAP (Protocolo simple de acceso a objetos), ofrecen una excelente seguridad e integridad de datos capacidades. Además, SOAP ofrece una lógica de reintento integrada para compensar las comunicaciones fallidas. Pero tales protocolos también son difíciles de trabajar. RESTful API es una alternativa más simple que se ha desarrollado exponencialmente en los últimos años. Las personas a menudo se confunden con respecto a los estándares REST. En comparación con SOAP, los servicios web más antiguos, REST es más flexible y fácil de implementar.
#
#### REST generalmente se prefiere sobre el [SOAP](https://es.wikipedia.org/wiki/Simple_Object_Access_Protocol) más robusto ya que el anterior usa menor ancho de banda, haciéndolo más apropiado para los servicios web integrales del mundo. Utiliza el protocolo HTTP para obtener datos o realizar operaciones en varios formatos de datos (como XML y JSON); permite procesos más rápidos.
#
#### En consecuencia, SOAP utiliza la transferencia de datos XML, definiendo operaciones como puertos [WSDL](https://es.wikipedia.org/wiki/WSDL) unidireccionales con varias instancias de proceso que comparten los mismos procedimientos. En REST, las operaciones se describen en los propios mensajes. Además, hay una sola dirección para cada instancia de proceso.
#
#### Otra diferencia entre SOAP y REST radica en cómo se acoplan estos protocolos. SOAP está fuertemente acoplado, mientras que este último está débilmente acoplado. El acoplamiento débil significa que los módulos son independientes y las variaciones en uno no perturban el funcionamiento de los demás. Como resultado, hay flexibilidad y reutilización cuando se agregan, sustituyen o ajustan módulos. Por otro lado, el acoplamiento estrecho significa que los módulos tienden a ser codependientes. Por lo tanto, las variaciones en un módulo pueden tener un efecto en todo el sistema. Todas estas diferencias son las que hacen que la API sea RESTful.
#
#### Varias aplicaciones y proyectos utilizan API REST para transferir datos, y las empresas adoptan cada vez más los servicios web RESTful para disfrutar del crecimiento horizontal.
### ¿Cómo funciona una API REST?

#### REST determina la estructura de un API. Los desarrolladores se obligan a un conjunto específico de reglas al diseñar una API. Por ejemplo, una ley establece que vincular a una URL debe devolver cierta información.

#### Cada URL se conoce como una solicitud, mientras que los datos devueltos se conocen como respuesta.

#### REST API desglosa una transacción para generar una secuencia de pequeños componentes. Cada componente aborda un aspecto fundamental específico de una transacción. Esta modularidad lo convierte en un enfoque de desarrollo flexible.

#### Una API REST aprovecha los métodos HTTP descritos por Protocolo RFC 2616. Utiliza las siguientes solicitudes HTTP:

- Solicitud GET buscar datos
- Solicitud PUT  para alterar el estado de los datos (como un objeto, archivo o bloque)
- Solicitud POST  para crear datos
- Solicitud DELETE Borrar petición para eliminarlo


|Acción	|HTTP method	|URI relativo|
|-------|---------------|------------|
|Obtener un producto según el id.	|GET	|/api/products/id|
|Crear un nuevo producto	        |POST	|/api/products|
|Actualizar un producto	            |PUT	|/api/products/id|
|Eliminar un producto	            |Delete	|/api/products/id

Para obtener información sobre cómo implementar esta API con ASP.NET Web API, consulte Creación de una [API web que admita operaciones CRUD](https://learn.microsoft.com/es-es/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api).
#
## ¿Para qué se utilizan las API RESTful?
#### Para comprender mejor qué es la API RESTful, para qué se utiliza y cómo funciona, consideremos un ejemplo.
#
#### Suponga que desea ver tutoriales en video sobre 'integración de datos' en Youtube. Vaya a YouTube, escriba 'integración de datos' en el campo de búsqueda, presione Intro y aparecerá una lista de videos sobre integración de datos. ¿Derecha?

#### Una API RESTful funciona de manera similar. Buscas algo y te devuelve una lista de resultados del servicio solicitado.

#### En la tecnología REST, se supone que todas las llamadas son apátridas. Esto significa que el servicio REST no puede retener nada entre ejecuciones, lo que lo hace beneficioso en aplicaciones en la nube. Esto se debe a que los constituyentes apátridas se pueden reasignar fácilmente en caso de falla. Además, se pueden escalar fácilmente para considerar variaciones de carga. Eso es porque cualquier solicitud se puede enviar a cualquier instancia de un constituyente.

#### Como no se pueden retener datos que deban ser recuperados por la transacción posterior, REST es el protocolo deseado para la comunicación por Internet. Como se dijo anteriormente, el REST API La tecnología también es útil para conectarse a aplicaciones en la nube, ya que acceder a un servicio a través de una API requiere un ajuste en la interpretación de la URL.


#
### 1.3.	  Configuración de un entorno de desarrollo para C# y .NET<a name="13"></a>

![](https://youtu.be/m_iLmZR8EYs?t=34)
[![Comprehensive Markdown Crash Course](https://miro.medium.com/max/1400/1*9R5BVkgSLM8vb0NyAN_2mQ.png)](https://www.youtube.com/watch?v=N6mTQSIN30A)

#

## UNIDAD II.- Conceptos Básicos de C#  y .NET
### 2.1	 Tipos de datos y Variables
#
## El sistema de tipos de C#<a name="21"></a>
    Artículo 22/09/2022 Tiempo de lectura: 16 minutos

#### C# es un lenguaje fuertemente tipado. Todas las variables y constantes tienen un tipo, al igual que todas las expresiones que se evalúan como un valor. Cada declaración del método especifica un nombre, el tipo y naturaleza (valor, referencia o salida) para cada parámetro de entrada y para el valor devuelto. La biblioteca de clases .NET define tipos numéricos integrados, así como tipos complejos que representan una amplia variedad de construcciones. Entre ellas se incluyen el sistema de archivos, conexiones de red, colecciones y matrices de objetos, y fechas. Los programas de C# típicos usan tipos de la biblioteca de clases, así como tipos definidos por el usuario que modelan los conceptos que son específicos del dominio del problema del programa.
     
#### Entre la información almacenada en un tipo se pueden incluir los siguientes elementos:

- El espacio de almacenamiento que requiere una variable del tipo.
- Los valores máximo y mínimo que puede representar.
- Los miembros (métodos, campos, eventos, etc.) que contiene.
- El tipo base del que hereda.
- Interfaces que implementa.
- Los tipos de operaciones permitidas.
#
#### El compilador usa información de tipo para garantizar que todas las operaciones que se realizan en el código cuentan con seguridad de tipos. Por ejemplo, si declara una variable de tipo int, el compilador le permite usar la variable en operaciones de suma y resta. Si intenta realizar esas mismas operaciones en una variable de tipo bool, el compilador genera un error, como se muestra en el siguiente ejemplo:
#
~~~c#
int a = 5;
int b = a + 2; //OK

bool test = true;

// Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
int c = a + test;
~~~




#
### 2.2	  Declaraciones condicionales y bucles<a name="22"></a>
#### Instrucciones y bucles de C# if:

Ejemplo

~~~c#
int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");
~~~    
# 
### Operaciones conjuntas con if y else

#### Para ejecutar un código distinto en las bifurcaciones true y false, cree una bifurcación else para que se ejecute cuando la condición sea false. Pruebe una rama else. Agregue las dos últimas líneas del código siguiente (ya debe tener los cuatro primeros):

 ~~~c#
 int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");
~~~
#
#### La instrucción que sigue a la palabra clave else se ejecuta solo si la condición de prueba es false. La combinación de if y else con condiciones booleanas ofrece toda la eficacia necesaria para administrar una condición true y false simultáneamente.

     Importante

    La sangría debajo de las instrucciones if y else se utiliza para los lectores humanos. El lenguaje C# no considera significativos los espacios en blanco ni las sangrías. La instrucción que sigue a la palabra clave if o else se ejecutará en función de la condición. Todos los ejemplos de este tutorial siguen una práctica común para aplicar sangría a las líneas en función del flujo de control de las instrucciones.

##### Dado que la sangría no es significativa, debe usar { y } para indicar si desea que más de una instrucción forme parte del bloque que se ejecuta de forma condicional. Los programadores de C# suelen usar esas llaves en todas las cláusulas if y else. El siguiente ejemplo es igual que el que acaba de crear. Modifique el código anterior para que coincida con el código siguiente:
~~~c#
int a = 5;
int b = 3;
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}
~~~

### Uso de bucles para repetir las operaciones

Ejemplo
~~~c#
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
~~~
#### La instrucción while comprueba una condición y ejecuta la instrucción o el bloque de instrucciones que aparece después de while. Comprueba repetidamente la condición, ejecutando esas instrucciones hasta que la condición sea false.

#### En este ejemplo aparece otro operador nuevo. El código ++ que aparece después de la variable **counter** es el operador de incremento. Suma un valor de uno al valor de counter y almacena dicho valor en la variable de counter.
#
## do while
#### El bucle while prueba la condición antes de ejecutar el código que sigue a while. El bucle do ... while primero ejecuta el código y después comprueba la condición. El bucle do while se muestra en el código siguiente:

~~~c#
int counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);
~~~


## Operaciones con el bucle for
#### Operaciones con el bucle for
~~~c#
for (int index = 0; index < 10; index++)
{
    Console.WriteLine($"Hello World! The index is {index}");
}
~~~

#### El código anterior funciona de la misma forma que los bucles while y do que ya ha usado. La instrucción for consta de tres partes que controlan su funcionamiento.

#### La primera parte es el inicializador de for: int index = 0; declara que index es la variable de bucle y establece su valor inicial en 0.

#### La parte central es la condición de for: index < 10 declara que este bucle for debe continuar ejecutándose mientras que el valor del contador sea menor que diez.

#### La última parte es el iterador de for: index++ especifica cómo modificar la variable de bucle después de ejecutar el bloque que sigue a la instrucción for. En este caso, especifica que index debe incrementarse en uno cada vez que el bloque se ejecuta
#




### 2.3	  Clases y Objetos<a name="23"></a>
[Clases y Objetos](https://github.com/ajimenezrosa/IntroduccionProgramacionOO#objetosClases)

### 2.4	  Manejo básico de Excepciones<a name="24"></a>
[Manejo básico de Excepciones](https://github.com/ajimenezrosa/IntroduccionProgramacionOO#EjercicioMetodoExcepciones2)
### 2.5	   Ejercicios<a name="25"></a>

#### Crear un programa de consola que aplique el concepto de clases y maneje exceptiion.


# 

## UNIDAD III.- Crear una API REST simple utilizando el marco ASP.NET Core

#### Para crear una API REST simple utilizando el marco ASP.NET Core, sigue los siguientes pasos:

- Abre Visual Studio y crea un nuevo proyecto de ASP.NET Core API. Puedes hacerlo seleccionando "Nuevo Proyecto" en el menú "Archivo" y luego seleccionando "ASP.NET Core Web Application" en la sección "Web".

- Selecciona "API" como el tipo de proyecto y haz clic en "Crear".

- Una vez que se haya creado el proyecto, abre el archivo "Startup.cs" y agrega el siguiente código en el método "ConfigureServices":
#
~~~C#
services.AddControllers();
~~~

- A continuación, agrega el siguiente código en el método "Configure":
#
~~~C#
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
~~~

- Ahora, crea un controlador para tu API. Puedes hacerlo haciendo clic derecho en la carpeta "Controllers" y seleccionando "Agregar -> Controlador".

- Agrega los métodos GET, POST, PUT y DELETE en el controlador para proporcionar las operaciones CRUD básicas. Por ejemplo, aquí está el código para el método GET:

~~~c#
[HttpGet]
public IEnumerable<string> Get()
{
    return new string[] { "value1", "value2" };
}

~~~
Ejemplos de Creaciones de WebApis segundo parcial

[Creacion de ApiRest Utilizando C#.net Core](https://github.com/ajimenezrosa/LENGUAJE-DE-PROGRAMACION/blob/main/2022/README_2022_3.md)


Creacion de EndPoint para nuestro REST API. 

### El objetivo de este ejercicio es crear un empleo utilizando la entidad clientes en este caso lo que haremos será crear un crud para un web Api específicamente un Api Rest

#
#### Las siguientes clases serán instanciadas durante la ejecución de la práctica esto lo haremos haciendo control punto Al momento de digitar nuestro código en las clases y objetos qué nos presenten error.
     ojo debemos estar seguros de que los mismos están escritos correctamente

~~~c#
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIAutores.Entidades;
~~~
#
#### Como ya hemos conversado para que esto sea un controlador debe de heredar de la clase **controllerbase**.

####  Además para poder utilizar cada uno de los EndPoint de nuestro **WEBAPI** debemos utilizar la etiqueta **[Apicontroller]** a su vez la etiqueta **Rout()** se utiliza para definir las rutas en las cuales serán consumidos nuestros **EndPoint** Al momento de ser terminados

~~~c#
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
~~~

#### Debemos utilizar el application dbcontext para poder tener acceso a nuestras bases de datos que para nuestro caso es una base de datos sql server

# 

## HttpGet
#
#### El método **GET()** nos permite extraer datos de nuestra base de datos en este caso retornar un archivo **json** el cual podrá ser consumido desde cualquier dispositivo que deseemos, Tenemos en este caso  un ejemplo de la extracción de los datos de la tabla clientes

~~~C#
        [HttpGet]
        public async Task<ActionResult<List<Clientes>>> Get()
        {
            return await context.clientes.ToListAsync();

        }
~~~
# 
#### Utilizamos **async await** para crear un método asincrono esto nos permite consultar nuestras bases de datos sin que las mismas se bloqueen Al momento de que otra persona esté accediendo el mismo registro 

    nota no puedes tener una **async** una **await** ni una **await** sin un **async** porque este presentará un problema o un error de código



## HttpPost
#
#### el método post nos permite hacer inserciones en nuestras bases de datos a través de nuestra web Api 

~~~c#
        [HttpPost]
        public async Task<ActionResult> Post(Clientes cliente)
        {
            context.Add(cliente);
            await context.SaveChangesAsync();
            return Ok();

        }
~~~

#### Esto es un ejemplo de un método post simple en el cual podrás hacer inserciones a la tabla de clientes a través del web Api

#

## HttpPut
#
#### El método put realiza actualizaciones a nuestras tablas a través de nuestro webapi.  Cómo podrás ver este tiene un poco más de código que los demás métodos debido a que tiene la necesidad de hacer varias validaciones.
####  Por ejemplo 
 - validar si el ID del cliente es igual al ID enviado por web Api 
 - validar que el registro que se está modificando en realidad existe en nuestra base de datos.
 
 ###  En caso de que el registro exista y sea igual al ID del objeto que se va a modificar procederemos a realizar las modificaciones de lugar en caso contrario retornar a un error

~~~c#
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

~~~

#
## HttpDelete
#

#### Por último en Point http delete el mismo eliminar registros en la base de datos a través de nuestra web Api para el mismo debemos realizar la validación de que el registro exista en caso contrario retornar a un error de existir el registro procederá eliminarlo

~~~C#
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

~~~

#
#### Al finalizar nuestro ejercicio nuestro código se verá de la siguiente manera.

#### Trata de hacerlo paso a paso no copiar código los errores no son el problema Debes tener la capacidad de resolverlos busca investiga , pregunta.

# Recuerda que la perseverancia es la clave para el éxito




