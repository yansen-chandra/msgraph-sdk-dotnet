using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ServicePrincipal : DirectoryObject, IParsable {
        /// <summary>true if the service principal account is enabled; otherwise, false. If set to false, then no users will be able to sign in to this app, even if they are assigned to it. Supports $filter (eq, ne, not, in).</summary>
        public bool? AccountEnabled {
            get { return BackingStore?.Get<bool?>("accountEnabled"); }
            set { BackingStore?.Set("accountEnabled", value); }
        }
        /// <summary>Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its &apos;FileHandler&apos; functionality. This will let services like Microsoft 365 call the application in the context of a document the user is working on.</summary>
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
        /// <summary>Used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities. Supports $filter (eq, not, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AlternativeNames {
            get { return BackingStore?.Get<List<string>?>("alternativeNames"); }
            set { BackingStore?.Set("alternativeNames", value); }
        }
#nullable restore
#else
        public List<string> AlternativeNames {
            get { return BackingStore?.Get<List<string>>("alternativeNames"); }
            set { BackingStore?.Set("alternativeNames", value); }
        }
#endif
        /// <summary>The description exposed by the associated application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDescription {
            get { return BackingStore?.Get<string?>("appDescription"); }
            set { BackingStore?.Set("appDescription", value); }
        }
#nullable restore
#else
        public string AppDescription {
            get { return BackingStore?.Get<string>("appDescription"); }
            set { BackingStore?.Set("appDescription", value); }
        }
#endif
        /// <summary>The display name exposed by the associated application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName {
            get { return BackingStore?.Get<string?>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#nullable restore
#else
        public string AppDisplayName {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#endif
        /// <summary>The unique identifier for the associated application (its appId property). Supports $filter (eq, ne, not, in, startsWith).</summary>
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
        /// <summary>Unique identifier of the applicationTemplate that the servicePrincipal was created from. Read-only. Supports $filter (eq, ne, NOT, startsWith).</summary>
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
        /// <summary>Contains the tenant id where the application is registered. This is applicable only to service principals backed by applications. Supports $filter (eq, ne, NOT, ge, le).</summary>
        public Guid? AppOwnerOrganizationId {
            get { return BackingStore?.Get<Guid?>("appOwnerOrganizationId"); }
            set { BackingStore?.Set("appOwnerOrganizationId", value); }
        }
        /// <summary>App role assignments for this app or service, granted to users, groups, and other service principals. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppRoleAssignment>? AppRoleAssignedTo {
            get { return BackingStore?.Get<List<AppRoleAssignment>?>("appRoleAssignedTo"); }
            set { BackingStore?.Set("appRoleAssignedTo", value); }
        }
#nullable restore
#else
        public List<AppRoleAssignment> AppRoleAssignedTo {
            get { return BackingStore?.Get<List<AppRoleAssignment>>("appRoleAssignedTo"); }
            set { BackingStore?.Set("appRoleAssignedTo", value); }
        }
#endif
        /// <summary>Specifies whether users or other service principals need to be granted an app role assignment for this service principal before users can sign in or apps can get tokens. The default value is false. Not nullable. Supports $filter (eq, ne, NOT).</summary>
        public bool? AppRoleAssignmentRequired {
            get { return BackingStore?.Get<bool?>("appRoleAssignmentRequired"); }
            set { BackingStore?.Set("appRoleAssignmentRequired", value); }
        }
        /// <summary>App role assignment for another app or service, granted to this service principal. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppRoleAssignment>? AppRoleAssignments {
            get { return BackingStore?.Get<List<AppRoleAssignment>?>("appRoleAssignments"); }
            set { BackingStore?.Set("appRoleAssignments", value); }
        }
#nullable restore
#else
        public List<AppRoleAssignment> AppRoleAssignments {
            get { return BackingStore?.Get<List<AppRoleAssignment>>("appRoleAssignments"); }
            set { BackingStore?.Set("appRoleAssignments", value); }
        }
