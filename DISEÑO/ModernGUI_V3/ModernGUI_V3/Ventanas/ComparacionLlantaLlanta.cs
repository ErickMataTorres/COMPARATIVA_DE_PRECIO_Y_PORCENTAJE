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
    public partial class ComparacionLlantaLlanta : Form
    {
        public ComparacionLlantaLlanta()
        {
            InitializeComponent();
        }

        private void ComparacionLlantaLlanta_Load(object sender, EventArgs e)
        {
            //CargarDataGridViews();//--------------Llamamiento del método en el Load para Cargar la información en los DataGridViews en cuanto cargue la ventana Load---------------// 
            dgvLlantiRed.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantiRed2 ", "Marca,Modelo,Medida,Precio");
            dgvProveedores.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantas2 ", " Marca,Modelo,Medida,Precio");
            CargaComboBox();
        }
        //---------------Método para cargar la información en los DataGridViews--------------//
        private void CargarDataGridViews()
        {
            try
            {
                dgvLlantiRed.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantiRed2 ", " Marca,Modelo,Medida,Precio");
                dgvProveedores.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantas2 where Ecommerce='" + cbEcommerce.Text+"'", " Marca,Modelo,Medida,Precio ");
                dgvLlantiRed.AutoResizeColumns();
                dgvProveedores.AutoResizeColumns();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido algo: " + exception.Message);
                if (Clases.Conexion.conx.State == ConnectionState.Open)
                {
                    Clases.Conexion.Desconectar();
                }
            }
        }
        private void CargaComboBox()
        {
            cbEcommerce.DataSource = Clases.Conexion.ConsultaComboBox(" TablaProveedor "," Id,Nombre ");
            cbEcommerce.ValueMember = "Id";
            cbEcommerce.DisplayMember = "Nombre";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //------Instancia para abrir la ventana para calcular la comparación y exportar a Excel-----------//
                ExportarExcel ventana = new ExportarExcel(cbEcommerce.Text);
                ventana.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido algo: " + exception.Message);
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

        private void cbEcommerce_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDataGridViews();
        }
    }
}
