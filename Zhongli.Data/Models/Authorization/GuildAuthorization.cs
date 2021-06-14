﻿using System;
using Zhongli.Data.Models.Discord;

namespace Zhongli.Data.Models.Authorization
{
    public class GuildAuthorization : IAuthorizationRule
    {
        public Guid Id { get; set; }

        public ulong GuildId { get; set; }

        public DateTimeOffset Date { get; set; }

        public virtual GuildUserEntity AddedBy { get; set; }

        public AuthorizationScope Scope { get; set; }
    }
}