using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Educacao.Application.Configuration
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
                        return service;
        }
    }
}
