using Webhook.Options;

namespace Webhook.Config
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebhooks(this IServiceCollection services, Action<WebhookOptions>? spaceAction)
        {
            var options = new WebhookOptions();

            services.Configure<RouteOptions>(opt =>
            {
                opt.ConstraintMap.Add("webhookRoutePrefix", typeof(WebhookRoutePrefixConstraint));
            });

            spaceAction?.Invoke(options);
            services.AddSingleton(options);

            return services;
        }
    }
}
