// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> Converts alphabetic, numeric, and symbolic Unicode characters which are not in the first 127 ASCII characters (the &quot;Basic Latin&quot; Unicode block) into their ASCII equivalents, if such equivalents exist. This token filter is implemented using Apache Lucene. </summary>
    public partial class AsciiFoldingTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of AsciiFoldingTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        public AsciiFoldingTokenFilter(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            ODataType = "#Microsoft.Azure.Search.AsciiFoldingTokenFilter";
        }

        /// <summary> Initializes a new instance of AsciiFoldingTokenFilter. </summary>
        /// <param name="preserveOriginal"> A value indicating whether the original token will be kept. Default is false. </param>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal AsciiFoldingTokenFilter(bool? preserveOriginal, string oDataType, string name) : base(oDataType, name)
        {
            PreserveOriginal = preserveOriginal;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.AsciiFoldingTokenFilter";
        }

        /// <summary> A value indicating whether the original token will be kept. Default is false. </summary>
        public bool? PreserveOriginal { get; set; }
    }
}
