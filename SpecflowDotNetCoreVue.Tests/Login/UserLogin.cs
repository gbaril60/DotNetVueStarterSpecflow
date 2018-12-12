using System;
using System.Text;
using System.Linq;
using Xunit;
using SpecflowDotNetCoreVue.Features.Login;
using SpecflowDotNetCoreVue.Dto;
using SpecflowDotNetCoreVue.Services;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace SpecflowDotNetCoreVue.Tests.Login
{
    public class UserLogin
    {
        private readonly LoginController _controller;

        public UserLogin()
        {
            // Arrange
            var repository = new FakeRepository<UserProfileDto>();
            var service = new UserProfileService(repository);
            _controller = new LoginController(service);

            repository.DataSet.Add(new UserProfileDto
            {
                SalesId = 123456,
                Username = "TestUser@email.com",
                PasswordHash = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes("ValidPassword"))
            });
        }

        [Fact(DisplayName = "It Exists")]
        public void ItExists()
        {
            var response = _controller.LogIn(123456, "Password");
        }

        [Fact(DisplayName = "It Returns an Action Result")]
        public void ItReturnsAnActionResult()
        {
            // Act
            var response = _controller.LogIn(123456, "Password");

            // Assert
            Assert.IsAssignableFrom<IActionResult>(response);
        }

        [Fact(DisplayName = "It returns not Authorized For Bad Sales Id")]
        public void ItReturnsNotAuthorizedForBadSalesId()
        {
            // Act
            var response = (StatusCodeResult)_controller.LogIn(45667, "ValidPassword");

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, (HttpStatusCode)response.StatusCode);
        }

        [Fact(DisplayName = "It Returns Ok For Valid Sales Id")]
        public void ItReturnsOkForValidSalesId()
        {
            // Act
            var response = (OkObjectResult)_controller.LogIn(123456, "ValidPassword");

            // Assert
            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)response.StatusCode);
        }
        [Fact(DisplayName = "It returns Unauthorized for Invalid Password")]
        public void ItReturnsUnathorizedforInvalidPassword()
        {
            // Act
            var response = (StatusCodeResult)_controller.LogIn(123456, "InvalidPassword");

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, (HttpStatusCode)response.StatusCode);
        }
    }
}
