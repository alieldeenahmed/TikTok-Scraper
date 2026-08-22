namespace TikTokTasteProfiler.Models;

public class Repost
{
    public int ID {get; set;}
    public int AccountID {get; set;}
    public int CreatorFollowers {get; set;}
    public string VideoID {get; set;}
    public string CreatorID {get; set;}
    public string CreatorHandle {get; set;}
    public TikTokAccount Account {get; set;}

    public int Likes {get; set;}
    public int Shares {get; set;}
    public int Comments {get; set;}
    public string VideoURL {get; set;}
    public string Audio {get; set;}
    public string Caption {get; set;}
    public DateTime PostDate {get; set;}
    public List<string> Hashtags {get; set;}

}