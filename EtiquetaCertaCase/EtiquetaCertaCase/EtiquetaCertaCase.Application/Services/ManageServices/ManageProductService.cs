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
                await _repository.AddAsync(_mapper.Map<Product>(request));
                result.SetSuccess();
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
                _repository.Update(request.Id, _mapper.Map<Product>(request));
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
    }
}
