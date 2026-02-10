using Xunit;
using RandomThings.Services;
using RandomThings.Models;

namespace RandomThings.Project.Tests;

public class ColorsServiceTests
{
    [Fact]
    public void Get_DefaultRange_ReturnsValueWithin0To100Inclusive()
    {
        var actual = ColorsService.GetAll();
        Assert.Collection(actual,
            item => Assert.Equal(item, new Color { Id = 1, Name = "Red", }),
            item => Assert.Equal(item, new Color { Id = 2, Name = "Blue", }),
            item => Assert.Equal(item, new Color { Id = 3, Name = "Yellow", }),
            item => Assert.Equal(item, new Color { Id = 4, Name = "Green", }),
            item => Assert.Equal(item, new Color { Id = 5, Name = "Purple", })
        );
    }

    [Fact]
    public void Get_Color_By_ID_Returns_Color_When_In_Range()
    {
        var actual = ColorsService.Get(1);
        Assert.Equal(actual, new Color { Id = 1, Name = "Red" });
    }
}