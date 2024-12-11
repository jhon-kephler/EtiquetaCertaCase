using AutoMapper;
using EtiquetaCertaCase.Core.Schema;
using EtiquetaCertaCase.Domain.Repositories;
using EtiquetaCertaCase.Application.Services.SearchServices.Interfaces;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;
using EtiquetaCertaCase.Domain.Entities;

namespace EtiquetaCertaCase.Application.Services.SearchServices
{
    public class SearchProductService : ISearchProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;

        public SearchProductService(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Result<ProductResponse>> SearchProduct(GetProductRequest request)
        {
            var result = new Result<ProductResponse>();

            try
            {
                var product = _repository.GetById(request.Id);
                if (product == null)
                {
                    result.SetError("Invalid Id");
                    return result;
                }
                
                var productResponse = _mapper.Map<ProductResponse>(product);
                productResponse = await ValidatePromotional(productResponse);

                result.SetSuccess(productResponse);
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            return result;
        }

        public async Task<PaginatedResult<ProductResponse>> ListProduct()
        {
            var result = new PaginatedResult<ProductResponse>();

            try
            {
                var products = _repository.GetAll();
                if (products == null)
                {
                    result.SetError("Product not found");
                    return result;
                }

                var productResponses = _mapper.Map<List<ProductResponse>>(products);
                var validatedProducts = new List<ProductResponse>();

                foreach (var productResponse in productResponses)
                {
                    var validatedProduct = await ValidatePromotional(productResponse);
                    validatedProducts.Add(validatedProduct);
                }

                result.SetSuccess(validatedProducts);
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            return result;
        }

        private async Task<ProductResponse> ValidatePromotional(ProductResponse response)
        {
            response.Price = DateTime.Now.Month == 11 ? response.Price - (response.Price * 0.10m) : response.Price;

            return response;
        }
    }
}
