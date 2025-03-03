using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class EdiscoveryCaseSettings : Entity, IParsable {
        /// <summary>The OCR (Optical Character Recognition) settings for the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OcrSettings? Ocr {
            get { return BackingStore?.Get<OcrSettings?>("ocr"); }
            set { BackingStore?.Set("ocr", value); }
        }
#nullable restore
#else
        public OcrSettings Ocr {
            get { return BackingStore?.Get<OcrSettings>("ocr"); }
            set { BackingStore?.Set("ocr", value); }
        }
#endif
        /// <summary>The redundancy (near duplicate and email threading) detection settings for the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RedundancyDetectionSettings? RedundancyDetection {
            get { return BackingStore?.Get<RedundancyDetectionSettings?>("redundancyDetection"); }
            set { BackingStore?.Set("redundancyDetection", value); }
        }
#nullable restore
#else
        public RedundancyDetectionSettings RedundancyDetection {
            get { return BackingStore?.Get<RedundancyDetectionSettings>("redundancyDetection"); }
            set { BackingStore?.Set("redundancyDetection", value); }
        }
#endif
        /// <summary>The Topic Modeling (Themes) settings for the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TopicModelingSettings? TopicModeling {
            get { return BackingStore?.Get<TopicModelingSettings?>("topicModeling"); }
            set { BackingStore?.Set("topicModeling", value); }
        }
#nullable restore
#else
        public TopicModelingSettings TopicModeling {
            get { return BackingStore?.Get<TopicModelingSettings>("topicModeling"); }
            set { BackingStore?.Set("topicModeling", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryCaseSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryCaseSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"ocr", n => { Ocr = n.GetObjectValue<OcrSettings>(OcrSettings.CreateFromDiscriminatorValue); } },
                {"redundancyDetection", n => { RedundancyDetection = n.GetObjectValue<RedundancyDetectionSettings>(RedundancyDetectionSettings.CreateFromDiscriminatorValue); } },
                {"topicModeling", n => { TopicModeling = n.GetObjectValue<TopicModelingSettings>(TopicModelingSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OcrSettings>("ocr", Ocr);
            writer.WriteObjectValue<RedundancyDetectionSettings>("redundancyDetection", RedundancyDetection);
            writer.WriteObjectValue<TopicModelingSettings>("topicModeling", TopicModeling);
        }
    }
}
