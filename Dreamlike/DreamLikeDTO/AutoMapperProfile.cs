using DreamLikeDAL;
using DreamLikeDAL.Models;
using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLikeDTO
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AgentDTO, Agent>();
            CreateMap<Agent, AgentDTO>();
            CreateMap<BlockedCategoryDTO, BlockedCategory>();
            CreateMap<BlockedCategory, BlockedCategoryDTO>();
            CreateMap<CategoryDTO, Category>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<CityDTO, City>();
            CreateMap<City, CityDTO>();
            CreateMap<CouponDTO, Coupon>();
            CreateMap<Coupon, CouponDTO>();
            CreateMap<EventDTO, Event>();
            CreateMap<Event, EventDTO>();
            CreateMap<ManagerDTO, Manager>();
            CreateMap<Manager, ManagerDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
            CreateMap<SelectedProductDTO, SelectedProduct>();
            CreateMap<SelectedProduct, SelectedProductDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
