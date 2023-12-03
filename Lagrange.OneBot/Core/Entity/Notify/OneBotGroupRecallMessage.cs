using System.Text.Json.Serialization;

namespace Lagrange.OneBot.Core.Entity.Notify;

[Serializable]
public class OneBotGroupRecallMessage(uint selfId, uint groupId, uint messageId, uint operatorId, uint userId) : OneBotNotify(selfId, "group_recall")
{
    [JsonPropertyName("group_id")] public uint GroupId { get; set; } = groupId;

    [JsonPropertyName("message_id")] public uint MessageId { get; set; } = messageId;

    [JsonPropertyName("operator_id")] public uint OperatorId { get; set; } = operatorId;

    [JsonPropertyName("user_id")] public uint UserId { get; set; } = userId;
}