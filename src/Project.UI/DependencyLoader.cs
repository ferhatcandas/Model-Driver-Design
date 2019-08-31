using Microsoft.Extensions.DependencyInjection;
using Project.Business.Managers;
using Project.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TStack.ADO;

namespace Project.UI
{
    public static class DependencyLoader
    {
        public static IServiceProvider Register(this IServiceCollection serviceCollection)
        {
            serviceCollection.UseADO(x => new TStack.ADO.Connection.ADOConnection(@"Server=.\sql2016;Database=Kutuphane;Trusted_Connection=True;"));
            serviceCollection.AddScoped<IService, Manager>();
            return serviceCollection.BuildServiceProvider();
        }
    }
}
