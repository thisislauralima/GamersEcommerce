//using GamersEcommerce.WebApi;
//using Microsoft.AspNetCore.Hosting;

//public static class Program
//{
//    public static async Task Main(string[] args)
//    {
//        await CreateHostBuilder(args).Build().RunAsync();
//        var builder = WebApplication.CreateBuilder(args);

//        builder.Services.AddControllers();
//        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//        builder.Services.AddEndpointsApiExplorer();
//        builder.Services.AddSwaggerGen();

//        var app = builder.Build();

//        // Configure the HTTP request pipeline.
//        if (app.Environment.IsDevelopment())
//        {
//            app.UseSwagger();
//            app.UseSwaggerUI();
//        }

//        app.UseHttpsRedirection();

//        app.UseAuthorization();

//        app.MapControllers();

//        app.Run();
//    }
//    private static IHostBuilder CreateHostBuilder(string[] args)
//            => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
//}

using GamersEcommerce.WebApi;

public static class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            await CreateHostBuilder(args).Build().RunAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    private static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    // https://bartwullems.blogspot.com/2019/02/aspnet-core-scope-validation.html
}