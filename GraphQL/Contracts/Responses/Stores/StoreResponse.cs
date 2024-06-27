using StoreMarket.Models;

namespace GraphQL.Contracts.Responses.Stores
{
    public class StoreResponse
    {
        public int Id { get; set; }
        public int Count { get; set; }
        //public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
