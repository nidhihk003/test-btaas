using Xunit;
public class OrderController_test {
    [Fact]
    public void GetOrderWithValidId() {
        Assert.Equal(OkObjectResult, new OrderController().Get(1));
    }
    [Fact]
    public void GetOrderWithNegativeId() {
        Assert.Equal(OkObjectResult, new OrderController().Get(-1));
    }
    [Fact]
    public void GetOrderWithZeroId() {
        Assert.Equal(OkObjectResult, new OrderController().Get(0));
    }
    [Fact]
    public void GetOrderWithLargeId() {
        Assert.Equal(OkObjectResult, new OrderController().Get(2147483647));
    }
    [Fact]
    public void GetOrderWithMinIntId() {
        Assert.Equal(OkObjectResult, new OrderController().Get(-2147483648));
    }
    [Fact]
    public void GetOrderWithNullId() {
        Assert.Equal(OkObjectResult, new OrderController().Get(null));
    }
    [Fact]
    public void GetOrderWithMaxIntPlusOneId() {
        Assert.Equal(OkObjectResult, new OrderController().Get(2147483648));
    }
    [Fact]
    public void GetOrderWithMinIntMinusOneId() {
        Assert.Equal(OkObjectResult, new OrderController().Get(-2147483649));
    }
    [Fact]
    public void GetOrderWithInvalidIdType() {
        Assert.Equal(OkObjectResult, new OrderController().Get("invalid"));
    }
    [Fact]
    public void GetOrderWithSpecialCharacterId() {
        Assert.Equal(OkObjectResult, new OrderController().Get("!@#$%^&*()"));
    }
}