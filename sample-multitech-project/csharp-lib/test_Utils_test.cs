using Xunit;
public class Utils_test {
    [Fact]
    public void AddTwoPositiveNumbers() {
        Assert.Equal(8, Utils.AddNumbers(3, 5));
    }
    [Fact]
    public void AddPositiveAndNegativeNumber() {
        Assert.Equal(7, Utils.AddNumbers(10, -3));
    }
    [Fact]
    public void AddTwoNegativeNumbers() {
        Assert.Equal(-10, Utils.AddNumbers(-4, -6));
    }
    [Fact]
    public void AddNumberAndZero() {
        Assert.Equal(7, Utils.AddNumbers(7, 0));
    }
    [Fact]
    public void AddZeroAndNumber() {
        Assert.Equal(9, Utils.AddNumbers(0, 9));
    }
    [Fact]
    public void AddTwoZeros() {
        Assert.Equal(0, Utils.AddNumbers(0, 0));
    }
    [Fact]
    public void AddMaxIntAndPositiveNumber() {
        Assert.Equal(-2147483648, Utils.AddNumbers(int.MaxValue, 1));
    }
    [Fact]
    public void AddMinIntAndNegativeNumber() {
        Assert.Equal(2147483647, Utils.AddNumbers(int.MinValue, -1));
    }
    [Fact]
    public void AddNegativeNumberAndPositiveNumber() {
        Assert.Equal(-5, Utils.AddNumbers(-8, 3));
    }
    [Fact]
    public void AddLargePositiveNumbers() {
        Assert.Equal(3000000, Utils.AddNumbers(1000000, 2000000));
    }
}