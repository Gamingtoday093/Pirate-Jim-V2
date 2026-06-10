using Discord;
using System;

namespace SomeCatIDK.PirateJim.Extensions;

public static class GuildUserExtensions
{
    public static bool IsTimedOut(this IGuildUser guildUser)
    {
        return guildUser.TimedOutUntil != null && guildUser.TimedOutUntil > DateTimeOffset.UtcNow;
    }
}
