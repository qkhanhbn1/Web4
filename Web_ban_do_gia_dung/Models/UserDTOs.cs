namespace Web_ban_do_gia_dung.Models
{
    public class UserDTOs
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTime? Created { get; set; }

        public bool? Status { get; set; }

        public int? RoleId { get; set; }

        public string? AvatarImg { get; set; }
    }
}
