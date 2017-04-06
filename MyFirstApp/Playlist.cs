using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Playlist
    {

        private int length;

        public int Id { get; set; }
        public string Title { get; set; }
        public List<Song> Songs { get; }
        public User Owner { get; set; }
        public float Rating { get; set; }
        public int Length { get { return length; } }
        //public DateTime DateCreated { get; set; }

        public Playlist() {

            Songs = new List<Song>();

        }

        public void AddSong(Song song) {

            Songs.Add(song);
            length += song.Length;

        }
    }
}
