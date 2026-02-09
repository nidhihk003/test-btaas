using Xunit;
public class Program_test {
    [Fact]
    public void CreateHostBuilder_WithEmptyArgs() {
        Assert.Equal(HostBuilder, DotNetApp.Program.CreateHostBuilder(new string[] { }));
    }
    [Fact]
    public void CreateHostBuilder_WithNullArgs() {
        Assert.Equal(HostBuilder, DotNetApp.Program.CreateHostBuilder(null));
    }
    [Fact]
    public void CreateHostBuilder_WithValidArgs() {
        Assert.Equal(HostBuilder, DotNetApp.Program.CreateHostBuilder(new string[] { "--urls", "http://localhost:5000" }));
    }
    [Fact]
    public void CreateHostBuilder_WithInvalidArgs() {
        Assert.Equal(HostBuilder, DotNetApp.Program.CreateHostBuilder(new string[] { "--invalid" }));
    }
    [Fact]
    public void Main_WithEmptyArgs() {
        Assert.Equal(void, DotNetApp.Program.Main(new string[] { }));
    }
    [Fact]
    public void Main_WithNullArgs() {
        Assert.Equal(void, DotNetApp.Program.Main(null));
    }
    [Fact]
    public void Main_WithValidArgs() {
        Assert.Equal(void, DotNetApp.Program.Main(new string[] { "--urls", "http://localhost:5000" }));
    }
    [Fact]
    public void Main_WithInvalidArgs() {
        Assert.Equal(void, DotNetApp.Program.Main(new string[] { "--invalid" }));
    }
}