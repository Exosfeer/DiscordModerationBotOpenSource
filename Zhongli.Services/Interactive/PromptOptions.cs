﻿using System.Collections.Generic;
using Discord;
using Zhongli.Services.Interactive.Criteria;

namespace Zhongli.Services.Interactive;

internal class PromptOptions
{
    public bool IsRequired { get; init; }

    public Color? Color { get; init; }

    public CriteriaCriterion<IMessage>? Criterion { get; init; }

    public IEnumerable<EmbedFieldBuilder>? Fields { get; init; }

    public int SecondsTimeout { get; init; }
}