﻿using AspNetCore.Identity.Mongo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TaskManagment.Domain.Core.Models;
using TaskManagment.Domain.Models;

namespace TaskManagment.Infrastructure.CrossCutting.Identity
{
    public static class IdentityConfig
    {
        public static void AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddIdentityMongoDbProvider<User, ApplicationRole>(identityOptions =>
            {
                configuration.GetSection("Identity").Bind(identityOptions);
            }, mongoIdentityOptions =>
            {
                mongoIdentityOptions.ConnectionString = configuration["Mongo:Connection"] + "/" + configuration["Mongo:Database"];
            });
        }

    }
}
