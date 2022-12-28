﻿namespace DSRNetSchool.Api;

using DSRNetSchool.Api.Settings;
using DSRNetSchool.Services.Actions;
using DSRNetSchool.Services.Books;
using DSRNetSchool.Services.Cache;
using DSRNetSchool.Services.RabbitMq;
using DSRNetSchool.Services.Settings;
using DSRNetSchool.Services.UserAccount;
using Microsoft.Extensions.DependencyInjection;

public static class Bootstrapper
{
    public static IServiceCollection RegisterAppServices(this IServiceCollection services)
    {
        services
            .AddMainSettings()
            .AddSwaggerSettings()
            .AddIdentitySettings()
            .AddApiSpecialSettings()
            .AddBookService()
            .AddUserAccountService()
            .AddCache()
            .AddRabbitMq()
            .AddActions()
            ;

        return services;
    }
}
