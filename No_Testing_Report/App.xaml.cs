﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using No_Testing_Report.ViewModels;
using System;
using System.Windows;


namespace No_Testing_Report
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		internal static IHost __Host;
		public static IHost Host => __Host
			??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
		public static IServiceProvider Services => __Host.Services;

		internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
			.RegisterViewModel()
		;

		protected override async void OnStartup(StartupEventArgs e)
		{
			var host = Host;
			base.OnStartup(e);
			await host.StartAsync().ConfigureAwait(false);
		}

		protected override async void OnExit(ExitEventArgs e)
		{
			using var host = Host;
			base.OnExit(e);
			await host.StopAsync().ConfigureAwait(false);
			Host.Dispose();
		}
	}
}
