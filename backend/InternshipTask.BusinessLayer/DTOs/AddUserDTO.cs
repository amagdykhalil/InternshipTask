namespace InternshipTask.BusinessLayer.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public record AddUserDTO
    {
        [Required]
        [StringLength(254, ErrorMessage = "Email must not exceed 254 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Username must not exceed 50 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,50}$", ErrorMessage = "Username can contain letters, numbers, and underscores (3–50 characters).")]
        public string UserName { get; set; }
    }

}
