namespace SpecflowDotNetCoreVue.Tests.Login
{
    using SpecflowDotNetCoreVue.Features.Login;
    using SpecflowDotNetCoreVue.Services;
    using SpecflowDotNetCoreVue.Dto;

    public class Login
    {
        private readonly LoginController _controller;

        public Login()
        {
            // Arrange
            var repository = new FakeRepository<UserProfileDto>();
            var service = new UserProfileService(repository);

             _controller = new LoginController(service);

             repository.DataSet.Add(new UserProfileDto {
                 Username = "TestUser@email.com",
                 
             });
        }
    }
}