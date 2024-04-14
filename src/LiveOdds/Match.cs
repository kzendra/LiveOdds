﻿namespace LiveOdds
{
    public class Match
    {
        internal Match(string homeTeam, string awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeScore = 0;
            AwayScore = 0;
        }

        public string HomeTeam {  get; private set; }

        public string AwayTeam { get; private set; }

        public int HomeScore { get; private set; } 

        public int AwayScore { get; private set; }
    }
}
