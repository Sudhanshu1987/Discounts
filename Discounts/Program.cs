using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Discounts.PrototypeApi.PrototypeApi;
using Microsoft.Extensions.DependencyInjection;

namespace Discounts
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase());

            services.AddMvc();
        }
    }
}
