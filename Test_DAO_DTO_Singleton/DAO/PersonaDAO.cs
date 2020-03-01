using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Test_DAO_DTO_Singleton.DTO;
using System.Windows.Forms;

namespace Test_DAO_DTO_Singleton.DAO
{
    class PersonaDAO : ConexionDB
    {
        SqlDataReader Reader;


        public IEnumerable<PersonaDTO> VerRegistros(string Condicion = "")
        {
            List<PersonaDTO> Lista = new List<PersonaDTO>();
            try
            {
                Conexion.Open();

                //Con esa consulta puedo buscar por filtro, poner un textbox donde ponga el ID o nombre para buscar su similitud
                SqlCommand Comando = new SqlCommand("SELECT * FROM Persona WHERE ID LIKE @Condicion+'%' or Nombre like @Condicion+'%'", Conexion);

                //Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Condicion", Condicion);



                Reader = Comando.ExecuteReader();



                while (Reader.Read())
                {
                    Lista.Add(new PersonaDTO
                    {
                        ID = Reader.GetInt32(0),
                        Nombre = Reader.GetString(1),
                        Fecha_Nacimiento = Reader.GetDateTime(2)
                    });
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                //NO CUMPLE CON LOS PATRONES, YA QUE LA CAPA DATOS NO DEBERIA USAR LA CAPA PRESE
                //SE HA USADO SOLO POR EMERGENCIA
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {

                Conexion.Close();
            }

            return Lista;

        }

        public void Insert() { }
        public void Edir() { }
        public void Delete() { }

    }
}
