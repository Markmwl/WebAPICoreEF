using System.Configuration;
using System.Diagnostics;

namespace WebAPICore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.WebHost.UseUrls(new[] { "http://localhost:8022", "https://localhost:8023" });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //添加跨域策略
            builder.Services.AddCors(options =>
            {
                options.AddPolicy
                (name: "myCors",
                builde =>
                {
                    builde.WithOrigins("*", "*", "*")
                          .AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                }
                );
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();

                Dal.Common.Common.IsDevelopment = true;
            }
            else
            {
                Dal.Common.Common.IsDevelopment = false;
            }

            app.UseSwagger();
            app.UseSwaggerUI();



            app.UseHttpsRedirection();

            //使用跨域策略
            app.UseCors("myCors");

            app.UseAuthorization();


            app.MapControllers();



            app.Run();
        }
    }
}