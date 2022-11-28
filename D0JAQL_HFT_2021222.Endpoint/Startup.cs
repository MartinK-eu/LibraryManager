using D0JAQL_HFT_2021222.Data;
using D0JAQL_HFT_2021222.Endpoint.Services;
using D0JAQL_HFT_2021222.Logic;
using D0JAQL_HFT_2021222.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Endpoint
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IStudentLogic, StudentLogic>();
            services.AddTransient<IBorrowingLogic, BorrowingLogic>();
            services.AddTransient<IBookLogic, BookLogic>();

            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IBorrowingRepository, BorrowingRepository>();
            services.AddTransient<IBookRepository, BookRepository>();

            services.AddTransient<LibraryDbContext, LibraryDbContext>();

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
            .AllowCredentials()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithOrigins("http://localhost:17241"));

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<SignalRHub>("/hub");
            });
        }
    }
}
