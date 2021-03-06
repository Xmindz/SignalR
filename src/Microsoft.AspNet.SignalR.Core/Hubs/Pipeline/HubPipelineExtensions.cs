﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

namespace Microsoft.AspNet.SignalR.Hubs
{
    public static class HubPipelineExtensions
    {
        public static void EnableAutoRejoiningGroups(this IHubPipeline pipeline)
        {
            pipeline.AddModule(new AutoRejoiningGroupsModule());
        }

        public static void RequireAuthentication(this IHubPipeline pipeline)
        {
            var authorizer = new AuthorizeAttribute();
            pipeline.AddModule(new AuthorizeModule(globalConnectionAuthorizer: authorizer, globalInvocationAuthorizer: authorizer));
        }
    }
}
