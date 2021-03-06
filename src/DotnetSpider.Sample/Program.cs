﻿using DotnetSpider.Core;
using DotnetSpider.Core.Monitor;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetSpider.Sample
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IocExtension.ServiceCollection.AddSingleton<IMonitorService, NLogMonitor>();

			JdSpider spiderBuilder = new JdSpider();
			spiderBuilder.Run("rerun");
		}
	}
}
