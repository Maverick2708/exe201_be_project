using Repository.Interface;
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

            return services;
        }
    }
}
