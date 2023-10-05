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
    public partial class ExportarExcelCategoria : Form
    {
        private string Ecommerce;
        private string Medida;

        public ExportarExcelCategoria()
        {
            InitializeComponent();

        }
        public ExportarExcelCategoria(string ecommerce,string medida)
        {
            InitializeComponent();
            Ecommerce = ecommerce;
            Medida = medida;
        }

        private void ExportarExcelCategoria_Load(object sender, EventArgs e)
        {
            lblResultadoComparacion.Text = "Resultado de comparación: " + Ecommerce;
            CargarGrid();//---------------Se manda llamar el método que cargar la información en el DataGridView de acuerdo a la consulta hecha---------------//
        }
        //---------------------Método para cargar la información en el DataGridView---------------------//
        private void CargarGrid()
        {
            try
            {
                dgvResultadoComparacion.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantas2 inner join TablaLlantiRed2 on TablaLlantas2.Medida=TablaLlantiRed2.Medida where TablaLlantiRed2.Marca='TOLEDO' and TablaLlantas2.Ecommerce='"+Ecommerce+"'"+" and TablaLlantiRed2.Medida='"+Medida+"' order by TablaLlantiRed2.Medida ", "TablaLlantiRed2.Modelo as [ModeloLlantiRed], TablaLlantiRed2.Medida as [Medida de LlantiRed],TablaLlantiRed2.Precio as [Precio de LlantiRed],TablaLlantas2.Marca, TablaLlantas2.Modelo,TablaLlantas2.Medida, TablaLlantas2.Precio, substring(convert(varchar(20),TablaLlantiRed2.Precio-TablaLlantas2.Precio),0,CHARINDEX('.',(TablaLlantiRed2.Precio-TablaLlantas2.Precio))+3) as [Diferencia de Precio],CAST(CAST(round((((TablaLlantiRed2.Precio - TablaLlantas2.Precio) / (TablaLlantas2.Precio)) * 100),0)as int)as varchar(100))+' %' as [Diferencia de Porcentaje] ");
                dgvResultadoComparacion.AutoResizeColumns();
                sbyte indice = 0;
                while (indice < dgvResultadoComparacion.ColumnCount)
                {
                    Color color = Color.LightGreen;
                    if (indice >= 3)
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
