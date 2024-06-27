using GraphQL.Contracts.Requests.Categories;
using GraphQL.Contracts.Responses;
using GraphQL.Contracts.Responses.Categories;

namespace GraphQL.Abstraction
{
    public interface ICategoryService
    {
        int AddCategory(CategoryCreateRequest category);
        IEnumerable<CategoryResponse> GetCategories ();
    }
}
