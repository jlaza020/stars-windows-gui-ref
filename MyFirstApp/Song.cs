using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Song: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public string Title { get; set; }
        public Album Album { get; set; }
        public string Artist { get { return Album.Artist;  } }
        public Image Image { get { return Album.Image; } }
        public string AlbumTitle { get { return Album.Title; } }
        public int Year { get { return Album.Year; } }
        public string Genre { get { return Album.Genre; } }
        public int Length { get; set; }

        public Song() { }

        protected void OnChange(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


    }
}
