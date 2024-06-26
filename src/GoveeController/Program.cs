﻿namespace GoveeController
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using SharpDeck.Extensions.Hosting;

    /// <summary>
    /// The plugin.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
#if DEBUG
            System.Diagnostics.Debugger.Launch();
#endif

            StreamDeckPluginHost.CreateDefaultBuilder()
            .ConfigureServices(services =>
                {
                    services
                        .AddSingleton<AuthorizationProvider>()
                        .AddSingleton<GoveeService>()
                        .AddHttpClient(nameof(GoveeHttpClient), c => c.BaseAddress = GoveeHttpClient.BaseAddress);
                })
                .RunStreamDeckPlugin();
        }
    }
}
