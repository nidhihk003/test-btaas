using Xunit;
public class order_service_test {
    [Fact]
    public void CreateOrderWithValidId() {
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
    public void CreateOrderWithMaxIntId() {
        Assert.Equal({'Id': 2147483647, 'Status': 'Created'}, new OrderService().CreateOrder(int.MaxValue));
    }
    [Fact]
    public void CreateOrderWithMinIntId() {
        Assert.Equal({'Id': -2147483648, 'Status': 'Created'}, new OrderService().CreateOrder(int.MinValue));
    }
}