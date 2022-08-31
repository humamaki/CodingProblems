using CodingProblems.Contracts;
using Microsoft.Extensions.Hosting;

namespace CodingProblems
{
    public class CodingProblemsWorker : IHostedService
    {
        private readonly IProblemSolution fizzBuzzService;
        public CodingProblemsWorker
        (
            IProblemSolution fizzBuzzService
        )
        { 
            this.fizzBuzzService = fizzBuzzService;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            fizzBuzzService.Run();  
            
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
