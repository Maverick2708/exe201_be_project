﻿using Repository.Interface;
using Repository.Repository;
using Services.Interface;
using Services.Services;

namespace BE_Project_Exe201
{
    static class DependencyInjection
    {
        public static IServiceCollection AddApiWebService(this IServiceCollection services)
        {
            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IReportServices, ReportServices>();

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonServices, PersonServices>();

            services.AddScoped<IGenreCommunityService, GenreCommunityService>();
            services.AddScoped<IGenreCommunityRepository, GenreCommunityRepository>();

            services.AddScoped<ICommunityService, CommunityService>();
            services.AddScoped<ICommunityRepository, CommunityRepository>();

            return services;
        }
    }
}
