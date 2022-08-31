// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CodingProblems
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await new HostBuilder()
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureServices(services => services.AddHostedService<CodingProblemsWorker>())
                .ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new CompositionRoot()))
                .RunConsoleAsync();
        }
    }
}
