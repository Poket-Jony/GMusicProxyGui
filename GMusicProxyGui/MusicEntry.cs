using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace GMusicProxyGui
{
    public class MusicEntry
    {
        public MusicEntry(TimeSpan duration, string artist, string album, string title, string proxyPath)
        {
            Duration = duration;
            Artist = artist;
            Album = album;
            Title = title;
            ProxyPath = proxyPath;
        }

        public TimeSpan Duration { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Title { get; set; }
        public string ProxyPath { get; set; }
        public Bitmap Cover { get; set; }
        public string FilePath { get; set; }
        public string ProxyId { get; set; }

        public bool IsFileExists()
        {
            return File.Exists(FilePath);
        }

        public void UpdateFilePath()
        {
            string path = CleanFileName(string.Format("{0} - {1}.mp3", Artist, Title));
            FilePath = Path.Combine(Properties.Settings.Default.musicPath, path);
        }

        private string CleanFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        public void UpdateIdFromProxyPath()
        {
            Regex regex = new Regex(@".*id=(.*)");
            if(regex.IsMatch(ProxyPath))
            {
                ProxyId = regex.Match(ProxyPath).Groups[1].Value;
            }
        }

        public Bitmap GetCoverFromFile()
        {
            try
            {
                if (IsFileExists())
                {
                    TagLib.File file = TagLib.File.Create(FilePath);
                    TagLib.IPicture pic = file.Tag.Pictures.First();
                    return Cover = new Bitmap(new MemoryStream(pic.Data.Data));
                }
            }
            catch (TagLib.CorruptFileException)
            {
                try
                {
                    File.Delete(FilePath);
                }
                catch { }
            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }

        public static List<MusicEntry> GetMusicEntrysByM3U(string m3uString)
        {
            if (string.IsNullOrEmpty(m3uString))
                return null;

            List<MusicEntry> entries = new List<MusicEntry>();
            Regex regexLine = new Regex(@"(\d*),(.*) - (.*) - (.*)");

            using (StringReader reader = new StringReader(m3uString))
            {
                string line;
                int lineCount = 0;

                MusicEntry entry = null;

                while ((line = reader.ReadLine()) != null)
                {
                    if (lineCount == 0 && line != "#EXTM3U")
                        throw new Exception("M3U header is missing.");

                    if (line.StartsWith("#EXTINF:"))
                    {
                        if (entry != null)
                            throw new Exception("Unexpected entry detected.");

                        line = line.Substring(8, line.Length - 8);

                        if (!regexLine.IsMatch(line))
                            throw new Exception("Invalid track information.");

                        Match match = regexLine.Match(line);

                        int seconds;
                        if (!int.TryParse(match.Groups[1].Value, out seconds))
                            throw new Exception("Invalid track duration.");

                        string artist = match.Groups[2].Value;
                        string title = match.Groups[3].Value;
                        string album = match.Groups[4].Value;

                        TimeSpan duration = TimeSpan.FromSeconds(seconds);

                        entry = new MusicEntry(duration, artist, album, title, null);
                    }
                    else if (entry != null && !line.StartsWith("#")) //ignore comments
                    {
                        Uri path;
                        if (!Uri.TryCreate(line, UriKind.RelativeOrAbsolute, out path))
                            throw new Exception("Invalid entry path.");

                        entry.ProxyPath = path.ToString();
                        entry.UpdateFilePath();
                        entry.UpdateIdFromProxyPath();

                        entries.Add(entry);
                        entry = null;
                    }
                    lineCount++;
                }
            }
            return entries;
        }

        public override string ToString()
        {
            return ProxyId;
        }
    }
}
