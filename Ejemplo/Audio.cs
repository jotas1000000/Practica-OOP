using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class Audio:MultimediaFile
    {
        public override void reproducir()
        {
            Console.WriteLine("Audio en REPRODUCCION");
        }

        public override void pausar()
        {
            Console.WriteLine("Audio en PAUSA");
        }

        public override void stop()
        {
            Console.WriteLine("Audio en DETENIDO");
        }
    }
}
