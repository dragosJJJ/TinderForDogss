namespace TinderForDogs.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; } 

        public int SenderDogId { get; set; } 
        public Dog SenderDog { get; set; }

        public string Content { get; set; } 
        public DateTime SentAt { get; set; }
    }
}
