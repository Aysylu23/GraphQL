using GraphQL.Abstraction;
using GraphQL.Contracts.Responses.Categories;
using GraphQL.Contracts.Responses.Products;
using GraphQL.Contracts.Responses.Stores;
using StoreMarket.Abstraction;
using StoreMarket.Models;

namespace GraphQL.GraphQL
{
    public class Query
    {
        private readonly IProductServices _productServices;
        private readonly ICategoryService _categoryServices;
        private readonly IStoreServices _storeService;
        public Query(IProductServices productServices, ICategoryService categoryService, IStoreServices storeService)
        {
            _productServices = productServices;
            _categoryServices = categoryService;
            _storeService = storeService;
        }

        public IEnumerable<ProductResponse> GetProducts() => _productServices.GetProducts();
        
        public ProductResponse GetProductById(int id) => _productServices.GetProductById(id);

        public IEnumerable<CategoryResponse> GetCategories() => _categoryServices.GetCategories();

        public IEnumerable<StoreResponse> GetStores() => _storeService.GetStores();

    }
}
