﻿namespace SomeCatIDK.PirateJim.Model;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global

public static class UORoles
{
    #if DEBUG
    
    public const ulong ArtContestWinner = 1269403242916347956;
    public const ulong ContentCreator = 1269403285991718942;
    public const ulong Contributor = 1269403317453328586;
    public const ulong YouTube = 1269403345240723528;
    public const ulong Twitch = 1269403383324999792;
    public const ulong Workshop = 1269403408561999893;
    public const ulong DiscordContestWinner = 1269403439830663271;
    public const ulong SpecialThanks = 1269403482209914990;
    public const ulong CrimsonBeret = 1269403516200288328;
    public const ulong Gold = 1269403549251403957;
    public const ulong EarlyAccess = 1269403573653995616;
    public const ulong WhiteHatter = 1269403596731191419;
    public const ulong Debugger = 1269403623838846986;
    public const ulong ModerationTeam = 1269403644198125638;
    public const ulong ThreadsBanned = 1269403684195008563;
    public const ulong Survivor = 1269403736090869920;
    public const ulong Experienced = 1269413897371254825;
    
    #else
    
    public const ulong SDG = 324232061093412867;
    public const ulong ModerationTeam = 326108032067174411;
    public const ulong Administrator = 324230861245513729;
    public const ulong Moderator = 324230866702434305;
    public const ulong JuniorModerator = 900374139452395530;
    public const ulong Supporter = 553316077636157451;
    public const ulong CommunityStaff = 521032653089013800;
    public const ulong Bots = 553308177756585995;
    public const ulong ModdingSupport = 553315866146766850;
    public const ulong GameSupport = 340042787896426496;
    public const ulong BotBoio = 614492148162625677;
    public const ulong Muted = 700375522412199996;
    public const ulong ThreadsBanned = 1083102466175926292;
    public const ulong ReactionMuted = 685230253819429048;
    public const ulong LivestreamMuted = 732627475200213012;
    public const ulong ModdingResources = 872654242165444709;
    public const ulong ArtContestWinner = 710738372414537728;
    public const ulong ContentCreator = 335740807753629699;
    public const ulong Contributor = 527922530401517586;
    public const ulong YouTube = 335740119996694530;
    public const ulong Twitch = 335740127462555661;
    public const ulong Workshop = 335762652225601536;
    public const ulong DiscordContestWinner = 816862441832448063;
    public const ulong SpecialThanks = 559385313890271244;
    public const ulong CrimsonBeret = 568778449779425293;
    public const ulong WhiteHatter = 568776874071687169;
    public const ulong Debugger = 568776870858850323;
    public const ulong NitroBooster = 585535333584732191;
    public const ulong Gold = 324231297096613888;
    public const ulong EarlyAccess = 333173979801976834;
    public const ulong Experienced = 568776711467040779;
    public const ulong Survivor = 554431731344736258;
    
    #endif
    
    public static readonly ulong[] GrantableRoles =
    [
        ArtContestWinner,
        ContentCreator,
        Contributor, 
        YouTube, 
        Twitch, 
        Workshop, 
        DiscordContestWinner, 
        SpecialThanks, 
        CrimsonBeret, 
        Gold, 
        EarlyAccess, 
        WhiteHatter, 
        Debugger
    ];
}