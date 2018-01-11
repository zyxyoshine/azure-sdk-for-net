// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The cluster create parameters.
    /// </summary>
    public partial class ClusterCreateProperties
    {
        /// <summary>
        /// Initializes a new instance of the ClusterCreateProperties class.
        /// </summary>
        public ClusterCreateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterCreateProperties class.
        /// </summary>
        /// <param name="clusterVersion">The version of the cluster.</param>
        /// <param name="osType">The type of operating system. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="tier">The cluster tier. Possible values include:
        /// 'Standard', 'Premium'</param>
        /// <param name="clusterDefinition">The cluster definition.</param>
        /// <param name="securityProfile">The security profile.</param>
        /// <param name="computeProfile">The compute profile.</param>
        /// <param name="storageProfile">The storage profile.</param>
        public ClusterCreateProperties(string clusterVersion = default(string), OSType? osType = default(OSType?), Tier? tier = default(Tier?), ClusterDefinition clusterDefinition = default(ClusterDefinition), SecurityProfile securityProfile = default(SecurityProfile), ComputeProfile computeProfile = default(ComputeProfile), StorageProfile storageProfile = default(StorageProfile))
        {
            ClusterVersion = clusterVersion;
            OsType = osType;
            Tier = tier;
            ClusterDefinition = clusterDefinition;
            SecurityProfile = securityProfile;
            ComputeProfile = computeProfile;
            StorageProfile = storageProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterVersion")]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Gets or sets the type of operating system. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public OSType? OsType { get; set; }

        /// <summary>
        /// Gets or sets the cluster tier. Possible values include: 'Standard',
        /// 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public Tier? Tier { get; set; }

        /// <summary>
        /// Gets or sets the cluster definition.
        /// </summary>
        [JsonProperty(PropertyName = "clusterDefinition")]
        public ClusterDefinition ClusterDefinition { get; set; }

        /// <summary>
        /// Gets or sets the security profile.
        /// </summary>
        [JsonProperty(PropertyName = "securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets the compute profile.
        /// </summary>
        [JsonProperty(PropertyName = "computeProfile")]
        public ComputeProfile ComputeProfile { get; set; }

        /// <summary>
        /// Gets or sets the storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public StorageProfile StorageProfile { get; set; }

    }
}