using Xunit;
public class userController_test {
    [Fact]
    public void GetUserById_ValidId_ReturnsOk() {
        Assert.Equal(OkObjectResult, controller.Get(1));
    }
    [Fact]
    public void GetUserById_InvalidId_ReturnsNotFound() {
        Assert.Equal(NotFoundResult, controller.Get(-1));
    }
    [Fact]
    public void GetUserById_ZeroId_ReturnsBadRequest() {
        Assert.Equal(BadRequestResult, controller.Get(0));
    }
    [Fact]
    public void GetUserById_NonExistentId_ReturnsNotFound() {
        Assert.Equal(NotFoundResult, controller.Get(9999));
    }
    [Fact]
    public void GetUserById_ValidId_ReturnsUser() {
        Assert.Equal({"id":2,"name":"John Doe"}, controller.Get(2));
    }
    [Fact]
    public void GetUserById_NegativeId_ReturnsBadRequest() {
        Assert.Equal(BadRequestResult, controller.Get(-5));
    }
    [Fact]
    public void GetUserById_NullId_ReturnsBadRequest() {
        Assert.Equal(BadRequestResult, controller.Get(null));
    }
    [Fact]
    public void GetUserById_MaxIntId_ReturnsNotFound() {
        Assert.Equal(NotFoundResult, controller.Get(int.MaxValue));
    }
    [Fact]
    public void GetUserById_MinIntId_ReturnsBadRequest() {
        Assert.Equal(BadRequestResult, controller.Get(int.MinValue));
    }
    [Fact]
    public void GetUserById_ValidId_ReturnsCorrectUserData() {
        Assert.Equal({"id":3,"name":"Jane Smith"}, controller.Get(3));
    }
}