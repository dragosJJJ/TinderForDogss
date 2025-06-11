namespace TinderForDogs.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public Dog Dog { get; set; }

        public string City { get; set; } 
        public string Neighborhood { get; set; }
        public string FavoritePark { get; set; } 

        public DateTime LastUpdated { get; set; }
    }
}
