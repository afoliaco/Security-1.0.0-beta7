// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Authentication.OpenIdConnect
{
    /// <summary>
    /// Default values related to OpenIdConnect authentication middleware
    /// </summary>
    public static class OpenIdConnectAuthenticationDefaults
    {
        /// <summary>
        /// Constant used to identify state in openIdConnect protocol message.
        /// </summary>
        public const string AuthenticationPropertiesKey = "OpenIdConnect.AuthenticationProperties";

        /// <summary>
        /// The default value used for OpenIdConnectAuthenticationOptions.AuthenticationScheme.
        /// </summary>
        public const string AuthenticationScheme = "OpenIdConnect";

        /// <summary>
        /// The default value for OpenIdConnectAuthenticationOptions.Caption.
        /// </summary>
        public const string Caption = "OpenIdConnect";

        /// <summary>
        /// The prefix used to provide a default OpenIdConnectAuthenticationOptions.CookieName.
        /// </summary>
        public const string CookiePrefix = ".AspNet.OpenIdConnect.";

        /// <summary>
        /// The prefix used to for the a nonce in the cookie.
        /// </summary>
        public const string CookieNoncePrefix = ".AspNet.OpenIdConnect.Nonce.";

        /// <summary>
        /// The property for the RedirectUri that was used when asking for a 'authorizationCode'.
        /// </summary>
        public const string RedirectUriForCodePropertiesKey = "OpenIdConnect.Code.RedirectUri";

        /// <summary>
        /// Constant used to identify userstate inside AuthenticationProperties that have been serialized in the 'state' parameter.
        /// </summary>
        public const string UserstatePropertiesKey = "OpenIdConnect.Userstate";
    }
}
