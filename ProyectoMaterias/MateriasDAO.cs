using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProyectoMaterias
{
    public class MateriasDAO
    {
        public static int crear(Materias mate)
        {
            string cadenaConexion = @"Server=DESKTOP-BVI966H\SQLEXPRESS; database=Materias; integrated security=true";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "insert into Estudiantes(codMaterias, nombreMateria, nivel, carrera )"
                + "values(@codMaterias, @nombreMateria, @nivel, @carrera )";

            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@codMaterias", mate.codMaterias);
            comando.Parameters.AddWithValue("@nombreMateria", mate.nombreMateria);
            comando.Parameters.AddWithValue("@nivel", mate.nivel);
            comando.Parameters.AddWithValue("@carrera", mate.carrera);

            conexion.Open();
            int X = comando.ExecuteNonQuery();

            conexion.Close();

            return X;
        }
        public static DataTable getAll()
        {
            string cadenaConexion = @"Server=DESKTOP-BVI966H\SQLEXPRESS; database=Materias; integrated security=true";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "select codMaterias, nombreMateria, nivel, carrera" + " from Estudiantes";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
