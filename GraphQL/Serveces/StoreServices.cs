using AutoMapper;
using GraphQL.Abstraction;
using GraphQL.Contracts.Requests.Categories;
using GraphQL.Contracts.Requests.Stores;
using GraphQL.Contracts.Responses.Categories;
using GraphQL.Contracts.Responses.Stores;
using StoreMarket.Contexts;
using StoreMarket.Models;

namespace GraphQL.Serveces
{
    public class StoreServices : IStoreServices
    {
        private readonly IMapper _mapper;
        private readonly StoreContext _storeContext;

        public StoreServices(StoreContext storeContext, IMapper mapper)
        {
            _storeContext = storeContext;
            _mapper = mapper;
        }

       public int AddStore(StoreCreateRequest store)
        {
            var mappEntity = _mapper.Map<Store>(store);
            _storeContext.Stores.Add(mappEntity);

            _storeContext.SaveChanges();

            return mappEntity.Id;
        }

        public IEnumerable<StoreResponse> GetStores()
        {
            IEnumerable<StoreResponse> stores = _storeContext.Stores.Select(_mapper.Map<StoreResponse>);

            return stores;
        }
    }
}
