// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.Framework.Internal;

namespace Microsoft.AspNet.Authorization
{
    public class AuthorizationOptions
    {
        private IDictionary<string, AuthorizationPolicy> PolicyMap { get; } = new Dictionary<string, AuthorizationPolicy>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// The initial default policy is to require any authenticated user
        /// </summary>
        public AuthorizationPolicy DefaultPolicy { get; set; } = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

        public void AddPolicy([NotNull] string name, [NotNull] AuthorizationPolicy policy)
        {
            PolicyMap[name] = policy;
        }

        public void AddPolicy([NotNull] string name, [NotNull] Action<AuthorizationPolicyBuilder> configurePolicy)
        {
            var policyBuilder = new AuthorizationPolicyBuilder();
            configurePolicy(policyBuilder);
            PolicyMap[name] = policyBuilder.Build();
        }

        public AuthorizationPolicy GetPolicy([NotNull] string name)
        {
            return PolicyMap.ContainsKey(name) ? PolicyMap[name] : null;
        }
   }
}