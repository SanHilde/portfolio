using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Entidades.Usuario;

namespace Entidades
{
    public static class SQL_database
    {
         static SqlConnection _connection;
         static SqlCommand _command;
         static string _connectionString;
         static List<string> listaDeUsuarios;

        public static List<string> ListaDeUsuarios { get => listaDeUsuarios; set => listaDeUsuarios = value; }

        static SQL_database()
        {
            _connectionString = "Server=DESKTOP-LK3M7DT\\SQLEXPRESS;Database=Controlador de gastos;Integrated Security=True;";
            _connection = new SqlConnection(_connectionString);
            _command = _connection.CreateCommand();
            _command.CommandType = System.Data.CommandType.Text;
            listaDeUsuarios = ObtenerUsuariosRegistrados();
        }

        private static List<string> ObtenerUsuariosRegistrados()
        {
            List<string> usuariosRegistrados = new List<string>();

            try
            {
                _connection.Open();

                var query = "SELECT DISTINCT usuarioRegistrado FROM Usuario";

                _command.CommandText = query;
                _command.Parameters.Clear();

                using (var sqlReader = _command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        string usuarioRegistrado = sqlReader["usuarioRegistrado"].ToString();
                        usuariosRegistrados.Add(usuarioRegistrado);
                    }
                }

                return usuariosRegistrados;
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }


