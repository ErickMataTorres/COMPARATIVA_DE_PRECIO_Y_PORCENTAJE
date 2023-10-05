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
    public partial class ComparacionFiltro : Form
    {
        public ComparacionFiltro()
        {
            InitializeComponent();
        }

        private void ComparacionFiltro_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CbModo_TextChanged(sender,e);
        }
        private void CargarCombo()
        {
            //cbMarca.DataSource = Clases.Conexion.ConsultaComboBox("TablaMarca", "*");
            //cbMarca.ValueMember = "Id";
            //cbMarca.DisplayMember = "Nombre";
            //cbMarca.Text = null;
            //cbModelo.DataSource = Clases.Conexion.ConsultaComboBox("TablaLlantiRed2 where Marca='" + cbMarca.Text + "'", "*");
            //cbModelo.DisplayMember = "Modelo";
            //cbModelo.Text = null;
            //cbMedida.DataSource = Clases.Conexion.ConsultaComboBox("TablaLlantiRed2 where Marca='" + cbMarca.Text + "' and Modelo='" + cbModelo.Text + "'", "*");
            //cbMedida.DisplayMember = "Medida";
            //cbMedida.Text = null;
            cbEcommerce.DataSource = Clases.Conexion.ConsultaComboBox("TablaProveedor", "*");
            cbEcommerce.ValueMember = "Id";
            cbEcommerce.DisplayMember = "Nombre";
            cbEcommerce.Text = null;
        }
        private void CargarGrid()
        {
            try
            { 
                if (cbMedida.Enabled && cbEcommerce.Enabled)
                {
                    dgvComparacion.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantiRed2 inner join TablaLlantas2 on TablaLlantiRed2.Medida=TablaLlantas2.Medida where TablaLlantiRed2.Marca=TablaLlantas2.Marca and TablaLlantiRed2.Modelo=TablaLlantas2.Modelo and TablaLlantiRed2.Marca='" + cbMarca.Text + "' and TablaLlantiRed2.Modelo='" + cbModelo.Text + "' and TablaLlantiRed2.Medida='"+cbMedida.Text+"' and TablaLlantas2.Ecommerce='" + cbEcommerce.Text + "'", " TablaLlantiRed2.Marca as [MarcaLlantiRed],TablaLlantiRed2.Modelo as [ModeloLlantiRed],TablaLlantiRed2.Medida as [MedidaLlantiRed],TablaLlantiRed2.Precio as [PrecioLlantiRed],TablaLlantas2.Marca as [Marca], TablaLlantas2.Modelo, TablaLlantas2.Medida, TablaLlantas2.Precio, (TablaLlantas2.Precio - TablaLlantiRed2.Precio) as [DiferenciaPrecio],(((TablaLlantas2.Precio - TablaLlantiRed2.Precio) / (TablaLlantas2.Precio)) * 100) as DiferenciaPorcentaje ");
                }
                else
                {
                    if (cbModo.Enabled && cbMedida.Enabled == false && cbEcommerce.Enabled)
                    {
                        dgvComparacion.DataSource = Clases.Conexion.ConsultaDataGrid("TablaLlantiRed2 inner join TablaLlantas2 on TablaLlantiRed2.Medida = TablaLlantas2.Medida where TablaLlantiRed2.Marca = TablaLlantas2.Marca and TablaLlantiRed2.Modelo = TablaLlantas2.Modelo and TablaLlantas2.Ecommerce = '"+cbEcommerce.Text+"'", " TablaLlantiRed2.Marca as [MarcaLlantiRed], TablaLlantiRed2.Modelo as [ModeloLlantiRed], TablaLlantiRed2.Medida as [MedidaLlantiRed], TablaLlantiRed2.Precio as [PrecioLlantiRed], TablaLlantas2.Marca as [Marca], TablaLlantas2.Modelo, TablaLlantas2.Medida, TablaLlantas2.Precio, (TablaLlantas2.Precio - TablaLlantiRed2.Precio) as [DiferenciaPrecio], (((TablaLlantas2.Precio - TablaLlantiRed2.Precio) / (TablaLlantas2.Precio)) * 100) as DiferenciaPorcentaje");
                    }
                }
                dgvComparacion.AutoResizeColumns();
                int indice = 0;
                while (indice < dgvComparacion.ColumnCount)
                {
                    Color color = Color.LightGreen;
                    if (indice >= 4)
                    {
                        color = Color.LightSkyBlue;
                    }
                    dgvComparacion.Columns[indice].DefaultCellStyle.BackColor = color;
                    indice++;
                }
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

        private void cbECommerce_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GbFiltro_Enter(object sender, EventArgs e)
        {

        }

        private void CbModo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CbModo_TextChanged(object sender, EventArgs e)
        {
            if (cbModo.Text == "")
            {
                cbMarca.Enabled = false;
                cbModelo.Enabled = false;
                cbMedida.Enabled = false;
                cbEcommerce.Enabled = false;
            }
            else
            {
                if (cbModo.Text == "Específica")
                {

                    
                    cbMarca.Enabled = true;
                    cbEcommerce.Enabled = false;
                    cbEcommerce.Text = null;

                    cbMarca.DataSource = Clases.Conexion.ConsultaComboBox("TablaMarca", "*");
                    cbMarca.ValueMember = "Id";
                    cbMarca.DisplayMember = "Nombre";
                    cbMarca.Text = null;

                }
                else
                {
                    if (cbModo.Text == "General")
                    {
                        cbMarca.Enabled = false;
                        cbModelo.Enabled = false;
                        cbMedida.Enabled = false;
                        cbMarca.Text = null;
                        cbModelo.Text = null;
                        cbMedida.Text = null;
                        cbEcommerce.Text = null;
                        cbEcommerce.Enabled = true;

                    }

                }
            }

        }

        private void CbMarca_TextChanged(object sender, EventArgs e)
        {
            if (cbMarca.Text != "")
            {
                cbModelo.Enabled = true;
                cbModelo.DataSource = Clases.Conexion.ConsultaComboBox("TablaLlantiRed2 where Marca='" + cbMarca.Text + "' group by Modelo", " Modelo ");
                cbModelo.DisplayMember = "Modelo";
                cbModelo.Text = null;
            }
            else
            {
                cbModelo.Enabled = false;
            }
        }

        private void CbModelo_TextChanged(object sender, EventArgs e)
        {
            if (cbModelo.Text != "")
            {
                cbMedida.Enabled = true;
                cbMedida.DataSource = Clases.Conexion.ConsultaComboBox("TablaLlantiRed2 where Marca='" + cbMarca.Text + "' and Modelo='" + cbModelo.Text + "' group by Medida ", " Medida ");
                cbMedida.DisplayMember = "Medida";
                cbMedida.Text = null;
            }
            else
            {
                cbMedida.Enabled = false;
            }
        }

        private void CbMedida_TextChanged(object sender, EventArgs e)
        {
            if (cbMedida.Text != "")
            {
                cbEcommerce.Enabled = true;

            }
            else
            {
                cbEcommerce.Enabled = false;
            }

        }
        public void MetodoExportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[1, indiceColumna] = col.Name;
            }
            int indiceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                MetodoExportarExcel(dgvComparacion);//----------------------Ésto se mete en el evento click de btnExportar para mandar llamar el método que hace el proceso de exportar a Excel, mandando su respectivo parámetro que es el DataGridView que quieramos que exporte para Excel--------------------//
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