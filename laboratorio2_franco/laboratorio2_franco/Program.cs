using System;
using System.Collections.Generic;

namespace laboratorio2_franco
{
    class Cancion
    {
        public string Nombre;
        public string Album;
        public string Artista;
        public string Genero;

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
        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> listaretorno = new List<Cancion>();
            switch (criterio)
            {
                case "nombrecancion":
                    for (int i = 0; i < listacanciones.Count; ++i)
                    {
                        if (valor== listacanciones[i].Nombre)
                        {
                           listaretorno.Add(listacanciones[i]);
                        }

                    }
                    if (listaretorno.Count == 0)
                    {
                        Console.WriteLine("No se encontraron canciones con este nombre");
                    }
                    return listaretorno;
                case "album":
                    for (int i = 0; i < listacanciones.Count; ++i)
                    {
                        if (valor == listacanciones[i].Album)
                        {
                            listaretorno.Add(listacanciones[i]);
                        }

                    }
                    if (listaretorno.Count==0)
                    {
                        Console.WriteLine("No se encontraron canciones con este album");
                    }
                    return listaretorno;
                case "artista":
                    for (int i = 0; i < listacanciones.Count; ++i)
                    {
                        if (valor == listacanciones[i].Artista)
                        {
                            listaretorno.Add(listacanciones[i]);
                        }

                    }
                    if (listaretorno.Count == 0)
                    {
                        Console.WriteLine("No se encontraron canciones con este artista");
                    }
                    return listaretorno;
                case "genero":
                    for (int i = 0; i < listacanciones.Count; ++i)
                    {
                        if (valor == listacanciones[i].Genero)
                        {
                            listaretorno.Add(listacanciones[i]);
                        }

                    }
                    if (listaretorno.Count == 0)
                    {
                        Console.WriteLine("No se encontraron canciones con este genero");
                    }
                    return listaretorno;
                default:
                    Console.WriteLine("Lo pusiste mal");
                        return listaretorno;





            }
        }
    }
}
