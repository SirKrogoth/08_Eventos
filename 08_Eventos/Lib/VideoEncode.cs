using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _08_Eventos.Lib
{
    class VideoEncode
    {
        public delegate void VideoEncodedHandler(Video video);
        public event VideoEncodedHandler Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Convertendo vídeo");
            Thread.Sleep(2000);
            Console.WriteLine("Vídeo convertido!");

            Encoded(video);
        }
    }
}
