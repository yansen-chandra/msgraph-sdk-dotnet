using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class Application : DirectoryObject, IParsable {
        /// <summary>Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its &apos;FileHandler&apos; functionality. This will let services like Office 365 call the application in the context of a document the user is working on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AddIn>? AddIns {
            get { return BackingStore?.Get<List<AddIn>?>("addIns"); }
            set { BackingStore?.Set("addIns", value); }
        }
#nullable restore
#else
        public List<AddIn> AddIns {
            get { return BackingStore?.Get<List<AddIn>>("addIns"); }
            set { BackingStore?.Set("addIns", value); }
        }
#endif
        /// <summary>Specifies settings for an application that implements a web API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiApplication? Api {
            get { return BackingStore?.Get<ApiApplication?>("api"); }
            set { BackingStore?.Set("api", value); }
        }
#nullable restore
#else
        public ApiApplication Api {
            get { return BackingStore?.Get<ApiApplication>("api"); }
            set { BackingStore?.Set("api", value); }
        }
#endif
        /// <summary>The unique identifier for the application that is assigned to an application by Azure AD. Not nullable. Read-only. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Unique identifier of the applicationTemplate. Supports $filter (eq, not, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationTemplateId {
            get { return BackingStore?.Get<string?>("applicationTemplateId"); }
            set { BackingStore?.Set("applicationTemplateId", value); }
        }
#nullable restore
#else
        public string ApplicationTemplateId {
            get { return BackingStore?.Get<string>("applicationTemplateId"); }
            set { BackingStore?.Set("applicationTemplateId", value); }
        }
#endif
        /// <summary>The appManagementPolicy applied to this application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppManagementPolicy>? AppManagementPolicies {
            get { return BackingStore?.Get<List<AppManagementPolicy>?>("appManagementPolicies"); }
            set { BackingStore?.Set("appManagementPolicies", value); }
        }
#nullable restore
#else
        public List<AppManagementPolicy> AppManagementPolicies {
            get { return BackingStore?.Get<List<AppManagementPolicy>>("appManagementPolicies"); }
            set { BackingStore?.Set("appManagementPolicies", value); }
        }
#endif
        /// <summary>The collection of roles defined for the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppRole>? AppRoles {
            get { return BackingStore?.Get<List<AppRole>?>("appRoles"); }
            set { BackingStore?.Set("appRoles", value); }
        }
#nullable restore
#else
        public List<AppRole> AppRoles {
            get { return BackingStore?.Get<List<AppRole>>("appRoles"); }
            set { BackingStore?.Set("appRoles", value); }
        }
#endif
        /// <summary>Specifies the certification status of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Certification? Certification {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Certification?>("certification"); }
            set { BackingStore?.Set("certification", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Certification Certification {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Certification>("certification"); }
            set { BackingStore?.Set("certification", value); }
        }
#endif
        /// <summary>The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.  Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderBy.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Supports $filter (/$count eq 0, /$count ne 0). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? CreatedOnBehalfOf {
            get { return BackingStore?.Get<DirectoryObject?>("createdOnBehalfOf"); }
            set { BackingStore?.Set("createdOnBehalfOf", value); }
        }
#nullable restore
#else
        public DirectoryObject CreatedOnBehalfOf {
            get { return BackingStore?.Get<DirectoryObject>("createdOnBehalfOf"); }
            set { BackingStore?.Set("createdOnBehalfOf", value); }
        }
#endif
        /// <summary>The defaultRedirectUri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultRedirectUri {
            get { return BackingStore?.Get<string?>("defaultRedirectUri"); }
            set { BackingStore?.Set("defaultRedirectUri", value); }
        }
#nullable restore
#else
        public string DefaultRedirectUri {
            get { return BackingStore?.Get<string>("defaultRedirectUri"); }
            set { BackingStore?.Set("defaultRedirectUri", value); }
        }
#endif
        /// <summary>Free text field to provide a description of the application object to end users. The maximum allowed size is 1024 characters. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisabledByMicrosoftStatus {
            get { return BackingStore?.Get<string?>("disabledByMicrosoftStatus"); }
            set { BackingStore?.Set("disabledByMicrosoftStatus", value); }
        }
#nullable restore
#else
        public string DisabledByMicrosoftStatus {
            get { return BackingStore?.Get<string>("disabledByMicrosoftStatus"); }
            set { BackingStore?.Set("disabledByMicrosoftStatus", value); }
        }
