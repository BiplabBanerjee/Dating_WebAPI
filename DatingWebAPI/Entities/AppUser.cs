using System.ComponentModel.DataAnnotations;

namespace DatingWebAPI.Entities
{
    public class AppUser
    {
        [Key]
        public string UId { get; set; } = Guid.NewGuid().ToString();

        public required string DisplayName { get; set; }

        public string? ImageUrl { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenExpiry { get; set; }
    }
}