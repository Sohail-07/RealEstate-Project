using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebAPI.Data;
using WebAPI.Extentions;
using WebAPI.Helpers;
using WebAPI.Interfaces;
using WebAPI.Middlewares;

namespace WebAPI
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
            services.AddDbContext<DataContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddControllers().AddNewtonsoftJson();
            services.AddCors();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            var secretKey = Configuration.GetSection("AppSettings:Key").Value;
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(secretKey));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).
                AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        IssuerSigningKey = key
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.ConfigureExceptionHandler(env);
            //app.ConfigureBuiltinExceptionHandler;
            app.UseRouting();

            app.UseCors(m => m.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