        public static Usuario Traer(string usuarioRegistrado, string contraseña)
        {
            try
            {
                Usuario usuario = null;
                _connection.Open();

                var query = "SELECT * FROM Usuario WHERE usuarioRegistrado = @usuarioRegistrado AND contraseña = @contraseña";
                _command.CommandText = query;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@contraseña", contraseña);

                using (var sqlReader = _command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        var nombreDeUsuario = sqlReader["nombreDeUsuario"].ToString();
                        var estadoInt = Convert.ToInt32(sqlReader["estado"]);
                        var categoriaUsuarioInt = Convert.ToInt32(sqlReader["categoriaUsuario"]);

                        // Convertir el entero al valor del enum correspondiente
                        TipoDeEstado estado = (TipoDeEstado)Enum.ToObject(typeof(TipoDeEstado), estadoInt);
                        TiposDeUsuarios categoriaUsuario = (TiposDeUsuarios)Enum.ToObject(typeof(TiposDeUsuarios), categoriaUsuarioInt);

                        // Aquí puedes crear una instancia de Usuario con los datos leídos, incluyendo el estado y la categoría del enum
                        if (estado == TipoDeEstado.Vigente)
                        {
                            usuario = new Usuario(usuarioRegistrado, contraseña, nombreDeUsuario, categoriaUsuario);
                        } else
                        {
                            usuario = null;
                        }
                    }
                }
                _connection.Close();
                return usuario;
            }
            catch
            {
                throw;
            }
        }
        public static Usuario Traer(string usuarioRegistrado)
        {
            List<string> listaAux;
            try
            {
                listaAux = new List<string>();
                Usuario usuario = null;
                _connection.Open();

                var query = "SELECT * FROM Usuario WHERE usuarioRegistrado = @usuarioRegistrado";
                _command.CommandText = query;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);

                using (var sqlReader = _command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        var nombreDeUsuario = sqlReader["nombreDeUsuario"].ToString();
                        var contraseña = sqlReader["contraseña"].ToString();
                        var estadoInt = Convert.ToInt32(sqlReader["estado"]);
                        var categoriaUsuarioInt = Convert.ToInt32(sqlReader["categoriaUsuario"]);

                        // Convertir el entero al valor del enum correspondiente
                        TipoDeEstado estado = (TipoDeEstado)Enum.ToObject(typeof(TipoDeEstado), estadoInt);
                        TiposDeUsuarios categoriaUsuario = (TiposDeUsuarios)Enum.ToObject(typeof(TiposDeUsuarios), categoriaUsuarioInt);

                        // Aquí puedes crear una instancia de Usuario con los datos leídos, incluyendo el estado y la categoría del enum
                        if (estado == TipoDeEstado.Vigente)
                        {
                            usuario = new Usuario(usuarioRegistrado, contraseña, nombreDeUsuario,categoriaUsuario);
                        }
                        else
                        {
                            usuario = null;
                        }
                        listaAux.Add(usuarioRegistrado);
                    }
                }
                _connection.Close();
                return usuario;
            }
            catch
            {
                throw;
            }
        }


        public static void Agregar(Usuario usuario)
            {
                try
                {
                    _command.Parameters.Clear();
                    _connection.Open();

                var query = "INSERT INTO Usuario (nombreDeUsuario, usuarioRegistrado, contraseña, estado, categoriaUsuario) VALUES (@nombreDeUsuario, @usuarioRegistrado, @contraseña, @estado, @categoriaUsuario)";

                _command.CommandText = query;
                _command.Parameters.AddWithValue("@nombreDeUsuario", usuario.NombreDeUsuario);
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuario.UsuarioRegistrado);
                _command.Parameters.AddWithValue("@contraseña", usuario.Constraseña);
                _command.Parameters.AddWithValue("@estado", usuario.Estado);
                _command.Parameters.AddWithValue("@categoriaUsuario", usuario.CategoriaUsuario);
                _command.ExecuteNonQuery();
            }           
                catch
                {
                    throw;
                }
                finally
                {
                    _connection.Close();
                }
            }
      /*  public static void Agregar(string categoria, Usuario usuario)
        {
            try
            {
                _command.Parameters.Clear();
                _connection.Open();

                var query = "INSERT INTO Categoria (usuarioRegistrado, categoria) VALUES (@usuarioRegistrado, @categoria)";

                    _command.CommandText = query;
                    _command.Parameters.AddWithValue("@usuarioRegistrado", usuario.UsuarioRegistrado);
                    _command.Parameters.AddWithValue("@categoria", categoria);
                    _command.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        public static void Agregar(Mes mes, string usuarioRegistrado)
        {
            try
            {
                _command.Parameters.Clear();
                _connection.Open();

                var query = "INSERT INTO Mes (usuarioRegistrado, sueldoCobrado, inicioDeCiclo, fechaDeInicio, finDeCiclo, ahorroPropuesto, objetivoCumplido, idMes) VALUES (@usuarioRegistrado, @sueldoCobrado, @inicioDeCiclo, @fechaDeInicio, @finDeCiclo, @ahorroPropuesto, @objetivoCumplido, @idMes)";

                _command.CommandText = query;
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@sueldoCobrado", mes.SueldoCobrado);
                _command.Parameters.AddWithValue("@inicioDeCiclo", mes.InicioDeCiclo);
                _command.Parameters.AddWithValue("@fechaDeInicio", mes.FechaDeInicio);
                _command.Parameters.AddWithValue("@finDeCiclo", mes.FinDeCliclo);
                _command.Parameters.AddWithValue("@ahorroPropuesto", mes.AhorroPropuesto);
                _command.Parameters.AddWithValue("@objetivoCumplido", mes.ObjtivoCumplido);
                _command.Parameters.AddWithValue("@idMes", mes.Id);
                _command.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        public static void Agregar(IConsumible consumo, string usuarioRegistrado, Mes mes)
        {
            int opcion=0;
            try
            {
                _command.Parameters.Clear();
                _connection.Open();

                var query = "INSERT INTO Consumo (usuarioRegistrado, idMes, monto, nombre, categoria, fecha, pagoRealizado, id) VALUES (@usuarioRegistrado, @idMes, @monto, @nombre, @categoria, @fecha, @pagoRealizado, @id)";
                if (consumo is ConsumoFijo)
                {
                    query = "INSERT INTO ConsumoFijo (usuarioRegistrado, idMes, monto, nombre, categoria, fecha, pagoRealizado, id, cantCuotas) VALUES (@usuarioRegistrado, @idMes, @monto, @nombre, @categoria, @fecha, @pagoRealizado, @id, @cantCuotas)";
                    opcion = 1;
                }
                if (consumo is ConsumoVolatil)
                {
                    query = "INSERT INTO ConsumoVolatil (usuarioRegistrado, idMes, monto, nombre, categoria, fecha, pagoRealizado, id, vigencia) VALUES (@usuarioRegistrado, @idMes, @monto, @nombre, @categoria, @fecha, @pagoRealizado, @id, @vigencia)";
                    opcion = 2;
                }
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@idMes", mes.Id);
                _command.Parameters.AddWithValue("@monto", consumo.Monto);
                _command.Parameters.AddWithValue("@nombre", consumo.Nombre);
                _command.Parameters.AddWithValue("@categoria", consumo.Categoria);
                _command.Parameters.AddWithValue("@fecha", consumo.Fecha);
                _command.Parameters.AddWithValue("@pagoRealizado", consumo.PagoRealizado);
                _command.Parameters.AddWithValue("@id", consumo.Id);
                switch (opcion)
                {
                    case 1:
                        ConsumoFijo consumoEnFijo = (ConsumoFijo)(object)consumo;             
                    _command.Parameters.AddWithValue("@cantCuotas", consumoEnFijo.CantCuotas);
                        break;
                    case 2:
                            ConsumoVolatil consumoEnVolatil = (ConsumoVolatil)(object)consumo;
                            _command.Parameters.AddWithValue("@vigencia", consumoEnVolatil.Vigencia);
                        break;
                    default:
                        break;
                }
                _command.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }*/
        public static void ActualizarDatos(Usuario usuario)
        {
            try
            {
                usuario.ListaDeMeses = ObtenerMesesPorUsuario(usuario.UsuarioRegistrado);
                usuario.ListaDeCategorias = ObtenerCategoriasPorUsuario(usuario.UsuarioRegistrado);
                foreach (Mes mes in  usuario.ListaDeMeses)
                {
                    mes.ListaConsumosEsporadicos = ObtenerConsumosPorUsuarioYMes(usuario.UsuarioRegistrado, mes.Id);
                    mes.ListaConsumosFijos = ObtenerConsumosFijosPorUsuarioYMes(usuario.UsuarioRegistrado, mes.Id);                    
                    mes.ListaConsumosVolatiles = ObtenerConsumosVolatilesPorUsuarioYMes(usuario.UsuarioRegistrado, mes.Id);
                }
            }
            catch
            {
                throw;
            }
        }
        public static void GuardarDatos(Usuario usuario)
        {
            try
            {
                foreach (string categoria in usuario.ListaDeCategorias)
                {
                    SQL_database.ActualizarOInsertarCategoria(categoria, usuario.UsuarioRegistrado);
                }
                foreach (Mes mes in usuario.ListaDeMeses)
                {
                    SQL_database.ActualizarOInsertarMes(mes,usuario.UsuarioRegistrado);
                    foreach (IConsumible consumo in mes.ListaConsumosEsporadicos)
                    {
                        SQL_database.ActualizarOInsertarConsumo (usuario.UsuarioRegistrado, mes.Id, consumo,"Consumo");
                    }
                    foreach (IConsumible consumo in mes.ListaConsumosFijos)
                    {
                        SQL_database.ActualizarOInsertarConsumo(usuario.UsuarioRegistrado, mes.Id, consumo,"ConsumoFijo");
                    }
                    foreach (IConsumible consumo in mes.ListaConsumosVolatiles)
                    {
                        SQL_database.ActualizarOInsertarConsumo(usuario.UsuarioRegistrado, mes.Id, consumo, "ConsumoVolatil");
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Mes> ObtenerMesesPorUsuario(string usuarioRegistrado)
        {
            List<Mes> meses = new List<Mes>();

            try
            {
                _connection.Open();

                var query = "SELECT * FROM Mes WHERE usuarioRegistrado = @usuarioRegistrado";
                _command.CommandText = query;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);

                using (var sqlReader = _command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        // Leer los datos de la fila
                        double sueldoCobrado = Convert.ToDouble(sqlReader["sueldoCobrado"]);
                        int inicioDeCiclo = Convert.ToInt32(sqlReader["inicioDeCiclo"]);
                        DateTime fechaDeInicio = Convert.ToDateTime(sqlReader["fechaDeInicio"]).ToUniversalTime();
                        DateTime finDeCiclo = Convert.ToDateTime(sqlReader["finDeCiclo"]).ToUniversalTime();
                        int ahorroPropuesto = Convert.ToInt32(sqlReader["ahorroPropuesto"]);
                        bool objetivoCumplido = Convert.ToBoolean(sqlReader["objetivoCumplido"]);
                        int idMes = Convert.ToInt32(sqlReader["idMes"]);

                        // Aquí puedes crear una instancia de Mes y agregarla a la lista de meses
                        Mes mes = new Mes(sueldoCobrado, inicioDeCiclo, fechaDeInicio, ahorroPropuesto, idMes);
                        mes.ObjtivoCumplido = objetivoCumplido;
                        mes.FinDeCliclo = finDeCiclo;
                        meses.Add(mes);
                    }
                }

                return meses;
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        public static List<Consumo> ObtenerConsumosPorUsuarioYMes(string usuarioRegistrado, int idMes)
        {
            List<Consumo> consumos = new List<Consumo>();

            try
            {
                //using (_connection)
                //{
                    _connection.Open();

                    var query = "SELECT * FROM Consumo WHERE usuarioRegistrado = @usuarioRegistrado AND idMes = @idMes";

                    _command.CommandText = query;
                    _command.Parameters.Clear();
                    _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                    _command.Parameters.AddWithValue("@idMes", idMes);

                    using (var sqlReader = _command.ExecuteReader())
                    {
                        while (sqlReader.Read())
                        {
                            Consumo consumo = new Consumo();
                            consumo.Id = Convert.ToInt32(sqlReader["id"]);
                            consumo.Monto = Convert.ToDouble(sqlReader["monto"]);
                            consumo.Nombre = sqlReader["nombre"].ToString();
                            consumo.Categoria = sqlReader["categoria"].ToString();
                            consumo.Fecha = Convert.ToDateTime(sqlReader["fecha"]).ToUniversalTime();
                            consumo.PagoRealizado = Convert.ToBoolean(sqlReader["pagoRealizado"]);
                            
                            // Agregar el objeto consumo a la lista
                            consumos.Add(consumo);
                        }
                    }
                //}
                return consumos;
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }               
        }
            public static List<ConsumoFijo> ObtenerConsumosFijosPorUsuarioYMes(string usuarioRegistrado, int idMes)
        {
            List<ConsumoFijo> consumosFijos = new List<ConsumoFijo>();

            try
            {
                    _connection.Open();

                    var query = "SELECT * FROM ConsumoFijo WHERE usuarioRegistrado = @usuarioRegistrado AND idMes = @idMes";

                    _command.CommandText = query;
                    _command.Parameters.Clear();
                    _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                    _command.Parameters.AddWithValue("@idMes", idMes);

                    using (var sqlReader = _command.ExecuteReader())
                    {
                        while (sqlReader.Read())
                        {
                            ConsumoFijo consumoFijo = new ConsumoFijo();
                            consumoFijo.Id = Convert.ToInt32(sqlReader["id"]);
                            consumoFijo.Monto = Convert.ToDouble(sqlReader["monto"]);
                            consumoFijo.Nombre = sqlReader["nombre"].ToString();
                            consumoFijo.Categoria = sqlReader["categoria"].ToString();
                            consumoFijo.Fecha = Convert.ToDateTime(sqlReader["fecha"]).ToUniversalTime();
                            consumoFijo.PagoRealizado = Convert.ToBoolean(sqlReader["pagoRealizado"]);
                            consumoFijo.CantCuotas = Convert.ToInt32(sqlReader["cantCuotas"]);

                            // Agregar el objeto consumoFijo a la lista
                            consumosFijos.Add(consumoFijo);
                        }
                    }
                return consumosFijos;
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }

            
        }
        public static List<ConsumoVolatil> ObtenerConsumosVolatilesPorUsuarioYMes(string usuarioRegistrado, int idMes)
        {
            List<ConsumoVolatil> consumosVolatiles = new List<ConsumoVolatil>();

            try
            {
                //using (_connection)
                //{
                    _connection.Open();

                    var query = "SELECT * FROM ConsumoVolatil WHERE usuarioRegistrado = @usuarioRegistrado AND idMes = @idMes";

                    _command.CommandText = query;
                    _command.Parameters.Clear();
                    _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                    _command.Parameters.AddWithValue("@idMes", idMes);

                    using (var sqlReader = _command.ExecuteReader())
                    {
                        while (sqlReader.Read())
                        {
                            ConsumoVolatil consumoVolatil = new ConsumoVolatil();
                            consumoVolatil.Id = Convert.ToInt32(sqlReader["id"]);
                            consumoVolatil.Monto = Convert.ToDouble(sqlReader["monto"]);
                            consumoVolatil.Nombre = sqlReader["nombre"].ToString();
                            consumoVolatil.Categoria = sqlReader["categoria"].ToString();
                            consumoVolatil.Fecha = Convert.ToDateTime(sqlReader["fecha"]).ToUniversalTime();
                            consumoVolatil.PagoRealizado = Convert.ToBoolean(sqlReader["pagoRealizado"]);
                            consumoVolatil.Vigencia = Convert.ToBoolean(sqlReader["vigencia"]);

                            // Agregar el objeto consumoVolatil a la lista
                            consumosVolatiles.Add(consumoVolatil);
                        }
                    }
                //}
                return consumosVolatiles;
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }

           
        }
        public static List<string> ObtenerCategoriasPorUsuario(string usuarioRegistrado)
        {
            List<string> categorias = new List<string>();

            try
            {
                _connection.Open();

                var query = "SELECT categoria FROM Categoria WHERE usuarioRegistrado = @usuarioRegistrado";
                _command.CommandText = query;
                _command.Parameters.Clear(); // Limpia los parámetros antes de agregarlos nuevamente
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);

                using (var sqlReader = _command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        var categoria = sqlReader["categoria"].ToString();
                        categorias.Add(categoria);
                    }
                }
                return categorias;
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }       
        }
        public static void ActualizarOInsertarConsumo(string usuarioRegistrado, int idMes, IConsumible consumo, string tipoConsumo)
        {
            string lista;
            string ultimoParametro;
            string ultimaActualizacion;
            string ultimoIngreso;
            try
            {
                _connection.Open();
                if (tipoConsumo== "ConsumoFijo")
                {
                    lista = "ConsumoFijo";
                    ultimoParametro = "id, cantCuotas";
                    ultimoIngreso = "id, @cantCuotas";
                    ultimaActualizacion = "pagoRealizado, cantCuotas = @cantCuotas";
                } else
                {
                    if (tipoConsumo == "ConsumoVolatil")
                    {
                        lista = "ConsumoVolatil";
                        ultimoParametro = "id, vigencia";
                        ultimaActualizacion = "pagoRealizado, vigencia = @vigencia";
                        ultimoIngreso = "id, @vigencia";
                    } else
                    {
                        lista = "Consumo";
                        ultimoParametro = "id";
                        ultimaActualizacion = "pagoRealizado";
                        ultimoIngreso = "id";
                    }
                }
                // Verificar si el consumo ya existe en la base de datos
                var queryVerificarExistencia = $"SELECT COUNT(*) FROM {lista} WHERE usuarioRegistrado = @usuarioRegistrado AND idMes = @idMes AND id = @id";
                _command.CommandText = queryVerificarExistencia;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@idMes", idMes);
                _command.Parameters.AddWithValue("@id", consumo.Id);

                int count = Convert.ToInt32(_command.ExecuteScalar());

                if (count == 0)
                {
                    // Si no existe, insertar un nuevo registro en la base de datos
                    var queryInsertar = $"INSERT INTO {lista} (usuarioRegistrado, idMes, monto, nombre, categoria, fecha, pagoRealizado, {ultimoParametro}) VALUES (@usuarioRegistrado, @idMes, @monto, @nombre, @categoria, @fecha, @pagoRealizado, @{ultimoIngreso})";
                    _command.CommandText = queryInsertar;
                }
                else
                {
                    // Si existe, actualizar el registro existente
                    var queryActualizar = $"UPDATE {lista} SET monto = @monto, nombre = @nombre, categoria = @categoria, fecha = @fecha, pagoRealizado = @{ultimaActualizacion} WHERE usuarioRegistrado = @usuarioRegistrado AND idMes = @idMes AND id = @id";
                    _command.CommandText = queryActualizar;
                }

                // Configurar los parámetros comunes para ambas consultas (tanto inserción como actualización)
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@idMes", idMes);
                _command.Parameters.AddWithValue("@monto", consumo.Monto);
                _command.Parameters.AddWithValue("@nombre", consumo.Nombre);
                _command.Parameters.AddWithValue("@categoria", consumo.Categoria);
                _command.Parameters.AddWithValue("@fecha", consumo.Fecha);
                _command.Parameters.AddWithValue("@pagoRealizado", consumo.PagoRealizado);
                _command.Parameters.AddWithValue("@id", consumo.Id);
                if (lista == "ConsumoFijo")
                {
                    ConsumoFijo consumoEnFijo = (ConsumoFijo)(object)consumo;
                    _command.Parameters.AddWithValue("@cantCuotas", SqlDbType.Int).Value = consumoEnFijo.CantCuotas;
                }
                if (lista == "ConsumoVolatil")
                {
                    ConsumoVolatil consumoEnVolatil = (ConsumoVolatil)(object)consumo;
                    _command.Parameters.AddWithValue("@vigencia", SqlDbType.Int).Value = consumoEnVolatil.Vigencia;
                }

                // Ejecutar la consulta
                _command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        public static void ActualizarOInsertarMes(Mes mes, string usuarioRegistrado)
        {
            try
            {
                _connection.Open();

                // Verificar si el mes ya existe en la base de datos
                var queryVerificarExistencia = "SELECT COUNT(*) FROM Mes WHERE usuarioRegistrado = @usuarioRegistrado AND idMes = @idMes";
                _command.CommandText = queryVerificarExistencia;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@idMes", mes.Id);

                int count = Convert.ToInt32(_command.ExecuteScalar());

                if (count == 0)
                {
                    // Si no existe, insertar un nuevo registro en la base de datos
                    var queryInsertar = "INSERT INTO Mes (usuarioRegistrado, idMes, sueldoCobrado, inicioDeCiclo, fechaDeInicio, finDeCiclo, ahorroPropuesto, objetivoCumplido) " +
                                        "VALUES (@usuarioRegistrado, @idMes, @sueldoCobrado, @inicioDeCiclo, @fechaDeInicio, @finDeCiclo, @ahorroPropuesto, @objetivoCumplido)";
                    _command.CommandText = queryInsertar;
                }
                else
                {
                    // Si existe, actualizar el registro existente
                    var queryActualizar = "UPDATE Mes SET sueldoCobrado = @sueldoCobrado, inicioDeCiclo = @inicioDeCiclo, " +
                                          "fechaDeInicio = @fechaDeInicio, finDeCiclo = @finDeCiclo, ahorroPropuesto = @ahorroPropuesto, " +
                                          "objetivoCumplido = @objetivoCumplido WHERE idMes = @idMes AND usuarioRegistrado = @usuarioRegistrado";
                    _command.CommandText = queryActualizar;
                }

                // Configurar los parámetros comunes para ambas consultas (tanto inserción como actualización)
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@idMes", mes.Id);
                _command.Parameters.AddWithValue("@sueldoCobrado", mes.SueldoCobrado);
                _command.Parameters.AddWithValue("@inicioDeCiclo", mes.InicioDeCiclo);
                _command.Parameters.AddWithValue("@fechaDeInicio", mes.FechaDeInicio);
                _command.Parameters.AddWithValue("@finDeCiclo", mes.FinDeCliclo);
                _command.Parameters.AddWithValue("@ahorroPropuesto", mes.AhorroPropuesto);
                _command.Parameters.AddWithValue("@objetivoCumplido", mes.ObjtivoCumplido);

                // Ejecutar la consulta
                _command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        public static void ActualizarOInsertarCategoria(string categoria, string usuarioRegistrado)
        {
            try
            {
                _connection.Open();

                // Verificar si la categoría ya existe en la base de datos
                var queryVerificarExistencia = "SELECT COUNT(*) FROM Categoria WHERE usuarioRegistrado = @usuarioRegistrado AND categoria = @categoria";
                _command.CommandText = queryVerificarExistencia;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@categoria", categoria);

                int count = Convert.ToInt32(_command.ExecuteScalar());

                if (count == 0)
                {
                    // Si no existe, insertar un nuevo registro en la base de datos
                    var queryInsertar = "INSERT INTO Categoria (usuarioRegistrado, categoria) VALUES (@usuarioRegistrado, @categoria)";
                    _command.CommandText = queryInsertar;
                }
                else
                {
                    // Si existe, no es necesario hacer nada ya que la categoría ya está en la base de datos
                    return;
                }

                // Configurar los parámetros para la inserción
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@usuarioRegistrado", usuarioRegistrado);
                _command.Parameters.AddWithValue("@categoria", categoria);

                // Ejecutar la consulta
                _command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }



    }
}
