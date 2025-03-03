using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ChatMessage : Entity, IParsable {
        /// <summary>References to attached objects like files, tabs, meetings etc.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageAttachment>? Attachments {
            get { return BackingStore?.Get<List<ChatMessageAttachment>?>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#nullable restore
#else
        public List<ChatMessageAttachment> Attachments {
            get { return BackingStore?.Get<List<ChatMessageAttachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Body {
            get { return BackingStore?.Get<ItemBody?>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#nullable restore
#else
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#endif
        /// <summary>If the message was sent in a channel, represents identity of the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ChannelIdentity? ChannelIdentity {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChannelIdentity?>("channelIdentity"); }
            set { BackingStore?.Set("channelIdentity", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ChannelIdentity ChannelIdentity {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChannelIdentity>("channelIdentity"); }
            set { BackingStore?.Set("channelIdentity", value); }
        }
#endif
        /// <summary>If the message was sent in a chat, represents the identity of the chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChatId {
            get { return BackingStore?.Get<string?>("chatId"); }
            set { BackingStore?.Set("chatId", value); }
        }
#nullable restore
#else
        public string ChatId {
            get { return BackingStore?.Get<string>("chatId"); }
            set { BackingStore?.Set("chatId", value); }
        }
#endif
        /// <summary>Timestamp of when the chat message was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Read only. Timestamp at which the chat message was deleted, or null if not deleted.</summary>
        public DateTimeOffset? DeletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>Read-only. Version number of the chat message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etag {
            get { return BackingStore?.Get<string?>("etag"); }
            set { BackingStore?.Set("etag", value); }
        }
#nullable restore
#else
        public string Etag {
            get { return BackingStore?.Get<string>("etag"); }
            set { BackingStore?.Set("etag", value); }
        }
#endif
        /// <summary>Read-only. If present, represents details of an event that happened in a chat, a channel, or a team, for example, adding new members. For event messages, the messageType property will be set to systemEventMessage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EventMessageDetail? EventDetail {
            get { return BackingStore?.Get<EventMessageDetail?>("eventDetail"); }
            set { BackingStore?.Set("eventDetail", value); }
        }
#nullable restore
#else
        public EventMessageDetail EventDetail {
            get { return BackingStore?.Get<EventMessageDetail>("eventDetail"); }
            set { BackingStore?.Set("eventDetail", value); }
        }
#endif
        /// <summary>Details of the sender of the chat message. Can only be set during migration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChatMessageFromIdentitySet? From {
            get { return BackingStore?.Get<ChatMessageFromIdentitySet?>("from"); }
            set { BackingStore?.Set("from", value); }
        }
#nullable restore
#else
        public ChatMessageFromIdentitySet From {
            get { return BackingStore?.Get<ChatMessageFromIdentitySet>("from"); }
            set { BackingStore?.Set("from", value); }
        }
#endif
        /// <summary>Content in a message hosted by Microsoft Teams - for example, images or code snippets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageHostedContent>? HostedContents {
            get { return BackingStore?.Get<List<ChatMessageHostedContent>?>("hostedContents"); }
            set { BackingStore?.Set("hostedContents", value); }
        }
#nullable restore
#else
        public List<ChatMessageHostedContent> HostedContents {
            get { return BackingStore?.Get<List<ChatMessageHostedContent>>("hostedContents"); }
            set { BackingStore?.Set("hostedContents", value); }
        }
#endif
        /// <summary>The importance property</summary>
        public ChatMessageImportance? Importance {
            get { return BackingStore?.Get<ChatMessageImportance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>Read only. Timestamp when edits to the chat message were made. Triggers an &apos;Edited&apos; flag in the Teams UI. If no edits are made the value is null.</summary>
        public DateTimeOffset? LastEditedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastEditedDateTime"); }
            set { BackingStore?.Set("lastEditedDateTime", value); }
        }
        /// <summary>Read only. Timestamp when the chat message is created (initial setting) or modified, including when a reaction is added or removed.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Locale of the chat message set by the client. Always set to en-us.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale {
            get { return BackingStore?.Get<string?>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#nullable restore
#else
        public string Locale {
            get { return BackingStore?.Get<string>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#endif
        /// <summary>List of entities mentioned in the chat message. Supported entities are: user, bot, team, and channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageMention>? Mentions {
            get { return BackingStore?.Get<List<ChatMessageMention>?>("mentions"); }
            set { BackingStore?.Set("mentions", value); }
        }
#nullable restore
#else
        public List<ChatMessageMention> Mentions {
            get { return BackingStore?.Get<List<ChatMessageMention>>("mentions"); }
            set { BackingStore?.Set("mentions", value); }
        }
#endif
        /// <summary>The messageHistory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageHistoryItem>? MessageHistory {
            get { return BackingStore?.Get<List<ChatMessageHistoryItem>?>("messageHistory"); }
            set { BackingStore?.Set("messageHistory", value); }
        }
#nullable restore
#else
        public List<ChatMessageHistoryItem> MessageHistory {
            get { return BackingStore?.Get<List<ChatMessageHistoryItem>>("messageHistory"); }
            set { BackingStore?.Set("messageHistory", value); }
        }
#endif
        /// <summary>The messageType property</summary>
        public ChatMessageType? MessageType {
            get { return BackingStore?.Get<ChatMessageType?>("messageType"); }
            set { BackingStore?.Set("messageType", value); }
        }
        /// <summary>Defines the properties of a policy violation set by a data loss prevention (DLP) application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChatMessagePolicyViolation? PolicyViolation {
            get { return BackingStore?.Get<ChatMessagePolicyViolation?>("policyViolation"); }
            set { BackingStore?.Set("policyViolation", value); }
        }
#nullable restore
#else
        public ChatMessagePolicyViolation PolicyViolation {
            get { return BackingStore?.Get<ChatMessagePolicyViolation>("policyViolation"); }
            set { BackingStore?.Set("policyViolation", value); }
        }
#endif
        /// <summary>Reactions for this chat message (for example, Like).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageReaction>? Reactions {
            get { return BackingStore?.Get<List<ChatMessageReaction>?>("reactions"); }
            set { BackingStore?.Set("reactions", value); }
        }
#nullable restore
#else
        public List<ChatMessageReaction> Reactions {
            get { return BackingStore?.Get<List<ChatMessageReaction>>("reactions"); }
            set { BackingStore?.Set("reactions", value); }
        }
#endif
        /// <summary>Replies for a specified message. Supports $expand for channel messages.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessage>? Replies {
            get { return BackingStore?.Get<List<ChatMessage>?>("replies"); }
            set { BackingStore?.Set("replies", value); }
        }
#nullable restore
#else
        public List<ChatMessage> Replies {
            get { return BackingStore?.Get<List<ChatMessage>>("replies"); }
            set { BackingStore?.Set("replies", value); }
        }
#endif
        /// <summary>Read-only. ID of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels, not chats.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReplyToId {
            get { return BackingStore?.Get<string?>("replyToId"); }
            set { BackingStore?.Set("replyToId", value); }
        }
#nullable restore
#else
        public string ReplyToId {
            get { return BackingStore?.Get<string>("replyToId"); }
            set { BackingStore?.Set("replyToId", value); }
        }
#endif
        /// <summary>The subject of the chat message, in plaintext.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary {
            get { return BackingStore?.Get<string?>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#nullable restore
#else
        public string Summary {
            get { return BackingStore?.Get<string>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#endif
        /// <summary>Read-only. Link to the message in Microsoft Teams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChatMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<ChatMessageAttachment>(ChatMessageAttachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"channelIdentity", n => { ChannelIdentity = n.GetObjectValue<Microsoft.Graph.Models.ChannelIdentity>(Microsoft.Graph.Models.ChannelIdentity.CreateFromDiscriminatorValue); } },
                {"chatId", n => { ChatId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"etag", n => { Etag = n.GetStringValue(); } },
                {"eventDetail", n => { EventDetail = n.GetObjectValue<EventMessageDetail>(EventMessageDetail.CreateFromDiscriminatorValue); } },
                {"from", n => { From = n.GetObjectValue<ChatMessageFromIdentitySet>(ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                {"hostedContents", n => { HostedContents = n.GetCollectionOfObjectValues<ChatMessageHostedContent>(ChatMessageHostedContent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"importance", n => { Importance = n.GetEnumValue<ChatMessageImportance>(); } },
                {"lastEditedDateTime", n => { LastEditedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"locale", n => { Locale = n.GetStringValue(); } },
                {"mentions", n => { Mentions = n.GetCollectionOfObjectValues<ChatMessageMention>(ChatMessageMention.CreateFromDiscriminatorValue)?.ToList(); } },
                {"messageHistory", n => { MessageHistory = n.GetCollectionOfObjectValues<ChatMessageHistoryItem>(ChatMessageHistoryItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"messageType", n => { MessageType = n.GetEnumValue<ChatMessageType>(); } },
                {"policyViolation", n => { PolicyViolation = n.GetObjectValue<ChatMessagePolicyViolation>(ChatMessagePolicyViolation.CreateFromDiscriminatorValue); } },
                {"reactions", n => { Reactions = n.GetCollectionOfObjectValues<ChatMessageReaction>(ChatMessageReaction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"replies", n => { Replies = n.GetCollectionOfObjectValues<ChatMessage>(ChatMessage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"replyToId", n => { ReplyToId = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ChatMessageAttachment>("attachments", Attachments);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteObjectValue<Microsoft.Graph.Models.ChannelIdentity>("channelIdentity", ChannelIdentity);
            writer.WriteStringValue("chatId", ChatId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("etag", Etag);
            writer.WriteObjectValue<EventMessageDetail>("eventDetail", EventDetail);
            writer.WriteObjectValue<ChatMessageFromIdentitySet>("from", From);
            writer.WriteCollectionOfObjectValues<ChatMessageHostedContent>("hostedContents", HostedContents);
            writer.WriteEnumValue<ChatMessageImportance>("importance", Importance);
            writer.WriteDateTimeOffsetValue("lastEditedDateTime", LastEditedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("locale", Locale);
            writer.WriteCollectionOfObjectValues<ChatMessageMention>("mentions", Mentions);
            writer.WriteCollectionOfObjectValues<ChatMessageHistoryItem>("messageHistory", MessageHistory);
            writer.WriteEnumValue<ChatMessageType>("messageType", MessageType);
            writer.WriteObjectValue<ChatMessagePolicyViolation>("policyViolation", PolicyViolation);
            writer.WriteCollectionOfObjectValues<ChatMessageReaction>("reactions", Reactions);
            writer.WriteCollectionOfObjectValues<ChatMessage>("replies", Replies);
            writer.WriteStringValue("replyToId", ReplyToId);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("summary", Summary);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
