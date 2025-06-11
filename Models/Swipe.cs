namespace TinderForDogs.Models
{
    public class Swipe
    {
        public int Id { get; set; }
        public int SwiperDogId { get; set; } 
        public Dog SwiperDog { get; set; }

        public int TargetDogId { get; set; } 
        public Dog TargetDog { get; set; }

        public bool Liked { get; set; } 
        public DateTime SwipedOn { get; set; }
    }
}
