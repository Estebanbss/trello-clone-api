
namespace TrelloClone.Data.DTOs
{
    public class AccountDtoOut
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string? Photo { get; set; }
        public string? Email { get; set; } = null!;
        public string Atype { get; set; } = null!;
        public DateTime RegDate { get; set; }

        
    }
}