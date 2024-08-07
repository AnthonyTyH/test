using OpticaPlusVision.Model.DAO;
using OpticaPlusVision.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticaPlusVision.Controller
{
    internal class ControllerProveedor
    {
        Proveedores objproveedor;
        public ControllerProveedor(Proveedores vista)
        {
            objproveedor = vista;
            objproveedor.Load += LlenarDatagrv;
            objproveedor.btnGuardar.Click += GuardarProveedor;
            objproveedor.btnConsulta.Click += LlenarDatagrv;
            objproveedor.btnEliminar.Click += EliminarProveedor;
            objproveedor.btnActualizar.Click += ActualizarProveedor;
        }


        public void GuardarProveedor(object sender, EventArgs e) 
        {
            DAoProveedor proveedor = new DAoProveedor();
            proveedor.Nombre_proveedor= objproveedor.txtProveedor.Text;
            proveedor.Telefono_proveedor = objproveedor.txtTelefono.Text;
            proveedor.Correo_proveedor = objproveedor.txtCorreo.Text;
            int valorRetornado = proveedor.GuardarProveedor();


            if (valorRetornado == 1)
            {   

                MessageBox.Show("Los datos han sido registrados exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser registrados",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            ActualizarDatagrv();
        }
        public void LlenarDatagrv(object sender, EventArgs e) 
        {
            ActualizarDatagrv();
        }
        public void ActualizarDatagrv() 
        {
            DAoProveedor proveedor = new DAoProveedor();
            string consulta = objproveedor.txtConsulta.Text;
            DataSet ds = proveedor.ConsultaProveedor(consulta);
            objproveedor.dgvConsulta.DataSource = ds.Tables["Proveedores"];
        }

     public void EliminarProveedor(object sender, EventArgs e)
        {
            DAoProveedor eliminarProveedor = new DAoProveedor();
            eliminarProveedor.Nombre_proveedor = objproveedor.txtProveedor.Text;
            eliminarProveedor.EliminarProveedor();
            ActualizarDatagrv();
        }


        private string actualizar;

        public void ActualizarProveedor(object sender, EventArgs e)
        {
            DAoProveedor actualizarProveedor = new DAoProveedor();
            actualizar = objproveedor.txt_Actualizar.Text;
            actualizarProveedor.Nombre_proveedor = objproveedor.txtProveedor.Text;
            actualizarProveedor.Telefono_proveedor = objproveedor.txtTelefono.Text;
            actualizarProveedor.Correo_proveedor = objproveedor.txtCorreo.Text;
            actualizarProveedor.ActualizarProveedor(actualizar);

            ActualizarDatagrv();
        }
    }


}
    



