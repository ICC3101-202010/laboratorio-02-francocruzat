using System;
using System.Collections.Generic;

namespace laboratorio2_franco
{
    class Cancion
    {
        string Nombre;
        string Album;
        string Artista;
        string Genero;

        public Cancion(string genero, string artista, string album, string nombre)
        {
            Genero = genero;
            Artista = artista;
            Album = album;
            Nombre = nombre;

        }
        public string Informacion()
        {
            return "genero:"+Genero+","+"artista:"+Artista+","+"album:"+Album+","+"nombre:"+Nombre;
            }
  








        public static void Main(string[] args)
        {
            var cancion = new Cancion("rock", "elvis presley", "hawai", "nada");
            Console.WriteLine(cancion.Informacion());
            var spotify = new Espotifai();
            spotify.AgregarCancion(cancion);
            spotify.VerCanciones();
            bool retorno = spotify.AgregarCancion(cancion);
            Console.WriteLine(retorno);
        }
    }
    class Espotifai
    {
        List<Cancion> listacanciones = new List<Cancion>();
        public bool AgregarCancion(Cancion cancion)
        {
            for (int i=0; i<listacanciones.Count; ++i)
            {
                if (cancion.Informacion() == listacanciones[i].Informacion())
                {
                    return false;
                }

            }
            listacanciones.Add(cancion);
            return true;
           
        }
        public void VerCanciones()
        {
            for (int i = 0; i < listacanciones.Count; ++i)
            {
                Console.WriteLine(listacanciones[i].Informacion());
            }
        }

    }
}
