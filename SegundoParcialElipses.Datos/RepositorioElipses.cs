using SegundoParcialElipses.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialElipses.Datos
{
    public class RepositorioElipses
    {
        private List<Elipse> elipses;

        public RepositorioElipses()
        {
            elipses = new List<Elipse>();
        }
        public bool AgregarElipse(Elipse nuevoElipse)
        {
            bool existe = elipses.Any(e => e.semiejeMayor == nuevoElipse.semiejeMayor &&
                                           e.semiejeMenor == nuevoElipse.semiejeMenor);
            if (!existe)
            {
                elipses.Add(nuevoElipse);
                return true;
            }

            return false;
        }

        public int ObtenerCantidadElipses()
        {
            return elipses.Count;
        }

        public List<Elipse> ObtenerElipses()
        {
            return new List<Elipse>(elipses); 
        }

    }

}
        


    

