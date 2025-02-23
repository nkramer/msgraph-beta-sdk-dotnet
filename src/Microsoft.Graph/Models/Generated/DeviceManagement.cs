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
    /// The type Device Management.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagement : Entity
    {
    
        /// <summary>
        /// Gets or sets settings.
        /// Account level settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets maximum dep tokens.
        /// Maximum number of dep tokens allowed per-tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumDepTokens", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaximumDepTokens { get; set; }
    
        /// <summary>
        /// Gets or sets intune account id.
        /// Intune Account Id for given tenant
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intuneAccountId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? IntuneAccountId { get; set; }
    
        /// <summary>
        /// Gets or sets last report aggregation date time.
        /// The last modified time of reporting for this account. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastReportAggregationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastReportAggregationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance report summarization date time.
        /// The last requested time of device compliance reporting for this account. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceComplianceReportSummarizationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DeviceComplianceReportSummarizationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets legacy pc manangement enabled.
        /// The property to enable Non-MDM managed legacy PC management for this account. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "legacyPcManangementEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? LegacyPcManangementEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets intune brand.
        /// intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intuneBrand", Required = Newtonsoft.Json.Required.Default)]
        public IntuneBrand IntuneBrand { get; set; }
    
        /// <summary>
        /// Gets or sets subscription state.
        /// Tenant mobile device management subscription state. The possible values are: pending, active, warning, disabled, deleted, blocked, lockedOut.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptionState", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSubscriptionState? SubscriptionState { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptions.
        /// Tenant's Subscription.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptions", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSubscriptions? Subscriptions { get; set; }
    
        /// <summary>
        /// Gets or sets managed device cleanup settings.
        /// Device cleanup rule
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceCleanupSettings", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceCleanupSettings ManagedDeviceCleanupSettings { get; set; }
    
        /// <summary>
        /// Gets or sets admin consent.
        /// Admin consent information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "adminConsent", Required = Newtonsoft.Json.Required.Default)]
        public AdminConsent AdminConsent { get; set; }
    
        /// <summary>
        /// Gets or sets device protection overview.
        /// Device protection overview.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceProtectionOverview", Required = Newtonsoft.Json.Required.Default)]
        public DeviceProtectionOverview DeviceProtectionOverview { get; set; }
    
        /// <summary>
        /// Gets or sets windows malware overview.
        /// Malware overview for windows devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsMalwareOverview", Required = Newtonsoft.Json.Required.Default)]
        public WindowsMalwareOverview WindowsMalwareOverview { get; set; }
    
        /// <summary>
        /// Gets or sets account move completion date time.
        /// The date &amp; time when tenant data moved between scaleunits.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountMoveCompletionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AccountMoveCompletionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets audit events.
        /// The Audit Events
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auditEvents", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementAuditEventsCollectionPage AuditEvents { get; set; }
    
        /// <summary>
        /// Gets or sets android for work settings.
        /// The singleton Android for Work settings entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidForWorkSettings", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkSettings AndroidForWorkSettings { get; set; }
    
        /// <summary>
        /// Gets or sets android for work app configuration schemas.
        /// Android for Work app configuration schema entities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidForWorkAppConfigurationSchemas", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementAndroidForWorkAppConfigurationSchemasCollectionPage AndroidForWorkAppConfigurationSchemas { get; set; }
    
        /// <summary>
        /// Gets or sets android for work enrollment profiles.
        /// Android for Work enrollment profile entities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidForWorkEnrollmentProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionPage AndroidForWorkEnrollmentProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets android managed store account enterprise settings.
        /// The singleton Android managed store account enterprise settings entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidManagedStoreAccountEnterpriseSettings", Required = Newtonsoft.Json.Required.Default)]
        public AndroidManagedStoreAccountEnterpriseSettings AndroidManagedStoreAccountEnterpriseSettings { get; set; }
    
        /// <summary>
        /// Gets or sets android managed store app configuration schemas.
        /// Android Enterprise app configuration schema entities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidManagedStoreAppConfigurationSchemas", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementAndroidManagedStoreAppConfigurationSchemasCollectionPage AndroidManagedStoreAppConfigurationSchemas { get; set; }
    
        /// <summary>
        /// Gets or sets android device owner enrollment profiles.
        /// Android device owner enrollment profile entities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidDeviceOwnerEnrollmentProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementAndroidDeviceOwnerEnrollmentProfilesCollectionPage AndroidDeviceOwnerEnrollmentProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets terms and conditions.
        /// The terms and conditions associated with device management of the company.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsAndConditions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTermsAndConditionsCollectionPage TermsAndConditions { get; set; }
    
        /// <summary>
        /// Gets or sets device configurations.
        /// The device configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceConfigurationsCollectionPage DeviceConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policies.
        /// The device compliance policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCompliancePoliciesCollectionPage DeviceCompliancePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets software update status summary.
        /// The software update status summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "softwareUpdateStatusSummary", Required = Newtonsoft.Json.Required.Default)]
        public SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy device state summary.
        /// The device compliance state summary for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicyDeviceStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy setting state summaries.
        /// The summary states of compliance policy settings for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicySettingStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCompliancePolicySettingStateSummariesCollectionPage DeviceCompliancePolicySettingStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection onboarding state summary.
        /// The summary state of ATP onboarding state for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionOnboardingStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public AdvancedThreatProtectionOnboardingStateSummary AdvancedThreatProtectionOnboardingStateSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration device state summaries.
        /// The device configuration device state summary for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationDeviceStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration user state summaries.
        /// The device configuration user state summary for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationUserStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public DeviceConfigurationUserStateSummary DeviceConfigurationUserStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets cart to class associations.
        /// The Cart To Class Associations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cartToClassAssociations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementCartToClassAssociationsCollectionPage CartToClassAssociations { get; set; }
    
        /// <summary>
        /// Gets or sets ios update statuses.
        /// The IOS software update installation statuses for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosUpdateStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIosUpdateStatusesCollectionPage IosUpdateStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets ndes connectors.
        /// The collection of Ndes connectors for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ndesConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementNdesConnectorsCollectionPage NdesConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration restricted apps violations.
        /// Restricted apps violations for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationRestrictedAppsViolations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionPage DeviceConfigurationRestrictedAppsViolations { get; set; }
    
        /// <summary>
        /// Gets or sets managed device encryption states.
        /// Encryption report for devices in this account
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceEncryptionStates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementManagedDeviceEncryptionStatesCollectionPage ManagedDeviceEncryptionStates { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration conflict summary.
        /// Summary of policies in conflict state for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationConflictSummary", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceConfigurationConflictSummaryCollectionPage DeviceConfigurationConflictSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device configurations all managed device certificate states.
        /// Summary of all certificates for all devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationsAllManagedDeviceCertificateStates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceConfigurationsAllManagedDeviceCertificateStatesCollectionPage DeviceConfigurationsAllManagedDeviceCertificateStates { get; set; }
    
        /// <summary>
        /// Gets or sets device categories.
        /// The list of device categories with the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCategories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCategoriesCollectionPage DeviceCategories { get; set; }
    
        /// <summary>
        /// Gets or sets exchange connectors.
        /// The list of Exchange Connectors configured by the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementExchangeConnectorsCollectionPage ExchangeConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets device enrollment configurations.
        /// The list of device enrollment configurations
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceEnrollmentConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceEnrollmentConfigurationsCollectionPage DeviceEnrollmentConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets exchange on premises policy.
        /// The policy which controls mobile device access to Exchange On Premises
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeOnPremisesPolicy", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementExchangeOnPremisesPolicy ExchangeOnPremisesPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets exchange on premises policies.
        /// The list of Exchange On Premisis policies configured by the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeOnPremisesPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementExchangeOnPremisesPoliciesCollectionPage ExchangeOnPremisesPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access settings.
        /// The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessSettings", Required = Newtonsoft.Json.Required.Default)]
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
    
        /// <summary>
        /// Gets or sets mobile threat defense connectors.
        /// The list of Mobile threat Defense connectors configured by the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileThreatDefenseConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementMobileThreatDefenseConnectorsCollectionPage MobileThreatDefenseConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets device management partners.
        /// The list of Device Management Partners configured by the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManagementPartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceManagementPartnersCollectionPage DeviceManagementPartners { get; set; }
    
        /// <summary>
        /// Gets or sets intents.
        /// The device management intents
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intents", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIntentsCollectionPage Intents { get; set; }
    
        /// <summary>
        /// Gets or sets setting definitions.
        /// The device management intent setting definitions
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementSettingDefinitionsCollectionPage SettingDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets templates.
        /// The available templates
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "templates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTemplatesCollectionPage Templates { get; set; }
    
        /// <summary>
        /// Gets or sets categories.
        /// The available categories
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "categories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementCategoriesCollectionPage Categories { get; set; }
    
        /// <summary>
        /// Gets or sets remote action audits.
        /// The list of device remote action audits with the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteActionAudits", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRemoteActionAuditsCollectionPage RemoteActionAudits { get; set; }
    
        /// <summary>
        /// Gets or sets apple push notification certificate.
        /// Apple push notification certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applePushNotificationCertificate", Required = Newtonsoft.Json.Required.Default)]
        public ApplePushNotificationCertificate ApplePushNotificationCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets device management scripts.
        /// The list of device management scripts associated with the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManagementScripts", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceManagementScriptsCollectionPage DeviceManagementScripts { get; set; }
    
        /// <summary>
        /// Gets or sets managed device overview.
        /// Device overview
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceOverview", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceOverview ManagedDeviceOverview { get; set; }
    
        /// <summary>
        /// Gets or sets detected apps.
        /// The list of detected apps associated with a device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectedApps", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDetectedAppsCollectionPage DetectedApps { get; set; }
    
        /// <summary>
        /// Gets or sets managed devices.
        /// The list of managed devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDevices", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementManagedDevicesCollectionPage ManagedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets windows malware information.
        /// The list of affected malware in the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsMalwareInformation", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsMalwareInformationCollectionPage WindowsMalwareInformation { get; set; }
    
        /// <summary>
        /// Gets or sets data sharing consents.
        /// Data sharing consents.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataSharingConsents", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDataSharingConsentsCollectionPage DataSharingConsents { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app troubleshooting events.
        /// The collection property of MobileAppTroubleshootingEvent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileAppTroubleshootingEvents", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementMobileAppTroubleshootingEventsCollectionPage MobileAppTroubleshootingEvents { get; set; }
    
        /// <summary>
        /// Gets or sets user experience analytics overview.
        /// User experience analytics overview
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userExperienceAnalyticsOverview", Required = Newtonsoft.Json.Required.Default)]
        public UserExperienceAnalyticsOverview UserExperienceAnalyticsOverview { get; set; }
    
        /// <summary>
        /// Gets or sets user experience analytics baselines.
        /// User experience analytics baselines
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userExperienceAnalyticsBaselines", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementUserExperienceAnalyticsBaselinesCollectionPage UserExperienceAnalyticsBaselines { get; set; }
    
        /// <summary>
        /// Gets or sets user experience analytics categories.
        /// User experience analytics categories
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userExperienceAnalyticsCategories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementUserExperienceAnalyticsCategoriesCollectionPage UserExperienceAnalyticsCategories { get; set; }
    
        /// <summary>
        /// Gets or sets derived credentials.
        /// Collection of Derived credential settings associated with account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "derivedCredentials", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDerivedCredentialsCollectionPage DerivedCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets windows autopilot settings.
        /// The Windows autopilot account settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsAutopilotSettings", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotSettings WindowsAutopilotSettings { get; set; }
    
        /// <summary>
        /// Gets or sets windows autopilot device identities.
        /// The Windows autopilot device identities contained collection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsAutopilotDeviceIdentities", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsAutopilotDeviceIdentitiesCollectionPage WindowsAutopilotDeviceIdentities { get; set; }
    
        /// <summary>
        /// Gets or sets windows autopilot deployment profiles.
        /// Windows auto pilot deployment profiles
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsAutopilotDeploymentProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionPage WindowsAutopilotDeploymentProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets imported device identities.
        /// The imported device identities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importedDeviceIdentities", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementImportedDeviceIdentitiesCollectionPage ImportedDeviceIdentities { get; set; }
    
        /// <summary>
        /// Gets or sets dep onboarding settings.
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "depOnboardingSettings", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDepOnboardingSettingsCollectionPage DepOnboardingSettings { get; set; }
    
        /// <summary>
        /// Gets or sets imported windows autopilot device identities.
        /// Collection of imported Windows autopilot devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importedWindowsAutopilotDeviceIdentities", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionPage ImportedWindowsAutopilotDeviceIdentities { get; set; }
    
        /// <summary>
        /// Gets or sets management conditions.
        /// The management conditions associated with device management of the company.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementConditions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementManagementConditionsCollectionPage ManagementConditions { get; set; }
    
        /// <summary>
        /// Gets or sets management condition statements.
        /// The management condition statements associated with device management of the company.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementConditionStatements", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementManagementConditionStatementsCollectionPage ManagementConditionStatements { get; set; }
    
        /// <summary>
        /// Gets or sets group policy configurations.
        /// The group policy configurations created by this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementGroupPolicyConfigurationsCollectionPage GroupPolicyConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets group policy definitions.
        /// The available group policy definitions for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementGroupPolicyDefinitionsCollectionPage GroupPolicyDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets group policy definition files.
        /// The available group policy definition files for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyDefinitionFiles", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementGroupPolicyDefinitionFilesCollectionPage GroupPolicyDefinitionFiles { get; set; }
    
        /// <summary>
        /// Gets or sets notification message templates.
        /// The Notification Message Templates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationMessageTemplates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementNotificationMessageTemplatesCollectionPage NotificationMessageTemplates { get; set; }
    
        /// <summary>
        /// Gets or sets domain join connectors.
        /// A list of connector objects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainJoinConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDomainJoinConnectorsCollectionPage DomainJoinConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// The Role Definitions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleDefinitionsCollectionPage RoleDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets role assignments.
        /// The Role Assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleAssignmentsCollectionPage RoleAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tags.
        /// The Role Scope Tags.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTags", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleScopeTagsCollectionPage RoleScopeTags { get; set; }
    
        /// <summary>
        /// Gets or sets resource operations.
        /// The Resource Operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceOperations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementResourceOperationsCollectionPage ResourceOperations { get; set; }
    
        /// <summary>
        /// Gets or sets remote assistance partners.
        /// The remote assist partners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteAssistancePartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRemoteAssistancePartnersCollectionPage RemoteAssistancePartners { get; set; }
    
        /// <summary>
        /// Gets or sets telecom expense management partners.
        /// The telecom expense management partners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "telecomExpenseManagementPartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTelecomExpenseManagementPartnersCollectionPage TelecomExpenseManagementPartners { get; set; }
    
        /// <summary>
        /// Gets or sets embedded simactivation code pools.
        /// The embedded SIM activation code pools created by this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "embeddedSIMActivationCodePools", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementEmbeddedSIMActivationCodePoolsCollectionPage EmbeddedSIMActivationCodePools { get; set; }
    
        /// <summary>
        /// Gets or sets troubleshooting events.
        /// The list of troubleshooting events for the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "troubleshootingEvents", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTroubleshootingEventsCollectionPage TroubleshootingEvents { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection app learning summaries.
        /// The windows information protection app learning summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionAppLearningSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionPage WindowsInformationProtectionAppLearningSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection network learning summaries.
        /// The windows information protection network learning summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionNetworkLearningSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionPage WindowsInformationProtectionNetworkLearningSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets intune branding profiles.
        /// Intune branding profiles targeted to AAD groups
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intuneBrandingProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIntuneBrandingProfilesCollectionPage IntuneBrandingProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets user pfx certificates.
        /// Collection of PFX certificates associated with a user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPfxCertificates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementUserPfxCertificatesCollectionPage UserPfxCertificates { get; set; }
    
    }
}

