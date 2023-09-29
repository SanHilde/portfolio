using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Entidades.Usuario;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Entidades
{
    public static class Firebase
    {
        static string idUsuario;
        static List<string> listaDeUsuarios;
        static string projectId;

       static Firebase ()
        {
            listaDeUsuarios = new List<string> ();
            idUsuario = null;
            projectId = "controlador-de-gastos-8a07d";
        }
        public static List<string> ListaDeUsuarios
        {
            get
            {
                return listaDeUsuarios;
            }
        }

        //base de datos firebase
        /*public static async Task<DocumentReference> Agregar(string usuario, string contraseña, string nombre, TiposDeUsuarios tipoDeUsuario)
        {
            var projectId = "controlador-de-gastos-8a07d";
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection("Usuario");//traigo todo
            var al = new Usuario(usuario, contraseña, nombre, tipoDeUsuario);

            var rta = await colRef.AddAsync(al); //asinconico-> await solo se hace en un metodo asincronico
            return rta;
        }*/
        public static async Task<DocumentReference> Agregar(Usuario usuario)
        {
            var projectId = "controlador-de-gastos-8a07d";
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection("Usuario");//traigo todo
            var rta = await colRef.AddAsync(usuario); //asinconico-> await solo se hace en un metodo asincronico
            return rta;
        }
        public static async Task<Usuario> Traer(string usuarioLogeado, string contraseñaLogeado)
        {
            //var usuarios = new List<Usuario>();
            listaDeUsuarios.Clear();
            Usuario usuarioBuscado=null;
            //var projectId = "controlador-de-gastos-8a07d";
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection("Usuario");//traigo todo
            var query = colRef.Limit(200);
            var snapshot = await query.GetSnapshotAsync();

            var lista = snapshot.ToList();
            foreach (var item in lista)
            {
                Usuario u = item.ConvertTo<Usuario>();
                listaDeUsuarios.Add(u.UsuarioRegistrado);
                /*SQL_database.Agregar(u);
                foreach (string categoria in u.ListaDeCategorias)
                {
                    SQL_database.Agregar(categoria, u);
                }

                foreach (Mes mes in u.ListaDeMeses)
                {
                    SQL_database.Agregar(mes,u.UsuarioRegistrado);
                    foreach (Consumo consumo in mes.ListaConsumosEsporadicos)
                    {
                        SQL_database.Agregar(consumo, u.UsuarioRegistrado, mes);
                    }
                    foreach (ConsumoVolatil consumo in mes.ListaConsumosVolatiles)
                    {
                        SQL_database.Agregar(consumo, u.UsuarioRegistrado, mes);
                    }
                    foreach (ConsumoFijo consumo in mes.ListaConsumosFijos)
                    {
                        SQL_database.Agregar(consumo, u.UsuarioRegistrado, mes);
                    }
                }*/

                if (u.UsuarioRegistrado == usuarioLogeado && u.Constraseña == contraseñaLogeado)
                {
                    usuarioBuscado = u;
                    idUsuario = item.Id;
                    //break;
                }
            }
            
            return usuarioBuscado;
        }

        public static async Task<Usuario> Traer(string usuarioLogeado)
        {
            //var usuarios = new List<Usuario>();
            //listaDeUsuarios.Clear();
            Usuario usuarioBuscado = null;
            //var projectId = "controlador-de-gastos-8a07d";
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection("Usuario");//traigo todo
            var query = colRef.Limit(200);
            var snapshot = await query.GetSnapshotAsync();

            var lista = snapshot.ToList();
            foreach (var item in lista)
            {
                Usuario u = item.ConvertTo<Usuario>();
                //listaDeUsuarios.Add(u.UsuarioRegistrado);
                if (u.UsuarioRegistrado == usuarioLogeado)
                {
                    usuarioBuscado = u;
                    idUsuario = item.Id;
                    break;
                }
            }

            return usuarioBuscado;
        }

        public static async Task<Usuario> Actualizar(Usuario usuario)
        {
            
            //var projectId = "controlador-de-gastos-8a07d";
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection("Usuario"); 
            var documentRef = colRef.Document(idUsuario); 
            await documentRef.SetAsync(usuario);
        
            return usuario;

        }
       
    }
}
