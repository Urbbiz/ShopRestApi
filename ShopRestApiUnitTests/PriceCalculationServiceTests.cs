using FluentAssertions;
using ShopRestApi.Dtos;
using ShopRestApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShopRestApiUnitTests
{
    public class PriceCalculationServiceTests
    {

        [Fact]
        public void ApplyDiscount_GivenRegularPrice_Calculate_CorrectDiscount()
        {
            var shopItem = new ShopItemDto()
            {
                Price = 3.00M
            };

            //Arrange
            var discountService = new DiscountService();

            var priceCalculationService = new PriceCalculationService(discountService);
            //Act
            var discountedItem = priceCalculationService.ApplyDiscount(shopItem);
            //Assert
            discountedItem.Price.Should().Be(2.7M);
        }
    }
}
