using Delivery.Data;
using Microsoft.EntityFrameworkCore;
namespace DeliveryAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<Delivery_Context>(options =>
                //options.UseNpgsql(builder.Configuration.GetConnectionString("MiApiUTN_001Context") ?? throw new InvalidOperationException("Connection string 'MiApiUTN_001Context' not found.")));
                // options.UseMySql(
                //builder.Configuration.GetConnectionString("MariaDB"),
                //new MySqlServerVersion(new Version(12, 2, 2))
                //)
                // builder.Services.AddDbContext<MiApiUTN_001Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"))
                //)

                );

            // Add services to the container.

            builder.Services.AddControllers()
                .AddNewtonsoftJson(Options =>
                Options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
