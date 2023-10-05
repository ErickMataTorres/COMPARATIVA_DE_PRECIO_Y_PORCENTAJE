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
    public partial class ComparacionGeneral : Form
    {
        public ComparacionGeneral()
        {
            InitializeComponent();
        }
        private void ComparacionGeneral_Load(object sender, EventArgs e)
        {
            CargarDataGrids();
            cbProveedor.DataSource = Clases.Conexion.ConsultaComboBox(" TablaProveedor order by Nombre", "*");
            cbProveedor.ValueMember = "Id";
            cbProveedor.DisplayMember = "Nombre";
            cbMedida.DataSource = Clases.Conexion.ConsultaComboBox("TablaLlantiRed2 group by Medida order by Medida", "Medida");
            cbMedida.DisplayMember = "Medida";
        }
        private void Comparacion()
        {
            if (dgvLlantiRed.CurrentRow == null || dgvLlantasProveedor.CurrentRow == null)
            {
                return;
            }
            decimal precioLlantiRed = 0;
            decimal precioProveedor = 0;
            decimal diferencia = 0;
            decimal diferenciaPorciento = 0;
            decimal.TryParse(dgvLlantiRed.CurrentRow.Cells["Precio"].Value.ToString(), out precioLlantiRed);
            decimal.TryParse(dgvLlantasProveedor.CurrentRow.Cells["Precio"].Value.ToString(), out precioProveedor);
            diferencia = (precioProveedor - precioLlantiRed);
            if (precioProveedor > precioLlantiRed)
            {
                diferenciaPorciento = (diferencia / precioProveedor) * 100;
            }
            else
            {
                diferencia = (precioLlantiRed - precioProveedor);
                diferenciaPorciento = (diferencia / precioLlantiRed) * 100;
                diferenciaPorciento = Convert.ToDecimal("-" + diferenciaPorciento);
            }
            txtDiferenciaPrecio.Text = diferencia.ToString();
            if (diferenciaPorciento == 0)
            {
                txtDiferenciaPorcentaje.Text = "0%";
                txtDiferenciaPrecio.BackColor = Color.LightBlue;
                txtDiferenciaPorcentaje.BackColor = Color.LightBlue;
            }
            else
            {
                if (diferenciaPorciento > 0)
                {
                    txtDiferenciaPrecio.BackColor = Color.LightGreen;
                    txtDiferenciaPorcentaje.BackColor = Color.LightGreen;
                }
                else
                {
                    if (diferenciaPorciento >= (-25))
                    {
                        txtDiferenciaPrecio.BackColor = Color.Yellow;
                        txtDiferenciaPorcentaje.BackColor = Color.Yellow;
                    }
                    else
                    {
                        if (diferenciaPorciento < (-25))
                        {
                            txtDiferenciaPrecio.BackColor = Color.Red;
                            txtDiferenciaPorcentaje.BackColor = Color.Red;
                        }
                    }
                }
                txtDiferenciaPorcentaje.Text = string.Format("{0:#.####}", diferenciaPorciento) + "%";
            }
        }
        private void CargarDataGrids()
        {
            dgvLlantiRed.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantiRed2 ", " Modelo,Medida,Precio ");
            dgvLlantasProveedor.DataSource = Clases.Conexion.ConsultaDataGrid(" TablaLlantas2 ", " Modelo,Medida,Precio,Ecommerce ");
        }
        private void cbProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            //Select Modelo,Medida,Precio,IdProveedor from TablaLlantas where Medida like '%220/55R15%' and IdProveedor=1
            if (cbMedida.Text == "")
            {
                return;
            }
            else
            {
                dgvLlantasProveedor.DataSource = Clases.Conexion.Buscar(" TablaLlantas2 ", " Modelo,Medida,Precio,Ecommerce ", " Medida ", cbMedida.Text.ToUpper().Trim(), " and [Ecommerce]='" + cbProveedor.Text+"'");
            }
        }
        private void cbMedida_TextChanged(object sender, EventArgs e)
        {
            dgvLlantiRed.DataSource = Clases.Conexion.Buscar(" TablaLlantiRed2 ", " Marca,Modelo,Medida,Precio ", " Medida ", cbMedida.Text.ToUpper().Trim(), "");
        }
        private void dgvLlantasProveedor_SelectionChanged(object sender, EventArgs e)
        {
            Comparacion();

        }

        private void dgvLlantiRed_SelectionChanged(object sender, EventArgs e)
        {
            Comparacion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}