namespace UserProfileServiceTests
{
    using Xunit;
    using SpecflowDotNetCoreVue.Dto;
    using SpecflowDotNetCoreVue.Tests.Login;
    using SpecflowDotNetCoreVue.Services;
    using SpecflowDotNetCoreVue.Data;
    
    public class GetUserProfileTests
    {
        [Fact(DisplayName = "It returns null for Non Existent Users")]
        public void ItReturnsNullForNonExistantUsers()
        {
            // Arrange
            var repository = new FakeRepository<UserProfileDto>();
            var service = new UserProfileService(repository);

            // Act
            var profile = service.GetUserProfile(45678);

            // Assert
            Assert.Null(profile);
        }
        [Fact(DisplayName = "It returns user profile for users that exist")]
        public void ItReturnsUserProfileForUsersThatExist(){
            // Arrange
            var repository = new FakeRepository<UserProfileDto>();
            var service = new UserProfileService(repository);

            repository.DataSet.Add(new UserProfileDto
            {
                SalesId = 123456
            });

            // Act
            var profile = service.GetUserProfile(123456);

            // Assert
            Assert.NotNull(profile);
            Assert.IsAssignableFrom<UserProfileDto>(profile);
        }
    }
}