#endif
        /// <summary>The roles exposed by the application which this service principal represents. For more information see the appRoles property definition on the application entity. Not nullable.</summary>
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
        /// <summary>The claimsMappingPolicies assigned to this service principal. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClaimsMappingPolicy>? ClaimsMappingPolicies {
            get { return BackingStore?.Get<List<ClaimsMappingPolicy>?>("claimsMappingPolicies"); }
            set { BackingStore?.Set("claimsMappingPolicies", value); }
        }
#nullable restore
#else
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies {
            get { return BackingStore?.Get<List<ClaimsMappingPolicy>>("claimsMappingPolicies"); }
            set { BackingStore?.Set("claimsMappingPolicies", value); }
        }
#endif
        /// <summary>Directory objects created by this service principal. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? CreatedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>?>("createdObjects"); }
            set { BackingStore?.Set("createdObjects", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> CreatedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>("createdObjects"); }
            set { BackingStore?.Set("createdObjects", value); }
        }
#endif
        /// <summary>The delegatedPermissionClassifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedPermissionClassification>? DelegatedPermissionClassifications {
            get { return BackingStore?.Get<List<DelegatedPermissionClassification>?>("delegatedPermissionClassifications"); }
            set { BackingStore?.Set("delegatedPermissionClassifications", value); }
        }
#nullable restore
#else
        public List<DelegatedPermissionClassification> DelegatedPermissionClassifications {
            get { return BackingStore?.Get<List<DelegatedPermissionClassification>>("delegatedPermissionClassifications"); }
            set { BackingStore?.Set("delegatedPermissionClassifications", value); }
        }
#endif
        /// <summary>Free text field to provide an internal end-user facing description of the service principal. End-user portals such MyApps will display the application description in this field. The maximum allowed size is 1024 characters. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
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
        /// <summary>The display name for the service principal. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
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
        /// <summary>The endpoints property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Endpoint>? Endpoints {
            get { return BackingStore?.Get<List<Endpoint>?>("endpoints"); }
            set { BackingStore?.Set("endpoints", value); }
        }
#nullable restore
#else
        public List<Endpoint> Endpoints {
            get { return BackingStore?.Get<List<Endpoint>>("endpoints"); }
            set { BackingStore?.Set("endpoints", value); }
        }
#endif
        /// <summary>Federated identities for a specific type of service principal - managed identity. Supports $expand and $filter (/$count eq 0, /$count ne 0).</summary>
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
        /// <summary>Home page or landing page of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Homepage {
            get { return BackingStore?.Get<string?>("homepage"); }
            set { BackingStore?.Set("homepage", value); }
        }
#nullable restore
#else
        public string Homepage {
            get { return BackingStore?.Get<string>("homepage"); }
            set { BackingStore?.Set("homepage", value); }
        }
#endif
        /// <summary>The homeRealmDiscoveryPolicies assigned to this service principal. Supports $expand.</summary>
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
        /// <summary>Basic profile information of the acquired application such as app&apos;s marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Azure AD apps. Supports $filter (eq, ne, not, ge, le, and eq on null values).</summary>
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
        /// <summary>The collection of key credentials associated with the service principal. Not nullable. Supports $filter (eq, not, ge, le).</summary>
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
        /// <summary>Specifies the URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The user launches the application from Microsoft 365, the Azure AD My Apps, or the Azure AD SSO URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoginUrl {
            get { return BackingStore?.Get<string?>("loginUrl"); }
            set { BackingStore?.Set("loginUrl", value); }
        }
#nullable restore
#else
        public string LoginUrl {
            get { return BackingStore?.Get<string>("loginUrl"); }
            set { BackingStore?.Set("loginUrl", value); }
        }
#endif
        /// <summary>Specifies the URL that will be used by Microsoft&apos;s authorization service to logout an user using OpenId Connect front-channel, back-channel or SAML logout protocols.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogoutUrl {
            get { return BackingStore?.Get<string?>("logoutUrl"); }
            set { BackingStore?.Set("logoutUrl", value); }
        }
#nullable restore
#else
        public string LogoutUrl {
            get { return BackingStore?.Get<string>("logoutUrl"); }
            set { BackingStore?.Set("logoutUrl", value); }
        }
