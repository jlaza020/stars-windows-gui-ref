using System;
using System.Collections.Generic;
using System.Drawing;                   // Image
using System.IO;                        // Stream, FileStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Database
    {
        public User CurrentUser { get; set; }
        public List<Album> Albums { get; }
        public List<Playlist> Playlists { get; }
        public List<Song> Songs { get; }
        public List<User> Users { get; }

        private static string rootPath = "../../dat";
        private static string imagesRootPath = "../../dat";
        private static string usersPath = "user.csv";
        private static string albumsPath = "album.csv";
        private static string songsPath = "song.csv";
        private static string playlistsPath = "playlist.csv";
        private static string playlistSongsPath = "playlistsongs.csv";

        public Database() {

            Albums = new List<Album>();
            Playlists = new List<Playlist>();
            Songs = new List<Song>();
            Users = new List<User>();
        }

        public Album GetAlbum(int id)
        {

            for (int i = 0; i < Albums.Count; i++)
            {

                if (Albums[i].Id == id)
                    return Albums[i];

            }

            return null;

        }

        public User GetUser(string username)
        {


            for (int i = 0; i < Users.Count; i++)
            {

                if (Users[i].Username == username)
                    return Users[i];

            }

            return null;

        }

        public Song GetSong(int id)
        {

            for (int i = 0; i < Songs.Count; i++)
            {

                if (Songs[i].Id == id)
                    return Songs[i];

            }

            return null;

        }

        public Playlist GetPlaylist(int id) {

            for (int i = 0; i < Playlists.Count; i++)
            {

                if (Playlists[i].Id == id)
                    return Playlists[i];

            }

            return null;

        }

        public void Load() {

            LoadUsers(rootPath + "/" + usersPath);
            LoadAlbums(rootPath + "/" + albumsPath, imagesRootPath);
            LoadSongs(rootPath + "/" + songsPath);
            LoadPlaylists(rootPath + "/" + playlistsPath);
            LoadPlaylistSongs(rootPath + "/" + playlistSongsPath);

        }

        public void LoadUsers(string path) {

            using (FileStream fileStream = File.OpenRead(@path))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    int i = 0;
                    string line = reader.ReadLine();

                    if (line == "" || line[0] == '#')
                        continue;

                    string[] values = line.Split(',');

                    User user = new User();
                    user.Username = values[i++];
                    user.Password = values[i++];

                    Users.Add(user);

                }
            }

        }

        public void LoadAlbums(string path, string imagesRootPath)
        {

            using (FileStream fileStream = File.OpenRead(@path))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    int i = 0;
                    string line = reader.ReadLine();

                    if (line == "" || line[0] == '#')
                        continue;

                    string[] values = line.Split(',');
                    
                    Album album = new Album();
                    album.Id = Int32.Parse(values[i++]);
                    album.Artist = values[i++];
                    album.Title = values[i++];
                    album.Genre = values[i++];
                    album.Year = Int32.Parse(values[i++]);
                    album.Image = Image.FromFile(imagesRootPath + "/" + values[i++], true);

                    Albums.Add(album);

                }
            }

        }

        public void LoadSongs(string path) {

            using (FileStream fileStream = File.OpenRead(@path))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    int i = 0;
                    string line = reader.ReadLine();

                    if (line == "" || line[0] == '#')
                        continue;

                    string[] values = line.Split(',');

                    Song song = new Song();
                    song.Id = Int32.Parse(values[i++]);
                    song.Title = values[i++];
                    song.Album = GetAlbum(Int32.Parse(values[i++]));
                    song.Length = Int32.Parse(values[i++]);
                    song.Album.AddSong(song);

                    Songs.Add(song);

                }
            }


        }

        public void LoadPlaylists(string path) {

            using (FileStream fileStream = File.OpenRead(@path))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    int i = 0;
                    string line = reader.ReadLine();

                    if (line == "" || line[0] == '#')
                        continue;

                    string[] values = line.Split(',');

                    Playlist playlist = new Playlist();
                    playlist.Id = Int32.Parse(values[i++]);
                    playlist.Title = values[i++];
                    playlist.Owner = GetUser(values[i++]);
                    playlist.Rating = float.Parse(values[i++]);
                    
                    Playlists.Add(playlist);

                }
            }

        }

        public void LoadPlaylistSongs(string path) {


            using (FileStream fileStream = File.OpenRead(@path))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    int i = 0;
                    string line = reader.ReadLine();

                    if (line == "" || line[0] == '#')
                        continue;

                    string[] values = line.Split(',');

                    int playListId = Int32.Parse(values[i++]);
                    int songId = Int32.Parse(values[i++]);

                    GetPlaylist(playListId).AddSong(GetSong(songId));

                }
            }

        }

        public bool LoginUser(string username, string password) {

            for (int i = 0; i < Users.Count; i++) {

                if (Users[i].Username == username && Users[i].Password == password)
                {
                    CurrentUser = Users[i];
                    return true;
                }
            }

            return false;

        }

    }
}
