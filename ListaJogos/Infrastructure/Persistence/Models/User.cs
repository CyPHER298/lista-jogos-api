using System.ComponentModel.DataAnnotations;

namespace ListaJogosDeals.Infrastructure.Persistence.Models;

public class User
{
    [Key] public Guid user_id { get; set; } = Guid.NewGuid();
    [Required] public long steam_id { get; set; }
    [Required] public string username { get; set; }
    public string avatar_url { get; set; }
    public string profile_url { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}