#endif
        /// <summary>The display name for the application. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExtensionProperty>? ExtensionProperties {
            get { return BackingStore?.Get<List<ExtensionProperty>?>("extensionProperties"); }
            set { BackingStore?.Set("extensionProperties", value); }
        }
#nullable restore
#else
        public List<ExtensionProperty> ExtensionProperties {
            get { return BackingStore?.Get<List<ExtensionProperty>>("extensionProperties"); }
            set { BackingStore?.Set("extensionProperties", value); }
        }
#endif
        /// <summary>Federated identities for applications. Supports $expand and $filter (startsWith, /$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FederatedIdentityCredential>? FederatedIdentityCredentials {
            get { return BackingStore?.Get<List<FederatedIdentityCredential>?>("federatedIdentityCredentials"); }
            set { BackingStore?.Set("federatedIdentityCredentials", value); }
        }
#nullable restore
#else
        public List<FederatedIdentityCredential> FederatedIdentityCredentials {
            get { return BackingStore?.Get<List<FederatedIdentityCredential>>("federatedIdentityCredentials"); }
            set { BackingStore?.Set("federatedIdentityCredentials", value); }
        }
#endif
        /// <summary>Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following valid string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all of the security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupMembershipClaims {
            get { return BackingStore?.Get<string?>("groupMembershipClaims"); }
            set { BackingStore?.Set("groupMembershipClaims", value); }
        }
#nullable restore
#else
        public string GroupMembershipClaims {
            get { return BackingStore?.Get<string>("groupMembershipClaims"); }
            set { BackingStore?.Set("groupMembershipClaims", value); }
        }
#endif
        /// <summary>The homeRealmDiscoveryPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HomeRealmDiscoveryPolicy>? HomeRealmDiscoveryPolicies {
            get { return BackingStore?.Get<List<HomeRealmDiscoveryPolicy>?>("homeRealmDiscoveryPolicies"); }
            set { BackingStore?.Set("homeRealmDiscoveryPolicies", value); }
        }
#nullable restore
#else
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies {
            get { return BackingStore?.Get<List<HomeRealmDiscoveryPolicy>>("homeRealmDiscoveryPolicies"); }
            set { BackingStore?.Set("homeRealmDiscoveryPolicies", value); }
        }
#endif
        /// <summary>Also known as App ID URI, this value is set when an application is used as a resource app. The identifierUris acts as the prefix for the scopes you&apos;ll reference in your API&apos;s code, and it must be globally unique. You can use the default value provided, which is in the form api://&lt;application-client-id&gt;, or specify a more readable URI like https://contoso.com/api. For more information on valid identifierUris patterns and best practices, see Azure AD application registration security best practices. Not nullable. Supports $filter (eq, ne, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IdentifierUris {
            get { return BackingStore?.Get<List<string>?>("identifierUris"); }
            set { BackingStore?.Set("identifierUris", value); }
        }
#nullable restore
#else
        public List<string> IdentifierUris {
            get { return BackingStore?.Get<List<string>>("identifierUris"); }
            set { BackingStore?.Set("identifierUris", value); }
        }
#endif
        /// <summary>Basic profile information of the application such as  app&apos;s marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Azure AD apps. Supports $filter (eq, ne, not, ge, le, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InformationalUrl? Info {
            get { return BackingStore?.Get<InformationalUrl?>("info"); }
            set { BackingStore?.Set("info", value); }
        }
#nullable restore
#else
        public InformationalUrl Info {
            get { return BackingStore?.Get<InformationalUrl>("info"); }
            set { BackingStore?.Set("info", value); }
        }
#endif
        /// <summary>Specifies whether this application supports device authentication without a user. The default is false.</summary>
        public bool? IsDeviceOnlyAuthSupported {
            get { return BackingStore?.Get<bool?>("isDeviceOnlyAuthSupported"); }
            set { BackingStore?.Set("isDeviceOnlyAuthSupported", value); }
        }
        /// <summary>Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where it is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.</summary>
        public bool? IsFallbackPublicClient {
            get { return BackingStore?.Get<bool?>("isFallbackPublicClient"); }
            set { BackingStore?.Set("isFallbackPublicClient", value); }
        }
        /// <summary>The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyCredential>? KeyCredentials {
            get { return BackingStore?.Get<List<KeyCredential>?>("keyCredentials"); }
            set { BackingStore?.Set("keyCredentials", value); }
        }
