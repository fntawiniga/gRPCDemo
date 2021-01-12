using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Server
{
    public class CharacterService: Demo.Characters.CharactersBase
    {
        public static IEnumerable<Character> Characters = new List<Character>
        {
            new Character {Id = 1, FirstName = "Peppa", LastName = "Pig", Show = "Peppa Pig" },
            new Character {Id = 2, FirstName = "Suzie", LastName = "Sheep", Show = "Peppa Pig" },
            new Character {Id = 3, FirstName = "Edmun", LastName = "Elephant", Show = "Peppa Pig" },
            new Character {Id = 4, FirstName = "Homer", LastName = "Simpson", Show = "Simpsons" },
            new Character {Id = 5, FirstName = "Emma", LastName = "Wiggle", Show = "Wiggles" },
            new Character {Id = 6, FirstName = "Lachie", LastName = "Wiggle", Show = "Wiggles" },
            new Character {Id = 7, FirstName = "Anthony", LastName = "Wiggle", Show = "Wiggles" },
            new Character {Id = 8, FirstName = "Simon", LastName = "Wiggle", Show = "Wiggles" },
        };

        public override Task<CharacterResponse> GetCharacter(CharacterRequest request, ServerCallContext context)
        {
            var character = Characters.FirstOrDefault(i => i.Id == request.Id);
            return Task.FromResult(new CharacterResponse { Character = character }) ;
        }
    }
}
