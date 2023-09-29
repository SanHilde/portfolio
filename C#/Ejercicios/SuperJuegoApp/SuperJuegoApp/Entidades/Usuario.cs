namespace Entidades
{
    public class Usuario
    {
        private string nombreDeUsuario;
        private string password;
        private Personaje personaje;

        public string NombreDeUsuario
        {
            get => nombreDeUsuario;
            set => nombreDeUsuario = value;
        }
        public Personaje Personaje
        {
            get => personaje;
            set => personaje = value;
        }

        public Usuario(string nombreDeUsuario, string password)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.password = password;
            this.personaje = null;
        }
        public Usuario(string nombreDeUsuario, string password, Personaje personaje):this(nombreDeUsuario,password)
        {
            this.personaje = personaje;
        }

        public bool ValidarUsuario(string usuarioIngresado, string passwordIngresada)
        {
            return this.nombreDeUsuario == usuarioIngresado && this.password == passwordIngresada;
        }

        public bool CrearPersonaje(Personaje personaje)
        {
            bool agregado = false;
            if (this.personaje == null)
            {
                this.personaje = personaje;
                agregado = true;
            }

            return agregado;
        }

        public bool BorrarPersonaje()
        {
            bool borrado = false;
            if (this.personaje != null)
            {
                this.personaje = null;
                borrado = true;
            }

            return borrado;
        }
    }
}