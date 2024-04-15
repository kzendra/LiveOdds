namespace LiveOdds
{
    public class Score
    {
        internal Score() { }

        public uint HomeScore { get; private set; }

        public uint AwayScore { get; private set; }

        internal void UpdateScore(uint home, uint away) 
        {
            //It might be able to decrease the score?
            if (home < HomeScore)
                throw new ArgumentException("Score cannot be decreased", nameof(home));

            if (away < AwayScore)
                throw new ArgumentException("Score cannot be decreased", nameof(away));

            HomeScore = home;
            AwayScore = away;
        }

        public uint TotalScore() 
        { 
            throw new NotImplementedException();
        }
    }
}
