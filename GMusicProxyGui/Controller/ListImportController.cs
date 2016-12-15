using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using GMusicProxyGui.Model;

namespace GMusicProxyGui.Controller
{
    public class ListImportController
    {
        private List<string> importList = new List<string>();
        public ListType Type { get; private set; }
        public List<MusicEntryModel> MusicList { get; private set; }

        public enum ListType
        {
            TitleAndArtist,
            ArtistAndTitle
        };

        public ListImportController(string path, ListType type)
        {
            if (File.Exists(path))
            {
                importList = File.ReadLines(path, Encoding.UTF8).ToList();
                Type = type;
                MusicList = GetMusicList();
            }
        }

        private List<MusicEntryModel> GetMusicList()
        {
            List<MusicEntryModel> mlist = new List<MusicEntryModel>();
            switch(Type)
            {
                case ListType.ArtistAndTitle:
                    {
                        Regex regexLine = new Regex(@"(.*) (?:-|–) (.*)");
                        foreach (string line in importList)
                        {
                            if (!string.IsNullOrEmpty(line) && regexLine.IsMatch(line))
                            {
                                Match match = regexLine.Match(line);
                                string artist = match.Groups[1].Value;
                                if (artist.Contains(';'))
                                    artist = artist.Remove(artist.IndexOf(';'));
                                string title = match.Groups[2].Value;
                                mlist.Add(new MusicEntryModel(artist, title));
                            }
                        }
                        break;
                    }
                case ListType.TitleAndArtist:
                    {
                        Regex regexLine = new Regex(@"(.*) (?:-|–) (.*)");
                        foreach (string line in importList)
                        {
                            if (!string.IsNullOrEmpty(line) && regexLine.IsMatch(line))
                            {
                                Match match = regexLine.Match(line);
                                string artist = match.Groups[2].Value;
                                string title = match.Groups[1].Value;
                                mlist.Add(new MusicEntryModel(artist, title));
                            }
                        }
                        break;
                    }
            }
            return GetMusicListByMetaList(mlist);
        }

        private List<MusicEntryModel> GetMusicListByMetaList(List<MusicEntryModel> metaList)
        {
            List<MusicEntryModel> musicList = new List<MusicEntryModel>();
            foreach(MusicEntryModel entry in metaList)
            {
                switch(Type)
                {
                    case ListType.TitleAndArtist:
                    case ListType.ArtistAndTitle:
                    {
                        List<MusicEntryModel> musicEntrys = ProxyApiController.Instance.GetMusicBySearch(entry.Title, entry.Artist, 1);
                        if (musicEntrys == null || musicEntrys.Count == 0)
                            continue;
                        musicList.Add(musicEntrys.First());
                        break;
                    }
                }
            }
            return musicList;
        }
    }
}
