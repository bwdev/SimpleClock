using System;
using Microsoft.Extensions.DependencyInjection;

namespace SystemClock.Core
{
    public interface IClock
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
    }

    public class Clock : IClock
    {
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;
    }

    public static class ClockExtension
    {
        public static void AddClock(this IServiceCollection services)
        {
            services.AddSingleton<IClock, Clock>();
        }
    }

}
