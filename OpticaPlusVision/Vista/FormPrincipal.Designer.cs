namespace OpticaPlusVision.Vista
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnFacturacion = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnInico = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Msgbnvenida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(646, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::OpticaPlusVision.Properties.Resources.loloklolo1;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1522, 114);
            this.panel1.TabIndex = 0;
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnProveedores.FlatAppearance.BorderSize = 0;
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.BtnProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProveedores.Location = new System.Drawing.Point(12, 297);
            this.BtnProveedores.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(178, 43);
            this.BtnProveedores.TabIndex = 6;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.UseVisualStyleBackColor = true;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClientes.Location = new System.Drawing.Point(12, 248);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(178, 43);
            this.BtnClientes.TabIndex = 5;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            // 
            // BtnReportes
            // 
            this.BtnReportes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(98)))));
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.BtnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReportes.Location = new System.Drawing.Point(12, 199);
            this.BtnReportes.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(178, 43);
            this.BtnReportes.TabIndex = 4;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = false;
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(98)))));
            this.BtnFacturacion.FlatAppearance.BorderSize = 0;
            this.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturacion.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.BtnFacturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFacturacion.Location = new System.Drawing.Point(12, 150);
            this.BtnFacturacion.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(178, 43);
            this.BtnFacturacion.TabIndex = 3;
            this.BtnFacturacion.Text = "Facturacion";
            this.BtnFacturacion.UseVisualStyleBackColor = false;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(98)))));
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVentas.Location = new System.Drawing.Point(12, 101);
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(178, 43);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = false;
            // 
            // BtnInventario
            // 
            this.BtnInventario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(98)))));
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInventario.Location = new System.Drawing.Point(12, 52);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(178, 43);
            this.BtnInventario.TabIndex = 1;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = false;
            // 
            // BtnInico
            // 
            this.BtnInico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(98)))));
            this.BtnInico.FlatAppearance.BorderSize = 0;
            this.BtnInico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInico.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInico.ForeColor = System.Drawing.Color.White;
            this.BtnInico.Location = new System.Drawing.Point(12, 3);
            this.BtnInico.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.BtnInico.Name = "BtnInico";
            this.BtnInico.Size = new System.Drawing.Size(178, 43);
            this.BtnInico.TabIndex = 0;
            this.BtnInico.Text = "Inicio";
            this.BtnInico.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(98)))));
            this.flowLayoutPanel1.Controls.Add(this.BtnInico);
            this.flowLayoutPanel1.Controls.Add(this.BtnInventario);
            this.flowLayoutPanel1.Controls.Add(this.BtnVentas);
            this.flowLayoutPanel1.Controls.Add(this.BtnFacturacion);
            this.flowLayoutPanel1.Controls.Add(this.BtnReportes);
            this.flowLayoutPanel1.Controls.Add(this.BtnClientes);
            this.flowLayoutPanel1.Controls.Add(this.BtnProveedores);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 114);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 677);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Msgbnvenida
            // 
            this.Msgbnvenida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Msgbnvenida.AutoSize = true;
            this.Msgbnvenida.Font = new System.Drawing.Font("Cambria Math", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msgbnvenida.Location = new System.Drawing.Point(741, 483);
            this.Msgbnvenida.Name = "Msgbnvenida";
            this.Msgbnvenida.Size = new System.Drawing.Size(152, 111);
            this.Msgbnvenida.TabIndex = 6;
            this.Msgbnvenida.Text = "Bienvenid@";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::OpticaPlusVision.Properties.Resources.optica_logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(467, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 791);
            this.Controls.Add(this.Msgbnvenida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "PaginaPricipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnInico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Msgbnvenida;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}