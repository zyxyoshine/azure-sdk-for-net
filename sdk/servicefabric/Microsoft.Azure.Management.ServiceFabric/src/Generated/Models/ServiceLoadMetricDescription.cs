// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies a metric to load balance a service during runtime.
    /// </summary>
    public partial class ServiceLoadMetricDescription
    {
        /// <summary>
        /// Initializes a new instance of the ServiceLoadMetricDescription
        /// class.
        /// </summary>
        public ServiceLoadMetricDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceLoadMetricDescription
        /// class.
        /// </summary>
        /// <param name="name">The name of the metric. If the service chooses
        /// to report load during runtime, the load metric name should match
        /// the name that is specified in Name exactly. Note that metric names
        /// are case sensitive.</param>
        /// <param name="weight">The service load metric relative weight,
        /// compared to other metrics configured for this service, as a number.
        /// Possible values include: 'Zero', 'Low', 'Medium', 'High'</param>
        /// <param name="primaryDefaultLoad">Used only for Stateful services.
        /// The default amount of load, as a number, that this service creates
        /// for this metric when it is a Primary replica.</param>
        /// <param name="secondaryDefaultLoad">Used only for Stateful services.
        /// The default amount of load, as a number, that this service creates
        /// for this metric when it is a Secondary replica.</param>
        /// <param name="defaultLoad">Used only for Stateless services. The
        /// default amount of load, as a number, that this service creates for
        /// this metric.</param>
        public ServiceLoadMetricDescription(string name, string weight = default(string), int? primaryDefaultLoad = default(int?), int? secondaryDefaultLoad = default(int?), int? defaultLoad = default(int?))
        {
            Name = name;
            Weight = weight;
            PrimaryDefaultLoad = primaryDefaultLoad;
            SecondaryDefaultLoad = secondaryDefaultLoad;
            DefaultLoad = defaultLoad;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the metric. If the service chooses to
        /// report load during runtime, the load metric name should match the
        /// name that is specified in Name exactly. Note that metric names are
        /// case sensitive.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the service load metric relative weight, compared to
        /// other metrics configured for this service, as a number. Possible
        /// values include: 'Zero', 'Low', 'Medium', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public string Weight { get; set; }

        /// <summary>
        /// Gets or sets used only for Stateful services. The default amount of
        /// load, as a number, that this service creates for this metric when
        /// it is a Primary replica.
        /// </summary>
        [JsonProperty(PropertyName = "primaryDefaultLoad")]
        public int? PrimaryDefaultLoad { get; set; }

        /// <summary>
        /// Gets or sets used only for Stateful services. The default amount of
        /// load, as a number, that this service creates for this metric when
        /// it is a Secondary replica.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryDefaultLoad")]
        public int? SecondaryDefaultLoad { get; set; }

        /// <summary>
        /// Gets or sets used only for Stateless services. The default amount
        /// of load, as a number, that this service creates for this metric.
        /// </summary>
        [JsonProperty(PropertyName = "defaultLoad")]
        public int? DefaultLoad { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}