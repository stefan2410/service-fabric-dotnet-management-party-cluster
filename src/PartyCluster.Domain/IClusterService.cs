﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace PartyCluster.Domain
{
    using System.Threading.Tasks;
    using Microsoft.ServiceFabric.Services.Remoting;

    public interface IClusterService : IService
    {
        /// <summary>
        /// Gets the status of the party for given user. 
        /// If user has joined a cluster the cluster information is returned. 
        /// Else it returns if there is room in the party.
        /// </summary>
        /// <param name="userId">The id of the user.</param>
        /// <returns>ClusterConnectionView instance.</returns>
        Task<UserView> GetPartyStatusAsync(string userId);

        /// <summary>
        /// Joins a random cluster from the list of available clusters.
        /// </summary>
        /// <param name="userId">The id of the user.</param>
        /// <param name="platform">The name of the platform - windows or linux.</param>
        /// <returns>ClusterConnectionView instance.</returns>
        Task<UserView> JoinRandomClusterAsync(string userId, Platform platform);
    }
}