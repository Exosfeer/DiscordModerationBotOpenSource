namespace Zhongli.Data.Models.Discord.Message;

public interface IMessageEntity : IChannelEntity, IGuildUserEntity
{
    ulong MessageId { get; set; }
}