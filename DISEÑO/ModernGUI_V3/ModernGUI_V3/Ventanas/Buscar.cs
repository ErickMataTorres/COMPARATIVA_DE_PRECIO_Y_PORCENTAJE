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
    public partial class Buscar : Form
    {
        string miTabla;
        string misCampos;
        string miOrden;
        string miRegreso;
        string ocultarCampo;
        string miOtraCondicion;
        string res = "";
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = Clases.Conexion.Buscar(miTabla, misCampos, miOrden, txtBuscar.Text.ToUpper().Trim(), miOtraCondicion);
            dgvBuscar.AutoResizeColumns();
            //dgvBuscar.Columns[miOrden].Width = dgvBuscar.Width - dgvBuscar.Columns[0].Width - dgvBuscar.RowHeadersWidth - 5;
            if (ocultarCampo != "")
            {
                dgvBuscar.Columns[ocultarCampo].Visible = false;
            }
        }
        public string Busca(string tabla, string campos, string orden, string regresar, string titulo, string ocultar, string otraCondicion)
        {
            miTabla = tabla;
            misCampos = campos;
            miOrden = orden;
            miRegreso = regresar;
            this.Text = "Consulta de " + titulo;
            ocultarCampo = ocultar;
            miOtraCondicion = otraCondicion;
            this.ShowDialog();
            return res;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvBuscar.DataSource = Clases.Conexion.Buscar(miTabla, misCampos, miOrden, txtBuscar.Text.ToUpper().Trim(), miOtraCondicion);
                //dgvBuscar.Columns[miOrden].Width = dgvBuscar.Width - dgvBuscar.Columns[0].Width - dgvBuscar.RowHeadersWidth - 5;
                dgvBuscar.AutoResizeColumns();
                if (ocultarCampo != "")
                {
                    dgvBuscar.Columns[ocultarCampo].Visible = false;
                }
            }
        }

        private void dgvBuscar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dgvBuscar.Rows.Count; count++)
            {
                if ((count % 2) == 0)
                {
                    dgvBuscar.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Moccasin;
                }
                else
                {
                    dgvBuscar.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Beige;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            res = dgvBuscar.CurrentRow.Cells[miRegreso].Value.ToString();
            Close();
        }

        private void dgvBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            res = dgvBuscar.CurrentRow.Cells[miRegreso].Value.ToString();
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}