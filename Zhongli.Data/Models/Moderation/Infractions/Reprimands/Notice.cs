using System;

namespace Zhongli.Data.Models.Moderation.Infractions.Reprimands;

public class Notice : ExpirableReprimand, INotice
{
    protected Notice() { }

    public Notice(TimeSpan? length, ReprimandDetails details) : base(length, details) { }
}