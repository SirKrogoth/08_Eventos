using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _08_Eventos.Lib;
using _08_Eventos.Lib.Mensageiro;


namespace _08_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += EventoClick;
        }

        //Criado manualmente
        public void EventoClick(object sender, EventArgs e)
        {
            Video video = new Video() { nome = "video.mp3" };
            VideoEncode v = new VideoEncode();

            v.Encoded += new Email().EnviarMensagem;
            v.Encoded += new SMS().EnviarMensagem;

            v.Encode(video);
        }
    }
}
