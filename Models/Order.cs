namespace SiteManagerServer.Models;

public class Order
{
    public long Id { get; set; }
    public required long SiteId { get; set; }
	public required int TotalPrice { get; set; }


}

