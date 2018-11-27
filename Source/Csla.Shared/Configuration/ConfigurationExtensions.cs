﻿#if NETSTANDARD2_0
//-----------------------------------------------------------------------
// <copyright file="ConfigurationExtensions.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Implement extension methods for .NET Core configuration</summary>
//-----------------------------------------------------------------------
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Csla.Configuration
{
  /// <summary>
  /// Implement extension methods for .NET Core configuration
  /// </summary>
  public static class ConfigurationExtensions
  {
    /// <summary>
    /// Add CSLA .NET services for use by the application
    /// and enable CSLA .NET configuration.
    /// </summary>
    /// <param name="services">IServiceCollection object</param>
    public static ICslaBuilder AddCsla(this IServiceCollection services)
    {
      services.AddSingleton<IDataPortalService, DataPortalService>();
      return null;
    }

    /// <summary>
    /// Configure CSLA .NET settings from .NET Core configuration
    /// subsystem.
    /// </summary>
    /// <param name="config">Configuration root object</param>
    public static IConfigurationRoot ConfigureCsla(this IConfigurationRoot config)
    {
      config.Bind("csla", new CslaConfigurationOptions());
      return config;
    }
  }
}
#endif