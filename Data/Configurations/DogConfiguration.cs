using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TinderForDogs.Models;

namespace TinderForDogs.Data.Configurations
{
    public class SeedDogsConfiguration : IEntityTypeConfiguration<Dog>
    {
        public void Configure(EntityTypeBuilder<Dog> builder)
        {
            builder.HasData(
                new Dog { Id = 1, Name = "Mirel", Breed = "Golden Retriever", Age = 3, Gender = "Male", Bio = "Loves to play fetch!", OwnerId = 1 },
                new Dog { Id = 2, Name = "Maria", Breed = "Labrador", Age = 2, Gender = "Female", Bio = "Enjoys swimming.", OwnerId = 2 },
                new Dog { Id = 3, Name = "Nefor", Breed = "Corgi", Age = 4, Gender = "Male", Bio = "Short legs, big heart.", OwnerId = 3 },
                new Dog { Id = 4, Name = "Olmanei", Breed = "Poodle", Age = 5, Gender = "Female", Bio = "Very smart and friendly.", OwnerId = 4 }
            );
        }
    }
}
