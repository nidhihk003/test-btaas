using Xunit;
public class order_test {
    [Fact]
    public void GetOrderId_DefaultIdValue() {
        Assert.Equal(0, new Order().Id);
    }
    [Fact]
    public void GetOrderStatus_DefaultStatusValue() {
        Assert.Equal(None, new Order().Status);
    }
    [Fact]
    public void SetOrderId_PositiveValue() {
        Assert.Equal(5, var order = new Order(); order.Id = 5; order.Id);
    }
    [Fact]
    public void SetOrderStatus_ValidString() {
        Assert.Equal(Processing, var order = new Order(); order.Status = "Processing"; order.Status);
    }
    [Fact]
    public void SetOrderId_MinimumBoundary() {
        Assert.Equal(-2147483648, var order = new Order(); order.Id = int.MinValue; order.Id);
    }
    [Fact]
    public void SetOrderId_MaximumBoundary() {
        Assert.Equal(2147483647, var order = new Order(); order.Id = int.MaxValue; order.Id);
    }
    [Fact]
    public void SetOrderStatus_EmptyString() {
        Assert.Equal(, var order = new Order(); order.Status = ""; order.Status);
    }
    [Fact]
    public void SetOrderId_ZeroValue() {
        Assert.Equal(0, var order = new Order(); order.Id = 0; order.Id);
    }
    [Fact]
    public void SetOrderStatus_NullValue() {
        Assert.Equal(None, var order = new Order(); order.Status = null; order.Status);
    }
    [Fact]
    public void GetOrderId_UnsetProperty() {
        Assert.Equal(0, var order = new Order(); order.Id);
    }
}