﻿using Discord;
using Discord.Commands;

namespace Zhongli.Services.Interactive.TypeReaders;

public static class Reader
{
    public static TypeReader Channel<T>() where T : class, IChannel => new ChannelTypeReader<T>();

    public static TypeReader Message<T>() where T : class, IMessage => new Core.TypeReaders.MessageTypeReader<T>();
}