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
    public partial class Llantas : Form
    {
        public Llantas()
        {
            InitializeComponent();
        }

        private void Llantas_Load(object sender, EventArgs e)
        {
            CargarComboBox();
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
                txtModelo.Clear();
                txtMedida.Clear();
                cbMarca.SelectedIndex = 0;
                txtPrecio.Clear();
                cbProveedor.SelectedIndex = 0;
                cbCategoria.SelectedIndex = 0;
                cbGenero.SelectedIndex = 0;

            }
            else
            {
                cbMarca.Focus();

            }
        }
        //------------------Método para cargar los ComboBoxs-------------------//
        private void CargarComboBox()
        {
            cbMarca.DataSource = Clases.Conexion.ConsultaComboBox(" TablaMarca order by Nombre", "*");
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Nombre";
            cbProveedor.DataSource = Clases.Conexion.ConsultaComboBox(" TablaProveedor order by Nombre", "*");
            cbProveedor.ValueMember = "Id";
            cbProveedor.DisplayMember = "Nombre";
            cbCategoria.DataSource = Clases.Conexion.ConsultaComboBox(" TablaCategoria order by Nombre", "*");
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Nombre";
            cbGenero.DataSource = Clases.Conexion.ConsultaComboBox(" TablaGenero order by Nombre", "*");
            cbGenero.ValueMember = "Id";
            cbGenero.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Llanta llanta = new Clases.Llanta();
                llanta.Marca = cbMarca.Text.ToUpper().Trim();
                llanta.Modelo = txtModelo.Text.ToUpper().Trim();
                llanta.Medida = txtMedida.Text.ToUpper().Trim();
                llanta.Precio = decimal.Parse(txtPrecio.Text);
                llanta.Ecommerce = cbProveedor.Text.ToUpper().Trim();
                //llanta.IdProveedor = int.Parse(cbProveedor.SelectedValue.ToString());
                //llanta.IdCategoria = int.Parse(cbCategoria.SelectedValue.ToString());
                //llanta.IdGenero = int.Parse(cbGenero.SelectedValue.ToString());
                Clases.Conexion.GuardarLlanta(llanta);
                MessageBox.Show("Se ha guardado con exito", "Aviso");
                Activar(true);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido una excepción: " + exception.Message);
                if (Clases.Conexion.conx.State == ConnectionState.Open)
                {
                    Clases.Conexion.Desconectar();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quisiera cancelar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Activar(true);
            }
        }

        private void txtMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtModelo.Text == "" || txtMedida.Text == "")
                {
                    return;
                }
                Activar(false);
                Clases.Llanta llanta = new Clases.Llanta(txtModelo.Text.ToUpper().Trim(), txtMedida.Text.ToUpper().Trim());
                if (llanta.Precio != -1)
                {
                    cbMarca.Text = llanta.Marca;
                    txtPrecio.Text = llanta.Precio.ToString();
                    cbProveedor.Text = llanta.Ecommerce;
                    //cbProveedor.SelectedValue = llanta.IdProveedor;
                    //cbCategoria.SelectedValue = llanta.IdCategoria;
                    //cbGenero.SelectedValue = llanta.IdGenero;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar ésta llanta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Clases.Conexion.EliminaLlanta(txtModelo.Text, txtMedida.Text);
                Activar(true);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar ventana = new Buscar();
            //string resultado = ventana.Busca("TablaLlantas", "Modelo,Medida,Precio,Modelo+'|'+Medida as Regresar", "Modelo", "Regresar", "Llantas","Regresar");
            string resultado = ventana.Busca(" TablaLlantas2 ", " Marca,Modelo,Medida,Precio,Modelo+'|'+Medida as Regresar,Ecommerce ", " Modelo", "Regresar", "Llantas", "Regresar", "");
            if (resultado != "")
            {
                txtModelo.Text = resultado.Substring(0, resultado.IndexOf('|'));
                txtMedida.Text = resultado.Substring(resultado.IndexOf('|') + 1);
                KeyPressEventArgs tecla = new KeyPressEventArgs((char)Keys.Enter);
                txtMedida_KeyPress(sender, tecla);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