#endif
        /// <summary>Roles that this service principal is a member of. HTTP Methods: GET Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>?>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#endif
        /// <summary>Free text field to capture information about the service principal, typically used for operational purposes. Maximum allowed size is 1024 characters.</summary>
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
        /// <summary>Specifies the list of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NotificationEmailAddresses {
            get { return BackingStore?.Get<List<string>?>("notificationEmailAddresses"); }
            set { BackingStore?.Set("notificationEmailAddresses", value); }
        }
#nullable restore
#else
        public List<string> NotificationEmailAddresses {
            get { return BackingStore?.Get<List<string>>("notificationEmailAddresses"); }
            set { BackingStore?.Set("notificationEmailAddresses", value); }
        }
#endif
        /// <summary>Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OAuth2PermissionGrant>? Oauth2PermissionGrants {
            get { return BackingStore?.Get<List<OAuth2PermissionGrant>?>("oauth2PermissionGrants"); }
            set { BackingStore?.Set("oauth2PermissionGrants", value); }
        }
#nullable restore
#else
        public List<OAuth2PermissionGrant> Oauth2PermissionGrants {
            get { return BackingStore?.Get<List<OAuth2PermissionGrant>>("oauth2PermissionGrants"); }
            set { BackingStore?.Set("oauth2PermissionGrants", value); }
        }
#endif
        /// <summary>The delegated permissions exposed by the application. For more information see the oauth2PermissionScopes property on the application entity&apos;s api property. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionScope>? Oauth2PermissionScopes {
            get { return BackingStore?.Get<List<PermissionScope>?>("oauth2PermissionScopes"); }
            set { BackingStore?.Set("oauth2PermissionScopes", value); }
        }
#nullable restore
#else
        public List<PermissionScope> Oauth2PermissionScopes {
            get { return BackingStore?.Get<List<PermissionScope>>("oauth2PermissionScopes"); }
            set { BackingStore?.Set("oauth2PermissionScopes", value); }
        }
#endif
        /// <summary>Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? OwnedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>?>("ownedObjects"); }
            set { BackingStore?.Set("ownedObjects", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> OwnedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>("ownedObjects"); }
            set { BackingStore?.Set("ownedObjects", value); }
        }
#endif
        /// <summary>Directory objects that are owners of this servicePrincipal. The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object. Read-only. Nullable.  Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).</summary>
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
        /// <summary>Specifies the single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps. The supported values are password, saml, notSupported, and oidc.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredSingleSignOnMode {
            get { return BackingStore?.Get<string?>("preferredSingleSignOnMode"); }
            set { BackingStore?.Set("preferredSingleSignOnMode", value); }
        }
#nullable restore
#else
        public string PreferredSingleSignOnMode {
            get { return BackingStore?.Get<string>("preferredSingleSignOnMode"); }
            set { BackingStore?.Set("preferredSingleSignOnMode", value); }
        }
#endif
        /// <summary>This property can be used on SAML applications (apps that have preferredSingleSignOnMode set to saml) to control which certificate is used to sign the SAML responses. For applications that are not SAML, do not write or otherwise rely on this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredTokenSigningKeyThumbprint {
            get { return BackingStore?.Get<string?>("preferredTokenSigningKeyThumbprint"); }
            set { BackingStore?.Set("preferredTokenSigningKeyThumbprint", value); }
        }
#nullable restore
#else
        public string PreferredTokenSigningKeyThumbprint {
            get { return BackingStore?.Get<string>("preferredTokenSigningKeyThumbprint"); }
            set { BackingStore?.Set("preferredTokenSigningKeyThumbprint", value); }
        }
#endif
        /// <summary>The URLs that user tokens are sent to for sign in with the associated application, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to for the associated application. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ReplyUrls {
            get { return BackingStore?.Get<List<string>?>("replyUrls"); }
            set { BackingStore?.Set("replyUrls", value); }
        }
#nullable restore
#else
        public List<string> ReplyUrls {
            get { return BackingStore?.Get<List<string>>("replyUrls"); }
            set { BackingStore?.Set("replyUrls", value); }
        }
