using StoreMarket.Models;

namespace GraphQL.Contracts.Responses.Categories
{
    public class CategoryDeleteResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }



        /*public CategoryDeleteResponse(Category categories)
        {
            Id = categories.Id;
            Name = categories.Name;
        }*/
    }
}

