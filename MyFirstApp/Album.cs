using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{

    public class Album
    {

        private int length;

        public int Id { get; set; }
        public string Title { get; set; }
        public List<Song> Songs { get; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }
        public Image Image { get; set; }

        public Album() {

            Songs = new List<Song>();

        }

        public void AddSong(Song song)
        {

            Songs.Add(song);
            length += song.Length;

        }

    }
}
