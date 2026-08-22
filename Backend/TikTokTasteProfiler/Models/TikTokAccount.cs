namespace TikTokTasteProfiler.Models;

public class TikTokAccount
{
    public int ID {get; set;}
    public int Followers {get; set;}
    public int Following {get; set;}
    public bool IsPublic; 
    public string Handle {get; set;}
    public DateTime LastScraped {get; set;}
    public List<Repost> Reposts {get; set;}
    public List<TasteProfile> Taste {get; set;};
}