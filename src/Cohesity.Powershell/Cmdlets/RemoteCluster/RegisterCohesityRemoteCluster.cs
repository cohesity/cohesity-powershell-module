// Copyright 2018 Cohesity Inc.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.RemoteCluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Registers a remote Cohesity Cluster with the local Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Registers a remote Cohesity Cluster with the local Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    /// <para>PS&gt;</para>
    /// <code>
    /// Register-CohesityRemoteCluster -RemoteClusterIps 10.2.37.210 -RemoteClusterCredential (Get-Credential) -EnableReplication -EnableRemoteAccess -StorageDomainPairs @{LocalStorageDomainId=5;LocalStorageDomainName="DefaultStorageDomain";RemoteStorageDomainId=5;RemoteStorageDomainName="DefaultStorageDomain"}
    /// </code>
    /// <para>
    /// Registers a new remote Cohesity Cluster with Cluster VIP (10.2.37.210) with the local Cohesity Cluster with the specified parameters.
    /// </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Register, "CohesityRemoteCluster")]
    [OutputType(typeof(Models.RemoteCluster))]
    public class RegisterCohesityRemoteCluster : PSCmdlet
    {
        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        #region Params

        /// <summary>
        /// <para type="description">
        /// Remote cluster VIP or node IP addresses.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string[] RemoteClusterIps { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// User credentials for the remote cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public PSCredential RemoteClusterCredential { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// If specified, enables management of the remote cluster from the local cluster.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter EnableRemoteAccess { get; set; }

        /// <summary>
        /// <para type="description">
        /// If specified, indicates that the remote cluster will be used for replication.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter EnableReplication { get; set; }

        /// <summary>
        /// <para type="description">
        /// If specified, compresses the outbound data when transferring the replication data over the network to the remote cluster.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter EnableOutBoundCompression { get; set; }

        /// <summary>
        /// <para type="description">
        /// If specified, compresses the outbound data when transferring the replication data over the network to the remote cluster.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public Hashtable[] StorageDomainPairs { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster.
        /// This key can be obtained by running New-CohesityReplicationEncryptionKey.
        /// If a key is not specified, replication traffic encryption is disabled.
        /// When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string EncryptionKey { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Specifies the maximum allowed data transfer rate between the local Cluster and remote Cluster.
        /// The value is specified in MB per second.
        /// If not set, the data transfer rate is not limited.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? BandwidthLimitMbps { get; set; } = null;

        #endregion

        #region Processing

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var param = new RegisterRemoteCluster
            {
                RemoteIps = new List<string>(RemoteClusterIps),
                UserName = RemoteClusterCredential.UserName,
                Password = RemoteClusterCredential.GetNetworkCredential().Password,
                PurposeRemoteAccess = EnableRemoteAccess.IsPresent,
                PurposeReplication = EnableReplication.IsPresent,
                CompressionEnabled = EnableOutBoundCompression.IsPresent,
                AllEndpointsReachable = true,
                ViewBoxPairInfo = null
            };

            if(BandwidthLimitMbps != null)
            {
                param.BandwidthLimit = new BandwidthLimit
                {
                    RateLimitBytesPerSec = BandwidthLimitMbps * 1024 * 1024
                };
            }

            if(EncryptionKey != null)
            {
                param.EncryptionKey = EncryptionKey;
            }

            if (StorageDomainPairs != null)
            {
                var viewBoxPairs = new List<ViewBoxPairInfo>();
                foreach (var pair in StorageDomainPairs)
                {
                    if (pair["LocalStorageDomainId"] == null)
                    {
                        throw new Exception("LocalStorageDomainId must be specified in the StorageDomainPairs parameter");
                    }
                    if (pair["LocalStorageDomainName"] == null)
                    {
                        throw new Exception("LocalStorageDomainName must be specified in the StorageDomainPairs parameter");
                    }
                    if (pair["RemoteStorageDomainId"] == null)
                    {
                        throw new Exception("RemoteStorageDomainId must be specified in the StorageDomainPairs parameter");
                    }
                    if (pair["RemoteStorageDomainName"] == null)
                    {
                        throw new Exception("RemoteStorageDomainName must be specified in the StorageDomainPairs parameter");
                    }

                    ViewBoxPairInfo viewBoxPair = new ViewBoxPairInfo
                    {
                        LocalViewBoxId = long.Parse(pair["LocalStorageDomainId"].ToString()),
                        RemoteViewBoxId = long.Parse(pair["RemoteStorageDomainId"].ToString()),
                        LocalViewBoxName = pair["LocalStorageDomainName"].ToString(),
                        RemoteViewBoxName = pair["RemoteStorageDomainName"].ToString()
                    };

                    viewBoxPairs.Add(viewBoxPair);
                }
                param.ViewBoxPairInfo = viewBoxPairs;
            }

            // POST /public/remoteClusters
            var preparedUrl = $"/public/remoteClusters";
            var result = Session.ApiClient.Post<Models.RemoteCluster>(preparedUrl, param);
            WriteObject(result);
        }

        #endregion
    }
}