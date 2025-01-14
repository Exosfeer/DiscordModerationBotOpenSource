using System;
using System.Collections.Concurrent;
using System.Threading;
using Discord;

namespace Zhongli.Services.Sticky;

public class StickyMessageDetails
{
    public CancellationTokenSource Token { get; set; } = new();

    public ConcurrentBag<IUserMessage> Messages { get; } = new();

    public DateTimeOffset? LastSent { get; set; }

    public int MessageCount { get; set; }
}