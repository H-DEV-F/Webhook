using Microsoft.AspNetCore.Mvc;

namespace Webhook.Controllers
{
    [ApiController, Route("{prefix:webhookRoutePrefix}/[controller]")]
    public abstract class ResponseHandler<TRequest, TResponse>
    {
        [HttpPost, Route("")]
        public abstract Task<TResponse> Handle([FromBody] TRequest request);
    }
}