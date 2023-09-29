namespace Anotaciones_de_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase 4:   
            //enumerados: (se agregan como clases, pero le cambio class por enum
            //son como defines, en el main:
            Colores unColor = Colores.Azul;
            Console.WriteLine (unColor.ToString());

            //tamb se puede recorrer con foreach
            /*
            foreach(string unColot Enum.GetNames (typeof(Colores)))
            {
               
            }
            */
        }
       
    }
    public enum Colores
    {
        Rojo, // toma como elemento 0 (en posicion)
        Azul,
        Amarillo,
        Negro
    }
}