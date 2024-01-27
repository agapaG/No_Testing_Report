
using Microsoft.Extensions.DependencyInjection;

namespace No_Testing_Report.ViewModels
{
	internal static class ViewModelRegistrator
	{
		public static IServiceCollection RegisterViewModel(this IServiceCollection services) => services
			.AddSingleton<MainVindowViewModel>()
		;
	}
}
