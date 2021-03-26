using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Video videoCualquiera = new Video("1920x1080", "4:30min", "Bachata", "Desconocido");
            videoCualquiera.informacionDelVideo();

            Console.WriteLine("***********************");

            MultimediaFile videoPoliformismo = new MultimediaFile();
            videoPoliformismo = new Video();
            videoPoliformismo.reproducir();

            Console.WriteLine("***********************");

            MultimediaFile musicaPoliformismo = new MultimediaFile();
            musicaPoliformismo = new Audio();
            musicaPoliformismo.reproducir();

            Console.WriteLine("***********************");

        }
    }
}
