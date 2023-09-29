using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Usuario;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Entidades
{
    [FirestoreData]
    public class Usuario
    {
        string nombreDeUsuario;
        string usuarioRegistrado;
        string contraseña;
        TipoDeEstado estado;
        TiposDeUsuarios categoriaUsuario;
        List<string> listaDeCategorias;
        List<Mes> listaDeMeses;

        public Usuario()
        {
            this.categoriaUsuario = TiposDeUsuarios.normal;
            this.listaDeCategorias = new List<string>();
            this.listaDeMeses = new List<Mes>();
            this.estado = TipoDeEstado.Vigente;
        }

        public Usuario(string usuario, string constraseña, string nombre) : this()
        {
            this.usuarioRegistrado = usuario;
            this.contraseña = constraseña;
            this.nombreDeUsuario = nombre;

        }

        public Usuario(string usuario, string constraseña, string nombre, TiposDeUsuarios tipoDeUsuario)
        {
            this.usuarioRegistrado = usuario;
            this.contraseña = constraseña;
            this.categoriaUsuario = tipoDeUsuario;
            this.nombreDeUsuario = nombre;
            this.listaDeCategorias = new List<string>();
            this.listaDeMeses = new List<Mes>();
        }

        [FirestoreProperty]
        public string UsuarioRegistrado
        {
            get
            {
                return this.usuarioRegistrado;
            }
            set
            {
                this.usuarioRegistrado = value;
            }
        }
        [FirestoreProperty]
        public string NombreDeUsuario
        {
            get
            {
                return this.nombreDeUsuario;
            }
            set
            {
                this.nombreDeUsuario = value;
            }
        }
        [FirestoreProperty]
        public string Constraseña
        {
            get
            {
                return this.contraseña;
            }
            set
            {
                this.contraseña = value;
            }
        }
        [FirestoreProperty]
        public TiposDeUsuarios CategoriaUsuario
        {
            get
            {
                return this.categoriaUsuario;
            }
            set
            {
                this.categoriaUsuario = value;
            }
        }

        [FirestoreProperty]
        public List<string> ListaDeCategorias
        {
            get
            {
                return this.listaDeCategorias;
            }
            set
            {
                listaDeCategorias = value;
            }
        }
        [FirestoreProperty]
        public List<Mes> ListaDeMeses
        {
            get
            {
                return this.listaDeMeses;
            }
            set
            {
                this.listaDeMeses = value;
            }
        }

        [FirestoreProperty]
        public TipoDeEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public bool ValidarUsuario(string usuarioIngresado, string contraseñaIngresada)
        {

            return this.usuarioRegistrado == usuarioIngresado && this.contraseña == contraseñaIngresada;

        }
        public bool ValidarUsuario(string usuarioIngresado)
        {

            return this.usuarioRegistrado == usuarioIngresado;

        }

        public enum TiposDeGastos
        {
            Fijo,
            Volatil,
            Esporadico
        }
        public enum TiposDeUsuarios
        {
            admin,
            normal
        }

        public enum TipoDeEstado
        {
            Vigente,
            Baja
        }


        public void AgregarMes(Mes nuevoMes)
        {
            Mes ultimoMes;

            if (ListaDeMeses.Count > 0)
            {
                ultimoMes = ListaDeMeses.Last();

                if (ultimoMes != null)
                {
                    //nuevoMes.ListaConsumosVolatiles = new List<ConsumoVolatil>(ultimoMes.ListaConsumosVolatiles);
                    //nuevoMes.ListaConsumosFijos = new List<ConsumoFijo>(ultimoMes.ListaConsumosFijos);
                    nuevoMes.Id = ListaDeMeses.Count;
                }

            }
            ListaDeMeses.Add(nuevoMes);
        }

        public void ActualizarCategoria(string categoriaVieja, string categoriaNueva, Mes ultimoMes)
        {
            Generics.RecorrerListaConFiltroString(ultimoMes.ListaConsumosVolatiles, Generics.FiltroCategoria, ConsumoSetCategoria,categoriaVieja,categoriaNueva);
            Generics.RecorrerListaConFiltroString(ultimoMes.ListaConsumosEsporadicos, Generics.FiltroCategoria, ConsumoSetCategoria, categoriaVieja, categoriaNueva);
            Generics.RecorrerListaConFiltroString(ultimoMes.ListaConsumosFijos, Generics.FiltroCategoria, ConsumoSetCategoria, categoriaVieja, categoriaNueva);
        }

        public void RehacerCategorias ()
        {
            List<string> nuevaLista = new List<string> ();
            Mes ultimoMes;
            if (listaDeMeses.Count > 0)
            {
                ultimoMes = listaDeMeses.Last();
                foreach (string item in listaDeCategorias)
                {
                    if (Generics.RecorrerListaConFiltroString(ultimoMes.ListaConsumosVolatiles, Generics.FiltroCategoria, item) == true ||
                        Generics.RecorrerListaConFiltroString(ultimoMes.ListaConsumosEsporadicos, Generics.FiltroCategoria, item) == true ||
                        Generics.RecorrerListaConFiltroString(ultimoMes.ListaConsumosFijos, Generics.FiltroCategoria, item) == true)
                    {
                        nuevaLista.Add(item);
                    }
                }
                listaDeCategorias = nuevaLista;
                Generics.RecorrerListaConFiltroInt(ultimoMes.ListaConsumosVolatiles, Generics.FiltroId, SetearIDCorrecto);
                Generics.RecorrerListaConFiltroInt(ultimoMes.ListaConsumosEsporadicos, Generics.FiltroId, SetearIDCorrecto);
                Generics.RecorrerListaConFiltroInt(ultimoMes.ListaConsumosFijos, Generics.FiltroId, SetearIDCorrecto);

            }
        }
        private void SetearIDCorrecto (IConsumible consumo, int idCorrecto)
        {
            consumo.Id = idCorrecto;
        }
        private void ConsumoSetCategoria (Consumo consumo, string categoriaNueva)
        {
            consumo.Categoria = categoriaNueva;
        }
        public void ActualizarMes (Mes mesPasado)
        {
            //int cantMeses = listaDeMeses.Count-1;
            //listaDeMeses[cantMeses] = mesPasado;
            for (int i = 0; i < listaDeMeses.Count; i++)
            {
                if (mesPasado.Id == listaDeMeses[i].Id)
                {
                    listaDeMeses[i] = mesPasado;
                    break;
                }
            }


        }

    }
}
