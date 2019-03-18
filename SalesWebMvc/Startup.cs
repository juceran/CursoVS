using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc.Context;
using SalesWebMvc.ContextFluentAPI;
using SalesWebMvc.Services;
using System;

namespace SalesWebMvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSession();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //autenticação

            //Context de acesso ao Banco de Dados
            services.AddDbContext<ComumContext>(options => options.UseNpgsql("Host=localhost;Database=Comum;Username=WODINPASS;Password=(*5523bASS%$12_."));
            services.AddDbContext<NovoContext>(options => options.UseNpgsql("Host=localhost;Database=Novo;Username=WODINPASS;Password=(*5523bASS%$12_."));
            services.AddDbContext<SalesWebMvcContext>(options => options.UseNpgsql("Host=localhost;Database=SalesWebMvc;Username=WODINPASS;Password=(*5523bASS%$12_."));

            //injeçao de dependência para personalizar a criação do campos no banco de dados, FluentAPI - Contexts
            services.AddScoped<EmpresaConfiguration>();
            services.AddScoped<DepartamentoConfiguration>();
            services.AddScoped<FormaPagamentoConfiguration>();
            services.AddScoped<PrazoPagamentoConfiguration>();

            services.AddScoped<PessoaConfiguration>();
            services.AddScoped<PessoaClienteConfiguration>();
            services.AddScoped<PessoaEmailConfiguration>();
            services.AddScoped<PessoaEnderecoConfiguration>();
            services.AddScoped<PessoaFisicaConfiguration>();
            services.AddScoped<PessoaFornecedorConfiguration>();
            services.AddScoped<PessoaJuridicaConfiguration>();
            services.AddScoped<PessoaUsuarioConfiguration>();
            services.AddScoped<PessoaUsuarioSenhaConfiguration>();
            services.AddScoped<PessoaTelefoneConfiguration>();

            //serviços dos repositorios
            services.AddScoped<DepartamentoService>();
            services.AddScoped<MenuService>();
            services.AddScoped<SubMenuService>();
            services.AddScoped<LoginService>();
            services.AddScoped<PessoaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //var builder = new ConfigurationBuilder()
            //                    .SetBasePath(env.ContentRootPath)
            //                    .AddJsonFile("appsettings.json",
            //                    optional: false,
            //                    reloadOnChange: true)
            //                    .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Logins}/{action=Login}/{id?}");
            });
        }
    }
}
