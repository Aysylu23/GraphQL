using AutoMapper;
using GraphQL.Abstraction;
using GraphQL.Contracts.Requests.Categories;
using GraphQL.Contracts.Responses;
using GraphQL.Contracts.Responses.Categories;
using StoreMarket.Contexts;
using StoreMarket.Models;

namespace GraphQL.Serveces
{
    public class CategoryService : ICategoryService
    {

        private readonly IMapper _mapper;
        private readonly StoreContext _storeContext;

        public CategoryService (StoreContext storeContext, IMapper mapper)
        {
            _storeContext = storeContext;
            _mapper = mapper;
        }

        public int AddCategory(CategoryCreateRequest category)
        {
            var mappEntity = _mapper.Map<Category>(category);
            _storeContext.Categories.Add(mappEntity);

            _storeContext.SaveChanges();
            
            return mappEntity.Id;
        }

        public IEnumerable<CategoryResponse> GetCategories()
        {
            IEnumerable<CategoryResponse> categories = _storeContext.Categories.Select(_mapper.Map<CategoryResponse>);

            return categories;
        }

    }
}
