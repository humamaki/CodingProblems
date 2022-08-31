using Autofac;
using CodingProblems.Contracts;
using CodingProblems.Services;

namespace CodingProblems
{
    public class CompositionRoot : Module
    {

        public CompositionRoot()
        { 
        
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FizzBuzzService>().As<IProblemSolution>();

            //base.Load(builder);

            Console.WriteLine($"Hello World - {nameof(CompositionRoot)}");
        }
    }
}
