using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace GMusicProxyGui
{
    public class ListImporter
    {
        private List<string> importList = new List<string>();
        public ListType Type { get; private set; }
        public List<MusicEntry> MusicList { get; private set; }

        public enum ListType
        {
            TitleAndArtist,
            ArtistAndTitle
        };

        public ListImporter(string path, ListType type)
        {
            if (File.Exists(path))
            {
                importList = File.ReadLines(path, Encoding.UTF8).ToList();
                Type = type;
                MusicList = GetMusicList();
            }
        }

        private List<MusicEntry> GetMusicList()
        {
            List<MusicEntry> mlist = new List<MusicEntry>();
            switch(Type)
            {
                case ListType.ArtistAndTitle:
                    {
                        Regex regexLine = new Regex(@"(.*) - (.*)");
                        foreach (string line in importList)
                        {
                            if (!string.IsNullOrEmpty(line) && regexLine.IsMatch(line))
                            {
                                Match match = regexLine.Match(line);
                                string artist = match.Groups[1].Value;
                                string title = match.Groups[2].Value;
                                mlist.Add(new MusicEntry(artist, title));
                            }
                        }
                        break;
                    }
                case ListType.TitleAndArtist:
                    {
                        Regex regexLine = new Regex(@"(.*) - (.*)");
                        foreach (string line in importList)
                        {
                            if (!string.IsNullOrEmpty(line) && regexLine.IsMatch(line))
                            {
                                Match match = regexLine.Match(line);
                                string artist = match.Groups[2].Value;
                                string title = match.Groups[1].Value;
                                mlist.Add(new MusicEntry(artist, title));
                            }
                        }
                        break;
                    }
            }
            return GetMusicListByMetaList(mlist);
        }

        private List<MusicEntry> GetMusicListByMetaList(List<MusicEntry> metaList)
        {
            List<MusicEntry> musicList = new List<MusicEntry>();
            foreach(MusicEntry entry in metaList)
            {
                switch(Type)
                {
                    case ListType.TitleAndArtist:
                    case ListType.ArtistAndTitle:
                        {
                            List<MusicEntry> musicEntrys = WebApi.Instance.GetMusicBySearch(entry.Title, entry.Artist);
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
