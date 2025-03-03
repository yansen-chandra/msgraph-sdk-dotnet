using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SearchHitsContainer : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The aggregations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SearchAggregation>? Aggregations {
            get { return BackingStore?.Get<List<SearchAggregation>?>("aggregations"); }
            set { BackingStore?.Set("aggregations", value); }
        }
#nullable restore
#else
        public List<SearchAggregation> Aggregations {
            get { return BackingStore?.Get<List<SearchAggregation>>("aggregations"); }
            set { BackingStore?.Set("aggregations", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A collection of the search results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SearchHit>? Hits {
            get { return BackingStore?.Get<List<SearchHit>?>("hits"); }
            set { BackingStore?.Set("hits", value); }
        }
#nullable restore
#else
        public List<SearchHit> Hits {
            get { return BackingStore?.Get<List<SearchHit>>("hits"); }
            set { BackingStore?.Set("hits", value); }
        }
#endif
        /// <summary>Provides information if more results are available. Based on this information, you can adjust the from and size properties of the searchRequest accordingly.</summary>
        public bool? MoreResultsAvailable {
            get { return BackingStore?.Get<bool?>("moreResultsAvailable"); }
            set { BackingStore?.Set("moreResultsAvailable", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The total number of results. Note this is not the number of results on the page, but the total number of results satisfying the query.</summary>
        public int? Total {
            get { return BackingStore?.Get<int?>("total"); }
            set { BackingStore?.Set("total", value); }
        }
        /// <summary>
        /// Instantiates a new searchHitsContainer and sets the default values.
        /// </summary>
        public SearchHitsContainer() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchHitsContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchHitsContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aggregations", n => { Aggregations = n.GetCollectionOfObjectValues<SearchAggregation>(SearchAggregation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hits", n => { Hits = n.GetCollectionOfObjectValues<SearchHit>(SearchHit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"moreResultsAvailable", n => { MoreResultsAvailable = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"total", n => { Total = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SearchAggregation>("aggregations", Aggregations);
            writer.WriteCollectionOfObjectValues<SearchHit>("hits", Hits);
            writer.WriteBoolValue("moreResultsAvailable", MoreResultsAvailable);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("total", Total);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
