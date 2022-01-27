using FluentAssertions;
using ShopRestApi.Controllers;
using ShopRestApi.Mocks;
using ShopRestApi.Repositories;
using ShopRestApi.Services;
using System.Threading.Tasks;
using Xunit;

namespace TestShopRestApi
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var discountServices = new DiscountService();

            var repository = new MockToyRepository();

            var toyController = new ToyController(repository, discountServices);

            var result = await toyController.GetAll();

            result.Should().NotBeEmpty();

        }
    }
}