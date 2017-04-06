using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class User: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username { get; set; }
        public string Password { get; set; }
        public List<Playlist> Playlists { get; }

        public User() {

            Playlists = new List<Playlist>();

        }

        public void AddPlaylist(Playlist playlist) {

            Playlists.Add(playlist);

        }

        protected void OnChange(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

    }
}
