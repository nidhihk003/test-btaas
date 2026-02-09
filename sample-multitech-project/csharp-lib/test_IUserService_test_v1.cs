using Xunit;
public class IUserService_test {
    [Fact]
    public void GetUser_ValidId_ReturnsUser() {
        Assert.Equal({ "id": 1, "name": "John Doe" }, userService.GetUser(1));
    }
    [Fact]
    public void GetUser_InvalidId_ReturnsNull() {
        Assert.Equal(null, userService.GetUser(-1));
    }
    [Fact]
    public void GetUser_NonExistentId_ReturnsNull() {
        Assert.Equal(null, userService.GetUser(100));
    }
    [Fact]
    public void GetUser_ZeroId_ReturnsNull() {
        Assert.Equal(null, userService.GetUser(0));
    }
    [Fact]
    public void GetUser_StringId_ThrowsArgumentException() {
        Assert.Equal(throws ArgumentException, userService.GetUser("abc"));
    }
    [Fact]
    public void GetUser_NullId_ThrowsArgumentNullException() {
        Assert.Equal(throws ArgumentNullException, userService.GetUser(null));
    }
    [Fact]
    public void GetUser_MaxIntId_ReturnsNull() {
        Assert.Equal(null, userService.GetUser(int.MaxValue));
    }
    [Fact]
    public void GetUser_MinIntId_ReturnsNull() {
        Assert.Equal(null, userService.GetUser(int.MinValue));
    }
    [Fact]
    public void GetUser_ValidIdWithLargeDataset_ReturnsUser() {
        Assert.Equal({ "id": 99999, "name": "Jane Doe" }, userService.GetUser(99999));
    }
    [Fact]
    public void GetUser_DuplicateId_ReturnsFirstUser() {
        Assert.Equal({ "id": 5, "name": "Alice" }, userService.GetUser(5));
    }
}