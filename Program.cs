// See https://aka.ms/new-console-template for more information
using SQLite;


Console.WriteLine("Hello, World!");

// Connessione al db
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtists = cn1.Query<Artist>("select * from Artists");
Console.WriteLine($" in questa tabella ci sono {tblArtists.Count} record!");


//fine del main.... inizio delle dichiarazioni
public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}
}