using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticaPlusVision.Model
{
    internal class dbContext
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                string server = "DESKTOP-QR03KRF";
                string database = "DbOPtivision";
                SqlConnection conexion = new SqlConnection("Server=" + server + "; Database=" + database + "; Integrated Security=true");

                conexion.Open();

                return conexion;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}