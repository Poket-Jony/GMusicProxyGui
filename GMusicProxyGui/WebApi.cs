using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMusicProxyGui
{
    public class WebApi
    {
        private WebController webController;

        private static WebApi instance;
        public static WebApi Instance //Singleton
        {
            get
            {
                if (instance == null)
                    instance = new WebApi();
                return instance;
            }
        }

        private WebApi()
        {
            webController = new WebController(Properties.Settings.Default.proxyUrl);
        }

        public static WebApi GetNewInstance()
        {
            return instance = new WebApi();
        }

        public List<MusicEntry> GetMusicBySearch(string title, string artist, int count = 20)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("type", "matches");
            if(!string.IsNullOrEmpty(title))
                data.Add("title", title);
            if(!string.IsNullOrEmpty(artist))
                data.Add("artist", artist);
            data.Add("exact", "no");
            data.Add("num_tracks", count.ToString());
            string response = webController.RequestString("get_by_search", data);
            return MusicEntry.GetMusicEntrysByM3U(response);
        }

        public List<MusicEntry> GetMusicByMixSearch(string title, string artist, int count = 20)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("type", "song");
            if (!string.IsNullOrEmpty(title))
                data.Add("title", title);
            if (!string.IsNullOrEmpty(artist))
                data.Add("artist", artist);
            data.Add("exact", "no");
            data.Add("num_tracks", count.ToString());
            data.Add("transient", "yes");
            string response = webController.RequestString("get_new_station_by_search", data);
            return MusicEntry.GetMusicEntrysByM3U(response);
        }

        public async Task DownloadSong(string url, string filePath)
        {
            try
            {
                await new WebController(url).RequestFile(filePath);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public enum SearchType
        {
            song,
            album,
            artist
        };
        public string GetIdBySearch(SearchType type, string title, string artist, bool exact = true)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("type", type.ToString());
            if (!string.IsNullOrEmpty(title))
                data.Add("title", title);
            if (!string.IsNullOrEmpty(artist))
                data.Add("artist", artist);
            data.Add("exact", exact ? "yes" : "no");
            return webController.RequestString("search_id", data);
        }

        public List<MusicEntry> GetAlbumById(string id)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("id", id);
            string response = webController.RequestString("get_album", data);
            return MusicEntry.GetMusicEntrysByM3U(response);
        }

        public List<PlaylistEntry> GetMyPlaylists()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("format", "text");
            data.Add("separator", "|");
            data.Add("only_url", "no");
            string response = webController.RequestString("get_all_playlists", data);
            return PlaylistEntry.GetPlaylistEntrysByText(response);
        }

        public List<PlaylistEntry> GetMyStations()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("format", "text");
            data.Add("separator", "|");
            data.Add("only_url", "no");
            string response = webController.RequestString("get_all_stations", data);
            return PlaylistEntry.GetPlaylistEntrysByText(response);
        }

        public List<MusicEntry> GetMusicByPlaylist(PlaylistEntry playlistEntry)
        {
            string response = webController.RequestString(playlistEntry.ProxyPath);
            return MusicEntry.GetMusicEntrysByM3U(response);
        }

        /*public MusicEntry GetSongById(string id)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("id", id);
            string response = webController.RequestString("get_song", data);
            List<MusicEntry> music = MusicEntry.GetMusicEntrysByM3U(response);
            return music != null ? music.First() : null;
        }*/

        public List<MusicEntry> GetArtistTopTracksById(string id, int count = 20)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("id", id);
            data.Add("type", "song");
            data.Add("num_tracks", count.ToString());
            string response = webController.RequestString("get_top_tracks_artist", data);
            return MusicEntry.GetMusicEntrysByM3U(response);
        }
    }
}
