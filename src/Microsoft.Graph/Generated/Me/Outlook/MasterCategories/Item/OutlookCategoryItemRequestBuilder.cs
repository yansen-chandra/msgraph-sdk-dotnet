using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Me.Outlook.MasterCategories.Item {
    /// <summary>
    /// Provides operations to manage the masterCategories property of the microsoft.graph.outlookUser entity.
    /// </summary>
    public class OutlookCategoryItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new OutlookCategoryItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutlookCategoryItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/outlook/masterCategories/{outlookCategory%2Did}{?%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OutlookCategoryItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutlookCategoryItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/outlook/masterCategories/{outlookCategory%2Did}{?%24select}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property masterCategories for me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<OutlookCategoryItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<OutlookCategoryItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// A list of categories defined for the user.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OutlookCategory?> GetAsync(Action<OutlookCategoryItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OutlookCategory> GetAsync(Action<OutlookCategoryItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OutlookCategory>(requestInfo, OutlookCategory.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property masterCategories in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OutlookCategory?> PatchAsync(OutlookCategory body, Action<OutlookCategoryItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OutlookCategory> PatchAsync(OutlookCategory body, Action<OutlookCategoryItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OutlookCategory>(requestInfo, OutlookCategory.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property masterCategories for me
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<OutlookCategoryItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<OutlookCategoryItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new OutlookCategoryItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// A list of categories defined for the user.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<OutlookCategoryItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<OutlookCategoryItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new OutlookCategoryItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property masterCategories in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(OutlookCategory body, Action<OutlookCategoryItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(OutlookCategory body, Action<OutlookCategoryItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new OutlookCategoryItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OutlookCategoryItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new OutlookCategoryItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public OutlookCategoryItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// A list of categories defined for the user.
        /// </summary>
        public class OutlookCategoryItemRequestBuilderGetQueryParameters {
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OutlookCategoryItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public OutlookCategoryItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new OutlookCategoryItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new OutlookCategoryItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public OutlookCategoryItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OutlookCategoryItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new OutlookCategoryItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public OutlookCategoryItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
