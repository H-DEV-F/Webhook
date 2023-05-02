using Webhook.Entities;

namespace Webhook.Controllers.Handler
{
    public class Hello : ResponseHandler<Request, Response>
    {
        public async override Task<Response> Handle(Request request)
        {
            return new Response()
            {
                Message = "Hello"
            };
        }
    }
}
