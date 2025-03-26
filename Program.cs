using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizza02.Aplicação.Servicos;
using Pizza02.Dominio.Servicos;
using Pizza02.Infraestrutura.Database;
using Pizza02.Infraestrutura.Repositorios;

namespace Pizza02
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContex>(options =>
            options.UseSqlite("Data Source=estoque.db"));

            services.AddScoped<IPizzaDominioServico, PizzaDominioServico>();

            services.AddScoped<IPizzaRepositorio, PizzaRepositorio>();
            services.AddScoped<IPizzaAppServico, PizzaAppServico>();

            var serviceProvider = services.BuildServiceProvider();


            ApplicationConfiguration.Initialize();
            Application.Run(new FormPizzaCadastro(serviceProvider));
        }
    }
}