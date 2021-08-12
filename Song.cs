using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab1OOP
{
    public class Song : IComparable
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre SongGenre { get; set; }
       
        public Song(string artist, string title, double duration, Genre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            SongGenre = genre;
        }

        //prints the title,artist,duration and genre of a song
        public override string ToString()
        {
            return string.Format($"{Artist} {Title} {Duration} {SongGenre}");
        }

        public int CompareTo(object obj)
        {
            Song ArtistIAmComparing = obj as Song;
            int returnValue = this.Artist.CompareTo(ArtistIAmComparing.Artist);
            return returnValue;
           
        }
    }
    public enum Genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }
}
