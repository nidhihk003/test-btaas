using Xunit;
public class order_service_test {
    [Fact]
    public void CreateOrderWithPositiveId() {
        Assert.Equal({'Id': 1, 'Status': 'Created'}, new OrderService().CreateOrder(1));
    }
    [Fact]
    public void CreateOrderWithZeroId() {
        Assert.Equal({'Id': 0, 'Status': 'Created'}, new OrderService().CreateOrder(0));
    }
    [Fact]
    public void CreateOrderWithNegativeId() {
        Assert.Equal({'Id': -1, 'Status': 'Created'}, new OrderService().CreateOrder(-1));
    }
    [Fact]
    public void CreateOrderWithLargePositiveId() {
        Assert.Equal({'Id': 2147483647, 'Status': 'Created'}, new OrderService().CreateOrder(2147483647));
    }
    [Fact]
    public void CreateOrderWithLargeNegativeId() {
        Assert.Equal({'Id': -2147483648, 'Status': 'Created'}, new OrderService().CreateOrder(-2147483648));
    }
    [Fact]
    public void CreateOrderWithTypicalId() {
        Assert.Equal({'Id': 12345, 'Status': 'Created'}, new OrderService().CreateOrder(12345));
    }
}