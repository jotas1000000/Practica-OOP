using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    interface IMultimediaFile
    {
        public void reproducir();

        public void pausar();

        public void stop();
    }
}
