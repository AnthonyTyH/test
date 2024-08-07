using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticaPlusVision.Model.DTO
{
    internal class DToProveedor:dbContext
    {
       private int id_Proveedor;
        private string nombre_proveedor;
        private string telefono_proveedor;
        private string correo_proveedor;

        public int Id_Proveedor { get => id_Proveedor; set => id_Proveedor = value; }
        public string Nombre_proveedor { get => nombre_proveedor; set => nombre_proveedor = value; }
        public string Telefono_proveedor { get => telefono_proveedor; set => telefono_proveedor = value; }
        public string Correo_proveedor { get => correo_proveedor; set => correo_proveedor = value; }
        
    }
}
