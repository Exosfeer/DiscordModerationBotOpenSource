using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Humanizer;
using Zhongli.Data;
using Zhongli.Data.Models.Authorization;
using Zhongli.Data.Models.Criteria;
using Zhongli.Services.CommandHelp;
using Zhongli.Services.Core;
using Zhongli.Services.Core.Listeners;
using Zhongli.Services.Core.Preconditions.Commands;
using Zhongli.Services.Interactive;
using Zhongli.Services.Utilities;
using GuildPermission = Zhongli.Data.Models.Discord.GuildPermission;

namespace Zhongli.Bot.Modules.Logging;

[Name("Logging Exclusions")]
[Group("log")]
[Alias("logs", "logging")]
[Summary("Manages logging exclusions.")]
[RequireAuthorization(AuthorizationScope.Configuration)]
public class LoggingExclusionsModule : InteractiveEntity<Criterion>
{
    private readonly ZhongliContext _db;

    public LoggingExclusionsModule(CommandErrorHandler error, ZhongliContext db) : base(error, db) { _db = db; }

    protected virtual string Title => "Censor Exclusions";

    [Command("exclude")]
    [Alias("ignore")]
    [Summary("Exclude the set criteria globally in logging.")]
    public async Task ExcludeAsync(Exclusions exclusions)
    {
        var collection = await GetCollectionAsync();
        collection.AddCriteria(exclusions);

        await _db.SaveChangesAsync();

        var embed = new EmbedBuilder()
            .WithTitle("Logging exclusions added")
            .WithColor(Color.Green)
            .AddField("Excluded: ", exclusions.ToCriteria().Humanize())
            .WithUserAsAuthor(Context.User, AuthorOptions.UseFooter | AuthorOptions.Requested);

        await ReplyAsync(embed: embed.Build());
    }

    [Command("include")]
    [Summary("Remove a global logging exclusion by ID.")]
    protected override Task RemoveEntityAsync(string id) => base.RemoveEntityAsync(id);

    [Command("exclusions")]
    [Alias("view exclusions", "list exclusions")]
    [Summary("View the configured logging exclusions.")]
    protected override Task ViewEntityAsync() => base.ViewEntityAsync();

    protected override bool IsMatch(Criterion entity, string id)
        => entity.Id.ToString().StartsWith(id, StringComparison.OrdinalIgnoreCase);

    protected override EmbedBuilder EntityViewer(Criterion entity) => entity.ToEmbedBuilder();

    protected override async Task<ICollection<Criterion>> GetCollectionAsync()
    {
        var guild = await _db.Guilds.TrackGuildAsync(Context.Guild);
        return guild.LoggingRules.LoggingExclusions;
    }

    [NamedArgumentType]
    public class Exclusions : ICriteriaOptions
    {
        [HelpSummary("The permissions that the user must have.")]
        public GuildPermission Permission { get; set; } = GuildPermission.None;

        [HelpSummary("The text or category channels that will be excluded.")]
        public IEnumerable<IGuildChannel>? Channels { get; set; }

        [HelpSummary("The users that are excluded.")]
        public IEnumerable<IGuildUser>? Users { get; set; }

        [HelpSummary("The roles that are excluded.")]
        public IEnumerable<IRole>? Roles { get; set; }
    }
}