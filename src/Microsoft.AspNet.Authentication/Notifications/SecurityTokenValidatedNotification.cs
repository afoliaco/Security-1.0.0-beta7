// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.Authentication
{
    public class SecurityTokenValidatedNotification<TMessage, TOptions> : BaseNotification<TOptions>
    {
        public SecurityTokenValidatedNotification(HttpContext context, TOptions options) : base(context, options)
        {
        }

        public TMessage ProtocolMessage { get; set; }
    }
}
