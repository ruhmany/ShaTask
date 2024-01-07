using Microsoft.Extensions.DependencyInjection;
using ShaTask.Domain.Interfaces.IRepositories;
using ShaTask.Domain.Interfaces.IUnitOfWork;
using ShaTask.Infrastructre.Presstance.Respositories;
using ShaTask.Infrastructre.Presstance.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Infrastructre
{
    public static class InfrastructureDIConfiguration
    {
        public static IServiceCollection InfraInjection(this IServiceCollection services)
        {
            services.AddScoped<ICashierRepository, CashierRepository>()
                .AddScoped<IInvoiceDetail, InvoiceDetailRepository>()
                .AddScoped<IInvoiceHeader, InvoiceHeaderRepository>()
                .AddScoped<IUOW, UnitOfWork>();
            return services;
        }
    }
}
