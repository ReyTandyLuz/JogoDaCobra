using JogoDaCobra.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaCobra.Entities
{
    internal class Cobra
    {
        public List<Point> Corpo {  get; private set; }
        public short Tamanho { get; private set; }
        public Direccion Direccion { get; set; }

        public Cobra()
        {
            Corpo = new() { new(40, 40) };
            Tamanho = 1;
            Direccion = Direccion.Right;
        }

        public Point Cabeca
        {
            get
            {
                return Corpo.First();
            }
            private set 
            {
                
            }
        }

        public void AumentarPontuacao() => Inf.Pontos += 10;
        public void Grow() => Tamanho++;
        public bool VerificarColicaoPropria() => Corpo.Count > 1 && Corpo.Skip(1).Any(segmento => segmento == Cabeca);
        public bool VerificarColicaoFronteira()
        {
            return Cabeca.X < 0 ||
                Cabeca.Y < 0 ||
                Cabeca.X > Inf.SIZE_WIDTH - 10 || 
                Cabeca.Y > Inf.SIZE_WIDTH - 10;
        }

        public void HandleKeyPress(Keys key)
        {
            switch(key)
            {
                case Keys.Up:
                    Direccion = Direccion.Up; 
                    break;
                
                case Keys.Down:
                    Direccion = Direccion.Down; 
                    break;
                
                case Keys.Left:
                    Direccion = Direccion.Left; 
                    break;
                
                case Keys.Right:
                    Direccion = Direccion.Right; 
                    break;
            }
        }

        public void Mover()
        {
            Point novaCabeca = Cabeca;

            switch(Direccion)
            {
                case Direccion.Up:
                    novaCabeca.Y -= 5;
                    break;

                case Direccion.Down:
                    novaCabeca.Y += 5;
                    break;

                case Direccion.Left:
                    novaCabeca.X -= 5;
                    break;

                case Direccion.Right:
                    novaCabeca.X += 5;
                    break;
            }

            Corpo.Insert(0, novaCabeca);
            while (Corpo.Count > Tamanho) 
                Corpo.RemoveAt(Corpo.Count - 1);
        }

        public void Draw(Graphics graficos)
        {
            foreach (Point p in Corpo)
                graficos.FillRectangle(Brushes.Purple, p.X, p.Y, 25, 25);
        }

        
    }
}
