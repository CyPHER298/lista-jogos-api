using System.ComponentModel.DataAnnotations;

namespace ListaJogosDeals.Infrastructure.Persistence.Models;

public class Price
{
    [Key] public long price_id { get; set; }
    public Game game { get; set; }
    [Required] public string game_id { get; set; }
    public string store_name { get; set; }
    [Required] public decimal current_retail { get; set; }
    [Required] public decimal current_keyshops { get; set; }
    public decimal historical_retail { get; set; }
    public decimal historical_keyshops { get; set; }
    public int cut_percentage { get; set; }
    public DateTime updated_at { get; set; } = DateTime.MinValue;
}