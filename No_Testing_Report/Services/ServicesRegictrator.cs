
using Microsoft.Extensions.DependencyInjection;

namespace No_Testing_Report.Services
{
	internal static class ServicesRegictrator
	{
		public static IServiceCollection RegisterServics(this IServiceCollection services) => services
			.AddTransient<Engineers>()
		;
	}
}
