namespace SiteManagerServer.Models;

public class Product
{
    public long Id { get; set; }
    public required string Name { get; set; }
	public required string Manufacturer { get; set; }
	public required string Model { get; set; }
    public int Price { get; set; }

}