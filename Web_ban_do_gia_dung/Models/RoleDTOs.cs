namespace Web_ban_do_gia_dung.Models
{
    public class RoleDTOs
    {
        public int RoleId { get; set; }

        public string Name { get; set; } = null!;

        public DateTime? Created { get; set; }

        public string? Description { get; set; }
    }
}
