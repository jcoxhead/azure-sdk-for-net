// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> A cognitive service resource provisioned with a key that is attached to a skillset. </summary>
    public partial class CognitiveServicesAccountKey : CognitiveServicesAccount
    {
        /// <summary> Initializes a new instance of CognitiveServicesAccountKey. </summary>
        /// <param name="key"> The key used to provision the cognitive service resource attached to a skillset. </param>
        public CognitiveServicesAccountKey(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Key = key;
            ODataType = "#Microsoft.Azure.Search.CognitiveServicesByKey";
        }

        /// <summary> Initializes a new instance of CognitiveServicesAccountKey. </summary>
        /// <param name="key"> The key used to provision the cognitive service resource attached to a skillset. </param>
        /// <param name="oDataType"> Identifies the concrete type of the cognitive service resource attached to a skillset. </param>
        /// <param name="description"> Description of the cognitive service resource attached to a skillset. </param>
        internal CognitiveServicesAccountKey(string key, string oDataType, string description) : base(oDataType, description)
        {
            Key = key;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.CognitiveServicesByKey";
        }

        /// <summary> The key used to provision the cognitive service resource attached to a skillset. </summary>
        public string Key { get; }
    }
}
