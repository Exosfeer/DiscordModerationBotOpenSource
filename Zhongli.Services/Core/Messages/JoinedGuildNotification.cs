﻿using System;
using Discord.WebSocket;
using MediatR;

namespace Zhongli.Services.Core.Messages;

/// <summary>
///     Describes an application-wide notification that occurs when <see cref="BaseSocketClient.JoinedGuild" /> is raised.
/// </summary>
public class JoinedGuildNotification : INotification
{
    /// <summary>
    ///     Constructs a new <see cref="JoinedGuildNotification" /> from the given values.
    /// </summary>
    /// <param name="guild">The value to use for <see cref="Guild" />.</param>
    /// <exception cref="ArgumentNullException">Throws for <paramref name="guild" />.</exception>
    public JoinedGuildNotification(SocketGuild guild)
    {
        Guild = guild ?? throw new ArgumentNullException(nameof(guild));
    }

    /// <summary>
    ///     The guild that the bot has joined.
    /// </summary>
    public SocketGuild Guild { get; }
}