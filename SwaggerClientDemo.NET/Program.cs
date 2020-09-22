using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerClientDemo.NET
{
    class Program
    { 

        static async Task Main(string[] args)
        {

            Console.WriteLine("Welcome to Nswag Generated Client");

            // Created object of class ValuesClient  

            Client client = new Client();

            // Call FindPetsByStatusAsync   
            var availablePets = await client.FindPetsByStatusAsync(new[] { Anonymous.Available });

            Tag tag = new Tag
            {
                Id = 10,
                Name = "doggo"
            };

            Category category = new Category
            {
                Id = 10,
                Name = "jumper"
            };

            Pet newPet = new Pet
            {
                Id = availablePets.Count + 1,
                Name = "kopek",
                PhotoUrls = new[] { "http//#" },
                Status = PetStatus.Available,
                Tags = new[] { tag },
                Category = category
            };

            // Call AddPetAsync 
            await client.AddPetAsync(newPet);
        }

    }
}
