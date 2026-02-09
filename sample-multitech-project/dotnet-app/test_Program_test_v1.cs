using Xunit;
public class Program_test {
    [Fact]
    public void MainWithEmptyArgs() {
        Assert.Equal(void, Program.Main(new string[] {}));
    }
    [Fact]
    public void MainWithNullArgs() {
        Assert.Equal(void, Program.Main(null));
    }
    [Fact]
    public void CreateHostBuilderWithEmptyArgs() {
        Assert.Equal(Microsoft.Extensions.Hosting.IHostBuilder, Program.CreateHostBuilder(new string[] {}));
    }
    [Fact]
    public void CreateHostBuilderWithNullArgs() {
        Assert.Equal(Microsoft.Extensions.Hosting.IHostBuilder, Program.CreateHostBuilder(null));
    }
    [Fact]
    public void CreateHostBuilderWithValidArgs() {
        Assert.Equal(Microsoft.Extensions.Hosting.IHostBuilder, Program.CreateHostBuilder(new string[] {"arg1", "arg2"}));
    }
    [Fact]
    public void CreateHostBuilderWithSpecialCharacterArgs() {
        Assert.Equal(Microsoft.Extensions.Hosting.IHostBuilder, Program.CreateHostBuilder(new string[] {"!@#$%^&*()"}));
    }
    [Fact]
    public void CreateHostBuilderWithLongArgs() {
        Assert.Equal(Microsoft.Extensions.Hosting.IHostBuilder, Program.CreateHostBuilder(new string[] {new string('a', 1000)}));
    }
    [Fact]
    public void CreateHostBuilderWithEmptyStringArgs() {
        Assert.Equal(Microsoft.Extensions.Hosting.IHostBuilder, Program.CreateHostBuilder(new string[] {""}));
    }
    [Fact]
    public void CreateHostBuilderWithArgsContainingSpaces() {
        Assert.Equal(Microsoft.Extensions.Hosting.IHostBuilder, Program.CreateHostBuilder(new string[] {"arg with spaces"}));
    }
    [Fact]
    public void CreateHostBuilderWithMixedArgs() {
        Assert.Equal(Microsoft.Extensions.Hosting.IHostBuilder, Program.CreateHostBuilder(new string[] {"arg1", "", null, "arg4"}));
    }
}