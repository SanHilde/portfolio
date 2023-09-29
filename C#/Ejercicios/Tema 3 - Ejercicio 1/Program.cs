using System.Text;
using System.Threading;

namespace Tema_3___Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaDeBanco = new Cuenta("Santiago Hildebrandt", 0);
            Console.WriteLine(cuentaDeBanco.Mostrar());

            Console.Write("Se ingreso $0.\n");
            cuentaDeBanco.Ingresar(0);
            Console.WriteLine(cuentaDeBanco.Mostrar());

            Console.Write("Se ingreso $-1.\n");
            cuentaDeBanco.Ingresar(-1);
            Console.WriteLine(cuentaDeBanco.Mostrar());

            Console.Write("Se ingreso $10.\n");
            cuentaDeBanco.Ingresar(10);
            Console.WriteLine(cuentaDeBanco.Mostrar());

            Console.Write("Se retiran $8.\n");
            cuentaDeBanco.Retirar(8);
            Console.WriteLine(cuentaDeBanco.Mostrar());

            Console.Write("Se retiran $5.\n");
            cuentaDeBanco.Retirar(5);
            Console.WriteLine(cuentaDeBanco.Mostrar());

        }
    }

    internal class Cuenta
    {
        string titular;
        int saldo;

        public Cuenta (string nombreIngresado, int saldoIngresado)
        {
            this.Titular = nombreIngresado;
            this.Saldo = saldoIngresado;
        }

        string Titular
        {
            get 
            {
                return this.titular;
            }

            set
            {
                this.titular = value;
            }
            
        }

        int Saldo 
        {
            get
            {
                return this.saldo;
            }

            set
            {
                this.saldo = value;
            }
        }

        public string Mostrar () 
        {
            string resultado = null;
            //StringBuilder resultado = new StringBuilder();
            resultado = $"La cuenta es de {this.Titular} y el saldo es de {this.Saldo}.\n";
            return resultado;
        }
        public void Ingresar(int monto)
        {
            if (monto>0)
            {
                this.saldo = this.saldo + monto;
            } else
            {
                Console.Write("El saldo ingresado debe ser mayor a 0.\n");
            }

        }
        public void Retirar(int monto)
        {
            if (monto > 0)
            {
                this.saldo = this.saldo - monto;
            }
            else
            {
                Console.Write("El saldo a retirar debe ser mayor a 0.\n");
            }
        }

    }


}