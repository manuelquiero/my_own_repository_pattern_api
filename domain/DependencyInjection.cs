﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection DomainDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
