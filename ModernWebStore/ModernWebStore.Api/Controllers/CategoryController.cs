using ModernWebStore.Domain.Commands.CategoryCommands;
using ModernWebStore.Domain.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ModernWebStore.Api.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryApplicationService _service;

        public CategoryController(ICategoryApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        //[Authorize]
        [Route("api/categories")]
        public Task<HttpResponseMessage> Get()
        {
            var categories = _service.Get();
            return CreateResponse(HttpStatusCode.Created, categories);
        }

        [HttpGet]
        //[Authorize]
        [Route("api/categories/{skip}/{take}")]
        public Task<HttpResponseMessage> Get(int skip, int take)
        {
            var categories = _service.Get(skip, take);
            return CreateResponse(HttpStatusCode.Created, categories);
        }

        [HttpGet]
        //[Authorize]
        [Route("api/categories/{id}")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var category = _service.Get(id);
            return CreateResponse(HttpStatusCode.Created, category);
        }

        [HttpPost]
        //[Authorize]
        [Route("api/categories")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateCategoryCommand(
                title: (string)body.title
            );

            var category = _service.Create(command);
            return CreateResponse(HttpStatusCode.Created, category);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/categories/{id}")]
        public Task<HttpResponseMessage> Put(int id, [FromBody]dynamic body)
        {
            var command = new EditCategoryCommand(
                id: id,
                title: (string)body.title
            );

            var category = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, category);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/categories/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var category = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, category);
        }
    }
}