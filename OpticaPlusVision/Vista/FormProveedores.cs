﻿using OpticaPlusVision.Controller;
using OpticaPlusVision.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticaPlusVision.Vista
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            ControllerConexion control = new ControllerConexion(this);
            ControllerProveedor proveedor = new ControllerProveedor(this);
        }

     
       
    }
        }




