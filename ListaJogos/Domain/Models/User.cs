using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace ListaJogosDeals.Domain.Models;

public class User
{
    [Key] private Guid user_id { get; set; }
    private long steam_id { get; set; }
    private string username { get; set; }
    private string avatar_url { get; set; }
    private string profile_url { get; set; }
    private DateTime created_at { get; set; }
    private DateTime updated_at { get; set; }
}