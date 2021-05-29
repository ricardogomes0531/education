using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Educacao.Infra.Configuration
{
    public static class InfraExtension
    {
        public static IServiceCollection AddInfra(this IServiceCollection service)
        {
            return service;
        }
    }
}
