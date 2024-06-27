using StoreMarket.Models;

namespace GraphQL.Contracts.Requests.Categories
{
    public class CategoryCreateRequest
    {
        public string Name { get; set; }
        public string? Description { get; set; }


        /*public Category CategoryGetEntity()
        {
            return new Category
            {
                Name = Name,
                Description = Description
            };

        }*/
    }
}
