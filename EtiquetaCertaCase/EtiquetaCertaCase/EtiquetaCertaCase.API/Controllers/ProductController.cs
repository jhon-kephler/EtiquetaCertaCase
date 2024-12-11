using EtiquetaCertaCase.Core.Schema;
using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EtiquetaCertaCase.API.Controllers
{
    [ApiController]
    [Route("api/product/[controller]")]
    [ApiExplorerSettings(GroupName = "product")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IMediator _mediator;

        public ProductController(ILogger<ProductController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet()]
        public Task<Result<ProductResponse>> Get([FromQuery] GetProductRequest request) =>
                _mediator.Send(request);

        [HttpGet("List")]
        public Task<PaginatedResult<ProductResponse>> GetList() =>
                _mediator.Send(new ListProductRequest());

        [HttpPost()]
        public Task<Result> Post(CreateProductRequest request) =>
                _mediator.Send(request);

        [HttpPut()]
        public Task<Result> Put(UpdateProductRequest request) =>
                _mediator.Send(request);

        [HttpDelete()]
        public Task<Result> Delete(DeleteProductRequest request) =>
                _mediator.Send(request);
    }
}
