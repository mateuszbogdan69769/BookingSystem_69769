﻿using Domain.Interfaces;
using Domain.Roots.Accounts.Repos;
using Domain.Roots.Bookings.Repos;
using Domain.Roots.Guests.Repos;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repos;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<BookingDbContext>();

        services.AddScoped<IBookingDbContext, BookingDbContext>();

        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IGuestRepository, GuestRepository>();
        services.AddScoped<IBookingRepository, BookingRepository>();

        return services;
    }
}