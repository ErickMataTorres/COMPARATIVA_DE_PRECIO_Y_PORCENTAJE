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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            cbEcommerce.DataSource = Clases.Conexion.ConsultaComboBox("TablaProveedor", "*");
            cbEcommerce.ValueMember = "Id";
            cbEcommerce.DisplayMember = "Nombre";
            Activar(true);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Marca marca = new Clases.Marca();
            marca.Id = int.Parse(txtId.Text);
            marca.Nombre = txtNombre.Text.ToUpper().Trim();
            marca.Ecommerce = cbEcommerce.Text.ToUpper().Trim();
            //marca.IdProveedor = int.Parse(cbProveedor.SelectedValue.ToString());
            Clases.Conexion.GuardarMarca(marca);
            MessageBox.Show("Se ha guardado correctamente", "Aviso");
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
                txtNombre.Clear();
                //cbProveedor.SelectedIndex = 0;
                txtId.Text = Clases.Conexion.ConsultaMaximo(" TablaMarca ", " max(Id)+1 ").ToString();
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
                Clases.Marca marca = new Clases.Marca(int.Parse(txtId.Text));
                if (marca.Id != -1)
                {
                    txtNombre.Text = marca.Nombre;
                    cbEcommerce.Text = marca.Ecommerce;
                    //cbProveedor.SelectedValue = marca.IdProveedor;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente quisiera eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Clases.Conexion.EliminaMarca(int.Parse(txtId.Text));
                    Activar(true);
                }
            }
            catch
            {
                MessageBox.Show("No se puede eliminar una marca que esta asignada", "Aviso");
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
            //string resultado = ventana.Busca(" TablaMarca inner join TablaLlantas on TablaMarca.Id=TablaLlantas.Marca inner join TablaProveedor on TablaProveedor.Id=TablaLlantas.IdProveedor inner join TablaCategoria on TablaCategoria.Id=TablaLlantas.IdCategoria inner join TablaGenero on TablaGenero.Id=TablaLlantas.IdGenero ", " TablaMarca.Nombre as Marca,TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio,TablaLlantas.Modelo+'|'+TablaLlantas.Medida as Regresar,TablaProveedor.Nombre as Proveedor,TablaCategoria.Nombre as Categoría,TablaGenero.Nombre as Género ", " TablaLlantas.Modelo", "Regresar", "Llantas", "Regresar","");
            string resultado = ventana.Busca(" TablaMarca ", " Id,Nombre", " Nombre ", "Id", "Marcas", "", "");
            if (resultado != "")
            {
                txtId.Text = resultado;
                KeyPressEventArgs tecla = new KeyPressEventArgs((char)Keys.Enter);
                txtId_KeyPress(sender, tecla);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
