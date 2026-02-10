using Xunit;
public class OrderController_test {
    [Fact]
    public void Get_ValidId_ReturnsOk() {
        Assert.Equal(Ok(result), new OrderController().Get(1));
    }
    [Fact]
    public void Get_NegativeId_ReturnsOkWithCreatedOrder() {
        Assert.Equal(Ok(result), new OrderController().Get(-1));
    }
    [Fact]
    public void Get_ZeroId_ReturnsOkWithCreatedOrder() {
        Assert.Equal(Ok(result), new OrderController().Get(0));
    }
    [Fact]
    public void Get_LargeId_ReturnsOkWithCreatedOrder() {
        Assert.Equal(Ok(result), new OrderController().Get(1000000));
    }
    [Fact]
    public void Get_MaxIntId_ReturnsOkWithCreatedOrder() {
        Assert.Equal(Ok(result), new OrderController().Get(int.MaxValue));
    }
    [Fact]
    public void Get_MinIntId_ReturnsOkWithCreatedOrder() {
        Assert.Equal(Ok(result), new OrderController().Get(int.MinValue));
    }
    [Fact]
    public void Get_SmallNegativeId_ReturnsOkWithCreatedOrder() {
        Assert.Equal(Ok(result), new OrderController().Get(-1000));
    }
    [Fact]
    public void Get_NullId_ThrowsArgumentNullException() {
        Assert.Equal(throws ArgumentNullException, new OrderController().Get(null));
    }
    [Fact]
    public void Get_ValidId_ReturnsTypeIActionResult() {
        Assert.Equal(is IActionResult, new OrderController().Get(123));
    }
}