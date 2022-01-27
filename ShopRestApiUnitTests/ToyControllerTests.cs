using FluentAssertions;
using Moq;
using ShopRestApi.Controllers;
using ShopRestApi.Enteties;
using ShopRestApi.Interfaces;
using ShopRestApi.Repositories;
using ShopRestApi.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace TestShopRestApi
{
    public class ToyControllerTests
    {

        [Fact]
        public async Task GetAll_ControllerAppliesDiscount()
        {
            var discountServices = new DiscountService();

            var repository = new Mock<IToyRepository>();
            
            repository.Setup(r => r.GetAll()).ReturnsAsync(new List<Toy>()
            {
                new Toy()
                {
                    Price = 3M
                }
            });

            var toyController = new ToyController(repository.Object, discountServices);

            var result = await toyController.GetAll();

            result.Should().NotBeEmpty();
            result.First().Price.Should().Be(2.7M);
        }




    }
}