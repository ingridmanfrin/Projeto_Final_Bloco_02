using Microsoft.EntityFrameworkCore;
using projeto_final_bloco_02.Data;
using System;

namespace projeto_final_bloco_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //Conexão com o Banco de Dados 
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            //conecção que estou utilizando 
            builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(connectionString)
            );

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configuração do CORS
            builder.Services.AddCors(options => {
                options.AddPolicy(name: "MyPolicy",
                    policy =>
                    {
                        policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //Inicializa o CORS
            app.UseCors("MyPolicy");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}