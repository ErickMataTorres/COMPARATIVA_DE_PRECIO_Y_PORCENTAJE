using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModernGUI_V3.Clases
{
    public class Llanta
    {
        //--------------------------------Propiedades-----------------------------------
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Medida { get; set; }
        public decimal Precio { get; set; }
        public string Ecommerce { get; set; }
        //public int IdProveedor { get; set; }
        //public int IdCategoria { get; set; }
        //public int IdGenero { get; set; }
        //---------------------------Constructor vacío----------------------------------
        public Llanta()
        {
        }
        //---------------------Constructor con parametros que sirve para consultar datos-----------------------------
        public Llanta(string modelo, string medida)
        {
            Modelo = modelo;
            Medida = medida;
            DataTable t = Clases.Conexion.ConsultaDatos("TablaLlantas2", "(Modelo+Medida)", Modelo, Medida);
            if (t.Rows.Count > 0)//---------Válida si existe un renglon de acuerdo a la consulta hecha------------
            {
                Marca = t.Rows[0]["Marca"].ToString();
                Precio = decimal.Parse(t.Rows[0]["Precio"].ToString());
                Ecommerce = t.Rows[0]["Ecommerce"].ToString();
                //IdProveedor = int.Parse(t.Rows[0]["IdProveedor"].ToString());
                //IdCategoria = int.Parse(t.Rows[0]["IdCategoria"].ToString());
                //IdGenero = int.Parse(t.Rows[0]["IdGenero"].ToString());
            }
            else
            {
                Precio = -1;//-----Se asigna un -1 al Precio si no existe ningún renglón con la consulta hecha---------
            }
        }
    }
}
