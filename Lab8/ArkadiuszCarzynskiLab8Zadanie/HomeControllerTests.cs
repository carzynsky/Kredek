using ArkadiuszCarzynskiLab6Zadanie.Controllers;
using ArkadiuszCarzynskiLab6Zadanie.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ArkadiuszCarzynskiLab8Zadanie
{
    public class HomeControllerTests
    {
        HomeController _controller;

        public HomeControllerTests()
        {
            _controller = new HomeController();
        }

        [Theory]
        [InlineData(23)]
        [InlineData(15)]
        public void GetListOfAllPhones_Equals(int amount)
        {
            // Act
            var result = _controller.GetListOfAllPhones();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<string>>(
                viewResult.ViewData.Model);
            Assert.Equal(amount, model.Count());
        }

        [Theory]
        [InlineData("iPhone 11")]
        [InlineData("Ajfon 22")]
        [InlineData("Xiaomi Najlepszy")]
        public void GetListOfAllPhones_ContainsModel(string phoneModel)
        {
            // Act
            var result = _controller.GetListOfAllPhones();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<string>>(
                viewResult.ViewData.Model);

            Assert.Contains(phoneModel, model);
        }

        [Theory]
        [InlineData("Apple")]
        [InlineData("Xiaomi")]
        [InlineData("Sony")]
        public void GetAllPhonesByBrand_Range(string brand)
        {
            // Act
            var result = _controller.GetAllPhonesByBrand(brand);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<PhoneViewModel>>(
                viewResult.ViewData.Model);

            Assert.InRange(model.Count, 1, 3);
        }

        [Fact]
        public void GetAllPhonesByBrand_TMP()
        {
            // Arrange
            string newBrand = "Apple";
            // Act
            var result = _controller.GetAllPhonesByBrand(newBrand);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<PhoneViewModel>>(
                viewResult.ViewData.Model);

            Assert.NotNull(model);
        }

    }
}
