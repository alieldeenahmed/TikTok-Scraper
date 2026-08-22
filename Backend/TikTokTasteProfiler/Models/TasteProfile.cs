namespace TikTokTasteProfiler.Models;

public class TasteProfile
{
    public int ID {get; set;}
    public int AccountID {get; set;}
    public int RepostsAnalyzed {get; set;}
    public List<string> Likes {get; set;}
    public List<string> Points {get; set;}
    public List<string> Caveats {get; set;}
    public List<string> Dislikes {get; set;}
    public List<string> Preferences {get; set;}
    public TikTokAccount Account {get; set;}
    public DateTime GeneratedAtUTC {get; set;}
}