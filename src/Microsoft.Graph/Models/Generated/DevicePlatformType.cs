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
    /// The enum DevicePlatformType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DevicePlatformType
    {
    
        /// <summary>
        /// Android
        /// </summary>
        Android = 0,
	
        /// <summary>
        /// Android For Work
        /// </summary>
        AndroidForWork = 1,
	
        /// <summary>
        /// IOS
        /// </summary>
        IOS = 2,
	
        /// <summary>
        /// Mac OS
        /// </summary>
        MacOS = 3,
	
        /// <summary>
        /// Windows Phone81
        /// </summary>
        WindowsPhone81 = 4,
	
        /// <summary>
        /// Windows81And Later
        /// </summary>
        Windows81AndLater = 5,
	
        /// <summary>
        /// Windows10And Later
        /// </summary>
        Windows10AndLater = 6,
	
        /// <summary>
        /// Android Work Profile
        /// </summary>
        AndroidWorkProfile = 7,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 8,
	
    }
}
