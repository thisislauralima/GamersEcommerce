namespace GamersEcommerce.WebApi.DependencyInjection
{
    public static class SwaggerExtension
    {
       public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            return app;
        }
    }
}
