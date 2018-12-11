using System;
using System.Linq;
using Xunit;
using SpecflowDotNetCoreVue.Features.Login;
using Microsoft.AspNetCore.Mvc;

namespace SpecflowDotNetCoreVue.Tests.Login
{
    public class LoginControllerTest
    {
        [Fact(DisplayName = "It takes a sales id")]
        public void ItReturnsAValue()
        {
            // Arrange
            var controller = new LoginController();

            // Act
            // Assert
            controller.LogIn(12345);
        }
        [Fact(DisplayName = "It returns a something")]
        public void ItReturnsSomething()
        {
            // Arrange
            var controller = new LoginController();
            // Act
            var res = controller.LogIn(12345);

        }
        [Fact(DisplayName = "It returns an IActionResult")]
        public void ItReturnsAnIActionResult()
        {
            // Arrange
            var controller = new LoginController();
            // Act
            var res = controller.LogIn(12345);
            // Assert
            Assert.IsAssignableFrom<IActionResult>(res);
        }
    }
}
