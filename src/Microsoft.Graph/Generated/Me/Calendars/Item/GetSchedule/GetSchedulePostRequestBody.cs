using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Me.Calendars.Item.GetSchedule {
    public class GetSchedulePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The AvailabilityViewInterval property</summary>
        public int? AvailabilityViewInterval {
            get { return BackingStore?.Get<int?>("AvailabilityViewInterval"); }
            set { BackingStore?.Set("AvailabilityViewInterval", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The EndTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? EndTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("EndTime"); }
            set { BackingStore?.Set("EndTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone EndTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("EndTime"); }
            set { BackingStore?.Set("EndTime", value); }
        }
#endif
        /// <summary>The Schedules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Schedules {
            get { return BackingStore?.Get<List<string>?>("Schedules"); }
            set { BackingStore?.Set("Schedules", value); }
        }
#nullable restore
#else
        public List<string> Schedules {
            get { return BackingStore?.Get<List<string>>("Schedules"); }
            set { BackingStore?.Set("Schedules", value); }
        }
#endif
        /// <summary>The StartTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? StartTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("StartTime"); }
            set { BackingStore?.Set("StartTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone StartTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("StartTime"); }
            set { BackingStore?.Set("StartTime", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new getSchedulePostRequestBody and sets the default values.
        /// </summary>
        public GetSchedulePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetSchedulePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetSchedulePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AvailabilityViewInterval", n => { AvailabilityViewInterval = n.GetIntValue(); } },
                {"EndTime", n => { EndTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"Schedules", n => { Schedules = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"StartTime", n => { StartTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AvailabilityViewInterval", AvailabilityViewInterval);
            writer.WriteObjectValue<DateTimeTimeZone>("EndTime", EndTime);
            writer.WriteCollectionOfPrimitiveValues<string>("Schedules", Schedules);
            writer.WriteObjectValue<DateTimeTimeZone>("StartTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
