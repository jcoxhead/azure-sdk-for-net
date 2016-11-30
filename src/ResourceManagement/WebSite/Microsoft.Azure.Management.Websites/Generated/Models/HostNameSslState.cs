// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Object that represents a SSL-enabled host name.
    /// </summary>
    public partial class HostNameSslState
    {
        /// <summary>
        /// Initializes a new instance of the HostNameSslState class.
        /// </summary>
        public HostNameSslState() { }

        /// <summary>
        /// Initializes a new instance of the HostNameSslState class.
        /// </summary>
        public HostNameSslState(SslState sslState, string name = default(string), string virtualIP = default(string), string thumbprint = default(string), bool? toUpdate = default(bool?))
        {
            Name = name;
            SslState = sslState;
            VirtualIP = virtualIP;
            Thumbprint = thumbprint;
            ToUpdate = toUpdate;
        }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// SSL type. Possible values include: 'Disabled', 'SniEnabled',
        /// 'IpBasedEnabled'
        /// </summary>
        [JsonProperty(PropertyName = "sslState")]
        public SslState SslState { get; set; }

        /// <summary>
        /// Virtual IP address assigned to the host name if IP based SSL is
        /// enabled
        /// </summary>
        [JsonProperty(PropertyName = "virtualIP")]
        public string VirtualIP { get; set; }

        /// <summary>
        /// SSL cert thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Set this flag to update existing host name
        /// </summary>
        [JsonProperty(PropertyName = "toUpdate")]
        public bool? ToUpdate { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
