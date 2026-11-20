namespace ListaJogosDeals.Domain.Models;

public class UserWishlist
{
    private Guid id { get; set; }
    private User user { get; set; }
    private List<Game> games { get; set; }
}