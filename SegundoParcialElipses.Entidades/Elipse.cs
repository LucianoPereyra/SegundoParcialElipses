using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialElipses.Entidades
{
    public class Elipse
    {
        private TipoBorde borde;
        private ColorElipse azul;

        public Elipse(int semiejeMayor, int semiejeMenor, TipoBorde borde, ColorElipse azul)
        {
            this.semiejeMayor = semiejeMayor;
            this.semiejeMenor = semiejeMenor;
            this.borde = borde;
            this.azul = azul;
        }

        public int semiejeMayor { get; set; }

        public int semiejeMenor { get; set; }



        public int CalcularArea()
        {
            double area = Math.PI * semiejeMayor * semiejeMenor;
            return (int)Math.Round(area);
        }

        public int CalcularPerimetro()
        {
            double perimetro = Math.PI * (3 * (semiejeMayor + semiejeMenor) -
            Math.Sqrt((3 * semiejeMayor + semiejeMenor) * (semiejeMayor + 3 * semiejeMenor)));
            return (int)Math.Round(perimetro);
        }

        public enum TipoBorde
        {
            Solido,
            Punteado,
            Rayado
        }

        public enum ColorElipse
        {
            Rojo,
            Verde,
            Azul,
            Amarillo,
            Negro,
            Blanco
        }

    }

    
}
