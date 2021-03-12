using Microsoft.Extensions.DependencyInjection;
using SSMS.BLL;
using SSMS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSMS.Models
{
    public class ServiceConfiguration
    {
        public static void Configuration(IServiceCollection services)
        {
            services.AddTransient<CategoryBLL>();
            services.AddTransient<CategoryReposetory>();
        }
    }
}
