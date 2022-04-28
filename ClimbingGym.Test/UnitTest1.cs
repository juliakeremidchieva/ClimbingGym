using ClimbingGym.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
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
            //dbContext = new InMemoryDbContext();
            //var serviceCollection = new ServiceCollection();

            //serviceProvider = serviceCollection
            //    .AddSingleton(sp => dbContext.CreateContext())
            //    .AddSingleton<ApplicationDbRepository, ApplicationDbRepository>()
            //    .AddSingleton<IOrderService, OrderService>()
            //    .BuildServiceProvider();

            //var repo = serviceProvider.GetService<IApplicationDbRepository>();
            //await SeedDbAsync(repo);
        }

        //[Test]
        //public void UnknownCustomerMustThrow()
        //{
        //    var order = new CustomerOrder()
        //    {
        //        CustomerNumber = "usdfhsdbjsh"
        //    };

        //    var service = serviceProvider.GetService<IOrderService>();


        //    Assert.CatchAsync<ArgumentException>(async () => await service.PlaceOrder(order), "Unknown custommer");
        //}

        //[Test]
        //public void KnownCustomerMustNotThrow()
        //{
        //    var order = new CustomerOrder()
        //    {
        //        CustomerNumber = "myTestNumber"
        //    };

        //    var service = serviceProvider.GetService<IOrderService>();

        //    Assert.DoesNotThrowAsync(async () => await service.PlaceOrder(order));
        //}

        //[Test]
        //public void NotEnoughtItemsShouldThrow()
        //{
        //    var order = new CustomerOrder()
        //    {
        //        CustomerNumber = "myTestNumber",
        //        Items = new List<ItemOrder>()
        //        {
        //            new ItemOrder()
        //            {
        //                Barcode = "1234567890",
        //                Count = 7
        //            }
        //        }
        //    };

        //    var service = serviceProvider.GetService<IOrderService>();

        //    Assert.CatchAsync<ArgumentException>(async () => await service.PlaceOrder(order), "Not enough quantity");
        //}

        //[Test]
        //public void EnoughtItemsInWarehouseShouldNotThrow()
        //{
        //    var order = new CustomerOrder()
        //    {
        //        CustomerNumber = "myTestNumber",
        //        Items = new List<ItemOrder>()
        //        {
        //            new ItemOrder()
        //            {
        //                Barcode = "1234567890",
        //                Count = 3
        //            }
        //        }
        //    };

        //    var service = serviceProvider.GetService<IOrderService>();

        //    Assert.DoesNotThrowAsync(async () => await service.PlaceOrder(order));
        //}

        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }

    }
}