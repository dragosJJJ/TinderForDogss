namespace TinderForDogs.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int Dog1Id { get; set; }
        public Dog Dog1 { get; set; }

        public int Dog2Id { get; set; }
        public Dog Dog2 { get; set; }

        public DateTime MatchedOn { get; set; }
        public bool IsConfirmed { get; set; } //maybe it will be changed 
    }
}
