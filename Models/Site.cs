namespace SiteManagerServer.Models;

public class Site
{
    public long Id { get; set; }
    public required string Name { get; set; }
	public required string Address { get; set; }
	public required string WorkType { get; set; }
}