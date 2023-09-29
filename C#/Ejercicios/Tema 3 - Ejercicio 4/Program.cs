using System.Text;

namespace Tema_3___Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Boligrafo azul;
            Boligrafo rojo;
            string impresion;

            azul = new Boligrafo(100, ConsoleColor.Blue);
            rojo = new Boligrafo(50, ConsoleColor.Red);

            azul.Pintar(50,out impresion);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine(impresion);
            Console.WriteLine("Pedi imprimir 50 y tengo 100");

            rojo.Pintar(60, out impresion);
            Console.ForegroundColor = rojo.GetColor();
            Console.WriteLine(impresion);
            Console.WriteLine("Pedi imprimir 60 y tengo 50");

            azul.Pintar(50, out impresion);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine(impresion);
            Console.WriteLine("Pedi imprimir 50 y tengo 50");

            azul.Pintar(50, out impresion);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine(impresion);
            Console.WriteLine("Pedi imprimir 50 y tengo 0");

            rojo.Recargar();
            azul.Recargar();
            Console.WriteLine("Recargue ambas");

            azul.Pintar(100, out impresion);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine(impresion);
            Console.WriteLine("Pedi imprimir 100 y tengo 100");

            rojo.Pintar(60, out impresion);
            Console.ForegroundColor = rojo.GetColor();
            Console.WriteLine(impresion);
            Console.WriteLine("Pedi imprimir 60 y tengo 100");




        }
    }
    internal class Boligrafo
    {
        short cantidadTintaMaxima;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.Tinta = tinta;
            this.Color = color;
            cantidadTintaMaxima = 100;// ->consultar esto tambien
        }

        private ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        private short Tinta 
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public ConsoleColor GetColor()
        {
            return this.Color;
        }

        public short GetTinta ()
        {
            return this.Tinta;
        }

        public bool Pintar (short gasto, out string dibujo)
        {
            short resultado;
            StringBuilder sb = new StringBuilder();
            string impresion = "*";

            resultado = (short)(this.GetTinta() - gasto);
            if (this.GetTinta() != 0) 
            {

                if (resultado >= 0)
                {
                    for (int i = 0; i < gasto; i++)
                    {
                        sb.Append(impresion);
                    }
                    this.SetTinta((short)-gasto);
                } else
                {
                    for (int i = 0; i < this.GetTinta(); i++)
                    {
                        sb.Append(impresion);
                    }
                    this.SetTinta((short)(-this.GetTinta()));
                }      
                dibujo = sb.ToString();
                return true;
            } else
            {
                dibujo = "";
                return false;
            }

        }

       public void Recargar ()
        {
            short recarga;
            recarga = (short) (cantidadTintaMaxima - this.GetTinta());
            this.SetTinta(recarga);
        }

        private void SetTinta (short tintaTrabajada)
        {
            short resultado;
            resultado = (short) (this.Tinta + tintaTrabajada);//consultar esto
            if (resultado >= 0 && resultado <= cantidadTintaMaxima)
            {
                this.Tinta = resultado;
            }
        }
    }
}