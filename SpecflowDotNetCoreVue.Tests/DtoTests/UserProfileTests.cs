using Xunit;
using SpecflowDotNetCoreVue.Dto;

public class UserProfileTests
{
    [Fact(DisplayName = "It Exists")]
    public void ItExists()
    {
        var dto = new UserProfileDto();
    }
    [Fact(DisplayName = "It has an id")]
    public void ItHasAnId()
    {
        // Arrange
        var dto = new UserProfileDto();
        
        // Act
        dto.Id = 1;

        // Assert
        Assert.Equal(1, dto.Id);
    }
}