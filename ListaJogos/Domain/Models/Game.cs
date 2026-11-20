namespace ListaJogosDeals.Domain.Models;

public class Game
{
    private Guid id { get; set; }
    private long game_id { get; set; }
    private string game_title { get; set; }
    private string description { get; set; }
    private string game_type { get; set; }
    private string game_header_img { get; set; }
    private string genre { get; set; }
    private string release_date { get; set; }
    private DateTime created_at { get; set; }
}