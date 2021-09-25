using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ecommerce_cart
{
    public static class ServiceExtension
    {
        public static void ECommerceServiceRegister(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("ECommerceDb");

        }
    }
}
