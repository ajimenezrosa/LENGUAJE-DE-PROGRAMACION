

# Lenguaje de programación  REST API C#


# [UNIDADES DE APRENDIZAJES	CONTENIDOS](#unidad1)
## [UNIDAD I.- Introducción al diseño y desarrollo de API REST](#unidad1)	
### [1.1.	  Descripción General de las API REST y sus casos de uso](#11)
### [1.2.	  Comprensión de los principios del diseño de API REST.](#12)
### [1.3.	  Configuración de un entorno de desarrollo para C# y .NET](#13)
#
## UNIDAD II.- Conceptos Básicos de C#  y .NET
### 2.1	 Tipos de datos y Variables
### 2.2	  Declaraciones condicionales y bucles
### 2.3	  Clases y Objetos
### 2.4	  Manejo básico de Excepciones
### 2.5	   Ejercicios
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
[![Comprehensive Markdown Crash Course](https://miro.medium.com/max/1400/1*9R5BVkgSLM8vb0NyAN_2mQ.png)](https://youtu.be/m_iLmZR8EYs?t=34)

#



