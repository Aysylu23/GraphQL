using GraphQL.Abstraction;
using GraphQL.Contracts.Requests.Categories;
using GraphQL.Contracts.Requests.Products;
using GraphQL.Contracts.Requests.Stores;
using StoreMarket.Abstraction;

namespace GraphQL.GraphQL
{
    public class Mutation
    {
        
        private readonly IProductServices _productServices;
        private readonly ICategoryService _categoryServices;
        private readonly IStoreServices _storeService;

        public Mutation(IProductServices productServices, ICategoryService categoryServices, IStoreServices storeService)
        {
            _productServices = productServices;
            _categoryServices = categoryServices;
            _storeService = storeService;
        }

        public int AddProduct (ProductCreateRequest request) => _productServices.AddProduct (request);
        public int DeleteProduct(int id) => _productServices.DeleteProduct (id);

        public int AddCategory(CategoryCreateRequest request) => _categoryServices.AddCategory(request);

        public int AddStore(StoreCreateRequest request) => _storeService.AddStore(request);
    }
}
