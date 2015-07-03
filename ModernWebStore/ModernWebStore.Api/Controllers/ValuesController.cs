using ModernWebStore.Domain.Commands.UserCommands;
using ModernWebStore.Domain.Services;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ModernWebStore.Api.Controllers
{
    public class ValuesController : BaseController
    {
        private readonly IUserApplicationService _service;

        public ValuesController(IUserApplicationService service)
        {
            this._service = service;
        }

        [HttpPost]
        [Route("api/users")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new RegisterUserCommand(
                email: (string)body.email,
                password: (string)body.password
            );

            var user = _service.Register(command);

            return CreateResponse(HttpStatusCode.OK, user);
        }
    }
}