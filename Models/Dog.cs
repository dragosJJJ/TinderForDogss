namespace TinderForDogs.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; } 
        public string Bio { get; set; } 
        public int OwnerId { get; set; }
        public User Owner { get; set; } 
    }
}
