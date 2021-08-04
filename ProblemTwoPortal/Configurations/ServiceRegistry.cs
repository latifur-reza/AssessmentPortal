using Microsoft.Extensions.DependencyInjection;
using ProblemTwoPortal.DataControl.Interfaces;
using ProblemTwoPortal.DataControl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Configurations
{
    public static class ServiceRegistry
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IBuilding, BuildingService>();
            services.AddTransient<IObject, ObjectService>();
            services.AddTransient<IDataField, DataFieldService>();
            services.AddTransient<IReading, ReadingService>();
        }
    }
}
