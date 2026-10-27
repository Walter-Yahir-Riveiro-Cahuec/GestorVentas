using System;
using Microsoft.Data.SqlClient;

namespace GestorVentas
{
    /// <summary>
    /// Gestiona la conexión hacia la base de datos SQL Server LocalDB.
    /// </summary>
    public static class Conexion
    {
        // Cadena de conexión dirigida a la instancia LocalDB y la base de datos GestorVentasDB
        private static readonly string CadenaConexion = 
            @"Server=(localdb)\MSSQLLocalDB;Database=GestorVentasDB;Trusted_Connection=True;TrustServerCertificate=True;";

        /// <summary>
        /// Crea y retorna una nueva instancia de SqlConnection apuntando a LocalDB.
        /// </summary>
        /// <returns>Objeto SqlConnection configurado.</returns>
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        /// <summary>
        /// Alias en inglés para compatibilidad.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return ObtenerConexion();
        }
    }
}
