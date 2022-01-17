﻿using FluentAssertions;
using ShopRestApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShopRestApiUnitTests
{
    public class DiscountServiceTests
    {
         [Fact]
        public void CalculateDiscount_GivenRegularPrice_CalculateCorrectDiscount()
        {
            //Arrange
            var price = 3.0M;
            var discountService = new DiscountService();
            //Act
            var returnedDiscount = discountService.CalculateDiscount(price);
            //Assert
            returnedDiscount.Should().Be(0.3M);
        }
    }
}
