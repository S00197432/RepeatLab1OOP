using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab1OOP
{
    class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre SongGenre { get; set; }
       
        public Song(string title, string artist, double duration, Genre genre)
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
    }
    public enum Genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }
}
