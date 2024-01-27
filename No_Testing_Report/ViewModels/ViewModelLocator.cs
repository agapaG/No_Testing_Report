
using Microsoft.Extensions.DependencyInjection;

namespace No_Testing_Report.ViewModels
{
	internal class ViewModelLocator
	{
		public MainVindowViewModel MainViewModel =>
			App.Services.GetRequiredService<MainVindowViewModel>();
	}
}
