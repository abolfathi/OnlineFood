﻿using Microsoft.Extensions.DependencyInjection;
using OnlineFood.Domain.InterfaceRepositories;
using OnlineFood.Domain.InterfaceRepositories.Cities;
using OnlineFood.Domain.InterfaceRepositories.Comments;
using OnlineFood.Domain.InterfaceRepositories.Customers;
using OnlineFood.Domain.InterfaceRepositories.Favorites;
using OnlineFood.Domain.InterfaceRepositories.MenuCategories;
using OnlineFood.Domain.InterfaceRepositories.OrderItems;
using OnlineFood.Domain.InterfaceRepositories.Orders;
using OnlineFood.Domain.InterfaceRepositories.Provinces;
using OnlineFood.Domain.InterfaceRepositories.RestaurantCategories;
using OnlineFood.Domain.InterfaceRepositories.Trancations;
using OnlineFood.Domain.InterfaceRepositories.Users;
using OnlineFood.Domain.IReaders;
using OnlineFood.Domain.IReaders.Cities;
using OnlineFood.Domain.IReaders.Comments;
using OnlineFood.Domain.IReaders.Customers;
using OnlineFood.Domain.IReaders.Favorites;
using OnlineFood.Domain.IReaders.MenuCategories;
using OnlineFood.Domain.IReaders.OrderItems;
using OnlineFood.Domain.IReaders.Orders;
using OnlineFood.Domain.IReaders.Provinces;
using OnlineFood.Domain.IReaders.RestaurantCategories;
using OnlineFood.Domain.IReaders.Trancations;
using OnlineFood.Domain.IReaders.Users;
using OnlineFood.Domain.IRepositories;
using OnlineFood.InfraStructure.Readers;
using OnlineFood.InfraStructure.Readers.Comments;
using OnlineFood.InfraStructure.Readers.Customers;
using OnlineFood.InfraStructure.Readers.Favorites;
using OnlineFood.InfraStructure.Readers.MenuCategories;
using OnlineFood.InfraStructure.Readers.OrderItems;
using OnlineFood.InfraStructure.Readers.Orders;
using OnlineFood.InfraStructure.Readers.Provinces;
using OnlineFood.InfraStructure.Readers.Trancations;
using OnlineFood.InfraStructure.Readers.Users;
using OnlineFood.InfraStructure.Repositories;
using OnlineFood.InfraStructure.Repositories.Cities;
using OnlineFood.InfraStructure.Repositories.Comments;
using OnlineFood.InfraStructure.Repositories.Customers;
using OnlineFood.InfraStructure.Repositories.Favorites;
using OnlineFood.InfraStructure.Repositories.MenuCategories;
using OnlineFood.InfraStructure.Repositories.OrderItems;
using OnlineFood.InfraStructure.Repositories.Orders;
using OnlineFood.InfraStructure.Repositories.Provinces;
using OnlineFood.InfraStructure.Repositories.RestaurantCategories;
using OnlineFood.InfraStructure.Repositories.Trancations;
using OnlineFood.InfraStructure.Repositories.Users;

namespace OnlineFood.InfraStructure;

public static class DIContainer
{
    public static IServiceCollection InfraStructureServiceCollections(this IServiceCollection service)
    {
        service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        service.AddScoped<IUserRepository, UserRepository>();
        service.AddScoped<ICommentRepository, CommentRepository>();
        service.AddScoped<ICustomerRepository, CustomerRepository>();
        service.AddScoped<IFavoriteRepository, FavoriteRepository>();
        service.AddScoped<IOrderItemRepository, OrderItemRepository>();
        service.AddScoped<IOrderRepository, OrderRepository>();
		service.AddScoped<ITrancationRepository, TrancationRepository>();
        service.AddScoped<ICityRepository, CityRepository>();
        service.AddScoped<IProvinceRepository, ProvinceRepository>();
        service.AddScoped<IMenuCategoryRepository, MenuCategoryRepository>();
        service.AddScoped<IRestaurantCategoryRepository, RestaurantCategoryRepository>();

        service.AddScoped(typeof(IGenericReader<>), typeof(GenericReader<>));
        service.AddScoped<IUserReader, UserReader>();
        service.AddScoped<ICommentReader, CommentReader>();
        service.AddScoped<ICustomerReader, CustomerReader>();
        service.AddScoped<IFavoriteReader, FavoriteReader>();
        service.AddScoped<IOrderItemReader, OrderItemReader>();
        service.AddScoped<IOrderReader, OrderReader>();
		service.AddScoped<ITrancationReader, TrancationReader>();
        service.AddScoped<ICityReader, CityReader>();
        service.AddScoped<IProvinceReader, ProvinceReader>();
        service.AddScoped<IMenuCategoryReader, MenuCategoryReader>();
        service.AddScoped<IRestaurantCategoryReader, RestaurantCategoryReader>();
        service.AddScoped<IUnitOfWork, UnitOfWork>();

		return service;
    }
}