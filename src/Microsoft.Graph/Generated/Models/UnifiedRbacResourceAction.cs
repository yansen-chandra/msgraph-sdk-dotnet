using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UnifiedRbacResourceAction : Entity, IParsable {
        /// <summary>The actionVerb property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionVerb {
            get { return BackingStore?.Get<string?>("actionVerb"); }
            set { BackingStore?.Set("actionVerb", value); }
        }
#nullable restore
#else
        public string ActionVerb {
            get { return BackingStore?.Get<string>("actionVerb"); }
            set { BackingStore?.Set("actionVerb", value); }
        }
#endif
        /// <summary>The authenticationContextId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationContextId {
            get { return BackingStore?.Get<string?>("authenticationContextId"); }
            set { BackingStore?.Set("authenticationContextId", value); }
        }
#nullable restore
#else
        public string AuthenticationContextId {
            get { return BackingStore?.Get<string>("authenticationContextId"); }
            set { BackingStore?.Set("authenticationContextId", value); }
        }
#endif
        /// <summary>The description property</summary>
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
        /// <summary>The isAuthenticationContextSettable property</summary>
        public bool? IsAuthenticationContextSettable {
            get { return BackingStore?.Get<bool?>("isAuthenticationContextSettable"); }
            set { BackingStore?.Set("isAuthenticationContextSettable", value); }
        }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The resourceScopeId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceScopeId {
            get { return BackingStore?.Get<string?>("resourceScopeId"); }
            set { BackingStore?.Set("resourceScopeId", value); }
        }
#nullable restore
#else
        public string ResourceScopeId {
            get { return BackingStore?.Get<string>("resourceScopeId"); }
            set { BackingStore?.Set("resourceScopeId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRbacResourceAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRbacResourceAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionVerb", n => { ActionVerb = n.GetStringValue(); } },
                {"authenticationContextId", n => { AuthenticationContextId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isAuthenticationContextSettable", n => { IsAuthenticationContextSettable = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"resourceScopeId", n => { ResourceScopeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionVerb", ActionVerb);
            writer.WriteStringValue("authenticationContextId", AuthenticationContextId);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isAuthenticationContextSettable", IsAuthenticationContextSettable);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("resourceScopeId", ResourceScopeId);
        }
    }
}
