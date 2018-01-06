namespace Russia2018.Domain
{
    public class Score
    {
        public int Id { get; set; }

        public ScoreType ScoreType { get; set; }

        public int PointsForHosts { get; set; }

        public int PointsForGuests { get; set; }
    }
}