#endif
        /// <summary>The resource-specific application permissions exposed by this application. Currently, resource-specific permissions are only supported for Teams apps accessing to specific chats and teams using Microsoft Graph. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResourceSpecificPermission>? ResourceSpecificApplicationPermissions {
            get { return BackingStore?.Get<List<ResourceSpecificPermission>?>("resourceSpecificApplicationPermissions"); }
            set { BackingStore?.Set("resourceSpecificApplicationPermissions", value); }
        }
#nullable restore
#else
        public List<ResourceSpecificPermission> ResourceSpecificApplicationPermissions {
            get { return BackingStore?.Get<List<ResourceSpecificPermission>>("resourceSpecificApplicationPermissions"); }
            set { BackingStore?.Set("resourceSpecificApplicationPermissions", value); }
        }
#endif
        /// <summary>The collection for settings related to saml single sign-on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SamlSingleSignOnSettings? SamlSingleSignOnSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SamlSingleSignOnSettings?>("samlSingleSignOnSettings"); }
            set { BackingStore?.Set("samlSingleSignOnSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SamlSingleSignOnSettings SamlSingleSignOnSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SamlSingleSignOnSettings>("samlSingleSignOnSettings"); }
            set { BackingStore?.Set("samlSingleSignOnSettings", value); }
        }
#endif
        /// <summary>Contains the list of identifiersUris, copied over from the associated application. Additional values can be added to hybrid applications. These values can be used to identify the permissions exposed by this app within Azure AD. For example,Client apps can specify a resource URI which is based on the values of this property to acquire an access token, which is the URI returned in the &apos;aud&apos; claim.The any operator is required for filter expressions on multi-valued properties. Not nullable.  Supports $filter (eq, not, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ServicePrincipalNames {
            get { return BackingStore?.Get<List<string>?>("servicePrincipalNames"); }
            set { BackingStore?.Set("servicePrincipalNames", value); }
        }
#nullable restore
#else
        public List<string> ServicePrincipalNames {
            get { return BackingStore?.Get<List<string>>("servicePrincipalNames"); }
            set { BackingStore?.Set("servicePrincipalNames", value); }
        }
#endif
        /// <summary>Identifies whether the service principal represents an application, a managed identity, or a legacy application. This is set by Azure AD internally. The servicePrincipalType property can be set to three different values: __Application - A service principal that represents an application or service. The appId property identifies the associated app registration, and matches the appId of an application, possibly from a different tenant. If the associated app registration is missing, tokens are not issued for the service principal.__ManagedIdentity - A service principal that represents a managed identity. Service principals representing managed identities can be granted access and permissions, but cannot be updated or modified directly.__Legacy - A service principal that represents an app created before app registrations, or through legacy experiences. Legacy service principal can have credentials, service principal names, reply URLs, and other properties which are editable by an authorized user, but does not have an associated app registration. The appId value does not associate the service principal with an app registration. The service principal can only be used in the tenant where it was created.__SocialIdp - For internal use.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalType {
            get { return BackingStore?.Get<string?>("servicePrincipalType"); }
            set { BackingStore?.Set("servicePrincipalType", value); }
        }
#nullable restore
#else
        public string ServicePrincipalType {
            get { return BackingStore?.Get<string>("servicePrincipalType"); }
            set { BackingStore?.Set("servicePrincipalType", value); }
        }
#endif
        /// <summary>Specifies the Microsoft accounts that are supported for the current application. Read-only. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization&apos;s Azure AD tenant (single-tenant).AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization&apos;s Azure AD tenant (multi-tenant).AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization&apos;s Azure AD tenant.PersonalMicrosoftAccount: Users with a personal Microsoft account only.</summary>
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
        /// <summary>Custom strings that can be used to categorize and identify the service principal. Not nullable. The value is the union of strings set here and on the associated application entity&apos;s tags property.Supports $filter (eq, not, ge, le, startsWith).</summary>
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
        /// <summary>Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD issues tokens for this application encrypted using the key specified by this property. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.</summary>
        public Guid? TokenEncryptionKeyId {
            get { return BackingStore?.Get<Guid?>("tokenEncryptionKeyId"); }
            set { BackingStore?.Set("tokenEncryptionKeyId", value); }
        }
        /// <summary>The tokenIssuancePolicies assigned to this service principal.</summary>
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
        /// <summary>The tokenLifetimePolicies assigned to this service principal.</summary>
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
        /// <summary>The transitiveMemberOf property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>?>("transitiveMemberOf"); }
            set { BackingStore?.Set("transitiveMemberOf", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>("transitiveMemberOf"); }
            set { BackingStore?.Set("transitiveMemberOf", value); }
        }
