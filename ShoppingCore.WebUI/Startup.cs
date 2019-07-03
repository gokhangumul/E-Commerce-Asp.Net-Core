using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.BusinessLayer.Concrete;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Concrete.EfCore.Context;
using ShoppingCore.DataAccessLayer.Concrete.EfCore.Repository;
using ShoppingCore.EntityLayer.DbModels;

namespace ShoppingCore.WebUI
{
    public class Startup
    {
        public IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
   
            services.AddDbContext<ShopContext>
                (options => options.UseSqlServer
                (configuration.GetConnectionString
                ("DefaultConnection"), b => b.MigrationsAssembly("ShoppingCore.WebUI")));
            //services.AddTransient<IServices<Product>, ProductManager>();
            //  services.AddTransient<IServices<Category>, GenericManager<Category>>();
            //services.AddTransient<IGenericRepository<Category>, GenericRepository<Category>>();
            // services.AddTransient<IGenericRepository<Product>, ProductRepository>();
            services.AddTransient<IServices<Image>, GenericManager<Image>>();
            services.AddTransient<IGenericRepository<Image>, GenericRepository<Image>>();
            services.AddTransient<IProductServices, ProductManager>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryServices, CategoryManager>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            app.UseStaticFiles();
            app.UseMvc(route =>
            {
                route.MapRoute(
                  name: "products",
                  template: "products/{category?}",
                  defaults:new {controller="Home", action="List"}
                  );

                route.MapRoute(
                    name:"default",
                    template:"{controller=Home}/{action=Index}/{id?}"
                    );
            });
            Seed.GetSeed(app);
        }
    }
}
