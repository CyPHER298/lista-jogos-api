using System.ComponentModel.DataAnnotations;

namespace ListaJogosDeals.Infrastructure.Persistence.Models;

public class UserWishlist
{
    [Key] public Guid user_wishlist_id { get; set; } = Guid.NewGuid();
    private User user { get; set; }
    private List<Game> games { get; set; }
    [Required] public Guid user_id { get; set; }
    [Required] public List<Guid> game_id { get; set; }
    public DateTime added_at { get; set; } = DateTime.MinValue;
}