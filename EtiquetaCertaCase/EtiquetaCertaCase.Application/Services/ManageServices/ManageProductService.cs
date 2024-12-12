using AutoMapper;
using EtiquetaCertaCase.Core.Schema;
using EtiquetaCertaCase.Domain.Entities;
using EtiquetaCertaCase.Domain.Repositories;
using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;
using EtiquetaCertaCase.Application.Services.ManageServices.Interfaces;

namespace EtiquetaCertaCase.Application.Services.ManageServices
{
    public class ManageProductService : IManageProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;

        public ManageProductService(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Result> CreateProduct(CreateProductRequest request)
        {
            var result = new Result();

            try
            {
                var product = _mapper.Map<Product>(request);

                var validate = await ValidateTextPropertie(product);
                if(!validate.IsSuccess)
                    return validate;

                await _repository.AddAsync(product);
                result.SetCreate();
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            return result;
        }

        public async Task<Result> UpdateProduct(UpdateProductRequest request)
        {
            var result = new Result();

            try
            {
                var product = _repository.GetById(request.Id);
                if (product == null)
                {
                    result.SetError("Invalid Id");
                    return result;
                }

                var newProduct = await ValidateUpdate(request, product);

                var validate = await ValidateTextPropertie(newProduct);
                if (!validate.IsSuccess)
                    return validate;

                _repository.Update(request.Id, newProduct);

                result.SetSuccess();
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            return result;
        }

        public async Task<Result> DeleteProduct(DeleteProductRequest request)
        {
            var result = new Result();

            try
            {
                _repository.Delete(request.Id);
                result.SetSuccess();
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            return result;
        }

        private async Task<Result> ValidateTextPropertie(Product product)
        {
            var result = new Result();

            if (product.Name.Length > 100)
                result.SetError("Name is too long");

            if (product.Category.Length > 100)
                result.SetError("Category is too long");

            return result;
        }

        private async Task<Product> ValidateUpdate(UpdateProductRequest request, Product product)
        {
            request.Name = !String.IsNullOrEmpty(request.Name) || product.Name != request.Name? request.Name : product.Name;
            request.Category = !String.IsNullOrEmpty(request.Category) || product.Category != request.Category ? request.Category : product.Category;
            request.Price = product.Price != request.Price ? request.Price.Value : product.Price;

            return _mapper.Map<Product>(request);
        }
    }
}
