using GraphQL.Contracts.Requests.Products;
using GraphQL.Contracts.Responses.Products;

namespace StoreMarket.Abstraction
{
    public interface IProductServices

    {
        public int AddProduct(ProductCreateRequest product);

        public IEnumerable<ProductResponse> GetProducts();
        public ProductResponse GetProductById(int id);
        public int DeleteProduct(ProductDeleteRequest product);
        public int DeleteProduct(int id);
        public string GetCsv(IEnumerable<ProductResponse> products);
        }
}
