using GraphQL.Contracts.Requests.Categories;
using GraphQL.Contracts.Requests.Products;
using GraphQL.Contracts.Requests.Stores;
using GraphQL.Contracts.Responses.Categories;
using GraphQL.Contracts.Responses.Products;
using GraphQL.Contracts.Responses.Stores;

namespace GraphQL.Abstraction
{
    public interface IStoreServices
    {
        public int AddStore(StoreCreateRequest store);

        public IEnumerable<StoreResponse> GetStores();
       
    }
}
