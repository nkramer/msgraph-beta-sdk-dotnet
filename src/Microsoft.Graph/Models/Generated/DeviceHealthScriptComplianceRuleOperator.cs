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
    /// The enum DeviceHealthScriptComplianceRuleOperator.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeviceHealthScriptComplianceRuleOperator
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Equal
        /// </summary>
        Equal = 1,
	
        /// <summary>
        /// Not Equal
        /// </summary>
        NotEqual = 2,
	
    }
}
