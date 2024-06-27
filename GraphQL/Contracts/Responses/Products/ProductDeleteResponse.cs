using StoreMarket.Models;

namespace GraphQL.Contracts.Responses.Products
{
    public class ProductDeleteResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public ProductDeleteResponse(Product products)
        {
            Id = products.Id;
            Name = products.Name;
        }


    }
}