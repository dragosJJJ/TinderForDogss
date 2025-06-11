using Microsoft.AspNetCore.Identity;

namespace TinderForDogs.Models
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Dog> Dogs { get; set; } = new List<Dog>();
    }
}
