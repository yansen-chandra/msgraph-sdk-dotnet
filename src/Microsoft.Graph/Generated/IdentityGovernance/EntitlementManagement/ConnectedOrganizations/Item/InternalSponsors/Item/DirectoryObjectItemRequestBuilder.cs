using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.InternalSponsors.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.InternalSponsors.Item {
    /// <summary>
    /// Builds and executes requests for operations under \identityGovernance\entitlementManagement\connectedOrganizations\{connectedOrganization-id}\internalSponsors\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the collection of identityGovernance entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganization%2Did}/internalSponsors/{directoryObject%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganization%2Did}/internalSponsors/{directoryObject%2Did}", rawUrl) {
        }
    }
}
