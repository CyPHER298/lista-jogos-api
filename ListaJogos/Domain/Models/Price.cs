namespace ListaJogosDeals.Domain.Models;

public class Price
{
    private Guid id { get; set; }
    private long price_id { get; set; }
    private Game game { get; set; }
    private string store_name { get; set; }
    private float current_price { get; set; }
    private float retail_price { get; set; }
    private int cut_percentage { get; set; }
    private bool historical_low { get; set; }
}