#endif
        /// <summary>Specifies the verified publisher of the application which this service principal represents.</summary>
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
        /// <summary>
        /// Instantiates a new ServicePrincipal and sets the default values.
        /// </summary>
        public ServicePrincipal() : base() {
            OdataType = "#microsoft.graph.servicePrincipal";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServicePrincipal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                {"addIns", n => { AddIns = n.GetCollectionOfObjectValues<AddIn>(AddIn.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alternativeNames", n => { AlternativeNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"appDescription", n => { AppDescription = n.GetStringValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"applicationTemplateId", n => { ApplicationTemplateId = n.GetStringValue(); } },
                {"appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<AppManagementPolicy>(AppManagementPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appOwnerOrganizationId", n => { AppOwnerOrganizationId = n.GetGuidValue(); } },
                {"appRoleAssignedTo", n => { AppRoleAssignedTo = n.GetCollectionOfObjectValues<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appRoleAssignmentRequired", n => { AppRoleAssignmentRequired = n.GetBoolValue(); } },
                {"appRoleAssignments", n => { AppRoleAssignments = n.GetCollectionOfObjectValues<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appRoles", n => { AppRoles = n.GetCollectionOfObjectValues<AppRole>(AppRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"claimsMappingPolicies", n => { ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>(ClaimsMappingPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdObjects", n => { CreatedObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"delegatedPermissionClassifications", n => { DelegatedPermissionClassifications = n.GetCollectionOfObjectValues<DelegatedPermissionClassification>(DelegatedPermissionClassification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"disabledByMicrosoftStatus", n => { DisabledByMicrosoftStatus = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endpoints", n => { Endpoints = n.GetCollectionOfObjectValues<Endpoint>(Endpoint.CreateFromDiscriminatorValue)?.ToList(); } },
                {"federatedIdentityCredentials", n => { FederatedIdentityCredentials = n.GetCollectionOfObjectValues<FederatedIdentityCredential>(FederatedIdentityCredential.CreateFromDiscriminatorValue)?.ToList(); } },
                {"homepage", n => { Homepage = n.GetStringValue(); } },
                {"homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"info", n => { Info = n.GetObjectValue<InformationalUrl>(InformationalUrl.CreateFromDiscriminatorValue); } },
                {"keyCredentials", n => { KeyCredentials = n.GetCollectionOfObjectValues<KeyCredential>(KeyCredential.CreateFromDiscriminatorValue)?.ToList(); } },
                {"loginUrl", n => { LoginUrl = n.GetStringValue(); } },
                {"logoutUrl", n => { LogoutUrl = n.GetStringValue(); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"notificationEmailAddresses", n => { NotificationEmailAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"oauth2PermissionGrants", n => { Oauth2PermissionGrants = n.GetCollectionOfObjectValues<OAuth2PermissionGrant>(OAuth2PermissionGrant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"oauth2PermissionScopes", n => { Oauth2PermissionScopes = n.GetCollectionOfObjectValues<PermissionScope>(PermissionScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ownedObjects", n => { OwnedObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"owners", n => { Owners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"passwordCredentials", n => { PasswordCredentials = n.GetCollectionOfObjectValues<PasswordCredential>(PasswordCredential.CreateFromDiscriminatorValue)?.ToList(); } },
                {"preferredSingleSignOnMode", n => { PreferredSingleSignOnMode = n.GetStringValue(); } },
                {"preferredTokenSigningKeyThumbprint", n => { PreferredTokenSigningKeyThumbprint = n.GetStringValue(); } },
                {"replyUrls", n => { ReplyUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"resourceSpecificApplicationPermissions", n => { ResourceSpecificApplicationPermissions = n.GetCollectionOfObjectValues<ResourceSpecificPermission>(ResourceSpecificPermission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"samlSingleSignOnSettings", n => { SamlSingleSignOnSettings = n.GetObjectValue<Microsoft.Graph.Models.SamlSingleSignOnSettings>(Microsoft.Graph.Models.SamlSingleSignOnSettings.CreateFromDiscriminatorValue); } },
                {"servicePrincipalNames", n => { ServicePrincipalNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"servicePrincipalType", n => { ServicePrincipalType = n.GetStringValue(); } },
                {"signInAudience", n => { SignInAudience = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tokenEncryptionKeyId", n => { TokenEncryptionKeyId = n.GetGuidValue(); } },
                {"tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"verifiedPublisher", n => { VerifiedPublisher = n.GetObjectValue<Microsoft.Graph.Models.VerifiedPublisher>(Microsoft.Graph.Models.VerifiedPublisher.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<AddIn>("addIns", AddIns);
            writer.WriteCollectionOfPrimitiveValues<string>("alternativeNames", AlternativeNames);
            writer.WriteStringValue("appDescription", AppDescription);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("applicationTemplateId", ApplicationTemplateId);
            writer.WriteCollectionOfObjectValues<AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteGuidValue("appOwnerOrganizationId", AppOwnerOrganizationId);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignedTo", AppRoleAssignedTo);
            writer.WriteBoolValue("appRoleAssignmentRequired", AppRoleAssignmentRequired);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<AppRole>("appRoles", AppRoles);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("createdObjects", CreatedObjects);
            writer.WriteCollectionOfObjectValues<DelegatedPermissionClassification>("delegatedPermissionClassifications", DelegatedPermissionClassifications);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("disabledByMicrosoftStatus", DisabledByMicrosoftStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Endpoint>("endpoints", Endpoints);
            writer.WriteCollectionOfObjectValues<FederatedIdentityCredential>("federatedIdentityCredentials", FederatedIdentityCredentials);
            writer.WriteStringValue("homepage", Homepage);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<InformationalUrl>("info", Info);
            writer.WriteCollectionOfObjectValues<KeyCredential>("keyCredentials", KeyCredentials);
            writer.WriteStringValue("loginUrl", LoginUrl);
            writer.WriteStringValue("logoutUrl", LogoutUrl);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteStringValue("notes", Notes);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationEmailAddresses", NotificationEmailAddresses);
            writer.WriteCollectionOfObjectValues<OAuth2PermissionGrant>("oauth2PermissionGrants", Oauth2PermissionGrants);
            writer.WriteCollectionOfObjectValues<PermissionScope>("oauth2PermissionScopes", Oauth2PermissionScopes);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedObjects", OwnedObjects);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("owners", Owners);
            writer.WriteCollectionOfObjectValues<PasswordCredential>("passwordCredentials", PasswordCredentials);
            writer.WriteStringValue("preferredSingleSignOnMode", PreferredSingleSignOnMode);
            writer.WriteStringValue("preferredTokenSigningKeyThumbprint", PreferredTokenSigningKeyThumbprint);
            writer.WriteCollectionOfPrimitiveValues<string>("replyUrls", ReplyUrls);
            writer.WriteCollectionOfObjectValues<ResourceSpecificPermission>("resourceSpecificApplicationPermissions", ResourceSpecificApplicationPermissions);
            writer.WriteObjectValue<Microsoft.Graph.Models.SamlSingleSignOnSettings>("samlSingleSignOnSettings", SamlSingleSignOnSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("servicePrincipalNames", ServicePrincipalNames);
            writer.WriteStringValue("servicePrincipalType", ServicePrincipalType);
            writer.WriteStringValue("signInAudience", SignInAudience);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteGuidValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteObjectValue<Microsoft.Graph.Models.VerifiedPublisher>("verifiedPublisher", VerifiedPublisher);
        }
    }
}
