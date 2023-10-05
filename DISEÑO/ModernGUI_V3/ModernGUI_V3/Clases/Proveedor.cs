using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModernGUI_V3.Clases
{
    public class Proveedor
    {
        //----------------Propiedades-----------------
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        //------------------Constructor vacío----------------------
        public Proveedor()
        {
        }
        //------------Constructor que recibe el parametro id que sirve para consultar datos-----------
        public Proveedor(int id)
        {
            Id = id;
            DataTable t = Clases.Conexion.ConsultaDatos("TablaProveedor", "Id", Id.ToString(), "");
            if (t.Rows.Count > 0)//-------Válida si existe un renglón de acuerdo a la consulta hecha----------
            {
                Nombre = t.Rows[0]["Nombre"].ToString();
                Domicilio = t.Rows[0]["Domicilio"].ToString();
                Telefono = t.Rows[0]["Telefono"].ToString();
                Correo = t.Rows[0]["Correo"].ToString();
            }
            else
            {
                Id = -1;//---------Si no se le asigna un -1 al Id que sirve para válidar si va a ser nuevo o no-----------
            }
        }
    }
}