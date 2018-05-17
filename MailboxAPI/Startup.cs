using Microsoft.EntityFrameworkCore;
using MailboxAPI.Models;
using MailboxAPI.Models.DataManager;
using MailboxAPI.Models.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace MailboxAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(opts => opts.UseSqlServer(Configuration["ConnectionStrings:MailboxDB"]));
            services.AddSingleton(typeof(IDataRepository<Factura, long>), typeof(FacturaManager));
            services.AddMvc();
            /*services.AddDbContext<ApplicationContext>(options
             => options.UseSqlServer(Configuration.GetConnectionString("MailboxDB")));*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
