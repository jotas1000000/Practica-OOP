using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class MultimediaFile:IMultimediaFile
    {
        string duracion;
        string genero;
        string autor;

        public string Duracion { get => duracion; set => duracion = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Autor { get => autor; set => autor = value; }

        public MultimediaFile()
        {

        }

        public MultimediaFile(string duracion="1920x1080", string genero="Rock", string autor="Desconocido")
        {
            this.duracion = duracion;
            this.genero = genero;
            this.autor = autor;
        }

        public virtual void reproducir()
        {
            Console.WriteLine("Archvo multimedia en REPRODUCCION");
        }

        public virtual void pausar()
        {
            Console.WriteLine("Archvo multimedia en PAUSA");
        }

        public virtual void stop()
        {
            Console.WriteLine("Archvo multimedia en DETENIDO");
        }

        
    }
}
