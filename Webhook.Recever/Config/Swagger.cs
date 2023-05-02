namespace Webhook.Config
{
    public static class Swagger
    {
        public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            return app;
        }
    }
}
