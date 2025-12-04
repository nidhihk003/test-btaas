public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.Run(context => context.Response.WriteAsync("Hello from .NET App"));
    }
}
