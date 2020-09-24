using System.ComponentModel.DataAnnotations;

namespace ExperienceSpeaks.Dtos
{
    public class UserCreateDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        public string Password { get; set; }
    }
}