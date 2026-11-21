using System.ComponentModel.DataAnnotations;

namespace ListaJogosDeals.Infrastructure.Persistence.Models;

public class Game
{
    [Key] public Guid game_id { get; set; } = Guid.NewGuid();
    [Required] public long app_id { get; set; }
    [Required] public string game_title { get; set; }
    public string description { get; set; }
    [Required] public string game_type { get; set; }
    public string game_header_img { get; set; }
    public string genre { get; set; }
    public string release_date { get; set; }
    public DateTime update_at { get; set; }
}