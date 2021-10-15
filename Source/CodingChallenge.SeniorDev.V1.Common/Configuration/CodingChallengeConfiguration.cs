namespace CodingChallenge.SeniorDev.V1.Common.Configuration
{
    public class CodingChallengeConfiguration
    {
        public InfoConfig Info { get; set; }
    }

    public class InfoConfig
    {
        public string Author { get; set; }
        public string HardestChallenge { get; set; }
    }
}
