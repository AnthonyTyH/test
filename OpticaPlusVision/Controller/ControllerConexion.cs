using OpticaPlusVision.Model;
using OpticaPlusVision.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticaPlusVision.Controller
{
    internal class ControllerConexion
    {
        Proveedores ObjForm;

        public ControllerConexion(Proveedores vista)
        {
            ObjForm = vista;
            ObjForm.BtnConectar.Click += new EventHandler(Conectar);
        }

        public void Conectar(object sender, EventArgs e)
        {
            if (dbContext.GetConnection() != null)
            {
                MessageBox.Show("Conexión exitosa", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Conexión fallida", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}