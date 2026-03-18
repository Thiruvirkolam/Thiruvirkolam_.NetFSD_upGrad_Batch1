using System;
using System.Collections.Generic;
using System.Text;

class Song
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Artist { get; set; }

    public Song(int id, string? title, string? artist)
    {
        Id = id;
        Title = title;
        Artist = artist;
    }

    public override string ToString()
    {
        return $"{Id} - {Title} by {Artist}";
    }
}

class Program
{
    static void Main()
    {
        LinkedList<Song> playlist = new LinkedList<Song>();

        var s1 = new Song(1, "Song A", "Artist 1");
        var s2 = new Song(2, "Song B", "Artist 2");
        var s3 = new Song(3, "Song C", "Artist 3");
        var s4 = new Song(4, "Song D", "Artist 4");

        playlist.AddFirst(s1);
        playlist.AddLast(s2);

        var node = playlist.Find(s2);
        if (node != null)
        {
        playlist.AddBefore(node, s3);
        }
        else
        {
        Console.WriteLine("Song not found to insert before.");
        }
        
        playlist.AddLast(s4);

        Console.WriteLine("Playlist Forward:");
        foreach (var song in playlist)
            Console.WriteLine(song);

        Console.WriteLine("\nPlaylist Backward:");
        var current = playlist.Last;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Previous;
        }

        Console.WriteLine("\nRemoving Song B:");
        playlist.Remove(s2);

        Console.WriteLine("\nSearch Song C:");
        var found = playlist.First;
        while (found != null)
        {
            if (found.Value.Title == "Song C")
            {
                Console.WriteLine("Found: " + found.Value);
                break;
            }
            found = found.Next;
        }

        Console.WriteLine("\nPlay Next Feature:");
        var currentSong = playlist.First;
        if (currentSong != null && currentSong.Next != null)
            Console.WriteLine("Next Song: " + currentSong.Next.Value);

        Console.WriteLine("\nFinal Playlist:");
        foreach (var song in playlist)
            Console.WriteLine(song);
    }
}