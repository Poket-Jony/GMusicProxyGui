using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Threading;
using NAudio.Wave;

namespace GMusicProxyGui.Controller
{
    public class AudioController
    {
        private static AudioController instance;
        public static AudioController Instance //Singleton
        {
            get
            {
                if (instance == null)
                    instance = new AudioController();
                return instance;
            }
        }

        public WaveOut WaveOut { get; } = new WaveOut(WaveCallbackInfo.FunctionCallback());
        public string AudioUrl { get; private set; }

        public async Task PlayMp3FromUrl(string url)
        {
            AudioUrl = url;
            Stream ms = new MemoryStream();
            Stream stream = WebRequest.Create(url).GetResponse().GetResponseStream();
            byte[] buffer = new byte[32768];
            int read;
            await Task.Run(() =>
            {
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, read);
            });
            stream.Close();
            ms.Position = 0;
            WaveStream blockAlignedStream = new BlockAlignReductionStream(WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(ms)));
            WaveOut.Init(blockAlignedStream);
            WaveOut.Play();
            while (WaveOut.PlaybackState == PlaybackState.Playing)
                await Task.Delay(100);
            blockAlignedStream.Close();
            ms.Close();
        }

        public void StopAudio()
        {
            WaveOut.Stop();
            AudioUrl = null;
        }
    }
}