#nullable restore
#else
        public List<KeyCredential> KeyCredentials {
            get { return BackingStore?.Get<List<KeyCredential>>("keyCredentials"); }
            set { BackingStore?.Set("keyCredentials", value); }
        }
#endif
        /// <summary>The main logo for the application. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Logo {
            get { return BackingStore?.Get<byte[]?>("logo"); }
            set { BackingStore?.Set("logo", value); }
        }
#nullable restore
#else
        public byte[] Logo {
            get { return BackingStore?.Get<byte[]>("logo"); }
            set { BackingStore?.Set("logo", value); }
        }
#endif
        /// <summary>Notes relevant for the management of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes {
            get { return BackingStore?.Get<string?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public string Notes {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>The oauth2RequirePostResponse property</summary>
        public bool? Oauth2RequirePostResponse {
            get { return BackingStore?.Get<bool?>("oauth2RequirePostResponse"); }
            set { BackingStore?.Set("oauth2RequirePostResponse", value); }
        }
        /// <summary>Application developers can configure optional claims in their Azure AD applications to specify the claims that are sent to their application by the Microsoft security token service. For more information, see How to: Provide optional claims to your app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.OptionalClaims? OptionalClaims {
            get { return BackingStore?.Get<Microsoft.Graph.Models.OptionalClaims?>("optionalClaims"); }
            set { BackingStore?.Set("optionalClaims", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.OptionalClaims OptionalClaims {
            get { return BackingStore?.Get<Microsoft.Graph.Models.OptionalClaims>("optionalClaims"); }
            set { BackingStore?.Set("optionalClaims", value); }
        }
#endif
        /// <summary>Directory objects that are owners of the application. Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? Owners {
            get { return BackingStore?.Get<List<DirectoryObject>?>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> Owners {
            get { return BackingStore?.Get<List<DirectoryObject>>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
#endif
        /// <summary>Specifies parental control settings for an application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ParentalControlSettings? ParentalControlSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ParentalControlSettings?>("parentalControlSettings"); }
            set { BackingStore?.Set("parentalControlSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ParentalControlSettings ParentalControlSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ParentalControlSettings>("parentalControlSettings"); }
            set { BackingStore?.Set("parentalControlSettings", value); }
        }
#endif
        /// <summary>The collection of password credentials associated with the application. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PasswordCredential>? PasswordCredentials {
            get { return BackingStore?.Get<List<PasswordCredential>?>("passwordCredentials"); }
            set { BackingStore?.Set("passwordCredentials", value); }
        }
#nullable restore
#else
        public List<PasswordCredential> PasswordCredentials {
            get { return BackingStore?.Get<List<PasswordCredential>>("passwordCredentials"); }
            set { BackingStore?.Set("passwordCredentials", value); }
        }
#endif
        /// <summary>Specifies settings for installed clients such as desktop or mobile devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicClientApplication? PublicClient {
            get { return BackingStore?.Get<PublicClientApplication?>("publicClient"); }
            set { BackingStore?.Set("publicClient", value); }
        }
#nullable restore
#else
        public PublicClientApplication PublicClient {
            get { return BackingStore?.Get<PublicClientApplication>("publicClient"); }
            set { BackingStore?.Set("publicClient", value); }
        }
#endif
        /// <summary>The verified publisher domain for the application. Read-only. For more information, see How to: Configure an application&apos;s publisher domain. Supports $filter (eq, ne, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublisherDomain {
            get { return BackingStore?.Get<string?>("publisherDomain"); }
            set { BackingStore?.Set("publisherDomain", value); }
        }
#nullable restore
#else
        public string PublisherDomain {
            get { return BackingStore?.Get<string>("publisherDomain"); }
            set { BackingStore?.Set("publisherDomain", value); }
        }
#endif
        /// <summary>Specifies whether this application requires Azure AD to verify the signed authentication requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.RequestSignatureVerification? RequestSignatureVerification {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RequestSignatureVerification?>("requestSignatureVerification"); }
            set { BackingStore?.Set("requestSignatureVerification", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.RequestSignatureVerification RequestSignatureVerification {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RequestSignatureVerification>("requestSignatureVerification"); }
            set { BackingStore?.Set("requestSignatureVerification", value); }
        }
#endif
        /// <summary>Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. For more information, see Limits on requested permissions per app. Not nullable. Supports $filter (eq, not, ge, le).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.RequiredResourceAccess>? RequiredResourceAccess {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RequiredResourceAccess>?>("requiredResourceAccess"); }
            set { BackingStore?.Set("requiredResourceAccess", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.RequiredResourceAccess> RequiredResourceAccess {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RequiredResourceAccess>>("requiredResourceAccess"); }
            set { BackingStore?.Set("requiredResourceAccess", value); }
        }
#endif
        /// <summary>The URL where the service exposes SAML metadata for federation. This property is valid only for single-tenant applications. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SamlMetadataUrl {
            get { return BackingStore?.Get<string?>("samlMetadataUrl"); }
            set { BackingStore?.Set("samlMetadataUrl", value); }
        }
#nullable restore
#else
        public string SamlMetadataUrl {
            get { return BackingStore?.Get<string>("samlMetadataUrl"); }
            set { BackingStore?.Set("samlMetadataUrl", value); }
        }
#endif
        /// <summary>References application or service contact information from a Service or Asset Management database. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceManagementReference {
            get { return BackingStore?.Get<string?>("serviceManagementReference"); }
            set { BackingStore?.Set("serviceManagementReference", value); }
        }
#nullable restore
#else
        public string ServiceManagementReference {
            get { return BackingStore?.Get<string>("serviceManagementReference"); }
            set { BackingStore?.Set("serviceManagementReference", value); }
        }
#endif
        /// <summary>Specifies the Microsoft accounts that are supported for the current application. The possible values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount (default), and PersonalMicrosoftAccount. See more in the table. The value of this object also limits the number of permissions an app can request. For more information, see Limits on requested permissions per app. The value for this property has implications on other app object properties. As a result, if you change this property, you may need to change other properties first. For more information, see Validation differences for signInAudience.Supports $filter (eq, ne, not).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignInAudience {
            get { return BackingStore?.Get<string?>("signInAudience"); }
            set { BackingStore?.Set("signInAudience", value); }
        }
#nullable restore
#else
        public string SignInAudience {
            get { return BackingStore?.Get<string>("signInAudience"); }
            set { BackingStore?.Set("signInAudience", value); }
        }
#endif
        /// <summary>Specifies settings for a single-page application, including sign out URLs and redirect URIs for authorization codes and access tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SpaApplication? Spa {
            get { return BackingStore?.Get<SpaApplication?>("spa"); }
            set { BackingStore?.Set("spa", value); }
        }
#nullable restore
#else
        public SpaApplication Spa {
            get { return BackingStore?.Get<SpaApplication>("spa"); }
            set { BackingStore?.Set("spa", value); }
        }
#endif
        /// <summary>Custom strings that can be used to categorize and identify the application. Not nullable. Strings added here will also appear in the tags property of any associated service principals.Supports $filter (eq, not, ge, le, startsWith) and $search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.</summary>
        public Guid? TokenEncryptionKeyId {
            get { return BackingStore?.Get<Guid?>("tokenEncryptionKeyId"); }
            set { BackingStore?.Set("tokenEncryptionKeyId", value); }
        }
        /// <summary>The tokenIssuancePolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TokenIssuancePolicy>? TokenIssuancePolicies {
            get { return BackingStore?.Get<List<TokenIssuancePolicy>?>("tokenIssuancePolicies"); }
            set { BackingStore?.Set("tokenIssuancePolicies", value); }
        }
#nullable restore
#else
        public List<TokenIssuancePolicy> TokenIssuancePolicies {
            get { return BackingStore?.Get<List<TokenIssuancePolicy>>("tokenIssuancePolicies"); }
            set { BackingStore?.Set("tokenIssuancePolicies", value); }
        }
#endif
        /// <summary>The tokenLifetimePolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TokenLifetimePolicy>? TokenLifetimePolicies {
            get { return BackingStore?.Get<List<TokenLifetimePolicy>?>("tokenLifetimePolicies"); }
            set { BackingStore?.Set("tokenLifetimePolicies", value); }
        }
#nullable restore
#else
        public List<TokenLifetimePolicy> TokenLifetimePolicies {
            get { return BackingStore?.Get<List<TokenLifetimePolicy>>("tokenLifetimePolicies"); }
            set { BackingStore?.Set("tokenLifetimePolicies", value); }
        }
#endif
        /// <summary>Specifies the verified publisher of the application. For more information about how publisher verification helps support application security, trustworthiness, and compliance, see Publisher verification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.VerifiedPublisher? VerifiedPublisher {
            get { return BackingStore?.Get<Microsoft.Graph.Models.VerifiedPublisher?>("verifiedPublisher"); }
            set { BackingStore?.Set("verifiedPublisher", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.VerifiedPublisher VerifiedPublisher {
            get { return BackingStore?.Get<Microsoft.Graph.Models.VerifiedPublisher>("verifiedPublisher"); }
            set { BackingStore?.Set("verifiedPublisher", value); }
        }
#endif
        /// <summary>Specifies settings for a web application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WebApplication? Web {
            get { return BackingStore?.Get<WebApplication?>("web"); }
            set { BackingStore?.Set("web", value); }
        }
#nullable restore
#else
        public WebApplication Web {
            get { return BackingStore?.Get<WebApplication>("web"); }
            set { BackingStore?.Set("web", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Application and sets the default values.
        /// </summary>
        public Application() : base() {
            OdataType = "#microsoft.graph.application";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Application CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Application();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addIns", n => { AddIns = n.GetCollectionOfObjectValues<AddIn>(AddIn.CreateFromDiscriminatorValue)?.ToList(); } },
                {"api", n => { Api = n.GetObjectValue<ApiApplication>(ApiApplication.CreateFromDiscriminatorValue); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"applicationTemplateId", n => { ApplicationTemplateId = n.GetStringValue(); } },
                {"appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<AppManagementPolicy>(AppManagementPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appRoles", n => { AppRoles = n.GetCollectionOfObjectValues<AppRole>(AppRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"certification", n => { Certification = n.GetObjectValue<Microsoft.Graph.Models.Certification>(Microsoft.Graph.Models.Certification.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdOnBehalfOf", n => { CreatedOnBehalfOf = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"defaultRedirectUri", n => { DefaultRedirectUri = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"disabledByMicrosoftStatus", n => { DisabledByMicrosoftStatus = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"extensionProperties", n => { ExtensionProperties = n.GetCollectionOfObjectValues<ExtensionProperty>(ExtensionProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"federatedIdentityCredentials", n => { FederatedIdentityCredentials = n.GetCollectionOfObjectValues<FederatedIdentityCredential>(FederatedIdentityCredential.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupMembershipClaims", n => { GroupMembershipClaims = n.GetStringValue(); } },
                {"homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"identifierUris", n => { IdentifierUris = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"info", n => { Info = n.GetObjectValue<InformationalUrl>(InformationalUrl.CreateFromDiscriminatorValue); } },
                {"isDeviceOnlyAuthSupported", n => { IsDeviceOnlyAuthSupported = n.GetBoolValue(); } },
                {"isFallbackPublicClient", n => { IsFallbackPublicClient = n.GetBoolValue(); } },
                {"keyCredentials", n => { KeyCredentials = n.GetCollectionOfObjectValues<KeyCredential>(KeyCredential.CreateFromDiscriminatorValue)?.ToList(); } },
                {"logo", n => { Logo = n.GetByteArrayValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"oauth2RequirePostResponse", n => { Oauth2RequirePostResponse = n.GetBoolValue(); } },
                {"optionalClaims", n => { OptionalClaims = n.GetObjectValue<Microsoft.Graph.Models.OptionalClaims>(Microsoft.Graph.Models.OptionalClaims.CreateFromDiscriminatorValue); } },
                {"owners", n => { Owners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"parentalControlSettings", n => { ParentalControlSettings = n.GetObjectValue<Microsoft.Graph.Models.ParentalControlSettings>(Microsoft.Graph.Models.ParentalControlSettings.CreateFromDiscriminatorValue); } },
                {"passwordCredentials", n => { PasswordCredentials = n.GetCollectionOfObjectValues<PasswordCredential>(PasswordCredential.CreateFromDiscriminatorValue)?.ToList(); } },
                {"publicClient", n => { PublicClient = n.GetObjectValue<PublicClientApplication>(PublicClientApplication.CreateFromDiscriminatorValue); } },
                {"publisherDomain", n => { PublisherDomain = n.GetStringValue(); } },
                {"requestSignatureVerification", n => { RequestSignatureVerification = n.GetObjectValue<Microsoft.Graph.Models.RequestSignatureVerification>(Microsoft.Graph.Models.RequestSignatureVerification.CreateFromDiscriminatorValue); } },
                {"requiredResourceAccess", n => { RequiredResourceAccess = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.RequiredResourceAccess>(Microsoft.Graph.Models.RequiredResourceAccess.CreateFromDiscriminatorValue)?.ToList(); } },
                {"samlMetadataUrl", n => { SamlMetadataUrl = n.GetStringValue(); } },
                {"serviceManagementReference", n => { ServiceManagementReference = n.GetStringValue(); } },
                {"signInAudience", n => { SignInAudience = n.GetStringValue(); } },
                {"spa", n => { Spa = n.GetObjectValue<SpaApplication>(SpaApplication.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tokenEncryptionKeyId", n => { TokenEncryptionKeyId = n.GetGuidValue(); } },
                {"tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"verifiedPublisher", n => { VerifiedPublisher = n.GetObjectValue<Microsoft.Graph.Models.VerifiedPublisher>(Microsoft.Graph.Models.VerifiedPublisher.CreateFromDiscriminatorValue); } },
                {"web", n => { Web = n.GetObjectValue<WebApplication>(WebApplication.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AddIn>("addIns", AddIns);
            writer.WriteObjectValue<ApiApplication>("api", Api);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("applicationTemplateId", ApplicationTemplateId);
            writer.WriteCollectionOfObjectValues<AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteCollectionOfObjectValues<AppRole>("appRoles", AppRoles);
            writer.WriteObjectValue<Microsoft.Graph.Models.Certification>("certification", Certification);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DirectoryObject>("createdOnBehalfOf", CreatedOnBehalfOf);
            writer.WriteStringValue("defaultRedirectUri", DefaultRedirectUri);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("disabledByMicrosoftStatus", DisabledByMicrosoftStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ExtensionProperty>("extensionProperties", ExtensionProperties);
            writer.WriteCollectionOfObjectValues<FederatedIdentityCredential>("federatedIdentityCredentials", FederatedIdentityCredentials);
            writer.WriteStringValue("groupMembershipClaims", GroupMembershipClaims);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteCollectionOfPrimitiveValues<string>("identifierUris", IdentifierUris);
            writer.WriteObjectValue<InformationalUrl>("info", Info);
            writer.WriteBoolValue("isDeviceOnlyAuthSupported", IsDeviceOnlyAuthSupported);
            writer.WriteBoolValue("isFallbackPublicClient", IsFallbackPublicClient);
            writer.WriteCollectionOfObjectValues<KeyCredential>("keyCredentials", KeyCredentials);
            writer.WriteByteArrayValue("logo", Logo);
            writer.WriteStringValue("notes", Notes);
            writer.WriteBoolValue("oauth2RequirePostResponse", Oauth2RequirePostResponse);
            writer.WriteObjectValue<Microsoft.Graph.Models.OptionalClaims>("optionalClaims", OptionalClaims);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("owners", Owners);
            writer.WriteObjectValue<Microsoft.Graph.Models.ParentalControlSettings>("parentalControlSettings", ParentalControlSettings);
            writer.WriteCollectionOfObjectValues<PasswordCredential>("passwordCredentials", PasswordCredentials);
            writer.WriteObjectValue<PublicClientApplication>("publicClient", PublicClient);
            writer.WriteStringValue("publisherDomain", PublisherDomain);
            writer.WriteObjectValue<Microsoft.Graph.Models.RequestSignatureVerification>("requestSignatureVerification", RequestSignatureVerification);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.RequiredResourceAccess>("requiredResourceAccess", RequiredResourceAccess);
            writer.WriteStringValue("samlMetadataUrl", SamlMetadataUrl);
            writer.WriteStringValue("serviceManagementReference", ServiceManagementReference);
            writer.WriteStringValue("signInAudience", SignInAudience);
            writer.WriteObjectValue<SpaApplication>("spa", Spa);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteGuidValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
            writer.WriteObjectValue<Microsoft.Graph.Models.VerifiedPublisher>("verifiedPublisher", VerifiedPublisher);
            writer.WriteObjectValue<WebApplication>("web", Web);
        }
    }
}
