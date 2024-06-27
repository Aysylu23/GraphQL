using AutoMapper;
using GraphQL.Contracts.Requests.Categories;
using GraphQL.Contracts.Requests.Products;
using GraphQL.Contracts.Requests.Stores;
using GraphQL.Contracts.Responses.Categories;
using GraphQL.Contracts.Responses.Products;
using GraphQL.Contracts.Responses.Stores;
using StoreMarket.Models;

namespace StoreMarket.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product, ProductResponse>(MemberList.Destination).ReverseMap();
            CreateMap<Product, ProductDeleteResponse>(MemberList.Destination).ReverseMap();
            CreateMap<Product, ProductUpdateRequest>(MemberList.Destination).ReverseMap();
            CreateMap<Product, ProductDeleteRequest>(MemberList.Destination).ReverseMap();
            CreateMap<Product, ProductCreateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Category, CategoryCreateRequest>(MemberList.Destination).ReverseMap();
            CreateMap<Category, CategoryCreateResponse>(MemberList.Destination).ReverseMap();

            CreateMap<Store, StoreCreateRequest>(MemberList.Destination).ReverseMap();
            CreateMap<Store, StoreCreateResponse>(MemberList.Destination).ReverseMap();

        }

         
    }
}
