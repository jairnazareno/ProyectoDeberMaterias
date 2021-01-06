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
        public static string cadenaConexion = @"Server=DESKTOP-BVI966H\SQLEXPRESS; database=Materias; integrated security=true";
        public static int crear(Materias mate)
        {
            //string cadenaConexion = @"Server=DESKTOP-BVI966H\SQLEXPRESS; database=Materias; integrated security=true";

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

        public static int actualizar(Materias mate)
        {


            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "update Estudiantes set  nombreMateria=@nombreMateria, nivel=@nivel, @carrera=@carrera "
                + " where codMaterias=@codMaterias";


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

        public static int eliminar(String codMaterias)
        {


            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "delete from Estudiantes " +
                "where codMaterias=@codMaterias ";


            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@codMaterias", codMaterias);



            conexion.Open();
            int X = comando.ExecuteNonQuery();

            conexion.Close();

            return X;
        }


        public static DataTable getAll()
        {
            
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "select codMaterias, upper(nombreMateria), nivel, carrera " + "from Estudiantes order by carrera";
            
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static Materias GetPersona(String codMaterias)
        {

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "select codMaterias, nombreMateria, nivel, carrera " + "from Estudiantes "
               + "where codMaterias=@codMaterias";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            ad.SelectCommand.Parameters.AddWithValue("@codMaterias", codMaterias);


            DataTable dt = new DataTable();
            ad.Fill(dt);

            Materias p = new Materias();
            //ENCERRAR VALORES
            p.codMaterias = "";
            p.nombreMateria = "";
            p.nivel = 0;
            p.carrera = "";
           
            foreach (DataRow fila in dt.Rows)
            {
                p.codMaterias = fila["codMaterias"].ToString();
                p.nombreMateria = fila["nombreMateria"].ToString();
                p.nivel = int.Parse(fila["nivel"].ToString());
                p.carrera = fila["carrera"].ToString();
               
                break;
            }
            return p;
        }
    }
}
