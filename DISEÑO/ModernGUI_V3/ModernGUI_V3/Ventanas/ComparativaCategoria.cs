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
    public partial class ComparativaCategoria : Form
    {
        public ComparativaCategoria()
        {
            InitializeComponent();
        }

        private void ComparativaCategoria_Load(object sender, EventArgs e)
        {
            dgvLlantiRed.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantiRed2 where Medida like '%" + cbMedida.Text + "%' and Marca='TOLEDO' ", "Modelo,Medida,Precio ");
            dgvEcommerce.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantas2 "," Marca,Modelo,Medida,Precio ");
            CargaComboBox();
        }
        private void CargaDataGrids()
        {
            dgvLlantiRed.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantiRed2 where Medida like '%"+cbMedida.Text+"%'   and Marca='TOLEDO' ", "Modelo, Medida,Precio ");
            dgvEcommerce.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantas2 where Medida='"+cbMedida.Text+"'", " Marca,Modelo,Medida,Precio ");
            dgvLlantiRed.AutoResizeColumns();
            dgvEcommerce.AutoResizeColumns();
        }
        private void CargaComboBox()
        {
            cbMedida.DataSource = Clases.Conexion.ConsultaComboBox(" TablaLlantiRed2 where Marca='TOLEDO' ", " Medida ");
            cbMedida.DisplayMember = "Medida";

            cbEcommerce.DataSource = Clases.Conexion.ConsultaComboBox(" TablaProveedor ", " Id,Nombre ");
            cbEcommerce.ValueMember = "Id";
            cbEcommerce.DisplayMember = "Nombre";

        }

        private void cbMedida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargaDataGrids();
            dgvEcommerce.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantas2 where Medida='" + cbMedida.Text + "' and Ecommerce='" + cbEcommerce.Text+"'", " Marca,Modelo,Medida,Precio ");
        }

        private void cbEcommerce_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvEcommerce.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantas2 where Medida='"+cbMedida.Text+"' and Ecommerce='"+cbEcommerce.Text+"'"," Marca,Modelo,Medida,Precio ");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //------Instancia para abrir la ventana para calcular la comparación y exportar a Excel-----------//
                Ventanas.ExportarExcelCategoria ventana = new Ventanas.ExportarExcelCategoria(cbEcommerce.Text,cbMedida.Text);
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
    }
}
