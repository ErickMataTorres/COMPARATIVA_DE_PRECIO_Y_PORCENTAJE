using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3.Ventanas
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
                Activar(true);
        }
        private void Activar(bool activo)
        {
            panel1.Enabled = activo;
            panel2.Enabled = !activo;
            panel3.Enabled = !activo;
            btnEliminar.Enabled = false;
            if (activo)
            {
                txtId.Text = Clases.Conexion.ConsultaMaximo(" TablaProveedor ", " max(Id)+1 ").ToString();
                txtNombre.Clear();
                txtDomicilio.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
            }
            else
            {
                txtNombre.Focus();
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtId.Text == "")
                {
                    return;
                }
                Activar(false);
                Clases.Proveedor proveedor = new Clases.Proveedor(int.Parse(txtId.Text));
                if (proveedor.Id != -1)
                {
                    txtNombre.Text = proveedor.Nombre;
                    txtDomicilio.Text = proveedor.Domicilio;
                    txtTelefono.Text = proveedor.Telefono;
                    txtCorreo.Text = proveedor.Correo;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere cancelar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Activar(true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Proveedor proveedor = new Clases.Proveedor();
                proveedor.Id = int.Parse(txtId.Text);
                proveedor.Nombre = txtNombre.Text.ToUpper().Trim();
                proveedor.Domicilio = txtDomicilio.Text.ToUpper().Trim();
                proveedor.Telefono = txtTelefono.Text.ToUpper().Trim();
                proveedor.Correo = txtCorreo.Text.ToUpper().Trim();
                Clases.Conexion.GuardarProveedor(proveedor);
                MessageBox.Show("Se ha guardado correctamente", "Aviso");
                Activar(true);
            }
            catch
            {
                MessageBox.Show("No se puede modificar un proveedor que ya esta asignado", "Aviso");
            }
            finally
            {
                if (Clases.Conexion.conx.State == ConnectionState.Open)
                {
                    Clases.Conexion.Desconectar();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar ventana = new Buscar();
            //string resultado = ventana.Busca("TablaLlantas", "Modelo,Medida,Precio,Modelo+'|'+Medida as Regresar", "Modelo", "Regresar", "Llantas","Regresar");
            string resultado = ventana.Busca(" TablaProveedor ", " * ", " Nombre ", "Id", "Proveedores", "", "");
            if (resultado != "")
            {
                txtId.Text = resultado;

                KeyPressEventArgs tecla = new KeyPressEventArgs((char)Keys.Enter);
                txtId_KeyPress(sender, tecla);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente quisiera eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Clases.Conexion.EliminaProveedor(int.Parse(txtId.Text));
                    Activar(true);
                }
            }
            catch
            {
                MessageBox.Show("No se puede eliminar un proveedor que está asignado", "Aviso");
            }
            finally
            {
                if (Clases.Conexion.conx.State == ConnectionState.Open)
                {
                    Clases.Conexion.Desconectar();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
