<<<<<<< HEAD
=======

>>>>>>> 0e96a2a63769f74875913189862754058c76679e
using PracticaLP;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var startup = new Startup(builder.Configuration);
<<<<<<< HEAD
=======

startup.ConfigureServices(builder.Services);
>>>>>>> 0e96a2a63769f74875913189862754058c76679e

startup.ConfigureServicies(builder.Services);
    
var app = builder.Build();

<<<<<<< HEAD
=======
// Configure the HTTP request pipeline.

>>>>>>> 0e96a2a63769f74875913189862754058c76679e
startup.Configure(app, app.Environment);

app.Run();
