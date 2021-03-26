using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class Video : MultimediaFile
    {
        string resolucion;

        public Video(string resolucion = "1080x720",string duracion="5min",string genero="pop", string autor="Desconocido")
            :base(duracion,genero,autor)
        {
            this.resolucion = resolucion;
        }

        public void activarSubtitulos()
        {
            Console.WriteLine("Subtitulos activados");
        }

        public void informacionDelVideo()
        {
            Console.WriteLine($"Duracion:{this.resolucion}");
            Console.WriteLine($"Duracion:{this.Duracion}");
            Console.WriteLine($"Genero:{this.Genero}");
            Console.WriteLine($"Autor:{this.Autor}");
        }

        public override void reproducir()
        {
            Console.WriteLine("Video en REPRODUCCION");
        }

        public override void pausar()
        {
            Console.WriteLine("Video en PAUSA");
        }

        public override void stop()
        {
            Console.WriteLine("Video en DETENIDO");
        }
        
    }
}
