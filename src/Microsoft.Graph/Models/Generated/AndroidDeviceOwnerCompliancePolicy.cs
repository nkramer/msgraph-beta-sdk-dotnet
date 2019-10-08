// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Android Device Owner Compliance Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidDeviceOwnerCompliancePolicy : DeviceCompliancePolicy
    {
    
        /// <summary>
        /// Gets or sets device threat protection enabled.
        /// Require that devices have enabled device threat protection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceThreatProtectionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection required security level.
        /// Require Mobile Threat Protection minimum risk level to report noncompliance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionRequiredSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets security require safety net attestation basic integrity.
        /// Require the device to pass the SafetyNet basic integrity check.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireSafetyNetAttestationBasicIntegrity", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity { get; set; }
    
        /// <summary>
        /// Gets or sets security require safety net attestation certified device.
        /// Require the device to pass the SafetyNet certified device check.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireSafetyNetAttestationCertifiedDevice", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum Android version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMinimumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum Android version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMaximumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets min android security patch level.
        /// Minimum Android security patch level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minAndroidSecurityPatchLevel", Required = Newtonsoft.Json.Required.Default)]
        public string MinAndroidSecurityPatchLevel { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Require a password to unlock device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum password length. Valid values 4 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum letter characters.
        /// Indicates the minimum number of letter characters required for device password. Valid values 1 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLetterCharacters", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLetterCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum lower case characters.
        /// Indicates the minimum number of lower case characters required for device password. Valid values 1 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLowerCaseCharacters", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLowerCaseCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum non letter characters.
        /// Indicates the minimum number of non-letter characters required for device password. Valid values 1 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumNonLetterCharacters", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumNonLetterCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum numeric characters.
        /// Indicates the minimum number of numeric characters required for device password. Valid values 1 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumNumericCharacters", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumNumericCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum symbol characters.
        /// Indicates the minimum number of symbol characters required for device password. Valid values 1 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumSymbolCharacters", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumSymbolCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum upper case characters.
        /// Indicates the minimum number of upper case letter characters required for device password. Valid values 1 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumUpperCaseCharacters", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumUpperCaseCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Type of characters in password
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity before a password is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires. Valid values 1 to 365
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password count to block.
        /// Number of previous passwords to block. Valid values 1 to 24
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordCountToBlock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordCountToBlock { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Require encryption on Android devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireEncryption { get; set; }
    
    }
}

