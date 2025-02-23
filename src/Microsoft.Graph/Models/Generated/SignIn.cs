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
    /// The type Sign In.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SignIn : Entity
    {
    
        /// <summary>
        /// Gets or sets alternate sign in name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alternateSignInName", Required = Newtonsoft.Json.Required.Default)]
        public string AlternateSignInName { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// App name displayed in the Azure Portal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// Unique GUID representing the app ID in the Azure Active Directory.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets applied conditional access policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliedConditionalAccessPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets authentication details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationDetails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AuthenticationDetail> AuthenticationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication methods used.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethodsUsed", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AuthenticationMethodsUsed { get; set; }
    
        /// <summary>
        /// Gets or sets authentication processing details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationProcessingDetails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValue> AuthenticationProcessingDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication requirement policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationRequirementPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AuthenticationRequirementPolicy> AuthenticationRequirementPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets client app used.
        /// Identifies the legacy client used for sign-in activity.  Includes Browser, Exchange Active Sync, modern clients, IMAP, MAPI, SMTP, and POP.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientAppUsed", Required = Newtonsoft.Json.Required.Default)]
        public string ClientAppUsed { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access status.
        /// Reports status of an activated conditional access policy. Possible values are: success, failure, notApplied, and unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessStatus", Required = Newtonsoft.Json.Required.Default)]
        public ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "correlationId", Required = Newtonsoft.Json.Required.Default)]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device detail.
        /// Device information from where the sign-in occurred; includes device ID, operating system, and browser.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceDetail", Required = Newtonsoft.Json.Required.Default)]
        public DeviceDetail DeviceDetail { get; set; }
    
        /// <summary>
        /// Gets or sets is interactive.
        /// Indicates if a sign-in is interactive or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isInteractive", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsInteractive { get; set; }
    
        /// <summary>
        /// Gets or sets ip address.
        /// IP address of the client used to sign in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipAddress", Required = Newtonsoft.Json.Required.Default)]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// Provides the city, state, and country code where the sign-in originated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location", Required = Newtonsoft.Json.Required.Default)]
        public SignInLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets mfa detail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mfaDetail", Required = Newtonsoft.Json.Required.Default)]
        public MfaDetail MfaDetail { get; set; }
    
        /// <summary>
        /// Gets or sets network location details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkLocationDetails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<NetworkLocationDetail> NetworkLocationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets original request id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalRequestId", Required = Newtonsoft.Json.Required.Default)]
        public string OriginalRequestId { get; set; }
    
        /// <summary>
        /// Gets or sets processing time in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processingTimeInMilliseconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ProcessingTimeInMilliseconds { get; set; }
    
        /// <summary>
        /// Gets or sets risk detail.
        /// Provides the 'reason' behind a specific state of a risky user, sign-in or a risk event. The possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far. Note: Details for this property require an Azure AD Premium P2 license. Other licenses return the value hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskDetail", Required = Newtonsoft.Json.Required.Default)]
        public RiskDetail? RiskDetail { get; set; }
    
        /// <summary>
        /// Gets or sets risk event types.
        /// Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskEventTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RiskEventType> RiskEventTypes { get; set; }
    
        /// <summary>
        /// Gets or sets risk level aggregated.
        /// Aggregated risk level. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers will be returned hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskLevelAggregated", Required = Newtonsoft.Json.Required.Default)]
        public RiskLevel? RiskLevelAggregated { get; set; }
    
        /// <summary>
        /// Gets or sets risk level during sign in.
        /// Risk level during sign-in. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers will be returned hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskLevelDuringSignIn", Required = Newtonsoft.Json.Required.Default)]
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets risk state.
        /// Reports status of the risky user, sign-in, or a risk event. The possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskState", Required = Newtonsoft.Json.Required.Default)]
        public RiskState? RiskState { get; set; }
    
        /// <summary>
        /// Gets or sets resource display name.
        /// Name of the resource the user signed into.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// ID of the resource that the user signed into.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceId", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets service principal id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePrincipalId", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets service principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Sign-in status. Possible values include Success and Failure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public SignInStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenIssuerName", Required = Newtonsoft.Json.Required.Default)]
        public string TokenIssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenIssuerType", Required = Newtonsoft.Json.Required.Default)]
        public TokenIssuerType? TokenIssuerType { get; set; }
    
        /// <summary>
        /// Gets or sets user agent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAgent", Required = Newtonsoft.Json.Required.Default)]
        public string UserAgent { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// Display name of the user that initiated the sign-in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// ID of the user that initiated the sign-in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principal name of the user that initiated the sign-in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
    }
}

