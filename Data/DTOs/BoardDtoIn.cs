namespace TrelloClone.Data.DTOs
{
     public class BoardDtoIn
     {
          public int Id { get; set; }
          public string Name { get; set; } = null!;
          public int AccountId { get; set; }
     }
}