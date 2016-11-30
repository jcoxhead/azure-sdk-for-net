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
    /// The VnetGateway contract. This is used to give the vnet gateway access
    /// to the VPN package.
    /// </summary>
    [JsonTransformation]
    public partial class VnetGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VnetGateway class.
        /// </summary>
        public VnetGateway() { }

        /// <summary>
        /// Initializes a new instance of the VnetGateway class.
        /// </summary>
        public VnetGateway(String name, String location, String id = default(String), String kind = default(String), String type = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), string vnetName = default(string), string vpnPackageUri = default(string))
            : base(name, location, id, kind, type, tags)
        {
            VnetName = vnetName;
            VpnPackageUri = vpnPackageUri;
        }

        /// <summary>
        /// The VNET name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// The URI where the Vpn package can be downloaded
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnPackageUri")]
        public string VpnPackageUri { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
