﻿using System;
using HandlerOrdering.Sample;
using NServiceBus;
using NServiceBus.Installation.Environments;

public class Program 
{
	static void Main()
	{
		var bus = Configure.With()
		         .CustomConfigurationSource(new CustomConfigurationSource())
		         .DefaultBuilder()
		         .UseTransport<Msmq>()
		         .UnicastBus()
				 .LoadMessageHandlers()
					.PurgeOnStartup(false)
			.JsonSerializer()
		         .CreateBus()
		         .Start(() => Configure.Instance.ForInstallationOn<Windows>().Install());
		bus.SendLocal(new MyMessage());
		Console.ReadLine();
	}

}