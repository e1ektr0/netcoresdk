using Oddin.OddsFeedSdk.API.Entities.Abstractions;

namespace Oddin.OddsFeedSdk.API.Entities;

internal class PeriodScore : IPeriodScore
{
    public PeriodScore(
        double homeScore,
        double awayScore,
        int periodNumber,
        int matchStatusCode,
        string type,
        int? homeWonRounds,
        int? awayWonRounds,
        int? homeKills,
        int? awayKills,
        int? homeGoals,
        int? awayGoals,
        int? homePoints,
        int? awayPoints,
        int? homeRuns,
        int? awayRuns,
        int? homeWicketsFallen,
        int? awayWicketsFallen,
        int? homeOversPlayed,
        int? awayOversPlayed,
        int? homeBallsPlayed,
        int? awayBallsPlayed,
        bool? homeWonCoinToss
    )
    {
        HomeScore = homeScore;
        AwayScore = awayScore;
        PeriodNumber = periodNumber;
        MatchStatusCode = matchStatusCode;
        Type = type;
        HomeWonRounds = homeWonRounds;
        AwayWonRounds = awayWonRounds;
        HomeKills = homeKills;
        AwayKills = awayKills;
        HomeGoals = homeGoals;
        AwayGoals = awayGoals;
        HomePoints = homePoints;
        AwayPoints = awayPoints;
        HomeRuns = homeRuns;
        AwayRuns = awayRuns;
        HomeWicketsFallen = homeWicketsFallen;
        AwayWicketsFallen = AwayWicketsFallen;
        HomeOversPlayed = homeOversPlayed;
        AwayOversPlayed = awayOversPlayed;
        HomeBallsPlayed = homeBallsPlayed;
        AwayBallsPlayed = awayBallsPlayed;
        HomeWonCoinToss = homeWonCoinToss;
    }

    public double HomeScore { get; }
    public double AwayScore { get; }
    public int PeriodNumber { get; }
    public int MatchStatusCode { get; }
    public string Type { get; }
    public int? HomeWonRounds { get; }
    public int? AwayWonRounds { get; }
    public int? HomeKills { get; }
    public int? AwayKills { get; }
    public int? HomeGoals { get; }
    public int? AwayGoals { get; }
    public int? HomePoints { get; }
    public int? AwayPoints { get; }
    public int? HomeRuns { get; }
    public int? AwayRuns { get; }
    public int? HomeWicketsFallen { get; }
    public int? AwayWicketsFallen { get; }
    public int? HomeOversPlayed { get; }
    public int? AwayOversPlayed { get; }
    public int? HomeBallsPlayed { get; }
    public int? AwayBallsPlayed { get; }
    public bool? HomeWonCoinToss { get; }
}