// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Http;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Diagnostics.CodeAnalysis;
using System.IdentityModel.Tokens.Jwt;

namespace Microsoft.AspNet.Authentication.OpenIdConnect
{
    /// <summary>
    /// This Notification can be used to be informed when an 'AuthorizationCode' is received over the OpenIdConnect protocol.
    /// </summary>
    public class AuthorizationCodeReceivedNotification : BaseNotification<OpenIdConnectAuthenticationOptions>
    {
        /// <summary>
        /// Creates a <see cref="AuthorizationCodeReceivedNotification"/>
        /// </summary>
        public AuthorizationCodeReceivedNotification(HttpContext context, OpenIdConnectAuthenticationOptions options) : base(context, options)
        { 
        }

        /// <summary>
        /// Gets or sets the 'code'.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="JwtSecurityToken"/> that was received in the id_token + code OpenIdConnectRequest.
        /// </summary>
        public JwtSecurityToken JwtSecurityToken { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="OpenIdConnectMessage"/>.
        /// </summary>
        public OpenIdConnectMessage ProtocolMessage { get; set; }

        /// <summary>
        /// Gets or sets the 'redirect_uri'.
        /// </summary>
        /// <remarks>This is the redirect_uri that was sent in the id_token + code OpenIdConnectRequest.</remarks>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Justification = "user controlled, not necessarily a URI")]
        public string RedirectUri { get; set; }
    }
}