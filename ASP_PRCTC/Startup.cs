using ASP_Practice.Data.Interfaces;
using ASP_Practice.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PRCTC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //������� ��� ����������� ��������
        public void ConfigureServices(IServiceCollection services)
        {
            // ����������� ��������� �������������� ������� MVC (NuGet)
            //options => options.EnableEndpointRouting = false ��� ������ ������� app.UseMvcWithDefaultRoute();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            
            services.AddTransient<IAllCars, MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //����������� �������� � ��������
            app.UseDeveloperExceptionPage();
            //����������� ���� �������
            app.UseStatusCodePages();
            //����������� ����� (css,�������� � �.�.)
            app.UseStaticFiles();
            //������������� Url-������, ������� �������� ���������� �� ���������
            app.UseMvcWithDefaultRoute();

            // ���� ���������� � ����������, ��������� ������
            //if (env.IsDevelopment())
            //{
            //    app.usedeveloperexceptionpage();
            //    app.run(async (context) =>
            //    {
            //        await context.response.writeasync("hello world!123");
            //    });
            //}


        }
    }
}
