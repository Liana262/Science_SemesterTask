using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Science_WebSite.Services;
using Science_WebSite.Models;
using Microsoft.AspNetCore.Http;
using Science_WebSite.Pages.Sessions;


namespace Science_WebSite
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
            services.AddDistributedMemoryCache();
            //services.AddSession(options => 
            //{
            //    options.Cookie.Name = ".CosmosPro.Session";
            //    options.Cookie.IsEssential = true;
            //    options.IdleTimeout = TimeSpan.FromSeconds(300);//5 min
            //});
            services.AddSingleton<IArticleRepository, ArticleRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.Use(async (context, next) =>
            //{
            //    context.Items["text"] = "Text from HttpContext.Items";
            //    await next.Invoke();
            //});

            //app.Run(async (context) =>
            //{
            //    context.Response.ContentType = "text/html; charset=utf-8";
            //    await context.Response.WriteAsync($"“екст: {context.Items["text"]}");

            //});

            //app.UseSession();   // добавл€ем механизм работы с сесси€ми
            //app.Run(async (context) =>
            //{

            //    if (context.Session.Keys.Contains("user"))
            //    {
            //        User user = context.Session.Get<User>("user");
            //        await context.Response.WriteAsync($"Hello {user.Name}, your last name: {user.LastName}!");
            //    }
            //    else
            //    {
            //        User user = new User { ID = 1, Name = "Tom", LastName = "myLastName", Email="TomLast@gmail.com", Login="tomyam", Password="postgreSQL" };
            //        context.Session.Set<User>("user", user);
            //        await context.Response.WriteAsync("see you, space-cowboy!");
            //    }
            //    //context.Response.Cookies.Append("name", "Tom");
            //    //if (context.Request.Cookies.ContainsKey("name"))
            //    //{
            //    //    string name = context.Request.Cookies["name"];
            //    //    await context.Response.WriteAsync($"Hello {name}!");
            //    //}
            //    //else
            //    //{
            //    //    await context.Response.WriteAsync("Hello World!");
            //    //}
                
            //});


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
