using System;
using System.Text.RegularExpressions;
using Discord;
using Zhongli.Data.Models.Moderation.Infractions.Censors;
using Zhongli.Data.Models.Moderation.Infractions.Reprimands;

namespace Zhongli.Services.Moderation;

public static class CensorExtensions
{
    public static Regex Regex(this ICensor censor)
        => new(censor.Pattern, censor.Options, TimeSpan.FromSeconds(1));

    public static string? CensoredMessage(this Censored censored)
        => (censored.Trigger as Censor)?.Regex()
            .Replace(censored.Content, m => Format.Bold(m.Value));
}