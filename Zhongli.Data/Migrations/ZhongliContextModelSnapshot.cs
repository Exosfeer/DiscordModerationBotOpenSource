﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Zhongli.Data;

namespace Zhongli.Data.Migrations
{
    [DbContext(typeof(ZhongliContext))]
    partial class ZhongliContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.AuthorizationRules", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("AuthorizationRules");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.ChannelAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal?>("AddedById")
                        .HasColumnType("numeric(20,0)");

                    b.Property<Guid?>("AuthorizationRulesId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Scope")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("AuthorizationRulesId");

                    b.ToTable("ChannelAuthorization");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.GuildAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal?>("AddedById")
                        .HasColumnType("numeric(20,0)");

                    b.Property<Guid?>("AuthorizationRulesId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("Scope")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("AuthorizationRulesId");

                    b.ToTable("GuildAuthorization");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.PermissionAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal?>("AddedById")
                        .HasColumnType("numeric(20,0)");

                    b.Property<Guid?>("AuthorizationRulesId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Permission")
                        .HasColumnType("integer");

                    b.Property<int>("Scope")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("AuthorizationRulesId");

                    b.ToTable("PermissionAuthorization");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.RoleAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal?>("AddedById")
                        .HasColumnType("numeric(20,0)");

                    b.Property<Guid?>("AuthorizationRulesId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("RoleId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("Scope")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("AuthorizationRulesId");

                    b.ToTable("RoleAuthorization");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.UserAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal?>("AddedById")
                        .HasColumnType("numeric(20,0)");

                    b.Property<Guid?>("AuthorizationRulesId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("Scope")
                        .HasColumnType("integer");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("AuthorizationRulesId");

                    b.ToTable("UserAuthorization");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Discord.GuildEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<Guid?>("AuthorizationRulesId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AutoModerationRulesId")
                        .HasColumnType("uuid");

                    b.Property<decimal?>("MuteRoleId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizationRulesId");

                    b.HasIndex("AutoModerationRulesId");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Discord.GuildUserEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DiscriminatorValue")
                        .HasColumnType("integer");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTimeOffset?>("JoinedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nickname")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WarningCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.AntiSpamRules", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<TimeSpan?>("DuplicateMessageTime")
                        .HasColumnType("interval");

                    b.Property<int?>("DuplicateTolerance")
                        .HasColumnType("integer");

                    b.Property<long?>("EmojiLimit")
                        .HasColumnType("bigint");

                    b.Property<long?>("MessageLimit")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan?>("MessageSpamTime")
                        .HasColumnType("interval");

                    b.Property<long?>("NewlineLimit")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("AntiSpamRules");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.AutoModerationRules", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AntiSpamRulesId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AntiSpamRulesId");

                    b.ToTable("AutoModerationRules");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.Ban", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DeleteDays")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("GuildUserEntityId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("ModeratorId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<decimal?>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.HasIndex("GuildUserEntityId");

                    b.HasIndex("ModeratorId");

                    b.HasIndex("UserId");

                    b.ToTable("Ban");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.Kick", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("GuildUserEntityId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("ModeratorId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<decimal?>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.HasIndex("GuildUserEntityId");

                    b.HasIndex("ModeratorId");

                    b.HasIndex("UserId");

                    b.ToTable("Kick");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.Mute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("GuildUserEntityId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<TimeSpan?>("Length")
                        .HasColumnType("interval");

                    b.Property<decimal?>("ModeratorId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<decimal?>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.HasIndex("GuildUserEntityId");

                    b.HasIndex("ModeratorId");

                    b.HasIndex("UserId");

                    b.ToTable("Mute");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.ReprimandAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("GuildUserEntityId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("ModeratorId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<int>("Reprimand")
                        .HasColumnType("integer");

                    b.Property<decimal?>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<Guid?>("WarningId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.HasIndex("GuildUserEntityId");

                    b.HasIndex("ModeratorId");

                    b.HasIndex("UserId");

                    b.HasIndex("WarningId");

                    b.ToTable("ReprimandAction");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.Warning", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("GuildUserEntityId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("ModeratorId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<decimal?>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.HasIndex("GuildUserEntityId");

                    b.HasIndex("ModeratorId");

                    b.HasIndex("UserId");

                    b.ToTable("Warning");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.WarningTrigger", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AutoModerationRulesId")
                        .HasColumnType("uuid");

                    b.Property<int>("Reprimand")
                        .HasColumnType("integer");

                    b.Property<long>("TriggerAt")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AutoModerationRulesId");

                    b.ToTable("WarningTrigger");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.ChannelAuthorization", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById");

                    b.HasOne("Zhongli.Data.Models.Authorization.AuthorizationRules", null)
                        .WithMany("ChannelAuthorizations")
                        .HasForeignKey("AuthorizationRulesId");

                    b.Navigation("AddedBy");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.GuildAuthorization", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById");

                    b.HasOne("Zhongli.Data.Models.Authorization.AuthorizationRules", null)
                        .WithMany("ServerAuthorizations")
                        .HasForeignKey("AuthorizationRulesId");

                    b.Navigation("AddedBy");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.PermissionAuthorization", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById");

                    b.HasOne("Zhongli.Data.Models.Authorization.AuthorizationRules", null)
                        .WithMany("PermissionAuthorizations")
                        .HasForeignKey("AuthorizationRulesId");

                    b.Navigation("AddedBy");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.RoleAuthorization", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById");

                    b.HasOne("Zhongli.Data.Models.Authorization.AuthorizationRules", null)
                        .WithMany("RoleAuthorizations")
                        .HasForeignKey("AuthorizationRulesId");

                    b.Navigation("AddedBy");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.UserAuthorization", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById");

                    b.HasOne("Zhongli.Data.Models.Authorization.AuthorizationRules", null)
                        .WithMany("UserAuthorizations")
                        .HasForeignKey("AuthorizationRulesId");

                    b.Navigation("AddedBy");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Discord.GuildEntity", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Authorization.AuthorizationRules", "AuthorizationRules")
                        .WithMany()
                        .HasForeignKey("AuthorizationRulesId");

                    b.HasOne("Zhongli.Data.Models.Moderation.AutoModerationRules", "AutoModerationRules")
                        .WithMany()
                        .HasForeignKey("AutoModerationRulesId");

                    b.Navigation("AuthorizationRules");

                    b.Navigation("AutoModerationRules");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Discord.GuildUserEntity", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildEntity", "Guild")
                        .WithMany("GuildUsers")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.AutoModerationRules", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Moderation.AntiSpamRules", "AntiSpamRules")
                        .WithMany()
                        .HasForeignKey("AntiSpamRulesId");

                    b.Navigation("AntiSpamRules");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.Ban", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildEntity", "Guild")
                        .WithMany()
                        .HasForeignKey("GuildId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", null)
                        .WithMany("BanHistory")
                        .HasForeignKey("GuildUserEntityId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "Moderator")
                        .WithMany()
                        .HasForeignKey("ModeratorId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Guild");

                    b.Navigation("Moderator");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.Kick", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildEntity", "Guild")
                        .WithMany()
                        .HasForeignKey("GuildId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", null)
                        .WithMany("KickHistory")
                        .HasForeignKey("GuildUserEntityId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "Moderator")
                        .WithMany()
                        .HasForeignKey("ModeratorId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Guild");

                    b.Navigation("Moderator");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.Mute", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildEntity", "Guild")
                        .WithMany()
                        .HasForeignKey("GuildId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", null)
                        .WithMany("MuteHistory")
                        .HasForeignKey("GuildUserEntityId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "Moderator")
                        .WithMany()
                        .HasForeignKey("ModeratorId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Guild");

                    b.Navigation("Moderator");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.ReprimandAction", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildEntity", "Guild")
                        .WithMany()
                        .HasForeignKey("GuildId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", null)
                        .WithMany("ReprimandHistory")
                        .HasForeignKey("GuildUserEntityId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "Moderator")
                        .WithMany()
                        .HasForeignKey("ModeratorId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Zhongli.Data.Models.Moderation.Reprimands.Warning", "Warning")
                        .WithMany()
                        .HasForeignKey("WarningId");

                    b.Navigation("Guild");

                    b.Navigation("Moderator");

                    b.Navigation("User");

                    b.Navigation("Warning");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.Reprimands.Warning", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Discord.GuildEntity", "Guild")
                        .WithMany()
                        .HasForeignKey("GuildId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", null)
                        .WithMany("WarningHistory")
                        .HasForeignKey("GuildUserEntityId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "Moderator")
                        .WithMany()
                        .HasForeignKey("ModeratorId");

                    b.HasOne("Zhongli.Data.Models.Discord.GuildUserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Guild");

                    b.Navigation("Moderator");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.WarningTrigger", b =>
                {
                    b.HasOne("Zhongli.Data.Models.Moderation.AutoModerationRules", null)
                        .WithMany("WarningTriggers")
                        .HasForeignKey("AutoModerationRulesId");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Authorization.AuthorizationRules", b =>
                {
                    b.Navigation("ChannelAuthorizations");

                    b.Navigation("PermissionAuthorizations");

                    b.Navigation("RoleAuthorizations");

                    b.Navigation("ServerAuthorizations");

                    b.Navigation("UserAuthorizations");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Discord.GuildEntity", b =>
                {
                    b.Navigation("GuildUsers");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Discord.GuildUserEntity", b =>
                {
                    b.Navigation("BanHistory");

                    b.Navigation("KickHistory");

                    b.Navigation("MuteHistory");

                    b.Navigation("ReprimandHistory");

                    b.Navigation("WarningHistory");
                });

            modelBuilder.Entity("Zhongli.Data.Models.Moderation.AutoModerationRules", b =>
                {
                    b.Navigation("WarningTriggers");
                });
#pragma warning restore 612, 618
        }
    }
}
