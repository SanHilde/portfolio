using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class DatosHardcode
    {
        private static Usuario usuarioUno;
        private static Usuario usuarioDos;
        private static Usuario usuarioTres;
        private static Mes mesHardcode;


        public  DatosHardcode() 
        {
            usuarioUno = new Usuario("admin", "admin", "admin", Usuario.TiposDeUsuarios.admin);
            usuarioDos = new Usuario("a", "a", "a");
            usuarioTres = new Usuario("san.hilde", "223485san", "Santiago");


            Sistema.AgregarUsuario(usuarioUno);
            Sistema.AgregarUsuario(usuarioDos);
            Sistema.AgregarUsuario(usuarioTres);

            mesHardcode = new Mes(130000, 5, new DateTime(2023, 2, 5), 20,1);
            mesHardcode.AgregarConsumo(10000, "Seguro del auto", "Casa", new DateTime(2023, 2, 5).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(6000, "Seguro de moto", "Casa", new DateTime(2023, 2, 5).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(5000, "Cuota gym", "Hobbies", new DateTime(2023, 2, 9).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(8000, "Aire Acondicionado", "Casa", new DateTime(2023, 2, 5).ToUniversalTime(), false, 12);
            mesHardcode.AgregarConsumo(10000, "Heladera", "Casa", new DateTime(2023, 2, 5).ToUniversalTime(), false, 3);
            mesHardcode.AgregarConsumo(4500, "Verduleria", "Casa", new DateTime(2023, 2, 12).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(5500, "Supermercado", "Casa", new DateTime(2023, 2, 10).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(3500, "Verduleria", "Casa", new DateTime(2023, 2, 23).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(2500, "Supermercado", "Casa", new DateTime(2023, 2, 25).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(4500, "Combustible auto", "Combustible", new DateTime(2023, 2, 8).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1500, "Combustible moto", "Combustible", new DateTime(2023, 2, 15).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1300, "Combustible moto", "Combustible", new DateTime(2023, 2, 28).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1500, "Asado con los pibes", "Salidas", new DateTime(2023, 2, 15).ToUniversalTime(), true);

            usuarioTres.ListaDeCategorias = new List<string>() { "Casa", "Salidas", "Combustible", "Impuestos", "Hobbies" };
            usuarioTres.ListaDeMeses.Add(mesHardcode);

            mesHardcode = new Mes(150000, 5, new DateTime(2023, 3, 5), 20,2);
            mesHardcode.AgregarConsumo(10500, "Seguro del auto", "Casa", new DateTime(2023, 3, 16).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(6300, "Seguro de moto", "Casa", new DateTime(2023, 3, 17).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(5250, "Cuota gym", "Hobbies", new DateTime(2023, 3, 22).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(8000, "Aire Acondicionado", "Casa", new DateTime(2023, 3, 16).ToUniversalTime(), false, 11);
            mesHardcode.AgregarConsumo(10000, "Heladera", "Casa", new DateTime(2023, 3, 16).ToUniversalTime(), false, 2);
            mesHardcode.AgregarConsumo(4725, "Verduleria", "Casa", new DateTime(2023, 3, 24).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(5725, "Supermercado", "Casa", new DateTime(2023, 3, 20).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(3725, "Verduleria", "Casa", new DateTime(2023, 3, 26).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(2725, "Supermercado", "Casa", new DateTime(2023, 3, 30).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(4725, "Combustible auto", "Combustible", new DateTime(2023, 3, 21).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1575, "Combustible moto", "Combustible", new DateTime(2023, 3, 28).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1375, "Combustible moto", "Combustible", new DateTime(2023, 3, 31).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1575, "Comida con la familia", "Salidas", new DateTime(2023, 3, 28).ToUniversalTime(), true);

            usuarioTres.ListaDeMeses.Add(mesHardcode);

            mesHardcode = new Mes(170000, 5, new DateTime(2023, 5, 5), 20,3);
            mesHardcode.AgregarConsumo(10500, "Seguro del auto", "Casa", new DateTime(2023, 4, 2).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(6300, "Seguro de moto", "Casa", new DateTime(2023, 4, 5).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(5250, "Cuota gym", "Hobbies", new DateTime(2023, 4, 8).ToUniversalTime(), false, true);
            mesHardcode.AgregarConsumo(8000, "Aire Acondicionado", "Casa", new DateTime(2023, 4, 6).ToUniversalTime(), false, 10);
            mesHardcode.AgregarConsumo(10000, "Heladera", "Casa", new DateTime(2023, 4, 6).ToUniversalTime(), false, 1);
            mesHardcode.AgregarConsumo(4987.5, "Verduleria", "Casa", new DateTime(2023, 4, 9).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(5987.5, "Supermercado", "Casa", new DateTime(2023, 4, 17).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(3987.5, "Verduleria", "Casa", new DateTime(2023, 4, 22).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(2987.5, "Supermercado", "Casa", new DateTime(2023, 4, 24).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(4987.5, "Combustible auto", "Combustible", new DateTime(2023, 4, 4).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1662.5, "Combustible moto", "Combustible", new DateTime(2023, 4, 14).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1462.5, "Combustible moto", "Combustible", new DateTime(2023, 4, 30).ToUniversalTime(), true);
            mesHardcode.AgregarConsumo(1662.5, "Asado con los pibes", "Salidas", new DateTime(2023, 4, 25).ToUniversalTime(), true);
            usuarioTres.ListaDeMeses.Add(mesHardcode);

        }

        public static Usuario UsuarioUno { get => usuarioUno; set => usuarioUno = value; }
        public static Usuario UsuarioDos { get => usuarioDos; set => usuarioDos = value; }
        public static Usuario UsuarioTres { get => usuarioTres; set => usuarioTres = value; }
    }
}
