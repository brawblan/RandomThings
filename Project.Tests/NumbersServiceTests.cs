using Xunit;
using RandomThings.Services;

namespace RandomThings.Project.Tests;

public class NumbersServiceTests
{
    [Fact]
    public void Get_DefaultRange_ReturnsValueWithin0To100Inclusive()
    {
        var value = NumbersService.Get();
        Assert.InRange(value, 0, 100);
    }

    [Fact]
    public void Get_CustomRange_ReturnsValueWithinMinInclusive_MaxExclusive()
    {
        var min = 10;
        var max = 20;
        var value = NumbersService.Get(min, max);
        Assert.InRange(value, min, max - 1);
    }

    [Fact]
    public void Get_WhenRangeHasSinglePossibleValue_ReturnsThatValue()
    {
        var min = 5;
        var max = 6; // only possible output is 5
        var value = NumbersService.Get(min, max);
        Assert.Equal(5, value);
    }
}