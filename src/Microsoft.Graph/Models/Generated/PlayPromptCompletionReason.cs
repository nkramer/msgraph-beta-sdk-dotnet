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
    /// The enum PlayPromptCompletionReason.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PlayPromptCompletionReason
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Completed Successfully
        /// </summary>
        CompletedSuccessfully = 1,
	
        /// <summary>
        /// Media Operation Canceled
        /// </summary>
        MediaOperationCanceled = 2,
	
    }
}
