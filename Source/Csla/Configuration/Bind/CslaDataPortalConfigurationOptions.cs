﻿//-----------------------------------------------------------------------
// <copyright file="  public class CslaDataPortalConfigurationOptions.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Use this type to configure the settings for CSLA .NET</summary>
//-----------------------------------------------------------------------
namespace Csla.Configuration
{

  /// <summary>
  /// Use this type to configure the settings for the CSLA .NET
  /// data portal using dot net core
  /// </summary>
  public class CslaDataPortalConfigurationOptions
  {
    /// <summary>
    /// Gets or sets the authentication type being used by the
    /// CSLA .NET framework.
    /// </summary>
    public string AuthenticationType { get => ApplicationContext.AuthenticationType; set => ApplicationContext.AuthenticationType = value; }

    /// <summary>
    /// Gets or sets whether the user's security principal flows from client to server.
    /// </summary>
    /// <remarks>
    /// You should avoid enabling this flow wherever possible. Anything on 
    /// the client can be manipulated, and using any data flowed from the 
    /// client to make security decisions on the server could make your 
    /// application vulnerable to impersonation exploits or elevation
    /// of privilege attacks.
    /// </remarks>
    public bool EnableSecurityPrincipalFlowFromClient { get => ApplicationContext.FlowSecurityPrincipalFromClient; set => ApplicationContext.FlowSecurityPrincipalFromClient = value; }

    /// <summary>
    /// Gets or sets a value indicating whether objects should be
    /// automatically cloned by the data portal Update()method 
    /// when using a local data portal configuration.
    /// </summary>
    public bool AutoCloneOnUpdate { get => ApplicationContext.AutoCloneOnUpdate; set => ApplicationContext.AutoCloneOnUpdate = value; }

    /// <summary>
    /// Gets or sets a value indicating whether the
    /// server-side business object should be returned to
    /// the client as part of the <see cref="DataPortalException"/> 
    /// (default is false).
    /// </summary>
    public bool ReturnObjectOnException { get => ApplicationContext.DataPortalReturnObjectOnException; set => ApplicationContext.DataPortalReturnObjectOnException = value; } 
  }
}