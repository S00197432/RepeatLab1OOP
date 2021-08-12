using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab1OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Song s1 = new Song("Ed Sheeran", "Beautiful People", 3.15, Genre.Pop);
            Song s2 = new Song("Regard", "Ride It", 3.37, Genre.Dance);
            Song s3 = new Song("Tones & I", "Dance Monkey", 4.20, Genre.Dance);
            Song s4 = new Song("Post Malone", "Circles", 3.25, Genre.Pop);
            Song s5 = new Song("Ed Sheeran", "South Of The Border", 4.26, Genre.Other);

            List<Song> Playlist = new List<Song>();

            Playlist.Add(s1);
            Playlist.Add(s2);
            Playlist.Add(s3);
            Playlist.Add(s4);
            Playlist.Add(s5);

            Display(Playlist);

            Playlist.Sort();
            
            Display(Playlist);

            Playlist = Playlist.OrderBy(i => Guid.NewGuid()).ToList();

            Display(Playlist);
           

        }
        
        //prints the songs details that was added above 
        private static void Display(List<Song> Playlist)
        {
            Console.WriteLine("\n{0,-20}{1,-30}{2,-20}{3,-40}", "Artist--", "Song--", "Duration--", "Genre--");
            foreach (Song song in Playlist)
            {
                Console.WriteLine($"{song.Artist,-20}{song.Title,-30}{song.Duration,-20}{song.SongGenre,-40}");
            }
        }
    }
}
