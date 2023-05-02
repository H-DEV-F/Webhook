using Webhook.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(opt => opt.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
{
    Version = "v1",
    Title = "Webhook",
    Description = "Example the webhook implementation.",
    Contact = new Microsoft.OpenApi.Models.OpenApiContact
    {
        Name = "Contact us",
        Email = "dev@development.com.br"
    },
    License = new Microsoft.OpenApi.Models.OpenApiLicense
    {
        Name = "License"
    }
}));

builder.Services.AddWebhooks(opt =>
{
    // default is "webhooks"
    opt.RoutePrefix = "webhooks";
});

var app = builder.Build();

app.UseSwaggerConfig();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
