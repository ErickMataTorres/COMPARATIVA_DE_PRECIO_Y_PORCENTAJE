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
    public partial class ExportarExcel : Form
    {
        private string Tabla;
        private string Campos;
        private string Ecommerce;
        private string Medida;
        private int Categoria;


        public ExportarExcel()
        {
            InitializeComponent();
        }
        public ExportarExcel(string ecommerce)
        {
            InitializeComponent();
            Ecommerce = ecommerce;
        }
        private void ExportarExcel_Load(object sender, EventArgs e)
        {
            lblResultadoComparacion.Text = "Resultado de comparación: " + Ecommerce;
            CargarGrid();//---------------Se manda llamar el método que cargar la información en el DataGridView de acuerdo a la consulta hecha---------------//
        }
        //---------------------Método para cargar la información en el DataGridView---------------------//
        private void CargarGrid()
        {
            try
            {
                dgvResultadoComparacion.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantiRed2 inner join TablaLlantas2 on TablaLlantiRed2.Medida=TablaLlantas2.Medida where TablaLlantiRed2.Marca=TablaLlantas2.Marca and TablaLlantiRed2.Modelo=TablaLlantas2.Modelo and TablaLlantas2.Ecommerce='"+Ecommerce+"'", " TablaLlantiRed2.Marca as [MarcaLlantiRed],TablaLlantiRed2.Modelo as [ModeloLlantiRed],TablaLlantiRed2.Medida as [MedidaLlantiRed],TablaLlantiRed2.Precio as [PrecioLlantiRed],TablaLlantas2.Marca as [Marca], TablaLlantas2.Modelo, TablaLlantas2.Medida, TablaLlantas2.Precio, (TablaLlantas2.Precio - TablaLlantiRed2.Precio) as [DiferenciaPrecio],(((TablaLlantas2.Precio - TablaLlantiRed2.Precio) / (TablaLlantas2.Precio)) * 100) as DiferenciaPorcentaje ");
                dgvResultadoComparacion.AutoResizeColumns();
                sbyte indice = 0;
                while (indice < dgvResultadoComparacion.ColumnCount)
                {
                    Color color = Color.LightGreen;
                    if (indice >= 4)
                    {
                        color = Color.LightSkyBlue;
                    }
                    dgvResultadoComparacion.Columns[indice].DefaultCellStyle.BackColor = color;
                    indice++;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido algo: " + exception.Message);
            }
        }
        //---------------------Método que recibe un parámetro de tipo DataGridView----------------------//
        //--------------Este método hace el proceso para exportar la información que haiga en el DataGridView que reciba en el parámetro----------------------//
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                MetodoExportarExcel(dgvResultadoComparacion);//----------------------Ésto se mete en el evento click de btnExportar para mandar llamar el método que hace el proceso de exportar a Excel, mandando su respectivo parámetro que es el DataGridView que quieramos que exporte para Excel--------------------//
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
