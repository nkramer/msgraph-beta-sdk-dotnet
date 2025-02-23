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
    /// The type Android General Device Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidGeneralDeviceConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets apps block clipboard sharing.
        /// Indicates whether or not to block clipboard sharing to copy and paste between applications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsBlockClipboardSharing", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppsBlockClipboardSharing { get; set; }
    
        /// <summary>
        /// Gets or sets apps block copy paste.
        /// Indicates whether or not to block copy and paste within applications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsBlockCopyPaste", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppsBlockCopyPaste { get; set; }
    
        /// <summary>
        /// Gets or sets apps block you tube.
        /// Indicates whether or not to block the YouTube app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsBlockYouTube", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppsBlockYouTube { get; set; }
    
        /// <summary>
        /// Gets or sets bluetooth blocked.
        /// Indicates whether or not to block Bluetooth.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bluetoothBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? BluetoothBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets camera blocked.
        /// Indicates whether or not to block the use of the camera.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cameraBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? CameraBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets cellular block data roaming.
        /// Indicates whether or not to block data roaming.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellularBlockDataRoaming", Required = Newtonsoft.Json.Required.Default)]
        public bool? CellularBlockDataRoaming { get; set; }
    
        /// <summary>
        /// Gets or sets cellular block messaging.
        /// Indicates whether or not to block SMS/MMS messaging.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellularBlockMessaging", Required = Newtonsoft.Json.Required.Default)]
        public bool? CellularBlockMessaging { get; set; }
    
        /// <summary>
        /// Gets or sets cellular block voice roaming.
        /// Indicates whether or not to block voice roaming.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellularBlockVoiceRoaming", Required = Newtonsoft.Json.Required.Default)]
        public bool? CellularBlockVoiceRoaming { get; set; }
    
        /// <summary>
        /// Gets or sets cellular block wi fi tethering.
        /// Indicates whether or not to block syncing Wi-Fi tethering.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellularBlockWiFiTethering", Required = Newtonsoft.Json.Required.Default)]
        public bool? CellularBlockWiFiTethering { get; set; }
    
        /// <summary>
        /// Gets or sets compliant apps list.
        /// List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppsList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> CompliantAppsList { get; set; }
    
        /// <summary>
        /// Gets or sets compliant app list type.
        /// Type of list that is in the CompliantAppsList. Possible values are: none, appsInListCompliant, appsNotInListCompliant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppListType", Required = Newtonsoft.Json.Required.Default)]
        public AppListType? CompliantAppListType { get; set; }
    
        /// <summary>
        /// Gets or sets diagnostic data block submission.
        /// Indicates whether or not to block diagnostic data submission.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "diagnosticDataBlockSubmission", Required = Newtonsoft.Json.Required.Default)]
        public bool? DiagnosticDataBlockSubmission { get; set; }
    
        /// <summary>
        /// Gets or sets location services blocked.
        /// Indicates whether or not to block location services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locationServicesBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? LocationServicesBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets google account block auto sync.
        /// Indicates whether or not to block Google account auto sync.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "googleAccountBlockAutoSync", Required = Newtonsoft.Json.Required.Default)]
        public bool? GoogleAccountBlockAutoSync { get; set; }
    
        /// <summary>
        /// Gets or sets google play store blocked.
        /// Indicates whether or not to block the Google Play store.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "googlePlayStoreBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? GooglePlayStoreBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk mode block sleep button.
        /// Indicates whether or not to block the screen sleep button while in Kiosk Mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskModeBlockSleepButton", Required = Newtonsoft.Json.Required.Default)]
        public bool? KioskModeBlockSleepButton { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk mode block volume buttons.
        /// Indicates whether or not to block the volume buttons while in Kiosk Mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskModeBlockVolumeButtons", Required = Newtonsoft.Json.Required.Default)]
        public bool? KioskModeBlockVolumeButtons { get; set; }
    
        /// <summary>
        /// Gets or sets date and time block changes.
        /// Indicates whether or not to block changing date and time while in KNOX Mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dateAndTimeBlockChanges", Required = Newtonsoft.Json.Required.Default)]
        public bool? DateAndTimeBlockChanges { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk mode apps.
        /// A list of apps that will be allowed to run when the device is in Kiosk Mode. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskModeApps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> KioskModeApps { get; set; }
    
        /// <summary>
        /// Gets or sets nfc blocked.
        /// Indicates whether or not to block Near-Field Communication.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nfcBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? NfcBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets password block fingerprint unlock.
        /// Indicates whether or not to block fingerprint unlock.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockFingerprintUnlock", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockFingerprintUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets password block trust agents.
        /// Indicates whether or not to block Smart Lock and other trust agents.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockTrustAgents", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockTrustAgents { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires. Valid values 1 to 365
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum length of passwords. Valid values 4 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// Minutes of inactivity before the screen times out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block. Valid values 0 to 24
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// Number of sign in failures allowed before factory reset. Valid values 1 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordSignInFailureCountBeforeFactoryReset", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Type of password that is required. Possible values are: deviceDefault, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, numeric, numericComplex, any.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidRequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Indicates whether or not to require a password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets power off blocked.
        /// Indicates whether or not to block powering off the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "powerOffBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? PowerOffBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets factory reset blocked.
        /// Indicates whether or not to block user performing a factory reset.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "factoryResetBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? FactoryResetBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// Indicates whether or not to block screenshots.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenCaptureBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets device sharing allowed.
        /// Indicates whether or not to allow device sharing mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceSharingAllowed", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceSharingAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets storage block google backup.
        /// Indicates whether or not to block Google Backup.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageBlockGoogleBackup", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageBlockGoogleBackup { get; set; }
    
        /// <summary>
        /// Gets or sets storage block removable storage.
        /// Indicates whether or not to block removable storage usage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageBlockRemovableStorage", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageBlockRemovableStorage { get; set; }
    
        /// <summary>
        /// Gets or sets storage require device encryption.
        /// Indicates whether or not to require device encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireDeviceEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireDeviceEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets storage require removable storage encryption.
        /// Indicates whether or not to require removable storage encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireRemovableStorageEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireRemovableStorageEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets voice assistant blocked.
        /// Indicates whether or not to block the use of the Voice Assistant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "voiceAssistantBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? VoiceAssistantBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets voice dialing blocked.
        /// Indicates whether or not to block voice dialing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "voiceDialingBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? VoiceDialingBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets web browser block popups.
        /// Indicates whether or not to block popups within the web browser.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webBrowserBlockPopups", Required = Newtonsoft.Json.Required.Default)]
        public bool? WebBrowserBlockPopups { get; set; }
    
        /// <summary>
        /// Gets or sets web browser block autofill.
        /// Indicates whether or not to block the web browser's auto fill feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webBrowserBlockAutofill", Required = Newtonsoft.Json.Required.Default)]
        public bool? WebBrowserBlockAutofill { get; set; }
    
        /// <summary>
        /// Gets or sets web browser block java script.
        /// Indicates whether or not to block JavaScript within the web browser.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webBrowserBlockJavaScript", Required = Newtonsoft.Json.Required.Default)]
        public bool? WebBrowserBlockJavaScript { get; set; }
    
        /// <summary>
        /// Gets or sets web browser blocked.
        /// Indicates whether or not to block the web browser.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webBrowserBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? WebBrowserBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets web browser cookie settings.
        /// Cookie settings within the web browser. Possible values are: browserDefault, blockAlways, allowCurrentWebSite, allowFromWebsitesVisited, allowAlways.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webBrowserCookieSettings", Required = Newtonsoft.Json.Required.Default)]
        public WebBrowserCookieSettings? WebBrowserCookieSettings { get; set; }
    
        /// <summary>
        /// Gets or sets wi fi blocked.
        /// Indicates whether or not to block syncing Wi-Fi.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wiFiBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? WiFiBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets apps install allow list.
        /// List of apps which can be installed on the KNOX device. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsInstallAllowList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> AppsInstallAllowList { get; set; }
    
        /// <summary>
        /// Gets or sets apps launch block list.
        /// List of apps which are blocked from being launched on the KNOX device. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsLaunchBlockList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> AppsLaunchBlockList { get; set; }
    
        /// <summary>
        /// Gets or sets apps hide list.
        /// List of apps to be hidden on the KNOX device. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsHideList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> AppsHideList { get; set; }
    
        /// <summary>
        /// Gets or sets security require verify apps.
        /// Require the Android Verify apps feature is turned on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireVerifyApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireVerifyApps { get; set; }
    
    }
}

