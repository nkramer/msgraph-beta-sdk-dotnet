// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum VpnAuthenticationMethod.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum VpnAuthenticationMethod
    {
    
        /// <summary>
        /// Certificate
        /// </summary>
        Certificate = 0,
	
        /// <summary>
        /// Username And Password
        /// </summary>
        UsernameAndPassword = 1,
	
        /// <summary>
        /// Derived Credential
        /// </summary>
        DerivedCredential = 3,
	
    }
}
