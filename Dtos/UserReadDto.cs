using System.ComponentModel.DataAnnotations;

namespace ExperienceSpeaks.Dtos
{
    public class UserReadDto
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        // public string Password { get; set; }
    }
}