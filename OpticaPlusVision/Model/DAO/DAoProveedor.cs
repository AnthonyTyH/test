using OpticaPlusVision.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticaPlusVision.Model.DAO
{
    internal class DAoProveedor:DToProveedor
    {
        SqlCommand comando = new SqlCommand();
        public int GuardarProveedor()
        {
            using (SqlConnection conexion = dbContext.GetConnection())
            {
               
                
                    string DatosP = "insert into Proveedores(Nombre_Proveedor, Telefono_Proveedor, Correo_Proveedor)" +
                        " values(@Proveedor, @Telefono, @Correo)";

              
                using (comando = new SqlCommand(DatosP, conexion))
                    {
                        comando.Parameters.AddWithValue("@Proveedor", Nombre_proveedor );
                        comando.Parameters.AddWithValue("@Telefono", Telefono_proveedor );
                        comando.Parameters.AddWithValue("@Correo", Correo_proveedor);

                    
                       return comando.ExecuteNonQuery();
                    }

                    
                
               
            }
        }

        public DataSet ConsultaProveedor(string consulta)
        {
            using (SqlConnection conexion = dbContext.GetConnection())
            {
                if (conexion != null)
                {
                    string query;

                    if (string.IsNullOrEmpty(consulta))
                    {
                        query = "SELECT * FROM Proveedores";
                    }
                    else
                    {
                        query = "SELECT * FROM Proveedores WHERE Nombre_Proveedor LIKE @Proveedor";
                    }

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        if (!string.IsNullOrEmpty(consulta))
                        {
                            comando.Parameters.AddWithValue("@Proveedor", consulta);
                        }

                        using (SqlDataAdapter data = new SqlDataAdapter(comando))
                        {
                            DataSet ds = new DataSet();
                            data.Fill(ds,"Proveedores");
                            return ds;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos.");
                    return null;
                 
                } 
            }
        }
        public void EliminarProveedor()
        {
            try
            {
                int valor = 0;
                string DatosP = "DELETE FROM Proveedores WHERE Nombre_Proveedor = @Proveedor";

                using (SqlConnection conexion = dbContext.GetConnection())
                {
                    using (SqlCommand comando = new SqlCommand(DatosP, conexion))
                    {
                       
                        comando.Parameters.AddWithValue("@Proveedor", Nombre_proveedor);

                  
                        valor = comando.ExecuteNonQuery();
                    }
                }

                if (valor == 1)
                {
                    MessageBox.Show("Se eliminó de manera exitosa.");
                }
                else
                {
                    MessageBox.Show("No se encontró al proveedor.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarProveedor(string actualizar)
        {
            comando.Connection = dbContext.GetConnection();
            int valor = 0;
            string DatosP = "UPDATE Proveedores SET Nombre_Proveedor = @Proveedor, Telefono_Proveedor = @Telefono, Correo_Proveedor = @Correo WHERE Nombre_proveedor = @Actualizar ";

            using (SqlConnection conexion = dbContext.GetConnection())
            {
                using (SqlCommand comando = new SqlCommand(DatosP, conexion))
                {
                    comando.Parameters.AddWithValue("@Proveedor", Nombre_proveedor);
                    comando.Parameters.AddWithValue("@Telefono", Telefono_proveedor);
                    comando.Parameters.AddWithValue("@Correo", Correo_proveedor);
                    comando.Parameters.AddWithValue("@Actualizar", actualizar );


                    valor = comando.ExecuteNonQuery();
                }
            }

            if (valor > 0)
            {
                MessageBox.Show("El proveedor se actualizó exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar datos.");
            }
        }






    }

}



