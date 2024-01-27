using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace No_Testing_Report
{
	internal class Program
	{
		[System.STAThreadAttribute()]
		internal static void Main(string[] Args)
		{
			try
			{
				No_Testing_Report.App app = new No_Testing_Report.App();
				app.InitializeComponent();
				app.Run();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] Args) => Host
			.CreateDefaultBuilder(Args)
			.ConfigureServices(App.ConfigureServices)
		;
	}
}
