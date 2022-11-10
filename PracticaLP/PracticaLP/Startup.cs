<<<<<<< HEAD
﻿namespace PracticaLP
{
    public class Startup
    {

=======
﻿using Microsoft.EntityFrameworkCore;
namespace PracticaLP
{
    public class Startup
    {
>>>>>>> 0e96a2a63769f74875913189862754058c76679e
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

<<<<<<< HEAD
        public void ConfigureServicies(IServiceCollection services )
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
=======
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
>>>>>>> 0e96a2a63769f74875913189862754058c76679e
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

<<<<<<< HEAD
            app.UseRouting();   

            app.UseAuthorization();

=======
            app.UseRouting();


            app.UseAuthorization();

            //app.MapControllers();

>>>>>>> 0e96a2a63769f74875913189862754058c76679e
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

<<<<<<< HEAD

        }



=======
        }

        internal void ConfigureServicces(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
>>>>>>> 0e96a2a63769f74875913189862754058c76679e
    }
}
