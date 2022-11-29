using System.Collections.Generic;
namespace ef_base
{

    internal class Program
{
        private static void Main(string[] args)
        {
            MusicAppDbcontext context = new();


            Artist artist1 = new()
            {
                
                FirstName = "MXR",
                LastName = "CVRY",
                Country = "Russia",

            };
            Album album1 = new()
            {
                Artist = artist1,
                Genre = "Phonk",
                Name = "Phonky",
                Year = 2022,
            };
            Playlist playlist1 = new()
            {
                Name = "Jek",
                Category = "Fun",

            };
            List<Song> songs = new()
            {
            new Song()
            {
                album = album1,
                Name = "Never Speak",
                length = 180,
                Playlists = new List<Playlist>() { playlist1 }
            },
            new Song()
            {
                Name = "Save That Shit",
                length = 351,
                album = album1,
                Playlists = new List<Playlist>() { playlist1 }
            }

            };
            

            album1.Songs = songs;
            artist1.Albums = new List<Album>() { album1 };
            playlist1.Songs = new List<Song>() { songs[1], songs[0] };

            context.SaveChanges();
            context.Albums.Add(album1);
            context.Playlists.Add(playlist1);
            context.Artists.Add(artist1);
            foreach (Song song in songs)
            {
                context.Songs.Add(song);
            }
            context.SaveChanges();
        }
    }
}