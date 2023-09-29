namespace Ejercicio_7
{   /*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de 
     * horas trabajadas en el mes de N cantidad de empleados de una fábrica.
    Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar 
    el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados 
    multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
    Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto 
    y el total a cobrar neto de todos los empleados ingresados.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            string respuesta="si";
            int sueldoParcial;
            int sueldoAntiguedad;
            int sueldoBruto;
            float impuesto;
            float sueldoNeto;
            Empleado unEmpleado;

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado:");
                unEmpleado.nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el valor de su hora de trabajo:");
                numeroIngresadoTexto = Console.ReadLine();
                unEmpleado.valorHora = int.Parse(numeroIngresadoTexto);

                Console.WriteLine("Ingrese la antiguedad del empleado (en años):");
                numeroIngresadoTexto = Console.ReadLine();
                unEmpleado.antiguedadAnios = int.Parse(numeroIngresadoTexto);

                Console.WriteLine("Ingrese las horas trabajadas en el mes:");
                numeroIngresadoTexto = Console.ReadLine();
                unEmpleado.horasTrabajadas = int.Parse(numeroIngresadoTexto);

                sueldoParcial = unEmpleado.valorHora * unEmpleado.horasTrabajadas;
                sueldoAntiguedad = unEmpleado.antiguedadAnios * 150;
                sueldoBruto = sueldoParcial + sueldoAntiguedad;
                impuesto = (float) sueldoBruto * 13 / 100;
                sueldoNeto = (float) sueldoBruto - impuesto;


                Console.WriteLine($"RECIBO\nEmpleado: {unEmpleado.nombre}\nAntiguedad: {unEmpleado.antiguedadAnios} años\nValor hora: ${unEmpleado.valorHora}\n" +
                                    $"Sueldo bruto: ${sueldoBruto}\nSueldo neto: ${sueldoNeto}");



                Console.WriteLine("Desea ingresar otro empleado? si/no:");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");

        }
        struct Empleado
        {
            public int valorHora;
            public string nombre;
            public int antiguedadAnios;
            public int horasTrabajadas;
        }
    }
}