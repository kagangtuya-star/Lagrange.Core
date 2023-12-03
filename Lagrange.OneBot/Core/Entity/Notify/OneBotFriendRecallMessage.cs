using System.Text.Json.Serialization;

namespace Lagrange.OneBot.Core.Entity.Notify;

[Serializable]
public class OneBotFriendRecallMessage(uint selfId, uint messageId, uint userId) : OneBotNotify(selfId, "group_recall")
{
    [JsonPropertyName("user_id")] public uint UserId { get; set; } = userId;
    [JsonPropertyName("message_id")] public uint MessageId { get; set; } = messageId;
}