using ClimbingGym.Core.Contracts;
using ClimbingGym.Core.Services;
using ClimbingGym.Infrastructure.Data;
using ClimbingGym.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClimbingGym.Test
{
    public class Tests
    {
        private ServiceProvider serviceProvider;
        private InMemoryDbContext dbContext;

        [SetUp]
        public async Task Setup()
        {
            dbContext = new InMemoryDbContext();
            var serviceCollection = new ServiceCollection();

            serviceProvider = serviceCollection
                .AddSingleton(sp => dbContext.CreateContext())
                .AddSingleton<ApplicationDbRepository, ApplicationDbRepository>()
                .AddSingleton<IRouteService, RouteService>()
                .BuildServiceProvider();

            var repo = serviceProvider.GetService<IApplicationDbRepository>();
            await SeedDbAsync(repo);
        }

        [Test]
        public void EnoughtItemsInWarehouseShouldNotThrow()
        {
            var service = serviceProvider.GetService<IRouteService>();
        }
        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }

        private async Task SeedDbAsync(IApplicationDbRepository? repo)
        {
            var sector = new Sector()
            {
                Id = Guid.NewGuid(),
                Name = "A",
                Routes = new List<Route>()
                {
                    new Route()
                    {
                        Name = "B",
                        Id = Guid.NewGuid(),
                       Color = "Blue",
                       DateFrom = DateTime.Now,
                       Description = "Something",
                       Grade = "Pro",
                       DateTo = DateTime.Now.AddDays(30)
                    }
                }
            };



            await repo.AddAsync(sector);
            await repo.SaveChangesAsync();
        }
    }
}