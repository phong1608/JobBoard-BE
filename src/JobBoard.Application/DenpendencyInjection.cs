using JobBoard.Application.Common.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace JobBoard.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);

                options.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });

            return services;
        }
    }
}
