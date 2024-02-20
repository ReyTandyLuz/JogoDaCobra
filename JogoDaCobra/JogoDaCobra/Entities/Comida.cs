using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaCobra.Entities
{
    internal class Comida
    {
        public Point Posicion { get; private set; }
        public Random Random { get; private set; }

        public Comida()
        {
            Posicion = new(100,100);
            Random = new();
        }

        public void Draw(Graphics graficos)
        {
            graficos.FillEllipse(Brushes.Orange, Posicion.X, Posicion.Y, 20,20);
        }

        public void GerarNovaPosicao()
        {
            int x = Random.Next(20, Inf.SIZE_WIDTH - 20);
            int y = Random.Next(20, Inf.SIZE_WIDTH - 20);
            Posicion = new(x, y);
        }
    }
}
