using Discord;
using Discord.Commands;

namespace Zhongli.Data.Models.Moderation.Infractions;

public static class ModerationExtensions
{
    public static T WithModerator<T>(this T action, IGuildUser moderator) where T : IModerationAction
    {
        action.Action = new ModerationAction(moderator);

        return action;
    }

    public static T WithModerator<T>(this T action, ICommandContext context) where T : IModerationAction
        => action.WithModerator((IGuildUser) context.User);
}